namespace BigData
{
    partial class MotoForm
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
            this.txbSearchMoto = new System.Windows.Forms.TextBox();
            this.dr_Moto = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSearchMoto = new System.Windows.Forms.Button();
            this.btnSortMotoASC = new System.Windows.Forms.Button();
            this.btnSortMotoDESC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dr_Moto)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearchMoto
            // 
            this.txbSearchMoto.Location = new System.Drawing.Point(270, 49);
            this.txbSearchMoto.Name = "txbSearchMoto";
            this.txbSearchMoto.Size = new System.Drawing.Size(383, 20);
            this.txbSearchMoto.TabIndex = 0;
            // 
            // dr_Moto
            // 
            this.dr_Moto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dr_Moto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.Link,
            this.Img});
            this.dr_Moto.Location = new System.Drawing.Point(12, 94);
            this.dr_Moto.Name = "dr_Moto";
            this.dr_Moto.Size = new System.Drawing.Size(1462, 737);
            this.dr_Moto.TabIndex = 1;
            this.dr_Moto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dr_Moto_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Tên xe";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link xe";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            // 
            // Img
            // 
            this.Img.HeaderText = "Ảnh xe";
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // btnSearchMoto
            // 
            this.btnSearchMoto.Location = new System.Drawing.Point(685, 49);
            this.btnSearchMoto.Name = "btnSearchMoto";
            this.btnSearchMoto.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMoto.TabIndex = 2;
            this.btnSearchMoto.Text = "Tìm kiếm";
            this.btnSearchMoto.UseVisualStyleBackColor = true;
            this.btnSearchMoto.Click += new System.EventHandler(this.BtnSearchMoto_Click);
            // 
            // btnSortMotoASC
            // 
            this.btnSortMotoASC.Location = new System.Drawing.Point(906, 49);
            this.btnSortMotoASC.Name = "btnSortMotoASC";
            this.btnSortMotoASC.Size = new System.Drawing.Size(122, 23);
            this.btnSortMotoASC.TabIndex = 3;
            this.btnSortMotoASC.Text = "Giá Thấp - Cao";
            this.btnSortMotoASC.UseVisualStyleBackColor = true;
            this.btnSortMotoASC.Click += new System.EventHandler(this.BtnSortMotoASC_Click);
            // 
            // btnSortMotoDESC
            // 
            this.btnSortMotoDESC.Location = new System.Drawing.Point(1077, 49);
            this.btnSortMotoDESC.Name = "btnSortMotoDESC";
            this.btnSortMotoDESC.Size = new System.Drawing.Size(122, 23);
            this.btnSortMotoDESC.TabIndex = 4;
            this.btnSortMotoDESC.Text = "Giá Cao - Thấp";
            this.btnSortMotoDESC.UseVisualStyleBackColor = true;
            this.btnSortMotoDESC.Click += new System.EventHandler(this.BtnSortMotoDESC_Click);
            // 
            // MotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 843);
            this.Controls.Add(this.btnSortMotoDESC);
            this.Controls.Add(this.btnSortMotoASC);
            this.Controls.Add(this.btnSearchMoto);
            this.Controls.Add(this.dr_Moto);
            this.Controls.Add(this.txbSearchMoto);
            this.Name = "MotoForm";
            this.Text = "MotoForm";
            this.Load += new System.EventHandler(this.MotoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dr_Moto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearchMoto;
        private System.Windows.Forms.DataGridView dr_Moto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.Button btnSearchMoto;
        private System.Windows.Forms.Button btnSortMotoASC;
        private System.Windows.Forms.Button btnSortMotoDESC;
    }
}