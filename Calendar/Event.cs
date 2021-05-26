using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Event : UserControl
    {
        private clsEvent clsEvent;
        internal clsEvent ClsEvent { get => clsEvent;
            set {
                clsEvent = value;
                lblInfos.Text = clsEvent.infos;
                lblName.Text = clsEvent.name;
                panel1.BackColor = clsEvent.color;


            } }

        public Event()
        {
            InitializeComponent();
        }


        private void Event_Load(object sender, EventArgs e)
        {

        }
    }
}
