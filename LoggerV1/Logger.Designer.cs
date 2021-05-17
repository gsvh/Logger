
namespace LoggerV1
{
    partial class Logger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logger));
            this.btnLogActivity = new System.Windows.Forms.Button();
            this.txtActivityNotes = new System.Windows.Forms.TextBox();
            this.txtHSpent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.llOverrideTimer = new System.Windows.Forms.LinkLabel();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.cbActivities = new System.Windows.Forms.ComboBox();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.btnAddActiv = new System.Windows.Forms.Button();
            this.btnRemoveSub = new System.Windows.Forms.Button();
            this.btnRemoveActivity = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtMSpent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnLogActivity
            // 
            this.btnLogActivity.Enabled = false;
            this.btnLogActivity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogActivity.Location = new System.Drawing.Point(393, 320);
            this.btnLogActivity.Name = "btnLogActivity";
            this.btnLogActivity.Size = new System.Drawing.Size(179, 51);
            this.btnLogActivity.TabIndex = 1;
            this.btnLogActivity.Text = "Log Activity";
            this.btnLogActivity.UseVisualStyleBackColor = true;
            this.btnLogActivity.Click += new System.EventHandler(this.btnLogActivity_Click);
            // 
            // txtActivityNotes
            // 
            this.txtActivityNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtActivityNotes.Location = new System.Drawing.Point(193, 148);
            this.txtActivityNotes.Multiline = true;
            this.txtActivityNotes.Name = "txtActivityNotes";
            this.txtActivityNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActivityNotes.Size = new System.Drawing.Size(466, 69);
            this.txtActivityNotes.TabIndex = 3;
            // 
            // txtHSpent
            // 
            this.txtHSpent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHSpent.Location = new System.Drawing.Point(193, 230);
            this.txtHSpent.Name = "txtHSpent";
            this.txtHSpent.Size = new System.Drawing.Size(34, 29);
            this.txtHSpent.TabIndex = 4;
            this.txtHSpent.Visible = false;
            this.txtHSpent.TextChanged += new System.EventHandler(this.txtHSpent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Activity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(45, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Activity Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(44, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Spent:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStart.Location = new System.Drawing.Point(50, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 51);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Activity";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.Window;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTimer.Location = new System.Drawing.Point(200, 233);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(70, 21);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "00:00:00";
            // 
            // llOverrideTimer
            // 
            this.llOverrideTimer.AutoSize = true;
            this.llOverrideTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llOverrideTimer.Location = new System.Drawing.Point(304, 229);
            this.llOverrideTimer.Name = "llOverrideTimer";
            this.llOverrideTimer.Size = new System.Drawing.Size(159, 17);
            this.llOverrideTimer.TabIndex = 11;
            this.llOverrideTimer.TabStop = true;
            this.llOverrideTimer.Text = "Manually enter time spent";
            this.llOverrideTimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOverrideTimer_LinkClicked);
            // 
            // cbSubjects
            // 
            this.cbSubjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSubjects.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubjects.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(193, 59);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(319, 29);
            this.cbSubjects.TabIndex = 12;
            // 
            // cbActivities
            // 
            this.cbActivities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbActivities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbActivities.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbActivities.FormattingEnabled = true;
            this.cbActivities.Location = new System.Drawing.Point(193, 103);
            this.cbActivities.Name = "cbActivities";
            this.cbActivities.Size = new System.Drawing.Size(319, 29);
            this.cbActivities.TabIndex = 13;
            // 
            // btnAddSub
            // 
            this.btnAddSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSub.Location = new System.Drawing.Point(521, 62);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(78, 28);
            this.btnAddSub.TabIndex = 14;
            this.btnAddSub.Text = "Add Subject";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // btnAddActiv
            // 
            this.btnAddActiv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActiv.Location = new System.Drawing.Point(521, 107);
            this.btnAddActiv.Name = "btnAddActiv";
            this.btnAddActiv.Size = new System.Drawing.Size(78, 28);
            this.btnAddActiv.TabIndex = 15;
            this.btnAddActiv.Text = "Add Activity";
            this.btnAddActiv.UseVisualStyleBackColor = true;
            this.btnAddActiv.Click += new System.EventHandler(this.btnAddActiv_Click);
            // 
            // btnRemoveSub
            // 
            this.btnRemoveSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSub.Location = new System.Drawing.Point(605, 62);
            this.btnRemoveSub.Name = "btnRemoveSub";
            this.btnRemoveSub.Size = new System.Drawing.Size(57, 28);
            this.btnRemoveSub.TabIndex = 16;
            this.btnRemoveSub.Text = "Remove";
            this.btnRemoveSub.UseVisualStyleBackColor = true;
            this.btnRemoveSub.Click += new System.EventHandler(this.btnRemoveSub_Click);
            // 
            // btnRemoveActivity
            // 
            this.btnRemoveActivity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveActivity.Location = new System.Drawing.Point(605, 106);
            this.btnRemoveActivity.Name = "btnRemoveActivity";
            this.btnRemoveActivity.Size = new System.Drawing.Size(57, 28);
            this.btnRemoveActivity.TabIndex = 17;
            this.btnRemoveActivity.Text = "Remove";
            this.btnRemoveActivity.UseVisualStyleBackColor = true;
            this.btnRemoveActivity.Click += new System.EventHandler(this.btnRemoveActivity_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(304, 246);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(268, 13);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "Indicate hours and minutes by using numbers only";
            this.lblError.Visible = false;
            // 
            // txtMSpent
            // 
            this.txtMSpent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMSpent.Location = new System.Drawing.Point(242, 230);
            this.txtMSpent.Name = "txtMSpent";
            this.txtMSpent.Size = new System.Drawing.Size(34, 29);
            this.txtMSpent.TabIndex = 19;
            this.txtMSpent.Visible = false;
            this.txtMSpent.TextChanged += new System.EventHandler(this.txtMSpent_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 20;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblH.Location = new System.Drawing.Point(225, 233);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(19, 21);
            this.lblH.TabIndex = 21;
            this.lblH.Text = "h";
            this.lblH.Visible = false;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblM.Location = new System.Drawing.Point(274, 233);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(24, 21);
            this.lblM.TabIndex = 22;
            this.lblM.Text = "m";
            this.lblM.Visible = false;
            // 
            // btnViewLog
            // 
            this.btnViewLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewLog.Location = new System.Drawing.Point(578, 320);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(84, 51);
            this.btnViewLog.TabIndex = 23;
            this.btnViewLog.Text = "View My Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(45, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date:";
            // 
            // dtPicker
            // 
            this.dtPicker.CustomFormat = "dd-MM-yyyy";
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(193, 270);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 29);
            this.dtPicker.TabIndex = 25;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 393);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.txtMSpent);
            this.Controls.Add(this.txtHSpent);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRemoveActivity);
            this.Controls.Add(this.btnRemoveSub);
            this.Controls.Add(this.btnAddActiv);
            this.Controls.Add(this.btnAddSub);
            this.Controls.Add(this.cbActivities);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.llOverrideTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActivityNotes);
            this.Controls.Add(this.btnLogActivity);
            this.Controls.Add(this.lblTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogActivity;
        private System.Windows.Forms.TextBox txtActivityNotes;
        private System.Windows.Forms.TextBox txtHSpent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.LinkLabel llOverrideTimer;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.ComboBox cbActivities;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.Button btnAddActiv;
        private System.Windows.Forms.Button btnRemoveSub;
        private System.Windows.Forms.Button btnRemoveActivity;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtMSpent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPicker;
    }
}

