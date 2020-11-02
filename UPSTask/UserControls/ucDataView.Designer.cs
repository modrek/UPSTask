namespace UPSTask.UserControls
{
    partial class ucDataView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.pnlEmployeeGrid = new System.Windows.Forms.Panel();
            this.pnlGridViewContorller = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.GrdEmployees = new System.Windows.Forms.DataGridView();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbnNew = new System.Windows.Forms.Button();
            this.pnlEmployeeDetail = new System.Windows.Forms.Panel();
            this.txtUpdatedAt = new System.Windows.Forms.TextBox();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.drpStatus = new System.Windows.Forms.ComboBox();
            this.Updatedat = new System.Windows.Forms.Label();
            this.Createdat = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.drpGender = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlSearch.SuspendLayout();
            this.pnlEmployeeGrid.SuspendLayout();
            this.pnlGridViewContorller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployees)).BeginInit();
            this.pnlActionButtons.SuspendLayout();
            this.pnlEmployeeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.Search);
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(807, 52);
            this.pnlSearch.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(541, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 25);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear filter";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnSearch.Location = new System.Drawing.Point(455, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(147, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 22);
            this.txtSearch.TabIndex = 27;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Search.Location = new System.Drawing.Point(14, 16);
            this.Search.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 16);
            this.Search.TabIndex = 26;
            this.Search.Text = "Filter on Name : ";
            // 
            // pnlEmployeeGrid
            // 
            this.pnlEmployeeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmployeeGrid.Controls.Add(this.pnlGridViewContorller);
            this.pnlEmployeeGrid.Controls.Add(this.GrdEmployees);
            this.pnlEmployeeGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEmployeeGrid.Location = new System.Drawing.Point(0, 52);
            this.pnlEmployeeGrid.Name = "pnlEmployeeGrid";
            this.pnlEmployeeGrid.Size = new System.Drawing.Size(807, 420);
            this.pnlEmployeeGrid.TabIndex = 19;
            // 
            // pnlGridViewContorller
            // 
            this.pnlGridViewContorller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridViewContorller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridViewContorller.Controls.Add(this.label1);
            this.pnlGridViewContorller.Controls.Add(this.numPage);
            this.pnlGridViewContorller.Location = new System.Drawing.Point(0, 381);
            this.pnlGridViewContorller.Name = "pnlGridViewContorller";
            this.pnlGridViewContorller.Size = new System.Drawing.Size(807, 36);
            this.pnlGridViewContorller.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Page :";
            // 
            // numPage
            // 
            this.numPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numPage.Location = new System.Drawing.Point(87, 6);
            this.numPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(66, 22);
            this.numPage.TabIndex = 17;
            this.numPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.ValueChanged += new System.EventHandler(this.numPage_ValueChanged);
            // 
            // GrdEmployees
            // 
            this.GrdEmployees.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.GrdEmployees.AllowUserToAddRows = false;
            this.GrdEmployees.AllowUserToDeleteRows = false;
            this.GrdEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.GrdEmployees.BackgroundColor = System.Drawing.Color.White;
            this.GrdEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdEmployees.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GrdEmployees.Location = new System.Drawing.Point(0, 0);
            this.GrdEmployees.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GrdEmployees.MultiSelect = false;
            this.GrdEmployees.Name = "GrdEmployees";
            this.GrdEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdEmployees.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.GrdEmployees.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            this.GrdEmployees.RowTemplate.Height = 26;
            this.GrdEmployees.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdEmployees.Size = new System.Drawing.Size(807, 381);
            this.GrdEmployees.TabIndex = 5;
            this.GrdEmployees.SelectionChanged += new System.EventHandler(this.GrdEmployees_SelectionChanged);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionButtons.Controls.Add(this.btnCancel);
            this.pnlActionButtons.Controls.Add(this.btnSave);
            this.pnlActionButtons.Controls.Add(this.btnDelete);
            this.pnlActionButtons.Controls.Add(this.btnEdit);
            this.pnlActionButtons.Controls.Add(this.tbnNew);
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 472);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Size = new System.Drawing.Size(807, 47);
            this.pnlActionButtons.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(297, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cencel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(227, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(157, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(87, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 32);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbnNew
            // 
            this.tbnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbnNew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnNew.Location = new System.Drawing.Point(17, 6);
            this.tbnNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbnNew.Name = "tbnNew";
            this.tbnNew.Size = new System.Drawing.Size(66, 32);
            this.tbnNew.TabIndex = 8;
            this.tbnNew.Text = "New";
            this.tbnNew.UseVisualStyleBackColor = true;
            this.tbnNew.Click += new System.EventHandler(this.tbnNew_Click);
            // 
            // pnlEmployeeDetail
            // 
            this.pnlEmployeeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmployeeDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployeeDetail.Controls.Add(this.txtUpdatedAt);
            this.pnlEmployeeDetail.Controls.Add(this.txtCreatedAt);
            this.pnlEmployeeDetail.Controls.Add(this.Id);
            this.pnlEmployeeDetail.Controls.Add(this.txtId);
            this.pnlEmployeeDetail.Controls.Add(this.drpStatus);
            this.pnlEmployeeDetail.Controls.Add(this.Updatedat);
            this.pnlEmployeeDetail.Controls.Add(this.Createdat);
            this.pnlEmployeeDetail.Controls.Add(this.Status);
            this.pnlEmployeeDetail.Controls.Add(this.drpGender);
            this.pnlEmployeeDetail.Controls.Add(this.Gender);
            this.pnlEmployeeDetail.Controls.Add(this.Email);
            this.pnlEmployeeDetail.Controls.Add(this.lblName);
            this.pnlEmployeeDetail.Controls.Add(this.txtEmail);
            this.pnlEmployeeDetail.Controls.Add(this.txtName);
            this.pnlEmployeeDetail.Location = new System.Drawing.Point(0, 518);
            this.pnlEmployeeDetail.Name = "pnlEmployeeDetail";
            this.pnlEmployeeDetail.Size = new System.Drawing.Size(807, 162);
            this.pnlEmployeeDetail.TabIndex = 22;
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdatedAt.Enabled = false;
            this.txtUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatedAt.Location = new System.Drawing.Point(481, 109);
            this.txtUpdatedAt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUpdatedAt.Name = "txtUpdatedAt";
            this.txtUpdatedAt.Size = new System.Drawing.Size(264, 22);
            this.txtUpdatedAt.TabIndex = 27;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedAt.Location = new System.Drawing.Point(98, 109);
            this.txtCreatedAt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(266, 22);
            this.txtCreatedAt.TabIndex = 26;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(16, 15);
            this.Id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(25, 16);
            this.Id.TabIndex = 25;
            this.Id.Text = "Id :";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(97, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(266, 22);
            this.txtId.TabIndex = 24;
            // 
            // drpStatus
            // 
            this.drpStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpStatus.FormattingEnabled = true;
            this.drpStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.drpStatus.Location = new System.Drawing.Point(97, 74);
            this.drpStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.drpStatus.Name = "drpStatus";
            this.drpStatus.Size = new System.Drawing.Size(266, 24);
            this.drpStatus.TabIndex = 23;
            // 
            // Updatedat
            // 
            this.Updatedat.AutoSize = true;
            this.Updatedat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatedat.Location = new System.Drawing.Point(391, 113);
            this.Updatedat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Updatedat.Name = "Updatedat";
            this.Updatedat.Size = new System.Drawing.Size(81, 16);
            this.Updatedat.TabIndex = 22;
            this.Updatedat.Text = "Updated at :";
            // 
            // Createdat
            // 
            this.Createdat.AutoSize = true;
            this.Createdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createdat.Location = new System.Drawing.Point(17, 114);
            this.Createdat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Createdat.Name = "Createdat";
            this.Createdat.Size = new System.Drawing.Size(76, 16);
            this.Createdat.TabIndex = 21;
            this.Createdat.Text = "Created at :";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(16, 79);
            this.Status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(51, 16);
            this.Status.TabIndex = 20;
            this.Status.Text = "Status :";
            // 
            // drpGender
            // 
            this.drpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpGender.FormattingEnabled = true;
            this.drpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.drpGender.Location = new System.Drawing.Point(481, 42);
            this.drpGender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.drpGender.Name = "drpGender";
            this.drpGender.Size = new System.Drawing.Size(264, 24);
            this.drpGender.TabIndex = 18;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(391, 46);
            this.Gender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(59, 16);
            this.Gender.TabIndex = 17;
            this.Gender.Text = "Gender :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(16, 47);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 16);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(391, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 16);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name :";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(97, 42);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(481, 10);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 22);
            this.txtName.TabIndex = 13;
            this.txtName.Text = "Mohammad";
            // 
            // ucDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEmployeeDetail);
            this.Controls.Add(this.pnlActionButtons);
            this.Controls.Add(this.pnlEmployeeGrid);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ucDataView";
            this.Size = new System.Drawing.Size(809, 680);
            this.Load += new System.EventHandler(this.ucDataView_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlEmployeeGrid.ResumeLayout(false);
            this.pnlGridViewContorller.ResumeLayout(false);
            this.pnlGridViewContorller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployees)).EndInit();
            this.pnlActionButtons.ResumeLayout(false);
            this.pnlEmployeeDetail.ResumeLayout(false);
            this.pnlEmployeeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Panel pnlEmployeeGrid;
        private System.Windows.Forms.Panel pnlGridViewContorller;
        private System.Windows.Forms.DataGridView GrdEmployees;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button tbnNew;
        private System.Windows.Forms.Panel pnlEmployeeDetail;
        private System.Windows.Forms.TextBox txtUpdatedAt;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox drpStatus;
        private System.Windows.Forms.Label Updatedat;
        private System.Windows.Forms.Label Createdat;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox drpGender;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numPage;
        private System.Windows.Forms.Label label1;
    }
}
