namespace Calendar
{
    partial class UCAddEvent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.txtinfos = new System.Windows.Forms.TextBox();
            this.cmbDebut = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infos : ";
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(318, 13);
            this.pnlColor.TabIndex = 1;
            // 
            // txtinfos
            // 
            this.txtinfos.Location = new System.Drawing.Point(48, 78);
            this.txtinfos.Multiline = true;
            this.txtinfos.Name = "txtinfos";
            this.txtinfos.Size = new System.Drawing.Size(267, 51);
            this.txtinfos.TabIndex = 2;
            // 
            // cmbDebut
            // 
            this.cmbDebut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebut.FormattingEnabled = true;
            this.cmbDebut.Location = new System.Drawing.Point(48, 23);
            this.cmbDebut.Name = "cmbDebut";
            this.cmbDebut.Size = new System.Drawing.Size(49, 21);
            this.cmbDebut.TabIndex = 3;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(246, 23);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(69, 21);
            this.cmbColor.TabIndex = 5;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Durée :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Couleur :";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(233, 135);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(82, 19);
            this.btnConfirmer.TabIndex = 9;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(145, 135);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(82, 19);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(48, 50);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 12;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(3, 135);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(82, 19);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // UCAddEvent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbDebut);
            this.Controls.Add(this.txtinfos);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.label1);
            this.Name = "UCAddEvent";
            this.Size = new System.Drawing.Size(318, 159);
            this.Load += new System.EventHandler(this.UCAddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtinfos;
        private System.Windows.Forms.ComboBox cmbDebut;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnSupprimer;

    }
}
