namespace Calendar
{
    partial class Event
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 11);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "$Name$";
            // 
            // lblInfos
            // 
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(3, 38);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(122, 97);
            this.lblInfos.TabIndex = 2;
            this.lblInfos.Text = "lblInfos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblInfos);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 135);
            this.panel2.TabIndex = 3;
            this.panel2.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel2);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(128, 135);
            this.Load += new System.EventHandler(this.Event_Load);
            this.DoubleClick += new System.EventHandler(this.Event_DoubleClick);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfos;
        public System.Windows.Forms.Panel panel2;
    }
}
