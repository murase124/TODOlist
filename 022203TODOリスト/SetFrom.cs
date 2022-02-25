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
        public SetFrom()
        {
            InitializeComponent();
            this.Text = "登録";
            this.button_OK.Text = "登録";
        }
        public SetFrom(string naiyou, DateTime nowDate)
        {
            InitializeComponent();
            textBox_naiyou.Text = naiyou;
            monthCalendar1.SetDate(nowDate);

            this.Text = "編集";
            this.button_OK.Text = "完了";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
