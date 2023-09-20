namespace Webbrowser1
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
            this.components = new System.ComponentModel.Container();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.contactDetailsDataSet = new Webbrowser1.ContactDetailsDataSet();
            this.contactDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDetailsTableAdapter = new Webbrowser1.ContactDetailsDataSetTableAdapters.ContactDetailsTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lbcontactdetaiils = new System.Windows.Forms.Label();
            this.lbEntercontactDetails = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbZip = new System.Windows.Forms.Label();
            this.lbFilterContacts = new System.Windows.Forms.Label();
            this.lbFiteron = new System.Windows.Forms.Label();
            this.lbPatter = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.contactDetailsBindingSource;
            this.DataGrid.Location = new System.Drawing.Point(28, 95);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(945, 423);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // contactDetailsDataSet
            // 
            this.contactDetailsDataSet.DataSetName = "ContactDetailsDataSet";
            this.contactDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactDetailsBindingSource
            // 
            this.contactDetailsBindingSource.DataMember = "ContactDetails";
            this.contactDetailsBindingSource.DataSource = this.contactDetailsDataSet;
            // 
            // contactDetailsTableAdapter
            // 
            this.contactDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            this.zipDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(780, 534);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 25);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1290, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(1290, 471);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(83, 25);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(890, 534);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(83, 25);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lbcontactdetaiils
            // 
            this.lbcontactdetaiils.AutoSize = true;
            this.lbcontactdetaiils.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontactdetaiils.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbcontactdetaiils.Location = new System.Drawing.Point(25, 35);
            this.lbcontactdetaiils.Name = "lbcontactdetaiils";
            this.lbcontactdetaiils.Size = new System.Drawing.Size(76, 20);
            this.lbcontactdetaiils.TabIndex = 5;
            this.lbcontactdetaiils.Text = "Contacts";
            // 
            // lbEntercontactDetails
            // 
            this.lbEntercontactDetails.AutoSize = true;
            this.lbEntercontactDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEntercontactDetails.Location = new System.Drawing.Point(1031, 68);
            this.lbEntercontactDetails.Name = "lbEntercontactDetails";
            this.lbEntercontactDetails.Size = new System.Drawing.Size(131, 16);
            this.lbEntercontactDetails.TabIndex = 6;
            this.lbEntercontactDetails.Text = "Enter Contact Details";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(1038, 113);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(1038, 150);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(42, 16);
            this.lbStreet.TabIndex = 8;
            this.lbStreet.Text = "Street";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(1038, 184);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(29, 16);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "City";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(1038, 224);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(38, 16);
            this.lbState.TabIndex = 10;
            this.lbState.Text = "State";
            // 
            // lbZip
            // 
            this.lbZip.AutoSize = true;
            this.lbZip.Location = new System.Drawing.Point(1038, 267);
            this.lbZip.Name = "lbZip";
            this.lbZip.Size = new System.Drawing.Size(26, 16);
            this.lbZip.TabIndex = 11;
            this.lbZip.Text = "Zip";
            // 
            // lbFilterContacts
            // 
            this.lbFilterContacts.AutoSize = true;
            this.lbFilterContacts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbFilterContacts.Location = new System.Drawing.Point(1031, 361);
            this.lbFilterContacts.Name = "lbFilterContacts";
            this.lbFilterContacts.Size = new System.Drawing.Size(91, 16);
            this.lbFilterContacts.TabIndex = 12;
            this.lbFilterContacts.Text = "Filter Contacts";
            // 
            // lbFiteron
            // 
            this.lbFiteron.AutoSize = true;
            this.lbFiteron.Location = new System.Drawing.Point(1038, 393);
            this.lbFiteron.Name = "lbFiteron";
            this.lbFiteron.Size = new System.Drawing.Size(56, 16);
            this.lbFiteron.TabIndex = 13;
            this.lbFiteron.Text = "Filter On";
            // 
            // lbPatter
            // 
            this.lbPatter.AutoSize = true;
            this.lbPatter.Location = new System.Drawing.Point(1038, 430);
            this.lbPatter.Name = "lbPatter";
            this.lbPatter.Size = new System.Drawing.Size(49, 16);
            this.lbPatter.TabIndex = 14;
            this.lbPatter.Text = "Pattern";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(1129, 107);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(244, 22);
            this.tbName.TabIndex = 15;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(1129, 147);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(244, 22);
            this.tbStreet.TabIndex = 16;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(1129, 181);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(244, 22);
            this.tbCity.TabIndex = 17;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(1129, 218);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(244, 22);
            this.tbState.TabIndex = 18;
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(1129, 264);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(244, 22);
            this.tbZip.TabIndex = 19;
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(1129, 424);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(244, 22);
            this.tbPattern.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Street",
            "City",
            "State",
            "Zip"});
            this.comboBox1.Location = new System.Drawing.Point(1129, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 591);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbPattern);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPatter);
            this.Controls.Add(this.lbFiteron);
            this.Controls.Add(this.lbFilterContacts);
            this.Controls.Add(this.lbZip);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbStreet);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbEntercontactDetails);
            this.Controls.Add(this.lbcontactdetaiils);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.DataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private ContactDetailsDataSet contactDetailsDataSet;
        private System.Windows.Forms.BindingSource contactDetailsBindingSource;
        private ContactDetailsDataSetTableAdapters.ContactDetailsTableAdapter contactDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lbcontactdetaiils;
        private System.Windows.Forms.Label lbEntercontactDetails;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbZip;
        private System.Windows.Forms.Label lbFilterContacts;
        private System.Windows.Forms.Label lbFiteron;
        private System.Windows.Forms.Label lbPatter;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbPattern;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

