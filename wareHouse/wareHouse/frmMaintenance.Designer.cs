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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbcontactsid = new System.Windows.Forms.ComboBox();
            this.dtparrivaldate = new System.Windows.Forms.DateTimePicker();
            this.txttrackingname = new System.Windows.Forms.ComboBox();
            this.txttrackingid = new System.Windows.Forms.TextBox();
            this.txtreturntrackingid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtreturntrackingname = new System.Windows.Forms.ComboBox();
            this.txtsnid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbpnid = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnewsnid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmainmsg = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "保存";
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
            this.cbbcname.FormattingEnabled = true;
            this.cbbcname.Location = new System.Drawing.Point(65, 27);
            this.cbbcname.Name = "cbbcname";
            this.cbbcname.Size = new System.Drawing.Size(116, 20);
            this.cbbcname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "产品名称";
            // 
            // cbbproname
            // 
            this.cbbproname.FormattingEnabled = true;
            this.cbbproname.Location = new System.Drawing.Point(65, 67);
            this.cbbproname.Name = "cbbproname";
            this.cbbproname.Size = new System.Drawing.Size(117, 20);
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
            this.dtpreturndate.Location = new System.Drawing.Point(65, 24);
            this.dtpreturndate.Name = "dtpreturndate";
            this.dtpreturndate.Size = new System.Drawing.Size(116, 21);
            this.dtpreturndate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "收货日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "快递单号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "快递公司名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "联系人";
            // 
            // cbbcontactsid
            // 
            this.cbbcontactsid.FormattingEnabled = true;
            this.cbbcontactsid.Location = new System.Drawing.Point(65, 68);
            this.cbbcontactsid.Name = "cbbcontactsid";
            this.cbbcontactsid.Size = new System.Drawing.Size(116, 20);
            this.cbbcontactsid.TabIndex = 3;
            // 
            // dtparrivaldate
            // 
            this.dtparrivaldate.Location = new System.Drawing.Point(65, 30);
            this.dtparrivaldate.Name = "dtparrivaldate";
            this.dtparrivaldate.Size = new System.Drawing.Size(117, 21);
            this.dtparrivaldate.TabIndex = 5;
            // 
            // txttrackingname
            // 
            this.txttrackingname.FormattingEnabled = true;
            this.txttrackingname.Location = new System.Drawing.Point(461, 31);
            this.txttrackingname.Name = "txttrackingname";
            this.txttrackingname.Size = new System.Drawing.Size(121, 20);
            this.txttrackingname.TabIndex = 3;
            // 
            // txttrackingid
            // 
            this.txttrackingid.Location = new System.Drawing.Point(260, 31);
            this.txttrackingid.Name = "txttrackingid";
            this.txttrackingid.Size = new System.Drawing.Size(115, 21);
            this.txttrackingid.TabIndex = 2;
            // 
            // txtreturntrackingid
            // 
            this.txtreturntrackingid.Location = new System.Drawing.Point(260, 24);
            this.txtreturntrackingid.Name = "txtreturntrackingid";
            this.txtreturntrackingid.Size = new System.Drawing.Size(115, 21);
            this.txtreturntrackingid.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsnid);
            this.groupBox1.Controls.Add(this.txtmainmsg);
            this.groupBox1.Controls.Add(this.txtmainname);
            this.groupBox1.Controls.Add(this.cbbpnid);
            this.groupBox1.Controls.Add(this.cbbproname);
            this.groupBox1.Controls.Add(this.cbbcname);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttrackingname);
            this.groupBox2.Controls.Add(this.txttrackingid);
            this.groupBox2.Controls.Add(this.dtparrivaldate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "收货信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtreturntrackingid);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cbbcontactsid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpreturndate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtnewsnid);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtreturntrackingname);
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 112);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发货信息";
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
            this.label12.Location = new System.Drawing.Point(189, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "快递单号";
            // 
            // txtreturntrackingname
            // 
            this.txtreturntrackingname.FormattingEnabled = true;
            this.txtreturntrackingname.Location = new System.Drawing.Point(461, 24);
            this.txtreturntrackingname.Name = "txtreturntrackingname";
            this.txtreturntrackingname.Size = new System.Drawing.Size(121, 20);
            this.txtreturntrackingname.TabIndex = 3;
            // 
            // txtsnid
            // 
            this.txtsnid.Location = new System.Drawing.Point(461, 68);
            this.txtsnid.Name = "txtsnid";
            this.txtsnid.Size = new System.Drawing.Size(121, 21);
            this.txtsnid.TabIndex = 2;
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
            // cbbpnid
            // 
            this.cbbpnid.FormattingEnabled = true;
            this.cbbpnid.Location = new System.Drawing.Point(260, 67);
            this.cbbpnid.Name = "cbbpnid";
            this.cbbpnid.Size = new System.Drawing.Size(115, 20);
            this.cbbpnid.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "规格型号";
            // 
            // txtnewsnid
            // 
            this.txtnewsnid.Location = new System.Drawing.Point(260, 69);
            this.txtnewsnid.Name = "txtnewsnid";
            this.txtnewsnid.Size = new System.Drawing.Size(115, 21);
            this.txtnewsnid.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "S/N号";
            // 
            // txtmainmsg
            // 
            this.txtmainmsg.Location = new System.Drawing.Point(260, 27);
            this.txtmainmsg.Name = "txtmainmsg";
            this.txtmainmsg.Size = new System.Drawing.Size(115, 21);
            this.txtmainmsg.TabIndex = 2;
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
            this.mainMsg,
            this.mainName});
            this.dgvMain.Location = new System.Drawing.Point(625, 29);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(374, 315);
            this.dgvMain.TabIndex = 9;
            // 
            // cid
            // 
            this.cid.HeaderText = "客户编号";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Visible = false;
            // 
            // cName
            // 
            this.cName.HeaderText = "客户名称";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // proID
            // 
            this.proID.HeaderText = "产品编号";
            this.proID.Name = "proID";
            this.proID.ReadOnly = true;
            this.proID.Visible = false;
            // 
            // proName
            // 
            this.proName.HeaderText = "产品名称";
            this.proName.Name = "proName";
            this.proName.ReadOnly = true;
            // 
            // mainMsg
            // 
            this.mainMsg.HeaderText = "维保原因";
            this.mainMsg.Name = "mainMsg";
            this.mainMsg.ReadOnly = true;
            // 
            // mainName
            // 
            this.mainName.HeaderText = "维保地";
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 356);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintenance";
            this.Text = "维修管理";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbcontactsid;
        private System.Windows.Forms.DateTimePicker dtparrivaldate;
        private System.Windows.Forms.ComboBox txttrackingname;
        private System.Windows.Forms.TextBox txttrackingid;
        private System.Windows.Forms.TextBox txtreturntrackingid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtreturntrackingname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsnid;
        private System.Windows.Forms.TextBox txtmainmsg;
        private System.Windows.Forms.ComboBox cbbpnid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnewsnid;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
    }
}