namespace wareHouse
{
    partial class frmDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtPID = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbClientName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTax = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbSale = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbbPNID = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbbproName = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.dtpCArriveDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbCtrackingName = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCtrackingID = new System.Windows.Forms.TextBox();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.autoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tstxtPID,
            this.tsbtnSelect,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
            this.toolStrip1.TabIndex = 1;
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
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel1.Text = "单号快速查询：";
            // 
            // tstxtPID
            // 
            this.tstxtPID.Name = "tstxtPID";
            this.tstxtPID.Size = new System.Drawing.Size(100, 25);
            this.tstxtPID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstxtPID_KeyPress);
            // 
            // tsbtnSelect
            // 
            this.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSelect.Image")));
            this.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSelect.Name = "tsbtnSelect";
            this.tsbtnSelect.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSelect.Text = "查询";
            this.tsbtnSelect.Click += new System.EventHandler(this.tsbtnSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton1.Text = "打印送货单";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbClientName);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtpCArriveDate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cbbCtrackingName);
            this.groupBox2.Controls.Add(this.txtRemark);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtCtrackingID);
            this.groupBox2.Controls.Add(this.txtContract);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 301);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出库信息";
            // 
            // cbbClientName
            // 
            this.cbbClientName.FormattingEnabled = true;
            this.cbbClientName.Location = new System.Drawing.Point(290, 18);
            this.cbbClientName.Name = "cbbClientName";
            this.cbbClientName.Size = new System.Drawing.Size(100, 20);
            this.cbbClientName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTax);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.cbbSale);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNumber);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cbbPNID);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cbbproName);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.dgvPro);
            this.groupBox3.Location = new System.Drawing.Point(0, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 217);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "货物信息";
            // 
            // cbTax
            // 
            this.cbTax.AutoSize = true;
            this.cbTax.Location = new System.Drawing.Point(8, 189);
            this.cbTax.Name = "cbTax";
            this.cbTax.Size = new System.Drawing.Size(48, 16);
            this.cbTax.TabIndex = 20;
            this.cbTax.Text = "含税";
            this.cbTax.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(89, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbSale
            // 
            this.cbbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Location = new System.Drawing.Point(71, 140);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(98, 20);
            this.cbbSale.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "折扣:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(71, 113);
            this.txtPrice.MaxLength = 100;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(98, 21);
            this.txtPrice.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "销售单价:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(71, 81);
            this.txtNumber.MaxLength = 100;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(98, 21);
            this.txtNumber.TabIndex = 9;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 11;
            this.label20.Text = "数量:";
            // 
            // cbbPNID
            // 
            this.cbbPNID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPNID.FormattingEnabled = true;
            this.cbbPNID.Location = new System.Drawing.Point(71, 49);
            this.cbbPNID.Name = "cbbPNID";
            this.cbbPNID.Size = new System.Drawing.Size(98, 20);
            this.cbbPNID.TabIndex = 8;
            this.cbbPNID.SelectedValueChanged += new System.EventHandler(this.cbbPNID_SelectedValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(30, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 12;
            this.label21.Text = "规格:";
            // 
            // cbbproName
            // 
            this.cbbproName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbproName.FormattingEnabled = true;
            this.cbbproName.Location = new System.Drawing.Point(71, 17);
            this.cbbproName.Name = "cbbproName";
            this.cbbproName.Size = new System.Drawing.Size(98, 20);
            this.cbbproName.TabIndex = 7;
            this.cbbproName.SelectedValueChanged += new System.EventHandler(this.cbbproName_SelectedValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 13;
            this.label22.Text = "产品名称:";
            // 
            // dgvPro
            // 
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoid,
            this.proID,
            this.proname,
            this.pnid,
            this.amount,
            this.sellprice,
            this.tax,
            this.sale,
            this.subtotal});
            this.dgvPro.Location = new System.Drawing.Point(188, 17);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.RowTemplate.Height = 23;
            this.dgvPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPro.Size = new System.Drawing.Size(643, 188);
            this.dgvPro.TabIndex = 0;
            this.dgvPro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellEndEdit);
            // 
            // dtpCArriveDate
            // 
            this.dtpCArriveDate.CustomFormat = "yyyy/MM/dd";
            this.dtpCArriveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCArriveDate.Location = new System.Drawing.Point(97, 55);
            this.dtpCArriveDate.Name = "dtpCArriveDate";
            this.dtpCArriveDate.Size = new System.Drawing.Size(100, 21);
            this.dtpCArriveDate.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "到货时间";
            // 
            // cbbCtrackingName
            // 
            this.cbbCtrackingName.FormattingEnabled = true;
            this.cbbCtrackingName.Items.AddRange(new object[] {
            "申通",
            "EMS",
            "顺丰",
            "圆通",
            "中通",
            "韵达",
            "天天",
            "汇通",
            "全峰",
            "德邦",
            "如风达",
            "宅急送"});
            this.cbbCtrackingName.Location = new System.Drawing.Point(700, 18);
            this.cbbCtrackingName.Name = "cbbCtrackingName";
            this.cbbCtrackingName.Size = new System.Drawing.Size(121, 20);
            this.cbbCtrackingName.TabIndex = 3;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(483, 55);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(339, 21);
            this.txtRemark.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(290, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtCtrackingID
            // 
            this.txtCtrackingID.Location = new System.Drawing.Point(483, 18);
            this.txtCtrackingID.Name = "txtCtrackingID";
            this.txtCtrackingID.Size = new System.Drawing.Size(100, 21);
            this.txtCtrackingID.TabIndex = 2;
            this.txtCtrackingID.Leave += new System.EventHandler(this.txtContract_Leave);
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(97, 18);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 21);
            this.txtContract.TabIndex = 0;
            this.txtContract.Leave += new System.EventHandler(this.txtContract_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(603, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "快递公司名称";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(410, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "备注";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(410, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "快递单号";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(219, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "发货人";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(217, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "客户名称";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "合同订单号";
            // 
            // autoid
            // 
            this.autoid.HeaderText = "序号";
            this.autoid.Name = "autoid";
            this.autoid.ReadOnly = true;
            // 
            // proID
            // 
            this.proID.HeaderText = "产品编号";
            this.proID.Name = "proID";
            this.proID.ReadOnly = true;
            this.proID.Visible = false;
            // 
            // proname
            // 
            this.proname.HeaderText = "产品名称";
            this.proname.Name = "proname";
            // 
            // pnid
            // 
            this.pnid.HeaderText = "规格型号";
            this.pnid.Name = "pnid";
            this.pnid.ReadOnly = true;
            this.pnid.Width = 200;
            // 
            // amount
            // 
            this.amount.HeaderText = "数量";
            this.amount.Name = "amount";
            // 
            // sellprice
            // 
            this.sellprice.HeaderText = "销售单价";
            this.sellprice.Name = "sellprice";
            this.sellprice.ReadOnly = true;
            // 
            // tax
            // 
            this.tax.HeaderText = "是否含税";
            this.tax.Name = "tax";
            this.tax.Visible = false;
            // 
            // sale
            // 
            this.sale.HeaderText = "折扣";
            this.sale.Name = "sale";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "小计";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDelivery";
            this.Text = "出库管理";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtPID;
        private System.Windows.Forms.ToolStripButton tsbtnSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpCArriveDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbCtrackingName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCtrackingID;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbPNID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbbproName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbbClientName;
        private System.Windows.Forms.ComboBox cbbSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}