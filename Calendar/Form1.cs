using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = e.Start;
            DateTime endDate = e.End;
            DateTime _tempDate;

            for (int i = 0; i < 7; i++)
            {
                if (startDate.DayOfWeek.ToString() != "Sunday")
                {
                    startDate = startDate.AddDays(-1);
                }
                else break;

            }
            for (int i = 0; i < 7; i++)
            {
                if (endDate.DayOfWeek.ToString() != "Saturday")
                {
                    endDate = endDate.AddDays(1);
                }
                else break;

            }
            monthCalendar1.SelectionStart = startDate;
            monthCalendar1.SelectionEnd = endDate;
            List<DateTime> tempWeek = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                tempWeek.Add(startDate.AddDays(i));
            }
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].HeaderText = tempWeek[i].DayOfWeek.ToString() + " " + tempWeek[i].Day.ToString() + " " + tempWeek[i].ToString("MMMM");
            }
        }
    }
}
