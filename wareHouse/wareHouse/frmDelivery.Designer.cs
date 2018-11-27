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
            this.components = new System.ComponentModel.Container();
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
            this.cbDirect = new System.Windows.Forms.CheckBox();
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
            this.cbbproName = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.autoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbSNCode = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbSNCode = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.gbSNCode.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1209, 25);
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
            this.tstxtPID.ToolTipText = "输入订单查询";
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
            this.groupBox2.Controls.Add(this.cbDirect);
            this.groupBox2.Controls.Add(this.cbbClientName);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtpCArriveDate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cbbCtrackingName);
            this.groupBox2.Controls.Add(this.txtRemark);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtCtrackingID);
            this.groupBox2.Controls.Add(this.txtOrder);
            this.groupBox2.Controls.Add(this.txtContract);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 367);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出库信息";
            // 
            // cbDirect
            // 
            this.cbDirect.AutoSize = true;
            this.cbDirect.Location = new System.Drawing.Point(512, 21);
            this.cbDirect.Name = "cbDirect";
            this.cbDirect.Size = new System.Drawing.Size(48, 16);
            this.cbDirect.TabIndex = 3;
            this.cbDirect.Text = "直发";
            this.cbDirect.UseVisualStyleBackColor = true;
            this.cbDirect.CheckedChanged += new System.EventHandler(this.cbDirect_CheckedChanged);
            // 
            // cbbClientName
            // 
            this.cbbClientName.FormattingEnabled = true;
            this.cbbClientName.Location = new System.Drawing.Point(263, 19);
            this.cbbClientName.Name = "cbbClientName";
            this.cbbClientName.Size = new System.Drawing.Size(243, 20);
            this.cbbClientName.TabIndex = 2;
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
            this.groupBox3.Controls.Add(this.cbbproName);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.dgvPro);
            this.groupBox3.Location = new System.Drawing.Point(0, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 285);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "货物信息";
            // 
            // cbTax
            // 
            this.cbTax.AutoSize = true;
            this.cbTax.Location = new System.Drawing.Point(824, 22);
            this.cbTax.Name = "cbTax";
            this.cbTax.Size = new System.Drawing.Size(48, 16);
            this.cbTax.TabIndex = 13;
            this.cbTax.Text = "含税";
            this.cbTax.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(874, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 26);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbSale
            // 
            this.cbbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Location = new System.Drawing.Point(587, 20);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(63, 20);
            this.cbbSale.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "折扣:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(720, 20);
            this.txtPrice.MaxLength = 100;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(98, 21);
            this.txtPrice.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "销售单价:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(439, 20);
            this.txtNumber.MaxLength = 100;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(98, 21);
            this.txtNumber.TabIndex = 10;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(398, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 11;
            this.label20.Text = "数量:";
            // 
            // cbbproName
            // 
            this.cbbproName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbproName.FormattingEnabled = true;
            this.cbbproName.Location = new System.Drawing.Point(77, 20);
            this.cbbproName.Name = "cbbproName";
            this.cbbproName.Size = new System.Drawing.Size(307, 20);
            this.cbbproName.TabIndex = 9;
            this.cbbproName.SelectedValueChanged += new System.EventHandler(this.cbbproName_SelectedValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 13;
            this.label22.Text = "产品名称";
            // 
            // dgvPro
            // 
            this.dgvPro.AllowUserToAddRows = false;
            this.dgvPro.AllowUserToDeleteRows = false;
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoid,
            this.proID,
            this.proname,
            this.amount,
            this.sellprice,
            this.tax,
            this.sale,
            this.subtotal});
            this.dgvPro.Location = new System.Drawing.Point(0, 49);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.ReadOnly = true;
            this.dgvPro.RowTemplate.Height = 23;
            this.dgvPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPro.Size = new System.Drawing.Size(933, 230);
            this.dgvPro.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvPro, "右击输入该产品的S/N码");
            this.dgvPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellContentClick);
            this.dgvPro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellEndEdit);
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
            this.proname.HeaderText = "产品名称(规格型号)";
            this.proname.Name = "proname";
            this.proname.ReadOnly = true;
            this.proname.Width = 300;
            // 
            // amount
            // 
            this.amount.HeaderText = "数量";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // sellprice
            // 
            this.sellprice.HeaderText = "销售单价";
            this.sellprice.Name = "sellprice";
            this.sellprice.ReadOnly = true;
            this.sellprice.Width = 150;
            // 
            // tax
            // 
            this.tax.HeaderText = "是否含税";
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            this.tax.Visible = false;
            // 
            // sale
            // 
            this.sale.HeaderText = "折扣";
            this.sale.Name = "sale";
            this.sale.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "小计";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 130;
            // 
            // dtpCArriveDate
            // 
            this.dtpCArriveDate.CustomFormat = "yyyy/MM/dd";
            this.dtpCArriveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCArriveDate.Location = new System.Drawing.Point(263, 55);
            this.dtpCArriveDate.Name = "dtpCArriveDate";
            this.dtpCArriveDate.Size = new System.Drawing.Size(100, 21);
            this.dtpCArriveDate.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(204, 59);
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
            this.cbbCtrackingName.Location = new System.Drawing.Point(840, 19);
            this.cbbCtrackingName.Name = "cbbCtrackingName";
            this.cbbCtrackingName.Size = new System.Drawing.Size(90, 20);
            this.cbbCtrackingName.TabIndex = 5;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(568, 55);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(362, 21);
            this.txtRemark.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(439, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(77, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtCtrackingID
            // 
            this.txtCtrackingID.Location = new System.Drawing.Point(625, 19);
            this.txtCtrackingID.Name = "txtCtrackingID";
            this.txtCtrackingID.Size = new System.Drawing.Size(117, 21);
            this.txtCtrackingID.TabIndex = 4;
            this.txtCtrackingID.Leave += new System.EventHandler(this.txtContract_Leave);
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(97, 19);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 21);
            this.txtContract.TabIndex = 0;
            this.txtContract.Leave += new System.EventHandler(this.txtContract_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(757, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "快递公司名称";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(533, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "备注";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(566, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "快递单号";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(369, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "发货人名称";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "客户公司";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "合同订单号";
            // 
            // gbSNCode
            // 
            this.gbSNCode.Controls.Add(this.btnSave);
            this.gbSNCode.Controls.Add(this.lbSNCode);
            this.gbSNCode.Controls.Add(this.label6);
            this.gbSNCode.Controls.Add(this.txtPName);
            this.gbSNCode.Controls.Add(this.label3);
            this.gbSNCode.Controls.Add(this.txtCount);
            this.gbSNCode.Controls.Add(this.label5);
            this.gbSNCode.Enabled = false;
            this.gbSNCode.Location = new System.Drawing.Point(939, 28);
            this.gbSNCode.Name = "gbSNCode";
            this.gbSNCode.Size = new System.Drawing.Size(270, 361);
            this.gbSNCode.TabIndex = 4;
            this.gbSNCode.TabStop = false;
            this.gbSNCode.Text = "S/N售出";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbSNCode
            // 
            this.lbSNCode.FormattingEnabled = true;
            this.lbSNCode.ItemHeight = 12;
            this.lbSNCode.Location = new System.Drawing.Point(124, 85);
            this.lbSNCode.Name = "lbSNCode";
            this.lbSNCode.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSNCode.Size = new System.Drawing.Size(128, 232);
            this.lbSNCode.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "S/N码";
            // 
            // txtPName
            // 
            this.txtPName.Enabled = false;
            this.txtPName.Location = new System.Drawing.Point(124, 17);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(128, 21);
            this.txtPName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "产品名称(型号)";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(124, 51);
            this.txtCount.MaxLength = 100;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(128, 21);
            this.txtCount.TabIndex = 9;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "内部订单号";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(97, 55);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(100, 21);
            this.txtOrder.TabIndex = 1;
            this.txtOrder.Leave += new System.EventHandler(this.txtContract_Leave);
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 394);
            this.Controls.Add(this.gbSNCode);
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
            this.gbSNCode.ResumeLayout(false);
            this.gbSNCode.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.GroupBox gbSNCode;
        private System.Windows.Forms.ListBox lbSNCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbDirect;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}