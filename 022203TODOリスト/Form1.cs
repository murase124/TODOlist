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
            delete();
            Get_Dete();
        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_Dete();
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_Dete();
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
                                reader["tourokubi"].ToString()
                            );
                            caunt_id++;
                        }
                    }
                }
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

                string sql = "insert into todo values(todo_id.nextval,'" + naiyou + "',TO_DATE('" + dey + "','YYYY/MM/DD HH24:MI:SS'),TO_DATE('" + DateTime.Now + "','YYYY/MM/DD HH24:MI:SS'), Delete_Flg = 'False') ";
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

        //削除SQL
        public void delete()
        {
            //データービューからidを取得
            string nowRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("id = " + nowRow + "を削除して本当によろしいですか？", "確認", MessageBoxButtons.YesNo);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

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
            else if (dr == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Noを押しました。");
            }
            else
            {
                MessageBox.Show("Yes,No以外の動作");
            }
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
