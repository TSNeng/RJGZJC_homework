
namespace OrderForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnChangeOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowAllOrders = new System.Windows.Forms.Button();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.txtLookUp = new System.Windows.Forms.TextBox();
            this.cbxLookUp = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsOrderlist = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnChangeOrder);
            this.panel1.Controls.Add(this.btnDeleteOrder);
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(609, 25);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(468, 25);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(88, 30);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnChangeOrder
            // 
            this.btnChangeOrder.Location = new System.Drawing.Point(323, 24);
            this.btnChangeOrder.Name = "btnChangeOrder";
            this.btnChangeOrder.Size = new System.Drawing.Size(95, 31);
            this.btnChangeOrder.TabIndex = 2;
            this.btnChangeOrder.Text = "修改订单";
            this.btnChangeOrder.UseVisualStyleBackColor = true;
            this.btnChangeOrder.Click += new System.EventHandler(this.btnChangeOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(191, 25);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(92, 30);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = "删除订单";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(44, 25);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(87, 30);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "添加订单";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowAllOrders);
            this.panel2.Controls.Add(this.btnLookUp);
            this.panel2.Controls.Add(this.txtLookUp);
            this.panel2.Controls.Add(this.cbxLookUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 73);
            this.panel2.TabIndex = 1;
            // 
            // btnShowAllOrders
            // 
            this.btnShowAllOrders.Location = new System.Drawing.Point(556, 22);
            this.btnShowAllOrders.Name = "btnShowAllOrders";
            this.btnShowAllOrders.Size = new System.Drawing.Size(139, 32);
            this.btnShowAllOrders.TabIndex = 3;
            this.btnShowAllOrders.Text = "显示全部订单";
            this.btnShowAllOrders.UseVisualStyleBackColor = true;
            this.btnShowAllOrders.Click += new System.EventHandler(this.btnShowAllOrders_Click);
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(429, 22);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(75, 32);
            this.btnLookUp.TabIndex = 2;
            this.btnLookUp.Text = "查询";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // txtLookUp
            // 
            this.txtLookUp.Location = new System.Drawing.Point(215, 22);
            this.txtLookUp.Name = "txtLookUp";
            this.txtLookUp.Size = new System.Drawing.Size(177, 26);
            this.txtLookUp.TabIndex = 1;
            // 
            // cbxLookUp
            // 
            this.cbxLookUp.FormattingEnabled = true;
            this.cbxLookUp.Items.AddRange(new object[] {
            "id",
            "final_count",
            "address"});
            this.cbxLookUp.Location = new System.Drawing.Point(44, 25);
            this.cbxLookUp.Name = "cbxLookUp";
            this.cbxLookUp.Size = new System.Drawing.Size(121, 24);
            this.cbxLookUp.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvOrderList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 307);
            this.panel3.TabIndex = 2;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiverDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.finalcountDataGridViewTextBoxColumn});
            this.dgvOrderList.DataSource = this.bdsOrderlist;
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderList.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 53;
            this.dgvOrderList.RowTemplate.Height = 28;
            this.dgvOrderList.Size = new System.Drawing.Size(800, 307);
            this.dgvOrderList.TabIndex = 0;
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "receiver";
            this.receiverDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            this.receiverDataGridViewTextBoxColumn.Width = 130;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "sender";
            this.senderDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.Width = 130;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 130;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 130;
            // 
            // finalcountDataGridViewTextBoxColumn
            // 
            this.finalcountDataGridViewTextBoxColumn.DataPropertyName = "final_count";
            this.finalcountDataGridViewTextBoxColumn.HeaderText = "final_count";
            this.finalcountDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.finalcountDataGridViewTextBoxColumn.Name = "finalcountDataGridViewTextBoxColumn";
            this.finalcountDataGridViewTextBoxColumn.Width = 130;
            // 
            // bdsOrderlist
            // 
            this.bdsOrderlist.DataSource = typeof(Orders.Order);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnChangeOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnShowAllOrders;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.TextBox txtLookUp;
        private System.Windows.Forms.ComboBox cbxLookUp;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsOrderlist;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

