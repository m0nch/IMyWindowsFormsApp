namespace IMyWindowsFormsApp
{
    partial class StudentsForm
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
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbLastName = new System.Windows.Forms.ComboBox();
            this.splitStudents = new System.Windows.Forms.SplitContainer();
            this.contextMenuGrdStudents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAssignTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRemoveTeacher = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitStudents)).BeginInit();
            this.splitStudents.Panel1.SuspendLayout();
            this.splitStudents.Panel2.SuspendLayout();
            this.splitStudents.SuspendLayout();
            this.contextMenuGrdStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 7);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(164, 18);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Students Information";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(109, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(358, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(19, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(19, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 15);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(19, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(19, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(109, 90);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(358, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(109, 118);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(358, 22);
            this.txtAge.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(109, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(358, 22);
            this.txtId.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(516, 33);
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
            this.btnRemove.Location = new System.Drawing.Point(516, 61);
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
            this.btnUpdate.Location = new System.Drawing.Point(516, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stFullName,
            this.stAge,
            this.TeacherId});
            this.grdStudents.ContextMenuStrip = this.contextMenuGrdStudents;
            this.grdStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStudents.Location = new System.Drawing.Point(0, 0);
            this.grdStudents.MultiSelect = false;
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.ReadOnly = true;
            this.grdStudents.RowHeadersVisible = false;
            this.grdStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudents.Size = new System.Drawing.Size(616, 299);
            this.grdStudents.TabIndex = 6;
            this.grdStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellClick);
            this.grdStudents.SelectionChanged += new System.EventHandler(this.grdStudent_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 273);
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
            this.cmbLastName.Location = new System.Drawing.Point(164, 272);
            this.cmbLastName.Name = "cmbLastName";
            this.cmbLastName.Size = new System.Drawing.Size(437, 21);
            this.cmbLastName.TabIndex = 5;
            this.cmbLastName.Visible = false;
            this.cmbLastName.SelectedValueChanged += new System.EventHandler(this.cmbLastName_SelectedValueChanged);
            // 
            // splitStudents
            // 
            this.splitStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStudents.Location = new System.Drawing.Point(0, 0);
            this.splitStudents.Name = "splitStudents";
            this.splitStudents.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitStudents.Panel1
            // 
            this.splitStudents.Panel1.Controls.Add(this.lblInfo);
            this.splitStudents.Panel1.Controls.Add(this.cmbLastName);
            this.splitStudents.Panel1.Controls.Add(this.lblId);
            this.splitStudents.Panel1.Controls.Add(this.btnUpdate);
            this.splitStudents.Panel1.Controls.Add(this.lblLastName);
            this.splitStudents.Panel1.Controls.Add(this.btnRemove);
            this.splitStudents.Panel1.Controls.Add(this.lblFirstName);
            this.splitStudents.Panel1.Controls.Add(this.btnAdd);
            this.splitStudents.Panel1.Controls.Add(this.lblAge);
            this.splitStudents.Panel1.Controls.Add(this.txtAge);
            this.splitStudents.Panel1.Controls.Add(this.lblSearch);
            this.splitStudents.Panel1.Controls.Add(this.txtFirstName);
            this.splitStudents.Panel1.Controls.Add(this.txtLastName);
            this.splitStudents.Panel1.Controls.Add(this.txtId);
            // 
            // splitStudents.Panel2
            // 
            this.splitStudents.Panel2.Controls.Add(this.grdStudents);
            this.splitStudents.Size = new System.Drawing.Size(616, 605);
            this.splitStudents.SplitterDistance = 302;
            this.splitStudents.TabIndex = 10;
            // 
            // contextMenuGrdStudents
            // 
            this.contextMenuGrdStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAssignTeacher,
            this.menuItemRemoveTeacher});
            this.contextMenuGrdStudents.Name = "contextMenuGrdTeachers";
            this.contextMenuGrdStudents.Size = new System.Drawing.Size(169, 48);
            // 
            // menuItemAssignTeacher
            // 
            this.menuItemAssignTeacher.Name = "menuItemAssignTeacher";
            this.menuItemAssignTeacher.Size = new System.Drawing.Size(168, 22);
            this.menuItemAssignTeacher.Text = "Assign Teacher";
            // 
            // menuItemRemoveTeacher
            // 
            this.menuItemRemoveTeacher.Name = "menuItemRemoveTeacher";
            this.menuItemRemoveTeacher.Size = new System.Drawing.Size(168, 22);
            this.menuItemRemoveTeacher.Text = "Remove Teacher";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 605);
            this.Controls.Add(this.splitStudents);
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.splitStudents.Panel1.ResumeLayout(false);
            this.splitStudents.Panel1.PerformLayout();
            this.splitStudents.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStudents)).EndInit();
            this.splitStudents.ResumeLayout(false);
            this.contextMenuGrdStudents.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbLastName;
        private System.Windows.Forms.SplitContainer splitStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.ContextMenuStrip contextMenuGrdStudents;
        private System.Windows.Forms.ToolStripMenuItem menuItemAssignTeacher;
        private System.Windows.Forms.ToolStripMenuItem menuItemRemoveTeacher;
    }
}

