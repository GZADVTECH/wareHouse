namespace wareHouse
{
    partial class frmStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStorage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.cbbLocation = new System.Windows.Forms.ComboBox();
            this.cbbCourier = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCourier = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtorderID = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.minus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDou = new System.Windows.Forms.Button();
            this.btnSNSave = new System.Windows.Forms.Button();
            this.lvSN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSNName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSNSNID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1101, 25);
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
            this.tstxtPID.MergeIndex = 0;
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
            this.toolStripButton1.Text = "打印入库单";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDeliveryDate);
            this.groupBox1.Controls.Add(this.rtbRemark);
            this.groupBox1.Controls.Add(this.cbbLocation);
            this.groupBox1.Controls.Add(this.cbbCourier);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCourier);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSupplierID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtorderID);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单据信息";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CustomFormat = "yyyy/MM/dd";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(300, 51);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(112, 21);
            this.dtpDeliveryDate.TabIndex = 4;
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(103, 82);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(719, 75);
            this.rtbRemark.TabIndex = 7;
            this.rtbRemark.Text = "";
            // 
            // cbbLocation
            // 
            this.cbbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocation.FormattingEnabled = true;
            this.cbbLocation.Items.AddRange(new object[] {
            "工厂",
            "公司",
            "直销"});
            this.cbbLocation.Location = new System.Drawing.Point(710, 18);
            this.cbbLocation.Name = "cbbLocation";
            this.cbbLocation.Size = new System.Drawing.Size(112, 20);
            this.cbbLocation.TabIndex = 3;
            // 
            // cbbCourier
            // 
            this.cbbCourier.FormattingEnabled = true;
            this.cbbCourier.Items.AddRange(new object[] {
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
            this.cbbCourier.Location = new System.Drawing.Point(493, 51);
            this.cbbCourier.Name = "cbbCourier";
            this.cbbCourier.Size = new System.Drawing.Size(112, 20);
            this.cbbCourier.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "收货日期";
            // 
            // txtCourier
            // 
            this.txtCourier.Location = new System.Drawing.Point(493, 18);
            this.txtCourier.MaxLength = 50;
            this.txtCourier.Name = "txtCourier";
            this.txtCourier.Size = new System.Drawing.Size(112, 21);
            this.txtCourier.TabIndex = 2;
            this.txtCourier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlKeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "仓位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "快递名称";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "快递单号";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(710, 51);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(112, 21);
            this.txtSupplierID.TabIndex = 6;
            this.txtSupplierID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "供应商订单号";
            // 
            // txtorderID
            // 
            this.txtorderID.Enabled = false;
            this.txtorderID.Location = new System.Drawing.Point(298, 18);
            this.txtorderID.Name = "txtorderID";
            this.txtorderID.Size = new System.Drawing.Size(116, 21);
            this.txtorderID.TabIndex = 1;
            // 
            // txtPID
            // 
            this.txtPID.Enabled = false;
            this.txtPID.Location = new System.Drawing.Point(105, 18);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(116, 21);
            this.txtPID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "合同订单号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "内部订单号";
            // 
            // dgvPro
            // 
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.productID,
            this.plus,
            this.minus,
            this.productName,
            this.pnid,
            this.supplierName,
            this.Num,
            this.actualAmount,
            this.isInvoice,
            this.invoiceID});
            this.dgvPro.Location = new System.Drawing.Point(0, 197);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.RowTemplate.Height = 23;
            this.dgvPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPro.Size = new System.Drawing.Size(855, 296);
            this.dgvPro.TabIndex = 8;
            this.dgvPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellClick);
            this.dgvPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellContentClick);
            this.dgvPro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellEndEdit);
            this.dgvPro.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPro_CellMouseDown);
            this.dgvPro.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellMouseLeave);
            // 
            // ID
            // 
            this.ID.HeaderText = "采购编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "产品编号";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Visible = false;
            // 
            // plus
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "+";
            this.plus.DefaultCellStyle = dataGridViewCellStyle1;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plus.HeaderText = "+";
            this.plus.Name = "plus";
            this.plus.Text = "+";
            this.plus.UseColumnTextForButtonValue = true;
            this.plus.Width = 20;
            // 
            // minus
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "-";
            this.minus.DefaultCellStyle = dataGridViewCellStyle2;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minus.HeaderText = "-";
            this.minus.Name = "minus";
            this.minus.Text = "-";
            this.minus.UseColumnTextForButtonValue = true;
            this.minus.Width = 20;
            // 
            // productName
            // 
            this.productName.HeaderText = "产品名称";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 150;
            // 
            // pnid
            // 
            this.pnid.HeaderText = "配置（规格）";
            this.pnid.Name = "pnid";
            this.pnid.ReadOnly = true;
            this.pnid.Width = 200;
            // 
            // supplierName
            // 
            this.supplierName.HeaderText = "供应商";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.HeaderText = "数量";
            this.Num.Name = "Num";
            this.Num.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Num.Width = 80;
            // 
            // actualAmount
            // 
            this.actualAmount.DataPropertyName = "actualAmount";
            this.actualAmount.HeaderText = "应收数量";
            this.actualAmount.Name = "actualAmount";
            this.actualAmount.ReadOnly = true;
            // 
            // isInvoice
            // 
            this.isInvoice.DataPropertyName = "isInvoice";
            this.isInvoice.HeaderText = "是否附有发票";
            this.isInvoice.Name = "isInvoice";
            this.isInvoice.ReadOnly = true;
            this.isInvoice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isInvoice.Width = 120;
            // 
            // invoiceID
            // 
            this.invoiceID.DataPropertyName = "invoiceID";
            this.invoiceID.HeaderText = "发票号码";
            this.invoiceID.Name = "invoiceID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDou);
            this.groupBox2.Controls.Add(this.btnSNSave);
            this.groupBox2.Controls.Add(this.lvSN);
            this.groupBox2.Controls.Add(this.txtSNName);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtSNSNID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSN);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(862, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 465);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "S/N号录入";
            // 
            // btnDou
            // 
            this.btnDou.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDou.Location = new System.Drawing.Point(194, 80);
            this.btnDou.Name = "btnDou";
            this.btnDou.Size = new System.Drawing.Size(27, 17);
            this.btnDou.TabIndex = 12;
            this.btnDou.Text = "...";
            this.btnDou.UseVisualStyleBackColor = true;
            this.btnDou.Click += new System.EventHandler(this.btnDou_Click);
            // 
            // btnSNSave
            // 
            this.btnSNSave.Location = new System.Drawing.Point(146, 115);
            this.btnSNSave.Name = "btnSNSave";
            this.btnSNSave.Size = new System.Drawing.Size(75, 23);
            this.btnSNSave.TabIndex = 13;
            this.btnSNSave.Text = "录入";
            this.btnSNSave.UseVisualStyleBackColor = true;
            this.btnSNSave.Click += new System.EventHandler(this.btnSNSave_Click);
            // 
            // lvSN
            // 
            this.lvSN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSN.FullRowSelect = true;
            this.lvSN.Location = new System.Drawing.Point(-1, 155);
            this.lvSN.Name = "lvSN";
            this.lvSN.Size = new System.Drawing.Size(240, 309);
            this.lvSN.TabIndex = 14;
            this.lvSN.UseCompatibleStateImageBehavior = false;
            this.lvSN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "产品名称";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "规格型号";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "S/N码";
            this.columnHeader3.Width = 80;
            // 
            // txtSNName
            // 
            this.txtSNName.Enabled = false;
            this.txtSNName.Location = new System.Drawing.Point(93, 21);
            this.txtSNName.Name = "txtSNName";
            this.txtSNName.Size = new System.Drawing.Size(128, 21);
            this.txtSNName.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 6;
            this.label15.Text = "产品名称";
            // 
            // txtSNSNID
            // 
            this.txtSNSNID.Enabled = false;
            this.txtSNSNID.Location = new System.Drawing.Point(93, 50);
            this.txtSNSNID.Name = "txtSNSNID";
            this.txtSNSNID.Size = new System.Drawing.Size(128, 21);
            this.txtSNSNID.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "规格型号";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(93, 77);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(95, 21);
            this.txtSN.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "S/N码录入";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStorage";
            this.Text = "入库管理";
            this.Load += new System.EventHandler(this.frmStorage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtPID;
        private System.Windows.Forms.ToolStripButton tsbtnSelect;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.ComboBox cbbCourier;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.ComboBox cbbLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDou;
        private System.Windows.Forms.Button btnSNSave;
        private System.Windows.Forms.ListView lvSN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtSNName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSNSNID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtorderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewButtonColumn plus;
        private System.Windows.Forms.DataGridViewButtonColumn minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn isInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceID;
    }
}