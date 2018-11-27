namespace wareHouse
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ttxtID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.inventoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseincludeTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesincludeTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbPName = new System.Windows.Forms.ComboBox();
            this.cbsale = new System.Windows.Forms.CheckBox();
            this.cbpurchase = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPNID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinventoryNumber = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.ttxtID,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(52, 22);
            this.tsbNew.Text = "新建";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton1.Text = "快速查询：";
            // 
            // ttxtID
            // 
            this.ttxtID.Name = "ttxtID";
            this.ttxtID.Size = new System.Drawing.Size(100, 25);
            this.ttxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttxtID_KeyPress);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Select";
            this.toolStripButton2.ToolTipText = "查询,内容为空查询全部";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton3.Text = "打印库存表";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryNumber,
            this.productID,
            this.productName,
            this.model,
            this.purchasePrice,
            this.purchaseincludeTax,
            this.salesPrice,
            this.salesincludeTax,
            this.unit,
            this.inventoryQuantity});
            this.dgvInventory.Location = new System.Drawing.Point(10, 142);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowTemplate.Height = 23;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(813, 329);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);
            // 
            // inventoryNumber
            // 
            this.inventoryNumber.DataPropertyName = "inventoryNumber";
            this.inventoryNumber.HeaderText = "库存编号";
            this.inventoryNumber.Name = "inventoryNumber";
            this.inventoryNumber.ReadOnly = true;
            this.inventoryNumber.Visible = false;
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "产品编号";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "产品名称";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 180;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "规格型号";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 200;
            // 
            // purchasePrice
            // 
            this.purchasePrice.DataPropertyName = "purchasePrice";
            this.purchasePrice.HeaderText = "采购单价";
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.ReadOnly = true;
            // 
            // purchaseincludeTax
            // 
            this.purchaseincludeTax.DataPropertyName = "purchaseincludeTax";
            this.purchaseincludeTax.HeaderText = "采购单价是否含税";
            this.purchaseincludeTax.Name = "purchaseincludeTax";
            this.purchaseincludeTax.ReadOnly = true;
            this.purchaseincludeTax.Visible = false;
            // 
            // salesPrice
            // 
            this.salesPrice.DataPropertyName = "salesPrice";
            this.salesPrice.HeaderText = "销售单价";
            this.salesPrice.Name = "salesPrice";
            this.salesPrice.ReadOnly = true;
            // 
            // salesincludeTax
            // 
            this.salesincludeTax.DataPropertyName = "salesincludeTax";
            this.salesincludeTax.HeaderText = "销售单价是否含税";
            this.salesincludeTax.Name = "salesincludeTax";
            this.salesincludeTax.ReadOnly = true;
            this.salesincludeTax.Visible = false;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "单位";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 80;
            // 
            // inventoryQuantity
            // 
            this.inventoryQuantity.DataPropertyName = "inventoryQuantity";
            this.inventoryQuantity.HeaderText = "库存数量";
            this.inventoryQuantity.Name = "inventoryQuantity";
            this.inventoryQuantity.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbPName);
            this.groupBox1.Controls.Add(this.cbsale);
            this.groupBox1.Controls.Add(this.cbpurchase);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbbUnit);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSalePrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPNID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtinventoryNumber);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产品信息操作";
            // 
            // cbbPName
            // 
            this.cbbPName.FormattingEnabled = true;
            this.cbbPName.Location = new System.Drawing.Point(86, 44);
            this.cbbPName.Name = "cbbPName";
            this.cbbPName.Size = new System.Drawing.Size(136, 20);
            this.cbbPName.TabIndex = 11;
            this.cbbPName.SelectedIndexChanged += new System.EventHandler(this.cbbPName_SelectedIndexChanged);
            // 
            // cbsale
            // 
            this.cbsale.AutoSize = true;
            this.cbsale.Location = new System.Drawing.Point(427, 46);
            this.cbsale.Name = "cbsale";
            this.cbsale.Size = new System.Drawing.Size(48, 16);
            this.cbsale.TabIndex = 6;
            this.cbsale.Text = "含税";
            this.cbsale.UseVisualStyleBackColor = true;
            // 
            // cbpurchase
            // 
            this.cbpurchase.AutoSize = true;
            this.cbpurchase.Location = new System.Drawing.Point(427, 20);
            this.cbpurchase.Name = "cbpurchase";
            this.cbpurchase.Size = new System.Drawing.Size(48, 16);
            this.cbpurchase.TabIndex = 4;
            this.cbpurchase.Text = "含税";
            this.cbpurchase.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(701, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbUnit
            // 
            this.cbbUnit.FormattingEnabled = true;
            this.cbbUnit.Items.AddRange(new object[] {
            "台",
            "个",
            "套",
            "卷",
            "包",
            "盒",
            "条"});
            this.cbbUnit.Location = new System.Drawing.Point(568, 44);
            this.cbbUnit.Name = "cbbUnit";
            this.cbbUnit.Size = new System.Drawing.Size(71, 20);
            this.cbbUnit.TabIndex = 9;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(568, 18);
            this.txtNum.MaxLength = 5;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(71, 21);
            this.txtNum.TabIndex = 8;
            this.txtNum.Text = "0";
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "库存数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "单位";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(305, 44);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(116, 21);
            this.txtSalePrice.TabIndex = 5;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtSalePrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "销售单价";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(305, 18);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 21);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "采购单价";
            // 
            // txtPNID
            // 
            this.txtPNID.Location = new System.Drawing.Point(305, 76);
            this.txtPNID.Name = "txtPNID";
            this.txtPNID.Size = new System.Drawing.Size(334, 21);
            this.txtPNID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "规格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "产品名称";
            // 
            // txtinventoryNumber
            // 
            this.txtinventoryNumber.Location = new System.Drawing.Point(86, 18);
            this.txtinventoryNumber.Name = "txtinventoryNumber";
            this.txtinventoryNumber.Size = new System.Drawing.Size(136, 21);
            this.txtinventoryNumber.TabIndex = 0;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(86, 76);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(136, 21);
            this.txtPID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "库存编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品编号";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventory";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox ttxtID;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbbUnit;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPNID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox cbsale;
        private System.Windows.Forms.CheckBox cbpurchase;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtinventoryNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseincludeTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesincludeTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryQuantity;
        private System.Windows.Forms.ComboBox cbbPName;
    }
}