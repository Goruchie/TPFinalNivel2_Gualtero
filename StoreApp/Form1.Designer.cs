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
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.pbxItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStore
            // 
            this.dgvStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStore.ColumnHeadersHeight = 50;
            this.dgvStore.Location = new System.Drawing.Point(12, 50);
            this.dgvStore.MultiSelect = false;
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.RowTemplate.Height = 50;
            this.dgvStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStore.Size = new System.Drawing.Size(525, 300);
            this.dgvStore.TabIndex = 0;
            this.dgvStore.SelectionChanged += new System.EventHandler(this.dgvStore_SelectionChanged);
            // 
            // pbxItem
            // 
            this.pbxItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxItem.Location = new System.Drawing.Point(559, 50);
            this.pbxItem.MaximumSize = new System.Drawing.Size(229, 300);
            this.pbxItem.MinimumSize = new System.Drawing.Size(229, 300);
            this.pbxItem.Name = "pbxItem";
            this.pbxItem.Size = new System.Drawing.Size(229, 300);
            this.pbxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxItem.TabIndex = 1;
            this.pbxItem.TabStop = false;
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxItem);
            this.Controls.Add(this.dgvStore);
            this.Name = "frmStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store App";
            this.Load += new System.EventHandler(this.frmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.PictureBox pbxItem;
    }
}

