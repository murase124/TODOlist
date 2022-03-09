using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022203TODOリスト
{
    public partial class SetFrom : Form
    {
        Form1 Form1;
        string id = null;
        public SetFrom()
        {
            InitializeComponent();
            this.Text = "登録";
            this.button_OK.Text = "登録";
            button_OK.Enabled = false;
        }
        public SetFrom(string naiyou, DateTime nowDate, string id, Form1 Form1)
        {
            InitializeComponent();
            textBox_naiyou.Text = naiyou;
            monthCalendar1.SetDate(nowDate);
            this.id = id;
            this.Form1 = Form1;
            this.Text = "編集";
            this.button_OK.Text = "完了";
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        

        private void textBox_naiyou_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_naiyou.Text))
            {
                button_OK.Enabled = false;
            }
            else
            {
                button_OK.Enabled = true;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                Form1.insert(textBox_naiyou.Text, monthCalendar1.SelectionRange.Start);
            }
            else
            {
                if (Form1.insert(textBox_naiyou.Text, monthCalendar1.SelectionRange.Start, id))
                {
                    Form1.delete();
                }
            }
        }
    }
}
