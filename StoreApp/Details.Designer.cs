namespace StoreApp
{
    partial class Details
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCodeD = new System.Windows.Forms.Label();
            this.lblNameD = new System.Windows.Forms.Label();
            this.lblDescriptionD = new System.Windows.Forms.Label();
            this.lblBrandD = new System.Windows.Forms.Label();
            this.lblCategoryD = new System.Windows.Forms.Label();
            this.lblPriceD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brand:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price:";
            // 
            // lblCodeD
            // 
            this.lblCodeD.AutoSize = true;
            this.lblCodeD.Location = new System.Drawing.Point(87, 42);
            this.lblCodeD.Name = "lblCodeD";
            this.lblCodeD.Size = new System.Drawing.Size(0, 13);
            this.lblCodeD.TabIndex = 6;
            // 
            // lblNameD
            // 
            this.lblNameD.AutoSize = true;
            this.lblNameD.Location = new System.Drawing.Point(87, 97);
            this.lblNameD.Name = "lblNameD";
            this.lblNameD.Size = new System.Drawing.Size(0, 13);
            this.lblNameD.TabIndex = 7;
            // 
            // lblDescriptionD
            // 
            this.lblDescriptionD.AutoSize = true;
            this.lblDescriptionD.Location = new System.Drawing.Point(87, 152);
            this.lblDescriptionD.MaximumSize = new System.Drawing.Size(285, 0);
            this.lblDescriptionD.Name = "lblDescriptionD";
            this.lblDescriptionD.Size = new System.Drawing.Size(0, 13);
            this.lblDescriptionD.TabIndex = 8;
            // 
            // lblBrandD
            // 
            this.lblBrandD.AutoSize = true;
            this.lblBrandD.Location = new System.Drawing.Point(87, 207);
            this.lblBrandD.Name = "lblBrandD";
            this.lblBrandD.Size = new System.Drawing.Size(0, 13);
            this.lblBrandD.TabIndex = 9;
            // 
            // lblCategoryD
            // 
            this.lblCategoryD.AutoSize = true;
            this.lblCategoryD.Location = new System.Drawing.Point(87, 262);
            this.lblCategoryD.Name = "lblCategoryD";
            this.lblCategoryD.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryD.TabIndex = 10;
            // 
            // lblPriceD
            // 
            this.lblPriceD.AutoSize = true;
            this.lblPriceD.Location = new System.Drawing.Point(81, 323);
            this.lblPriceD.Name = "lblPriceD";
            this.lblPriceD.Size = new System.Drawing.Size(0, 13);
            this.lblPriceD.TabIndex = 11;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 375);
            this.Controls.Add(this.lblPriceD);
            this.Controls.Add(this.lblCategoryD);
            this.Controls.Add(this.lblBrandD);
            this.Controls.Add(this.lblDescriptionD);
            this.Controls.Add(this.lblNameD);
            this.Controls.Add(this.lblCodeD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCodeD;
        private System.Windows.Forms.Label lblNameD;
        private System.Windows.Forms.Label lblDescriptionD;
        private System.Windows.Forms.Label lblBrandD;
        private System.Windows.Forms.Label lblCategoryD;
        private System.Windows.Forms.Label lblPriceD;
    }
}