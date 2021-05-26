using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        CultureInfo cult = new CultureInfo("fr-FR");
        List<DateTime> tempWeek = new List<DateTime>();

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
            tempWeek.Clear();
            for (int i = 0; i < 7; i++)
            {
                tempWeek.Add(startDate.AddDays(i));
            }
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].HeaderText = tempWeek[i].ToString("D", cult);
                //dataGridView1.Columns[i].HeaderText = tempWeek[i].DayOfWeek.ToString() + " " + tempWeek[i].Day.ToString() + " " + tempWeek[i].ToString("MMMM") + " " + tempWeek[i].ToString("yyyy");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 8; i < 20; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i - 8].HeaderCell.Value = i + ":00";
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            { 
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            addEvent.confirmEvent += confirmEvent;
            addEvent.SendToBack();

        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }
        }
        
        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addEvent.Visible = false;
            addEvent.SendToBack();
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            addEvent.Top= dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Top + 48;
            addEvent.Left = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Left + 247;
            addEvent.Visible = true;
            addEvent.BringToFront();
        }
        private void confirmEvent()
        {
            clsEvent _event = new clsEvent(
                DateTime.Parse(tempWeek[dataGridView1.CurrentCell.ColumnIndex].ToString("d")+ " " + dataGridView1.CurrentRow.HeaderCell.Value),
                addEvent.getDuree,
                addEvent.getName,
                addEvent.getInfos,
                addEvent.getColor );
            clsEvent.listEvent.Add(_event);
            event1.ClsEvent = _event;
            event1.Location = addEvent.Location;
            event1.Width = dataGridView1.CurrentCell.Size.Width;
            event1.Height = dataGridView1.CurrentRow.Height * _event.duree;
            event1.BringToFront();
            addEvent.SendToBack();
        }
    }
}
