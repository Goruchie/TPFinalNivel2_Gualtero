namespace StoreApp
{
    partial class frmStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStore));
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.pbxItem = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btbDetails = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cboFilterBy = new System.Windows.Forms.ComboBox();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStore
            // 
            this.dgvStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStore.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStore.ColumnHeadersHeight = 50;
            this.dgvStore.Location = new System.Drawing.Point(12, 30);
            this.dgvStore.MultiSelect = false;
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.RowTemplate.Height = 50;
            this.dgvStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStore.Size = new System.Drawing.Size(639, 300);
            this.dgvStore.TabIndex = 0;
            this.dgvStore.SelectionChanged += new System.EventHandler(this.dgvStore_SelectionChanged);
            // 
            // pbxItem
            // 
            this.pbxItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxItem.Location = new System.Drawing.Point(657, 30);
            this.pbxItem.MaximumSize = new System.Drawing.Size(250, 300);
            this.pbxItem.MinimumSize = new System.Drawing.Size(229, 300);
            this.pbxItem.Name = "pbxItem";
            this.pbxItem.Size = new System.Drawing.Size(250, 300);
            this.pbxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxItem.TabIndex = 1;
            this.pbxItem.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(94, 345);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Edit";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btbDetails
            // 
            this.btbDetails.Location = new System.Drawing.Point(256, 345);
            this.btbDetails.Name = "btbDetails";
            this.btbDetails.Size = new System.Drawing.Size(75, 23);
            this.btbDetails.TabIndex = 5;
            this.btbDetails.Text = "Details";
            this.btbDetails.UseVisualStyleBackColor = true;
            this.btbDetails.Click += new System.EventHandler(this.btbDetails_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(12, 400);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(32, 13);
            this.lblFilterBy.TabIndex = 6;
            this.lblFilterBy.Text = "Field:";
            // 
            // cboFilterBy
            // 
            this.cboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterBy.FormattingEnabled = true;
            this.cboFilterBy.Location = new System.Drawing.Point(48, 396);
            this.cboFilterBy.Name = "cboFilterBy";
            this.cboFilterBy.Size = new System.Drawing.Size(121, 21);
            this.cboFilterBy.TabIndex = 7;
            this.cboFilterBy.SelectedIndexChanged += new System.EventHandler(this.cboFilterBy_SelectedIndexChanged);
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Location = new System.Drawing.Point(208, 399);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(42, 13);
            this.lblCriteria.TabIndex = 8;
            this.lblCriteria.Text = "Criteria:";
            // 
            // cboCriteria
            // 
            this.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Location = new System.Drawing.Point(256, 395);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(121, 21);
            this.cboCriteria.TabIndex = 9;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(431, 400);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 10;
            this.lblFilter.Text = "Filter:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(469, 396);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(575, 395);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 434);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboCriteria);
            this.Controls.Add(this.lblCriteria);
            this.Controls.Add(this.cboFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btbDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbxItem);
            this.Controls.Add(this.dgvStore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(935, 473);
            this.MinimumSize = new System.Drawing.Size(935, 473);
            this.Name = "frmStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store App";
            this.Load += new System.EventHandler(this.frmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.PictureBox pbxItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btbDetails;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cboFilterBy;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

