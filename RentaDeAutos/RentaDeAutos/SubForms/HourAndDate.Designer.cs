
namespace RentaDeAutos.SubForms
{
    partial class HourAndDate
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
            this.panelClock = new System.Windows.Forms.Panel();
            this.SelectedDay = new System.Windows.Forms.TextBox();
            this.hourPlus = new System.Windows.Forms.Button();
            this.quarterMinPLus = new System.Windows.Forms.Button();
            this.oneMinutePlus = new System.Windows.Forms.Button();
            this.oneMinuteMinus = new System.Windows.Forms.Button();
            this.quarterMinMinus = new System.Windows.Forms.Button();
            this.hourMinus = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 54);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // panelClock
            // 
            this.panelClock.BackColor = System.Drawing.Color.White;
            this.panelClock.Location = new System.Drawing.Point(297, 22);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(200, 200);
            this.panelClock.TabIndex = 1;
            // 
            // SelectedDay
            // 
            this.SelectedDay.Location = new System.Drawing.Point(18, 22);
            this.SelectedDay.Name = "SelectedDay";
            this.SelectedDay.Size = new System.Drawing.Size(248, 20);
            this.SelectedDay.TabIndex = 2;
            // 
            // hourPlus
            // 
            this.hourPlus.Location = new System.Drawing.Point(503, 22);
            this.hourPlus.Name = "hourPlus";
            this.hourPlus.Size = new System.Drawing.Size(75, 23);
            this.hourPlus.TabIndex = 3;
            this.hourPlus.Text = "+1:00";
            this.hourPlus.UseVisualStyleBackColor = true;
            this.hourPlus.Click += new System.EventHandler(this.hourPlus_Click);
            // 
            // quarterMinPLus
            // 
            this.quarterMinPLus.Location = new System.Drawing.Point(503, 51);
            this.quarterMinPLus.Name = "quarterMinPLus";
            this.quarterMinPLus.Size = new System.Drawing.Size(75, 23);
            this.quarterMinPLus.TabIndex = 4;
            this.quarterMinPLus.Text = "+0:15";
            this.quarterMinPLus.UseVisualStyleBackColor = true;
            this.quarterMinPLus.Click += new System.EventHandler(this.quarterMinPLus_Click);
            // 
            // oneMinutePlus
            // 
            this.oneMinutePlus.Location = new System.Drawing.Point(503, 80);
            this.oneMinutePlus.Name = "oneMinutePlus";
            this.oneMinutePlus.Size = new System.Drawing.Size(75, 23);
            this.oneMinutePlus.TabIndex = 5;
            this.oneMinutePlus.Text = "+0:01";
            this.oneMinutePlus.UseVisualStyleBackColor = true;
            this.oneMinutePlus.Click += new System.EventHandler(this.oneMinutePlus_Click);
            // 
            // oneMinuteMinus
            // 
            this.oneMinuteMinus.Location = new System.Drawing.Point(503, 109);
            this.oneMinuteMinus.Name = "oneMinuteMinus";
            this.oneMinuteMinus.Size = new System.Drawing.Size(75, 23);
            this.oneMinuteMinus.TabIndex = 6;
            this.oneMinuteMinus.Text = "-0:01";
            this.oneMinuteMinus.UseVisualStyleBackColor = true;
            this.oneMinuteMinus.Click += new System.EventHandler(this.oneMinuteMinus_Click);
            // 
            // quarterMinMinus
            // 
            this.quarterMinMinus.Location = new System.Drawing.Point(503, 138);
            this.quarterMinMinus.Name = "quarterMinMinus";
            this.quarterMinMinus.Size = new System.Drawing.Size(75, 23);
            this.quarterMinMinus.TabIndex = 7;
            this.quarterMinMinus.Text = "-0:15";
            this.quarterMinMinus.UseVisualStyleBackColor = true;
            this.quarterMinMinus.Click += new System.EventHandler(this.quarterMinMinus_Click);
            // 
            // hourMinus
            // 
            this.hourMinus.Location = new System.Drawing.Point(503, 167);
            this.hourMinus.Name = "hourMinus";
            this.hourMinus.Size = new System.Drawing.Size(75, 23);
            this.hourMinus.TabIndex = 8;
            this.hourMinus.Text = "-1:00";
            this.hourMinus.UseVisualStyleBackColor = true;
            this.hourMinus.Click += new System.EventHandler(this.hourMinus_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(390, 237);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(91, 41);
            this.AcceptButton.TabIndex = 9;
            this.AcceptButton.Text = "Aceptar";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(487, 237);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(91, 41);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // HourAndDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 281);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.hourMinus);
            this.Controls.Add(this.quarterMinMinus);
            this.Controls.Add(this.oneMinuteMinus);
            this.Controls.Add(this.oneMinutePlus);
            this.Controls.Add(this.quarterMinPLus);
            this.Controls.Add(this.hourPlus);
            this.Controls.Add(this.SelectedDay);
            this.Controls.Add(this.panelClock);
            this.Controls.Add(this.monthCalendar1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "HourAndDate";
            this.Text = "HourAndDate";
            this.Shown += new System.EventHandler(this.HourAndDate_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox SelectedDay;
        private System.Windows.Forms.Button hourPlus;
        private System.Windows.Forms.Button quarterMinPLus;
        private System.Windows.Forms.Button oneMinutePlus;
        private System.Windows.Forms.Button oneMinuteMinus;
        private System.Windows.Forms.Button quarterMinMinus;
        private System.Windows.Forms.Button hourMinus;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
    }
}