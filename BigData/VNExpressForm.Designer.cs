namespace BigData
{
    partial class VNExpressForm
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
            this.txbSearchNews = new System.Windows.Forms.TextBox();
            this.drListNews = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSearchNews = new System.Windows.Forms.Button();
            this.btnSortNewsASC = new System.Windows.Forms.Button();
            this.btnSortNewsDESC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drListNews)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearchNews
            // 
            this.txbSearchNews.Location = new System.Drawing.Point(272, 37);
            this.txbSearchNews.Name = "txbSearchNews";
            this.txbSearchNews.Size = new System.Drawing.Size(252, 20);
            this.txbSearchNews.TabIndex = 0;
            // 
            // drListNews
            // 
            this.drListNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drListNews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Link,
            this.Desc,
            this.Img});
            this.drListNews.Location = new System.Drawing.Point(21, 86);
            this.drListNews.Name = "drListNews";
            this.drListNews.Size = new System.Drawing.Size(1462, 711);
            this.drListNews.TabIndex = 1;
            this.drListNews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrListNews_CellContentClick);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.HeaderText = "Tiêu đề";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 69;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Desc.HeaderText = "Mô tả ngắn";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 86;
            // 
            // Img
            // 
            this.Img.HeaderText = "Ảnh";
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // btnSearchNews
            // 
            this.btnSearchNews.Location = new System.Drawing.Point(561, 33);
            this.btnSearchNews.Name = "btnSearchNews";
            this.btnSearchNews.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNews.TabIndex = 2;
            this.btnSearchNews.Text = "Tìm kiếm";
            this.btnSearchNews.UseVisualStyleBackColor = true;
            this.btnSearchNews.Click += new System.EventHandler(this.BtnSearchNews_Click);
            // 
            // btnSortNewsASC
            // 
            this.btnSortNewsASC.Location = new System.Drawing.Point(876, 33);
            this.btnSortNewsASC.Name = "btnSortNewsASC";
            this.btnSortNewsASC.Size = new System.Drawing.Size(75, 23);
            this.btnSortNewsASC.TabIndex = 3;
            this.btnSortNewsASC.Text = "A - Z";
            this.btnSortNewsASC.UseVisualStyleBackColor = true;
            this.btnSortNewsASC.Click += new System.EventHandler(this.BtnSortNewsASC_Click);
            // 
            // btnSortNewsDESC
            // 
            this.btnSortNewsDESC.Location = new System.Drawing.Point(990, 33);
            this.btnSortNewsDESC.Name = "btnSortNewsDESC";
            this.btnSortNewsDESC.Size = new System.Drawing.Size(75, 23);
            this.btnSortNewsDESC.TabIndex = 4;
            this.btnSortNewsDESC.Text = "Z - A";
            this.btnSortNewsDESC.UseVisualStyleBackColor = true;
            this.btnSortNewsDESC.Click += new System.EventHandler(this.BtnSortNewsDESC_Click);
            // 
            // VNExpressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 809);
            this.Controls.Add(this.btnSortNewsDESC);
            this.Controls.Add(this.btnSortNewsASC);
            this.Controls.Add(this.btnSearchNews);
            this.Controls.Add(this.drListNews);
            this.Controls.Add(this.txbSearchNews);
            this.Name = "VNExpressForm";
            this.Text = "ListNews";
            this.Load += new System.EventHandler(this.ListNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drListNews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearchNews;
        private System.Windows.Forms.DataGridView drListNews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.Button btnSearchNews;
        private System.Windows.Forms.Button btnSortNewsASC;
        private System.Windows.Forms.Button btnSortNewsDESC;
    }
}