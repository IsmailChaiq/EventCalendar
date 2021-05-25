
namespace Calendar
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(8, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day1,
            this.Day2,
            this.Day3,
            this.Day4,
            this.Day5,
            this.Day6,
            this.Day7});
            this.dataGridView1.Location = new System.Drawing.Point(247, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 460);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Day1
            // 
            this.Day1.HeaderText = "Day1";
            this.Day1.Name = "Day1";
            // 
            // Day2
            // 
            this.Day2.HeaderText = "Day2";
            this.Day2.Name = "Day2";
            // 
            // Day3
            // 
            this.Day3.HeaderText = "Day3";
            this.Day3.Name = "Day3";
            // 
            // Day4
            // 
            this.Day4.HeaderText = "Day4";
            this.Day4.Name = "Day4";
            // 
            // Day5
            // 
            this.Day5.HeaderText = "Day5";
            this.Day5.Name = "Day5";
            // 
            // Day6
            // 
            this.Day6.HeaderText = "Day6";
            this.Day6.Name = "Day6";
            // 
            // Day7
            // 
            this.Day7.HeaderText = "Day7";
            this.Day7.Name = "Day7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7;
    }
}

