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
        public event EventHandler<EventDoubleClicked> OnPnlDoubleClick;
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
            foreach(Control c in this.Controls)
            {
                c.DoubleClick += panel2_DoubleClick;
                foreach (Control cc in c.Controls)
                {
                    cc.DoubleClick += panel2_DoubleClick;
                }
            }
        }
        protected virtual void OnDoubleClick(EventDoubleClicked e)
        {
            EventHandler<EventDoubleClicked> handler = OnPnlDoubleClick;
            if( handler != null)
            {
                handler(this, e);
            }
        }

        public class EventDoubleClicked : EventArgs
        {
            public clsEvent objEvent { get; set; }
        }


        private void Event_Load(object sender, EventArgs e)
        {

        }

        private void Event_DoubleClick(object sender, EventArgs e)
        {
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            EventDoubleClicked eArgs = new EventDoubleClicked();
            eArgs.objEvent = clsEvent;
            OnDoubleClick(eArgs);
        }
    }
}
