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
    public partial class UCAddEvent : UserControl
    {
        public event Action confirmEvent;
        private clsEvent _objEvent;
        public clsEvent objEvent
        {
            get
            {
                return _objEvent;
            }
            set
            {
                _objEvent = value;
                txtNom.Text = _objEvent.name;
                txtinfos.Text = _objEvent.infos;
                pnlColor.BackColor = _objEvent.color;
                cmbDebut.Text = _objEvent.duree + "h";


            }
        }
        public string getDuree
        {
            get
            {
                return cmbDebut.Text[0].ToString();
            }
        }
        public string getInfos
        {
            get
            {
                return txtinfos.Text;
            }
        }
        public string getName
        {
            get
            {
                return txtNom.Text;
            }
        }
        public Color getColor
        {
            get
            {
                return pnlColor.BackColor;
            }
        }
        public UCAddEvent()
        {
            InitializeComponent();
        }

        private void UCAddEvent_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
            {
                cmbDebut.Items.Add(i + "h");
            }
            cmbDebut.Text = "1h";
            cmbColor.Items.Add("Blanc");
            cmbColor.Items.Add("Rouge");
            cmbColor.Items.Add("Vert");
            cmbColor.Items.Add("Bleu");
            cmbColor.Items.Add("Noir");
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.Text)
            {
                case "Rouge":
                    pnlColor.BackColor = Color.Red;
                    break;
                case "Blanc":
                    pnlColor.BackColor = Color.White;
                    break;
                case "Vert":
                    pnlColor.BackColor = Color.Green;
                    break;
                case "Bleu":
                    pnlColor.BackColor = Color.Blue;
                    break;
                case "Noir":
                    pnlColor.BackColor = Color.Black;
                    break;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

            confirmEvent();
        }
    }
}
