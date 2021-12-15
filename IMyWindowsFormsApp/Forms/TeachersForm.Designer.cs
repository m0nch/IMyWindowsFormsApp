namespace IMyWindowsFormsApp
{
    partial class TeachersForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdTeachers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tchFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tchAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuGrdTeachers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAssignStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbLastName = new System.Windows.Forms.ComboBox();
            this.splitTeachers = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.lblStudents = new System.Windows.Forms.Label();
            this.stId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeachers)).BeginInit();
            this.contextMenuGrdTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTeachers)).BeginInit();
            this.splitTeachers.Panel1.SuspendLayout();
            this.splitTeachers.Panel2.SuspendLayout();
            this.splitTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(168, 18);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Teachers Information";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(102, 68);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(358, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 15);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 100);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 128);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(102, 96);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(358, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(102, 124);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(358, 22);
            this.txtAge.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(102, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(358, 22);
            this.txtId.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(509, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(509, 67);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Clik);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(509, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdTeachers
            // 
            this.grdTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tchFullName,
            this.tchAge});
            this.grdTeachers.ContextMenuStrip = this.contextMenuGrdTeachers;
            this.grdTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTeachers.Location = new System.Drawing.Point(0, 0);
            this.grdTeachers.MultiSelect = false;
            this.grdTeachers.Name = "grdTeachers";
            this.grdTeachers.ReadOnly = true;
            this.grdTeachers.RowHeadersVisible = false;
            this.grdTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTeachers.Size = new System.Drawing.Size(724, 202);
            this.grdTeachers.TabIndex = 6;
            this.grdTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellClick);
            this.grdTeachers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTeachers_CellMouseDoubleClick);
            this.grdTeachers.SelectionChanged += new System.EventHandler(this.grdStudent_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tchFullName
            // 
            this.tchFullName.DataPropertyName = "FullName";
            this.tchFullName.HeaderText = "Name";
            this.tchFullName.Name = "tchFullName";
            this.tchFullName.ReadOnly = true;
            // 
            // tchAge
            // 
            this.tchAge.DataPropertyName = "Age";
            this.tchAge.HeaderText = "Age";
            this.tchAge.Name = "tchAge";
            this.tchAge.ReadOnly = true;
            // 
            // contextMenuGrdTeachers
            // 
            this.contextMenuGrdTeachers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAssignStudent,
            this.menuItemEditStudent});
            this.contextMenuGrdTeachers.Name = "contextMenuGrdTeachers";
            this.contextMenuGrdTeachers.Size = new System.Drawing.Size(181, 70);
            // 
            // menuItemAssignStudent
            // 
            this.menuItemAssignStudent.Name = "menuItemAssignStudent";
            this.menuItemAssignStudent.Size = new System.Drawing.Size(180, 22);
            this.menuItemAssignStudent.Text = "Assign Student";
            this.menuItemAssignStudent.Click += new System.EventHandler(this.menuItemAssignStudent_Click);
            // 
            // menuItemEditStudent
            // 
            this.menuItemEditStudent.Name = "menuItemEditStudent";
            this.menuItemEditStudent.Size = new System.Drawing.Size(180, 22);
            this.menuItemEditStudent.Text = "Edit Student";
            this.menuItemEditStudent.Click += new System.EventHandler(this.menuItemEditStudent_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 158);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(143, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Choose by Full Name";
            this.lblSearch.Visible = false;
            // 
            // cmbLastName
            // 
            this.cmbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLastName.FormattingEnabled = true;
            this.cmbLastName.Location = new System.Drawing.Point(165, 157);
            this.cmbLastName.Name = "cmbLastName";
            this.cmbLastName.Size = new System.Drawing.Size(429, 21);
            this.cmbLastName.TabIndex = 5;
            this.cmbLastName.Visible = false;
            this.cmbLastName.SelectedValueChanged += new System.EventHandler(this.cmbLastName_SelectedValueChanged);
            // 
            // splitTeachers
            // 
            this.splitTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTeachers.Location = new System.Drawing.Point(0, 0);
            this.splitTeachers.Name = "splitTeachers";
            this.splitTeachers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitTeachers.Panel1
            // 
            this.splitTeachers.Panel1.Controls.Add(this.lblInfo);
            this.splitTeachers.Panel1.Controls.Add(this.cmbLastName);
            this.splitTeachers.Panel1.Controls.Add(this.lblId);
            this.splitTeachers.Panel1.Controls.Add(this.btnUpdate);
            this.splitTeachers.Panel1.Controls.Add(this.lblLastName);
            this.splitTeachers.Panel1.Controls.Add(this.btnRemove);
            this.splitTeachers.Panel1.Controls.Add(this.lblFirstName);
            this.splitTeachers.Panel1.Controls.Add(this.btnAdd);
            this.splitTeachers.Panel1.Controls.Add(this.lblAge);
            this.splitTeachers.Panel1.Controls.Add(this.txtAge);
            this.splitTeachers.Panel1.Controls.Add(this.lblSearch);
            this.splitTeachers.Panel1.Controls.Add(this.txtFirstName);
            this.splitTeachers.Panel1.Controls.Add(this.txtLastName);
            this.splitTeachers.Panel1.Controls.Add(this.txtId);
            // 
            // splitTeachers.Panel2
            // 
            this.splitTeachers.Panel2.Controls.Add(this.splitContainer1);
            this.splitTeachers.Size = new System.Drawing.Size(724, 635);
            this.splitTeachers.SplitterDistance = 193;
            this.splitTeachers.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTeachers);
            this.splitContainer1.Panel1.Controls.Add(this.grdTeachers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdStudents);
            this.splitContainer1.Panel2.Controls.Add(this.lblStudents);
            this.splitContainer1.Size = new System.Drawing.Size(724, 438);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 7;
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachers.Location = new System.Drawing.Point(0, 0);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(74, 16);
            this.lblTeachers.TabIndex = 7;
            this.lblTeachers.Text = "Teachers";
            // 
            // grdStudents
            // 
            this.grdStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stId,
            this.stFullName,
            this.stAge,
            this.TeacherId});
            this.grdStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStudents.Location = new System.Drawing.Point(0, 16);
            this.grdStudents.MultiSelect = false;
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.ReadOnly = true;
            this.grdStudents.RowHeadersVisible = false;
            this.grdStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudents.Size = new System.Drawing.Size(724, 216);
            this.grdStudents.TabIndex = 9;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(0, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(208, 16);
            this.lblStudents.TabIndex = 8;
            this.lblStudents.Text = "Selected Teacher\'s Students";
            // 
            // stId
            // 
            this.stId.DataPropertyName = "Id";
            this.stId.HeaderText = "Id";
            this.stId.Name = "stId";
            this.stId.ReadOnly = true;
            // 
            // stFullName
            // 
            this.stFullName.DataPropertyName = "FullName";
            this.stFullName.HeaderText = "Name";
            this.stFullName.Name = "stFullName";
            this.stFullName.ReadOnly = true;
            // 
            // stAge
            // 
            this.stAge.DataPropertyName = "Age";
            this.stAge.HeaderText = "Age";
            this.stAge.Name = "stAge";
            this.stAge.ReadOnly = true;
            // 
            // TeacherId
            // 
            this.TeacherId.HeaderText = "TeacherId";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 635);
            this.Controls.Add(this.splitTeachers);
            this.Name = "TeachersForm";
            this.Text = "Teachers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeachersForm_FormClosed);
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTeachers)).EndInit();
            this.contextMenuGrdTeachers.ResumeLayout(false);
            this.splitTeachers.Panel1.ResumeLayout(false);
            this.splitTeachers.Panel1.PerformLayout();
            this.splitTeachers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTeachers)).EndInit();
            this.splitTeachers.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdTeachers;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbLastName;
        private System.Windows.Forms.SplitContainer splitTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tchFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tchAge;
        private System.Windows.Forms.ContextMenuStrip contextMenuGrdTeachers;
        private System.Windows.Forms.ToolStripMenuItem menuItemAssignStudent;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditStudent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn stId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
    }
}

