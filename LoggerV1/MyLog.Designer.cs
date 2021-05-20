
namespace LoggerV1
{
    partial class MyLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyLog));
            //this.lOGGERDataSet = new LoggerV1.LOGGERDataSet();
            this.userActivityLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.userActivityLogTableAdapter = new LoggerV1.LOGGERDataSetTableAdapters.UserActivityLogTableAdapter();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.subjectsTableAdapter = new LoggerV1.LOGGERDataSetTableAdapters.SubjectsTableAdapter();
            //this.activitiesTableAdapter = new LoggerV1.LOGGERDataSetTableAdapters.ActivitiesTableAdapter();
            this.userActivityLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.activitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userActivityLogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            //((System.ComponentModel.ISupportInitialize)(this.lOGGERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityLogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityLogBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lOGGERDataSet
            // 
            //this.lOGGERDataSet.DataSetName = "LOGGERDataSet";
            //this.lOGGERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userActivityLogBindingSource
            // 
            this.userActivityLogBindingSource.DataMember = "UserActivityLog";
            //this.userActivityLogBindingSource.DataSource = this.lOGGERDataSet;
            // 
            // userActivityLogTableAdapter
            // 
            //this.userActivityLogTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
           // this.subjectsBindingSource.DataSource = this.lOGGERDataSet;
            // 
            // subjectsTableAdapter
            // 
            //this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // activitiesTableAdapter
            // 
            //this.activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // userActivityLogBindingSource1
            // 
            this.userActivityLogBindingSource1.DataMember = "UserActivityLog";
            //this.userActivityLogBindingSource1.DataSource = this.lOGGERDataSet;
            // 
            // subjectsBindingSource1
            // 
            //this.subjectsBindingSource1.DataMember = "Subjects";
            //this.subjectsBindingSource1.DataSource = this.lOGGERDataSet;
            // 
            // dgvLog
            // 
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.txtSubject,
            this.txtActivity,
            this.txtNotes,
            this.txtTime});
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLog.Location = new System.Drawing.Point(0, 53);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(1003, 382);
            this.dgvLog.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.FillWeight = 5F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.FillWeight = 9F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // txtSubject
            // 
            this.txtSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtSubject.FillWeight = 23F;
            this.txtSubject.HeaderText = "Subject";
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtSubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtActivity
            // 
            this.txtActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtActivity.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtActivity.FillWeight = 23F;
            this.txtActivity.HeaderText = "Activity";
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtActivity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtNotes
            // 
            this.txtNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtNotes.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtNotes.FillWeight = 40F;
            this.txtNotes.HeaderText = "Activity Notes";
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtTime
            // 
            this.txtTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtTime.FillWeight = 5F;
            this.txtTime.HeaderText = "Minutes Spent";
            this.txtTime.Name = "txtTime";
            // 
            // cbDelete
            // 
            this.cbDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDelete.FormattingEnabled = true;
            this.cbDelete.Location = new System.Drawing.Point(43, 16);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(51, 25);
            this.cbDelete.TabIndex = 1;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteRow.Location = new System.Drawing.Point(100, 12);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(93, 30);
            this.btnDeleteRow.TabIndex = 2;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExport.Location = new System.Drawing.Point(710, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(111, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export to PDF";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(927, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(250, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your name:";
            // 
            // activitiesBindingSource
            // 
            this.activitiesBindingSource.DataMember = "Activities";
           // this.activitiesBindingSource.DataSource = this.lOGGERDataSet;
            // 
            // userActivityLogBindingSource
            // 
            this.userActivityLogBindingSource.DataMember = "UserActivityLog";
            //this.userActivityLogBindingSource2.DataSource = this.lOGGERDataSet;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(370, 12);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 30);
            this.txtName.TabIndex = 5;
            // 
            // MyLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.dgvLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLog";
            this.Load += new System.EventHandler(this.MyLog_Load);
            //((System.ComponentModel.ISupportInitialize)(this.lOGGERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityLogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityLogBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private LOGGERDataSet lOGGERDataSet;
        private System.Windows.Forms.BindingSource userActivityLogBindingSource;
        //private LOGGERDataSetTableAdapters.UserActivityLogTableAdapter userActivityLogTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
       // private LOGGERDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        //private LOGGERDataSetTableAdapters.ActivitiesTableAdapter activitiesTableAdapter;
        private System.Windows.Forms.BindingSource userActivityLogBindingSource1;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.ComboBox cbDelete;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource activitiesBindingSource1;
        private System.Windows.Forms.BindingSource activitiesBindingSource;
        private System.Windows.Forms.BindingSource userActivityLogBindingSource2;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTime;
    }
}