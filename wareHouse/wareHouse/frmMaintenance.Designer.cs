namespace wareHouse
{
    partial class frmMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenance));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbcname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbproname = new System.Windows.Forms.ComboBox();
            this.txtmainname = new System.Windows.Forms.TextBox();
            this.dtpreturndate = new System.Windows.Forms.DateTimePicker();
            this.txtreturntrackingid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtsnid = new System.Windows.Forms.TextBox();
            this.txtmainmsg = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnewsnid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtreturntrackingname = new System.Windows.Forms.ComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnsnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returntrackingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returntrackingname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactinfo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbcontactsid = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttrackingname = new System.Windows.Forms.ComboBox();
            this.txttrackingid = new System.Windows.Forms.TextBox();
            this.dtparrivaldate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1011, 25);
            this.toolStrip1.TabIndex = 0;
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
            this.toolStripButton4.Text = "打印维修单";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "维保地名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-255, -96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "客户名称";
            // 
            // cbbcname
            // 
            this.cbbcname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcname.FormattingEnabled = true;
            this.cbbcname.Location = new System.Drawing.Point(65, 27);
            this.cbbcname.Name = "cbbcname";
            this.cbbcname.Size = new System.Drawing.Size(115, 20);
            this.cbbcname.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "产品名称(规格型号)";
            // 
            // cbbproname
            // 
            this.cbbproname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbproname.FormattingEnabled = true;
            this.cbbproname.Location = new System.Drawing.Point(131, 67);
            this.cbbproname.Name = "cbbproname";
            this.cbbproname.Size = new System.Drawing.Size(244, 20);
            this.cbbproname.TabIndex = 3;
            // 
            // txtmainname
            // 
            this.txtmainname.Location = new System.Drawing.Point(461, 27);
            this.txtmainname.Name = "txtmainname";
            this.txtmainname.Size = new System.Drawing.Size(121, 21);
            this.txtmainname.TabIndex = 2;
            // 
            // dtpreturndate
            // 
            this.dtpreturndate.CustomFormat = "yyyy/MM/dd";
            this.dtpreturndate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpreturndate.Location = new System.Drawing.Point(65, 24);
            this.dtpreturndate.Name = "dtpreturndate";
            this.dtpreturndate.Size = new System.Drawing.Size(116, 21);
            this.dtpreturndate.TabIndex = 9;
            // 
            // txtreturntrackingid
            // 
            this.txtreturntrackingid.Location = new System.Drawing.Point(260, 24);
            this.txtreturntrackingid.Name = "txtreturntrackingid";
            this.txtreturntrackingid.Size = new System.Drawing.Size(115, 21);
            this.txtreturntrackingid.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtContactinfo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbbcontactsid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txttrackingname);
            this.groupBox1.Controls.Add(this.txttrackingid);
            this.groupBox1.Controls.Add(this.dtparrivaldate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsnid);
            this.groupBox1.Controls.Add(this.txtmainmsg);
            this.groupBox1.Controls.Add(this.txtmainname);
            this.groupBox1.Controls.Add(this.cbbproname);
            this.groupBox1.Controls.Add(this.cbbcname);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 215);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "S/N号";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(198, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "维保原因";
            // 
            // txtsnid
            // 
            this.txtsnid.Location = new System.Drawing.Point(461, 68);
            this.txtsnid.Name = "txtsnid";
            this.txtsnid.Size = new System.Drawing.Size(121, 21);
            this.txtsnid.TabIndex = 5;
            // 
            // txtmainmsg
            // 
            this.txtmainmsg.Location = new System.Drawing.Point(260, 27);
            this.txtmainmsg.Name = "txtmainmsg";
            this.txtmainmsg.Size = new System.Drawing.Size(115, 21);
            this.txtmainmsg.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtreturntrackingid);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpreturndate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtnewsnid);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtreturntrackingname);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 93);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发货信息";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "S/N号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "快递公司名称";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 12);
            this.label14.TabIndex = 4;
            // 
            // txtnewsnid
            // 
            this.txtnewsnid.Location = new System.Drawing.Point(65, 59);
            this.txtnewsnid.Name = "txtnewsnid";
            this.txtnewsnid.Size = new System.Drawing.Size(115, 21);
            this.txtnewsnid.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "发货日期";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "快递单号";
            // 
            // txtreturntrackingname
            // 
            this.txtreturntrackingname.FormattingEnabled = true;
            this.txtreturntrackingname.Items.AddRange(new object[] {
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
            this.txtreturntrackingname.Location = new System.Drawing.Point(461, 24);
            this.txtreturntrackingname.Name = "txtreturntrackingname";
            this.txtreturntrackingname.Size = new System.Drawing.Size(121, 20);
            this.txtreturntrackingname.TabIndex = 11;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cName,
            this.proID,
            this.proName,
            this.pnid,
            this.snid,
            this.mainMsg,
            this.mainName,
            this.arrivatedate,
            this.trackingID,
            this.trackingname,
            this.contactsid,
            this.returnsnid,
            this.returndate,
            this.returntrackingid,
            this.returntrackingname});
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMain.Location = new System.Drawing.Point(625, 29);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(374, 313);
            this.dgvMain.TabIndex = 9;
            this.dgvMain.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDown);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "cID";
            this.cid.HeaderText = "客户编号";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Visible = false;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "cName";
            this.cName.HeaderText = "客户名称";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // proID
            // 
            this.proID.DataPropertyName = "productID";
            this.proID.HeaderText = "产品编号";
            this.proID.Name = "proID";
            this.proID.ReadOnly = true;
            this.proID.Visible = false;
            // 
            // proName
            // 
            this.proName.DataPropertyName = "productName";
            this.proName.HeaderText = "产品名称";
            this.proName.Name = "proName";
            this.proName.ReadOnly = true;
            // 
            // pnid
            // 
            this.pnid.DataPropertyName = "PNID";
            this.pnid.HeaderText = "规格型号";
            this.pnid.Name = "pnid";
            this.pnid.ReadOnly = true;
            // 
            // snid
            // 
            this.snid.DataPropertyName = "SNID";
            this.snid.HeaderText = "S/N号";
            this.snid.Name = "snid";
            this.snid.ReadOnly = true;
            this.snid.Visible = false;
            // 
            // mainMsg
            // 
            this.mainMsg.DataPropertyName = "maintenanceMsg";
            this.mainMsg.HeaderText = "维保原因";
            this.mainMsg.Name = "mainMsg";
            this.mainMsg.ReadOnly = true;
            // 
            // mainName
            // 
            this.mainName.DataPropertyName = "maintenanceName";
            this.mainName.HeaderText = "维保地";
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            // 
            // arrivatedate
            // 
            this.arrivatedate.DataPropertyName = "arrivalDate";
            this.arrivatedate.HeaderText = "收货时间";
            this.arrivatedate.Name = "arrivatedate";
            this.arrivatedate.ReadOnly = true;
            this.arrivatedate.Visible = false;
            // 
            // trackingID
            // 
            this.trackingID.DataPropertyName = "trackingID";
            this.trackingID.HeaderText = "快递单号";
            this.trackingID.Name = "trackingID";
            this.trackingID.ReadOnly = true;
            this.trackingID.Visible = false;
            // 
            // trackingname
            // 
            this.trackingname.DataPropertyName = "trackingName";
            this.trackingname.HeaderText = "快递公司名称";
            this.trackingname.Name = "trackingname";
            this.trackingname.ReadOnly = true;
            this.trackingname.Visible = false;
            // 
            // contactsid
            // 
            this.contactsid.DataPropertyName = "contactsID";
            this.contactsid.HeaderText = "联系人编号";
            this.contactsid.Name = "contactsid";
            this.contactsid.ReadOnly = true;
            this.contactsid.Visible = false;
            // 
            // returnsnid
            // 
            this.returnsnid.DataPropertyName = "returnproductID";
            this.returnsnid.HeaderText = "归还新S/N号";
            this.returnsnid.Name = "returnsnid";
            this.returnsnid.ReadOnly = true;
            this.returnsnid.Visible = false;
            // 
            // returndate
            // 
            this.returndate.DataPropertyName = "returnDate";
            this.returndate.HeaderText = "归还日期";
            this.returndate.Name = "returndate";
            this.returndate.ReadOnly = true;
            this.returndate.Visible = false;
            // 
            // returntrackingid
            // 
            this.returntrackingid.DataPropertyName = "returntrackingID";
            this.returntrackingid.HeaderText = "归还快递单号";
            this.returntrackingid.Name = "returntrackingid";
            this.returntrackingid.ReadOnly = true;
            this.returntrackingid.Visible = false;
            // 
            // returntrackingname
            // 
            this.returntrackingname.DataPropertyName = "returntrackingName";
            this.returntrackingname.HeaderText = "归还快递公司名称";
            this.returntrackingname.Name = "returntrackingname";
            this.returntrackingname.ReadOnly = true;
            this.returntrackingname.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(71, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(513, 21);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.Text = "广东省广州市天河区壬丰大厦22楼2211A室";
            // 
            // txtContactinfo
            // 
            this.txtContactinfo.Location = new System.Drawing.Point(260, 139);
            this.txtContactinfo.Name = "txtContactinfo";
            this.txtContactinfo.Size = new System.Drawing.Size(115, 21);
            this.txtContactinfo.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "联系地址";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "联系方式";
            // 
            // cbbcontactsid
            // 
            this.cbbcontactsid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcontactsid.FormattingEnabled = true;
            this.cbbcontactsid.Location = new System.Drawing.Point(65, 139);
            this.cbbcontactsid.Name = "cbbcontactsid";
            this.cbbcontactsid.Size = new System.Drawing.Size(116, 20);
            this.cbbcontactsid.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "联系人";
            // 
            // txttrackingname
            // 
            this.txttrackingname.FormattingEnabled = true;
            this.txttrackingname.Items.AddRange(new object[] {
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
            this.txttrackingname.Location = new System.Drawing.Point(461, 105);
            this.txttrackingname.Name = "txttrackingname";
            this.txttrackingname.Size = new System.Drawing.Size(121, 20);
            this.txttrackingname.TabIndex = 27;
            // 
            // txttrackingid
            // 
            this.txttrackingid.Location = new System.Drawing.Point(260, 105);
            this.txttrackingid.Name = "txttrackingid";
            this.txttrackingid.Size = new System.Drawing.Size(115, 21);
            this.txttrackingid.TabIndex = 26;
            // 
            // dtparrivaldate
            // 
            this.dtparrivaldate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtparrivaldate.CustomFormat = "yyyy/MM/dd";
            this.dtparrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtparrivaldate.Location = new System.Drawing.Point(65, 105);
            this.dtparrivaldate.Name = "dtparrivaldate";
            this.dtparrivaldate.Size = new System.Drawing.Size(115, 21);
            this.dtparrivaldate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "收货日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "快递单号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "快递公司名称";
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 358);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintenance";
            this.Text = "维修管理";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbcname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbproname;
        private System.Windows.Forms.TextBox txtmainname;
        private System.Windows.Forms.DateTimePicker dtpreturndate;
        private System.Windows.Forms.TextBox txtreturntrackingid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtreturntrackingname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtsnid;
        private System.Windows.Forms.TextBox txtmainmsg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnewsnid;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn snid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingname;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactsid;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnsnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returntrackingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn returntrackingname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactinfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbcontactsid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txttrackingname;
        private System.Windows.Forms.TextBox txttrackingid;
        private System.Windows.Forms.DateTimePicker dtparrivaldate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}