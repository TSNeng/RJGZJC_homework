
namespace OrderForm
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGoodsPrice = new System.Windows.Forms.TextBox();
            this.labGoodsPrice = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.txtItemNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labGoodsName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGoodsPrice);
            this.panel1.Controls.Add(this.labGoodsPrice);
            this.panel1.Controls.Add(this.txtGoodsName);
            this.panel1.Controls.Add(this.btnSaveDetails);
            this.panel1.Controls.Add(this.txtItemNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labGoodsName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // txtGoodsPrice
            // 
            this.txtGoodsPrice.Location = new System.Drawing.Point(284, 187);
            this.txtGoodsPrice.Name = "txtGoodsPrice";
            this.txtGoodsPrice.Size = new System.Drawing.Size(100, 26);
            this.txtGoodsPrice.TabIndex = 8;
            // 
            // labGoodsPrice
            // 
            this.labGoodsPrice.AutoSize = true;
            this.labGoodsPrice.Location = new System.Drawing.Point(116, 198);
            this.labGoodsPrice.Name = "labGoodsPrice";
            this.labGoodsPrice.Size = new System.Drawing.Size(88, 16);
            this.labGoodsPrice.TabIndex = 7;
            this.labGoodsPrice.Text = "GoodsPrice";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(284, 49);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(100, 26);
            this.txtGoodsName.TabIndex = 6;
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.Location = new System.Drawing.Point(535, 111);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDetails.TabIndex = 5;
            this.btnSaveDetails.Text = "确定";
            this.btnSaveDetails.UseVisualStyleBackColor = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // txtItemNum
            // 
            this.txtItemNum.Location = new System.Drawing.Point(284, 114);
            this.txtItemNum.Name = "txtItemNum";
            this.txtItemNum.Size = new System.Drawing.Size(100, 26);
            this.txtItemNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ItemNum";
            // 
            // labGoodsName
            // 
            this.labGoodsName.AutoSize = true;
            this.labGoodsName.Location = new System.Drawing.Point(110, 49);
            this.labGoodsName.Name = "labGoodsName";
            this.labGoodsName.Size = new System.Drawing.Size(80, 16);
            this.labGoodsName.TabIndex = 0;
            this.labGoodsName.Text = "GoodsName";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtItemNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labGoodsName;
        private System.Windows.Forms.Button btnSaveDetails;
        private System.Windows.Forms.TextBox txtGoodsPrice;
        private System.Windows.Forms.Label labGoodsPrice;
        private System.Windows.Forms.TextBox txtGoodsName;
    }
}