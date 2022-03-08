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
    public partial class ALL_DATA : Form
    {
        Form1 Form1;
        string id;
        public ALL_DATA(Form1 Form1)
        {
            this.Form1 = Form1;
            InitializeComponent();
            Get_ALL_Dete();
        }
        public ALL_DATA(Form1 Form1,string id)
        {
            this.Form1 = Form1;
            this.id = id;
            InitializeComponent();
            Get_Select_Dete();
            this.Text = "SELECT_DATA";
        }

        private void ALL_DATA_Load(object sender, EventArgs e)
        {
           
        }

        public void Get_ALL_Dete()
        {

            //自分作
            try
            {
                dataSet11.ToDoDataTable.Rows.Clear();//ビュー削除
                string sql = "SELECT * FROM todo ORDER BY data_id ,id";
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
                            dataSet11.ToDoDataTable.AddToDoDataTableRow(
                                reader["id"].ToString(),
                                reader["naiyou"].ToString(),
                                reader["simekiri"].ToString(),
                                reader["tourokubi"].ToString(),
                                reader["delete_flg"].ToString(),
                                reader["data_id"].ToString()
                            );
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
        public void Get_Select_Dete()
        {

            //自分作
            try
            {
                dataSet11.ToDoDataTable.Rows.Clear();//ビュー削除
                string sql = "SELECT * FROM todo WHERE data_id = (select data_id from todo WHERE id=" + id + ") ORDER BY data_id ,id";
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
                            dataSet11.ToDoDataTable.AddToDoDataTableRow(
                                reader["id"].ToString(),
                                reader["naiyou"].ToString(),
                                reader["simekiri"].ToString(),
                                reader["tourokubi"].ToString(),
                                reader["delete_flg"].ToString(),
                                reader["data_id"].ToString()
                            );
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

        private void 編集履歴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(dataGridView1.CurrentRow.Cells[2].Value.ToString(), out DateTime simekiri);
            DateTime.TryParse(dataGridView1.CurrentRow.Cells[2].Value.ToString(), out DateTime tourokubi);

           Form1.Data_Return(
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                 simekiri,
                dataGridView1.CurrentRow.Cells[5].Value.ToString());

            Get_ALL_Dete();
        }
    }
}
