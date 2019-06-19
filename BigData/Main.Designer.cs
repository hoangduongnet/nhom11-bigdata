namespace BigData
{
    partial class Main
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
            this.btn_VnExpress = new System.Windows.Forms.Button();
            this.btn_Moto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_VnExpress
            // 
            this.btn_VnExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VnExpress.Location = new System.Drawing.Point(12, 140);
            this.btn_VnExpress.Name = "btn_VnExpress";
            this.btn_VnExpress.Size = new System.Drawing.Size(215, 163);
            this.btn_VnExpress.TabIndex = 0;
            this.btn_VnExpress.Text = "Tin tức";
            this.btn_VnExpress.UseVisualStyleBackColor = true;
            this.btn_VnExpress.Click += new System.EventHandler(this.Btn_VnExpress_Click);
            // 
            // btn_Moto
            // 
            this.btn_Moto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Moto.Location = new System.Drawing.Point(245, 140);
            this.btn_Moto.Name = "btn_Moto";
            this.btn_Moto.Size = new System.Drawing.Size(215, 163);
            this.btn_Moto.TabIndex = 1;
            this.btn_Moto.Text = "Xe Máy";
            this.btn_Moto.UseVisualStyleBackColor = true;
            this.btn_Moto.Click += new System.EventHandler(this.Btn_Moto_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(125, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "NHÓM 11 BIGDATA";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Moto);
            this.Controls.Add(this.btn_VnExpress);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VnExpress;
        private System.Windows.Forms.Button btn_Moto;
        private System.Windows.Forms.TextBox textBox1;
    }
}