
namespace OrderForm
{
    partial class Form2
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
            this.labId = new System.Windows.Forms.Label();
            this.labReceiver = new System.Windows.Forms.Label();
            this.labSender = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxReceiver = new System.Windows.Forms.ComboBox();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.bdsOrderDetails = new System.Windows.Forms.BindingSource(this.components);
            this.sumcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(198, 9);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(24, 16);
            this.labId.TabIndex = 0;
            this.labId.Text = "id";
            // 
            // labReceiver
            // 
            this.labReceiver.AutoSize = true;
            this.labReceiver.Location = new System.Drawing.Point(334, 9);
            this.labReceiver.Name = "labReceiver";
            this.labReceiver.Size = new System.Drawing.Size(72, 16);
            this.labReceiver.TabIndex = 1;
            this.labReceiver.Text = "receiver";
            // 
            // labSender
            // 
            this.labSender.AutoSize = true;
            this.labSender.Location = new System.Drawing.Point(552, 9);
            this.labSender.Name = "labSender";
            this.labSender.Size = new System.Drawing.Size(56, 16);
            this.labSender.TabIndex = 2;
            this.labSender.Text = "sender";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(12, 9);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(64, 16);
            this.labAddress.TabIndex = 3;
            this.labAddress.Text = "address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(82, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 26);
            this.txtAddress.TabIndex = 5;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(625, 6);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 26);
            this.txtSender.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(228, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxReceiver);
            this.panel1.Controls.Add(this.btnDeleteDetail);
            this.panel1.Controls.Add(this.btnAddDetail);
            this.panel1.Controls.Add(this.btnSaveOrder);
            this.panel1.Controls.Add(this.labAddress);
            this.panel1.Controls.Add(this.txtSender);
            this.panel1.Controls.Add(this.labSender);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.labId);
            this.panel1.Controls.Add(this.labReceiver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 9;
            // 
            // cbxReceiver
            // 
            this.cbxReceiver.FormattingEnabled = true;
            this.cbxReceiver.Items.AddRange(new object[] {
            "Li",
            "Tang"});
            this.cbxReceiver.Location = new System.Drawing.Point(425, 9);
            this.cbxReceiver.Name = "cbxReceiver";
            this.cbxReceiver.Size = new System.Drawing.Size(121, 24);
            this.cbxReceiver.TabIndex = 12;
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(577, 55);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(87, 34);
            this.btnDeleteDetail.TabIndex = 11;
            this.btnDeleteDetail.Text = "删除明细";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(352, 55);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(84, 34);
            this.btnAddDetail.TabIndex = 10;
            this.btnAddDetail.Text = "添加明细";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(124, 55);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(85, 34);
            this.btnSaveOrder.TabIndex = 9;
            this.btnSaveOrder.Text = "保存订单";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 10;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sumcostDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.itemNumDataGridViewTextBoxColumn});
            this.dgvOrder.DataSource = this.bdsOrderDetails;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 53;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.Size = new System.Drawing.Size(800, 350);
            this.dgvOrder.TabIndex = 0;
            // 
            // bdsOrderDetails
            // 
            this.bdsOrderDetails.DataSource = typeof(Orders.OrderDetails);
            // 
            // sumcostDataGridViewTextBoxColumn
            // 
            this.sumcostDataGridViewTextBoxColumn.DataPropertyName = "sum_cost";
            this.sumcostDataGridViewTextBoxColumn.HeaderText = "sum_cost";
            this.sumcostDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.sumcostDataGridViewTextBoxColumn.Name = "sumcostDataGridViewTextBoxColumn";
            this.sumcostDataGridViewTextBoxColumn.Width = 130;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 130;
            // 
            // itemNumDataGridViewTextBoxColumn
            // 
            this.itemNumDataGridViewTextBoxColumn.DataPropertyName = "itemNum";
            this.itemNumDataGridViewTextBoxColumn.HeaderText = "itemNum";
            this.itemNumDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.itemNumDataGridViewTextBoxColumn.Name = "itemNumDataGridViewTextBoxColumn";
            this.itemNumDataGridViewTextBoxColumn.Width = 130;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labReceiver;
        private System.Windows.Forms.Label labSender;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.BindingSource bdsOrderDetails;
        private System.Windows.Forms.ComboBox cbxReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumDataGridViewTextBoxColumn;
    }
}