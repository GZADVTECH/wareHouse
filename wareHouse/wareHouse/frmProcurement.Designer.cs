namespace wareHouse
{
    partial class frmProcurement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcurement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbParts = new System.Windows.Forms.CheckBox();
            this.cbTax = new System.Windows.Forms.CheckBox();
            this.cbbSupplierName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProcurement = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbSale = new System.Windows.Forms.ComboBox();
            this.cbbPNID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbcheck = new System.Windows.Forms.CheckBox();
            this.dtpBuy = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.cbbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtPID = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurement)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采购订单";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbParts);
            this.groupBox3.Controls.Add(this.cbcheck);
            this.groupBox3.Controls.Add(this.cbTax);
            this.groupBox3.Controls.Add(this.cbbSupplierName);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.dgvProcurement);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtNumber);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbbSale);
            this.groupBox3.Controls.Add(this.cbbPNID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbbName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 280);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "采购货物";
            // 
            // cbParts
            // 
            this.cbParts.AutoSize = true;
            this.cbParts.Location = new System.Drawing.Point(493, 23);
            this.cbParts.Name = "cbParts";
            this.cbParts.Size = new System.Drawing.Size(96, 16);
            this.cbParts.TabIndex = 22;
            this.cbParts.Text = "有无配套产品";
            this.cbParts.UseVisualStyleBackColor = true;
            // 
            // cbTax
            // 
            this.cbTax.AutoSize = true;
            this.cbTax.Location = new System.Drawing.Point(419, 23);
            this.cbTax.Name = "cbTax";
            this.cbTax.Size = new System.Drawing.Size(72, 16);
            this.cbTax.TabIndex = 21;
            this.cbTax.Text = "是否含税";
            this.cbTax.UseVisualStyleBackColor = true;
            // 
            // cbbSupplierName
            // 
            this.cbbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSupplierName.FormattingEnabled = true;
            this.cbbSupplierName.Location = new System.Drawing.Point(99, 73);
            this.cbbSupplierName.Name = "cbbSupplierName";
            this.cbbSupplierName.Size = new System.Drawing.Size(121, 20);
            this.cbbSupplierName.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(632, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProcurement
            // 
            this.dgvProcurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proID,
            this.supID,
            this.Column1,
            this.Column2,
            this.amount,
            this.Column4,
            this.Column5,
            this.price,
            this.tax,
            this.parts,
            this.check});
            this.dgvProcurement.Location = new System.Drawing.Point(8, 105);
            this.dgvProcurement.Name = "dgvProcurement";
            this.dgvProcurement.RowTemplate.Height = 23;
            this.dgvProcurement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcurement.Size = new System.Drawing.Size(699, 169);
            this.dgvProcurement.TabIndex = 3;
            this.dgvProcurement.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcurement_CellValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(543, 45);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 21);
            this.txtAmount.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(287, 21);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 21);
            this.txtPrice.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "折扣";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "总金额：";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(287, 47);
            this.txtNumber.MaxLength = 100;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(121, 21);
            this.txtNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "单价";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "数量";
            // 
            // cbbSale
            // 
            this.cbbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.cbbSale.Location = new System.Drawing.Point(287, 73);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(121, 20);
            this.cbbSale.TabIndex = 1;
            // 
            // cbbPNID
            // 
            this.cbbPNID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPNID.FormattingEnabled = true;
            this.cbbPNID.Location = new System.Drawing.Point(99, 47);
            this.cbbPNID.Name = "cbbPNID";
            this.cbbPNID.Size = new System.Drawing.Size(121, 20);
            this.cbbPNID.TabIndex = 1;
            this.cbbPNID.SelectedValueChanged += new System.EventHandler(this.cbbPNID_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "规格";
            // 
            // cbbName
            // 
            this.cbbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(99, 21);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(121, 20);
            this.cbbName.TabIndex = 1;
            this.cbbName.SelectedValueChanged += new System.EventHandler(this.cbbName_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "产品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "供应商名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpBuy);
            this.groupBox2.Controls.Add(this.dtpArrival);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.UserName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPID);
            this.groupBox2.Controls.Add(this.cbbClient);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基础信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "客户名称";
            // 
            // cbcheck
            // 
            this.cbcheck.AutoSize = true;
            this.cbcheck.Location = new System.Drawing.Point(591, 23);
            this.cbcheck.Name = "cbcheck";
            this.cbcheck.Size = new System.Drawing.Size(96, 16);
            this.cbcheck.TabIndex = 18;
            this.cbcheck.Text = "是否附有发票";
            this.cbcheck.UseVisualStyleBackColor = true;
            // 
            // dtpBuy
            // 
            this.dtpBuy.CustomFormat = "yyyy/MM/dd";
            this.dtpBuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBuy.Location = new System.Drawing.Point(77, 72);
            this.dtpBuy.Name = "dtpBuy";
            this.dtpBuy.Size = new System.Drawing.Size(129, 21);
            this.dtpBuy.TabIndex = 16;
            // 
            // dtpArrival
            // 
            this.dtpArrival.CustomFormat = "yyyy/MM/dd";
            this.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrival.Location = new System.Drawing.Point(330, 72);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(130, 21);
            this.dtpArrival.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "预计到货日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "发货日期";
            // 
            // UserName
            // 
            this.UserName.Enabled = false;
            this.UserName.Location = new System.Drawing.Point(330, 31);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(130, 21);
            this.UserName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "采购人";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(77, 30);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(129, 21);
            this.txtPID.TabIndex = 14;
            // 
            // cbbClient
            // 
            this.cbbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClient.FormattingEnabled = true;
            this.cbbClient.Location = new System.Drawing.Point(552, 30);
            this.cbbClient.Name = "cbbClient";
            this.cbbClient.Size = new System.Drawing.Size(121, 20);
            this.cbbClient.TabIndex = 1;
            this.cbbClient.SelectedValueChanged += new System.EventHandler(this.cbbPNID_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "内部订单号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.tstxtPID,
            this.tsbtnSelect,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "新建";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "保存";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "删除";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel2.Text = "单号快速查询：";
            // 
            // tstxtPID
            // 
            this.tstxtPID.Name = "tstxtPID";
            this.tstxtPID.Size = new System.Drawing.Size(100, 25);
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
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton4.Text = "打印采购单";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton5.Text = "打印收货通知单";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // proID
            // 
            this.proID.HeaderText = "产品编号";
            this.proID.Name = "proID";
            this.proID.ReadOnly = true;
            this.proID.Visible = false;
            // 
            // supID
            // 
            this.supID.HeaderText = "供应商编号";
            this.supID.Name = "supID";
            this.supID.ReadOnly = true;
            this.supID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "产品名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "规格";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "数量";
            this.amount.Name = "amount";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "供应商";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "折扣";
            this.Column5.Name = "Column5";
            // 
            // price
            // 
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            // 
            // tax
            // 
            this.tax.HeaderText = "是否含税";
            this.tax.Name = "tax";
            this.tax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tax.Visible = false;
            // 
            // parts
            // 
            this.parts.HeaderText = "有无配套产品";
            this.parts.Name = "parts";
            this.parts.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.parts.Visible = false;
            // 
            // check
            // 
            this.check.HeaderText = "是否附有发票";
            this.check.Name = "check";
            this.check.Visible = false;
            // 
            // frmProcurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 468);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcurement";
            this.Text = "采购管理";
            this.Load += new System.EventHandler(this.frmProcurement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurement)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbcheck;
        private System.Windows.Forms.DateTimePicker dtpBuy;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProcurement;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbPNID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbSupplierName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbClient;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstxtPID;
        private System.Windows.Forms.ToolStripButton tsbtnSelect;
        private System.Windows.Forms.CheckBox cbParts;
        private System.Windows.Forms.CheckBox cbTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn check;
    }
}