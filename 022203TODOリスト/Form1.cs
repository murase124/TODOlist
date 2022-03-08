using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace _022203TODOリスト
{
    public partial class Form1 : Form
    {
        int caunt_id;
        public Form1()
        {
            InitializeComponent();
            caunt_id = 0;
            Get_Dete();
        }

        private void 登録ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addData();
            Get_Dete();
        }

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //警告
            string nowRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("id = " + nowRow + "を削除して本当によろしいですか？", "確認", MessageBoxButtons.YesNo);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                delete();
            }
            else if (dr == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Noを押しました。");
            }
            else
            {
                MessageBox.Show("Yes,No以外の動作");
            }

            Get_Dete();
        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editData();            
            Get_Dete();
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_Dete();
        }

        private void 編集履歴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            //追加処理　itemhormを表示
            //モーダル
            ALL_DATA Form = new ALL_DATA(this,id);
            Form.ShowDialog();
        }



        //追加　フォーム
        private void addData()
        {
            //追加処理　itemhormを表示
            //モーダル
            SetFrom FrmItem;
            FrmItem = new SetFrom();
            DialogResult drRet = FrmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                caunt_id++;
                insert(FrmItem.textBox_naiyou.Text, FrmItem.monthCalendar1.SelectionRange.Start);
            }
        }

        //編集　フォーム
        private void editData()
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string naiyou = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             DateTime.TryParse(dataGridView1.CurrentRow.Cells[2].Value.ToString(), out DateTime simekiri);

            //追加処理　itemhormを表示
            //モーダル
            SetFrom FrmItem;
            FrmItem = new SetFrom(naiyou,simekiri);
            DialogResult drRet = FrmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                caunt_id++;
                insert(FrmItem.textBox_naiyou.Text, FrmItem.monthCalendar1.SelectionRange.Start,id);
                delete();
            }
        }

        //取得　SQL
        public void Get_Dete()
        {
            //自分作
            try
            {
                dataSet1.ToDoDataTable.Rows.Clear();//ビュー削除
                string sql = "SELECT * FROM todo WHERE Delete_Flg = 'False' ORDER BY simekiri";
                OracleConnection conn = new OracleConnection();

                conn.ConnectionString = connection();

                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sql))
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            dataSet1.ToDoDataTable.AddToDoDataTableRow(
                                reader["id"].ToString(),
                                reader["naiyou"].ToString(),
                                reader["simekiri"].ToString(),
                                reader["tourokubi"].ToString(),
                                reader["delete_flg"].ToString(),
                                reader["data_id"].ToString()
                            );
                            caunt_id++;
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //追加SQL
        public void insert(in string naiyou, DateTime dey)
        {
            try
            {
                caunt_id++;
                DateTime localDate = DateTime.Now;

                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = connection();
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                string sql = "insert into todo values(todo_id.nextval,'" + naiyou + "',TO_DATE('" + dey + "','YYYY/MM/DD HH24:MI:SS'),TO_DATE('" + DateTime.Now + "','YYYY/MM/DD HH24:MI:SS'),'False',todo_id.currval)";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MessageBox.Show("失敗");
            }
        }
        
        public bool insert(in string naiyou, DateTime dey, string id)
        {
            try
            {
                caunt_id++;
                DateTime localDate = DateTime.Now;

                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = connection();   
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                string sql = "insert into todo values(todo_id.nextval,'" + naiyou + "',TO_DATE('" + dey + "','YYYY/MM/DD HH24:MI:SS'),TO_DATE('" + DateTime.Now + "','YYYY/MM/DD HH24:MI:SS'),'False',"+id+")";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MessageBox.Show("失敗");
                return false;
            }
            return true;
        }

        //削除SQL
        public void delete()
        {
            //データービューからidを取得
            string nowRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {
                caunt_id--;
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = connection();
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                //string sql = "DELETE FROM todo WHERE id='" + nowRow + "'";
                string sql = "UPDATE todo SET Delete_Flg = 'True' WHERE id ='" + nowRow + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("失敗");
            }
        }

        public bool delete(string nowRow)
        {
            //データービューからidを取得

            try
            {
                caunt_id--;
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = connection();
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                //string sql = "DELETE FROM todo WHERE id='" + nowRow + "'";
                string sql = "UPDATE todo SET Delete_Flg = 'True' WHERE data_id="+nowRow+" AND id!=(select max(id) from todo where data_id= "+nowRow+")";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("失敗");
                return false;
            }
            return true;
        }

        private void 全てToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //追加処理　itemhormを表示
            //モーダル
            ALL_DATA Form = new ALL_DATA(this);
            Form.ShowDialog();
        }

        public void Data_Return(string naiyou, DateTime simekiri, string Data_id)
        {
           if(insert( naiyou, simekiri, Data_id))
            {
                delete(Data_id);
            }
            Get_Dete();


        }


        private string connection()
        {
            //oracle connection string

            StreamReader sr = new StreamReader(
        "C:\\Users\\user\\Documents\\GitHub\\Text\\ToDo.txt", Encoding.GetEncoding("Shift_JIS"));

            string text = sr.ReadToEnd();

            sr.Close();

            Console.Write(text);

            return text;
        }

        
    }
}
