using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 今日日期
            int todayYear = int.Parse(TodayYear.Text);
            int todayMonth = int.Parse(TodayMonth.Text);
            int todayDay = int.Parse(TodayDay.Text);

            // 今日星期
            int day = int.Parse(Day.Text);

            // 要計算的日期
            int countYear = int.Parse(CountYear.Text);
            int countMonth = int.Parse(CountMonth.Text);
            int countDay = int.Parse(CountDay.Text);

            // 月大于12 或 日大于31 或 2月大于29
            if ((todayMonth > 12) || (todayDay > 31) || (todayMonth == 2 && todayDay > 29))
            {
                label5.Text = "Error";
            }
            else if ((countMonth > 12) || (countDay > 31) || (countMonth == 2 && countDay > 29))
            {
                label5.Text = "Error";
            }
            // 2，4，6，9，11只有30天
            else if ((todayMonth == 2 || todayMonth == 4 || todayMonth == 6 || todayMonth == 9 || todayMonth == 11) && todayDay > 30)
            {
                label5.Text = "Error";
            }
            else if ((countMonth == 2 || countMonth == 4 || countMonth == 6 || countMonth == 9 || countMonth == 11) && countDay > 30)
            {
                label5.Text = "Error";
            }
            // 百年一润,四百年不润,四年一润
            else if (todayYear % 4 == 0 && todayYear % 100 != 0 && todayMonth == 2 && todayDay > 28 || todayYear % 400 == 0 && todayMonth == 2 && todayDay > 28)
            {
                label5.Text = "Error";
            }
            else if (countYear % 4 == 0 && countYear % 100 != 0 && countMonth == 2 && countDay > 28 || countYear % 400 == 0 && countMonth == 2 && countDay > 28)
            {
                label5.Text = "Error";
            }
            else if (day > 7)
            {
                label5.Text = "Error";
            }

            // 答案星期
            int AnwDay;

            int Anw = (countYear - todayYear) * 365 + (countYear / 4 - todayYear / 4) - (countYear / 100 - todayYear / 100);
            double a1 = (countYear - todayYear);
            double a2 = a1 * 365;
            double a3 = (countYear / 4 - todayYear / 4);
            double a4 = (countYear / 100 - todayYear / 100);
            double a5 = a3 - a4;
            double a6 = a2 + a5;

            int Anw1 = Anw % 7;

            AnwDay = day + Anw1;
            AnwDay = AnwDay % 7;
            if (AnwDay == 0)
            {
                label5.Text = "7";
            }
            else
            {
                label5.Text = AnwDay.ToString();
            }
        }
    }
}
