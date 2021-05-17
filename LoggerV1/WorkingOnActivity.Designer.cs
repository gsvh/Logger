
namespace LoggerV1
{
    partial class WorkingOnActivity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingOnActivity));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblActivityNotes = new System.Windows.Forms.Label();
            this.txtActivityNotes = new System.Windows.Forms.TextBox();
            this.SecondTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.Window;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(149, 190);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(80, 25);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(546, 177);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(223, 51);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Finish && Log Activity";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time Spent:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(12, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(80, 30);
            this.lblSubject.TabIndex = 14;
            this.lblSubject.Text = "Subject";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(12, 39);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(84, 30);
            this.lblActivity.TabIndex = 16;
            this.lblActivity.Text = "Activity";
            // 
            // lblActivityNotes
            // 
            this.lblActivityNotes.AutoSize = true;
            this.lblActivityNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityNotes.Location = new System.Drawing.Point(1, 87);
            this.lblActivityNotes.Name = "lblActivityNotes";
            this.lblActivityNotes.Size = new System.Drawing.Size(131, 25);
            this.lblActivityNotes.TabIndex = 17;
            this.lblActivityNotes.Text = "Activity Notes:";
            // 
            // txtActivityNotes
            // 
            this.txtActivityNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityNotes.Location = new System.Drawing.Point(149, 92);
            this.txtActivityNotes.Multiline = true;
            this.txtActivityNotes.Name = "txtActivityNotes";
            this.txtActivityNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActivityNotes.Size = new System.Drawing.Size(620, 79);
            this.txtActivityNotes.TabIndex = 18;
            // 
            // SecondTimer
            // 
            this.SecondTimer.Interval = 1000;
            this.SecondTimer.Tick += new System.EventHandler(this.SecondTimer_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date:";
            // 
            // dtPicker
            // 
            this.dtPicker.CustomFormat = "dd-mm-yyyy";
            this.dtPicker.Enabled = false;
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(318, 187);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 29);
            this.dtPicker.TabIndex = 20;
            // 
            // WorkingOnActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 240);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActivityNotes);
            this.Controls.Add(this.lblActivityNotes);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkingOnActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working On Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblActivityNotes;
        private System.Windows.Forms.Timer SecondTimer;
        public System.Windows.Forms.Label lblSubject;
        public System.Windows.Forms.Label lblActivity;
        public System.Windows.Forms.TextBox txtActivityNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPicker;
    }
}