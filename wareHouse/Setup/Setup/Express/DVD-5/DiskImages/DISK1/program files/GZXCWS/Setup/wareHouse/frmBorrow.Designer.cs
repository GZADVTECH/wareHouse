namespace wareHouse
{
    partial class frmBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.dtpBorrowTime = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbproname = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBorrower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.lbSNCode = new System.Windows.Forms.ListBox();
            this.borrowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowSNCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowOperatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSNCode);
            this.groupBox1.Controls.Add(this.rtbRemark);
            this.groupBox1.Controls.Add(this.cbReturn);
            this.groupBox1.Controls.Add(this.dtpBorrowTime);
            this.groupBox1.Controls.Add(this.dtpReturnTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbproname);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtBorrower);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础资料";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(257, 75);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(380, 83);
            this.rtbRemark.TabIndex = 9;
            this.rtbRemark.Text = "";
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(565, 47);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(72, 16);
            this.cbReturn.TabIndex = 7;
            this.cbReturn.Text = "是否归还";
            this.cbReturn.UseVisualStyleBackColor = true;
            // 
            // dtpBorrowTime
            // 
            this.dtpBorrowTime.CustomFormat = "yyyy/MM/dd";
            this.dtpBorrowTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrowTime.Location = new System.Drawing.Point(257, 45);
            this.dtpBorrowTime.Name = "dtpBorrowTime";
            this.dtpBorrowTime.Size = new System.Drawing.Size(105, 21);
            this.dtpBorrowTime.TabIndex = 6;
            // 
            // dtpReturnTime
            // 
            this.dtpReturnTime.CustomFormat = "yyyy/MM/dd";
            this.dtpReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnTime.Location = new System.Drawing.Point(445, 45);
            this.dtpReturnTime.Name = "dtpReturnTime";
            this.dtpReturnTime.Size = new System.Drawing.Size(105, 21);
            this.dtpReturnTime.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "产品名称(规格型号)";
            // 
            // cbbproname
            // 
            this.cbbproname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbproname.FormattingEnabled = true;
            this.cbbproname.Location = new System.Drawing.Point(290, 18);
            this.cbbproname.Name = "cbbproname";
            this.cbbproname.Size = new System.Drawing.Size(351, 20);
            this.cbbproname.TabIndex = 5;
            this.cbbproname.SelectedValueChanged += new System.EventHandler(this.cbbproname_SelectedValueChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(65, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "S/N码";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(65, 18);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 1;
            // 
            // txtBorrower
            // 
            this.txtBorrower.Location = new System.Drawing.Point(65, 72);
            this.txtBorrower.Name = "txtBorrower";
            this.txtBorrower.Size = new System.Drawing.Size(100, 21);
            this.txtBorrower.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "借货编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "借货人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "归还时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "借出时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "备注";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowNumber,
            this.borrowProductID,
            this.borrowSNCode,
            this.borrowQuantity,
            this.borrower,
            this.borrowOperatorID,
            this.borrowTime,
            this.borrowReturnTime,
            this.IsReturn,
            this.borrowRemark,
            this.borrowStatus});
            this.dgvBorrow.Location = new System.Drawing.Point(13, 200);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(647, 261);
            this.dgvBorrow.TabIndex = 3;
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            // 
            // lbSNCode
            // 
            this.lbSNCode.FormattingEnabled = true;
            this.lbSNCode.ItemHeight = 12;
            this.lbSNCode.Location = new System.Drawing.Point(65, 103);
            this.lbSNCode.Name = "lbSNCode";
            this.lbSNCode.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSNCode.Size = new System.Drawing.Size(100, 52);
            this.lbSNCode.TabIndex = 10;
            // 
            // borrowNumber
            // 
            this.borrowNumber.DataPropertyName = "borrowNumber";
            this.borrowNumber.HeaderText = "借货编号";
            this.borrowNumber.Name = "borrowNumber";
            this.borrowNumber.ReadOnly = true;
            // 
            // borrowProductID
            // 
            this.borrowProductID.DataPropertyName = "borrowProductID";
            this.borrowProductID.HeaderText = "产品编号";
            this.borrowProductID.Name = "borrowProductID";
            this.borrowProductID.ReadOnly = true;
            // 
            // borrowSNCode
            // 
            this.borrowSNCode.DataPropertyName = "borrowSNCode";
            this.borrowSNCode.HeaderText = "S/N码";
            this.borrowSNCode.Name = "borrowSNCode";
            this.borrowSNCode.ReadOnly = true;
            // 
            // borrowQuantity
            // 
            this.borrowQuantity.DataPropertyName = "borrowQuantity";
            this.borrowQuantity.HeaderText = "数量";
            this.borrowQuantity.Name = "borrowQuantity";
            this.borrowQuantity.ReadOnly = true;
            // 
            // borrower
            // 
            this.borrower.DataPropertyName = "borrower";
            this.borrower.HeaderText = "借货人";
            this.borrower.Name = "borrower";
            this.borrower.ReadOnly = true;
            // 
            // borrowOperatorID
            // 
            this.borrowOperatorID.DataPropertyName = "borrowOperatorID";
            this.borrowOperatorID.HeaderText = "操作员编号";
            this.borrowOperatorID.Name = "borrowOperatorID";
            this.borrowOperatorID.ReadOnly = true;
            // 
            // borrowTime
            // 
            this.borrowTime.DataPropertyName = "borrowTime";
            this.borrowTime.HeaderText = "借出时间";
            this.borrowTime.Name = "borrowTime";
            this.borrowTime.ReadOnly = true;
            // 
            // borrowReturnTime
            // 
            this.borrowReturnTime.DataPropertyName = "borrowReturnTime";
            this.borrowReturnTime.HeaderText = "归还时间";
            this.borrowReturnTime.Name = "borrowReturnTime";
            this.borrowReturnTime.ReadOnly = true;
            // 
            // IsReturn
            // 
            this.IsReturn.DataPropertyName = "IsReturn";
            this.IsReturn.HeaderText = "是否归还";
            this.IsReturn.Name = "IsReturn";
            this.IsReturn.ReadOnly = true;
            // 
            // borrowRemark
            // 
            this.borrowRemark.DataPropertyName = "borrowRemark";
            this.borrowRemark.HeaderText = "备注";
            this.borrowRemark.Name = "borrowRemark";
            this.borrowRemark.ReadOnly = true;
            // 
            // borrowStatus
            // 
            this.borrowStatus.DataPropertyName = "borrowStatus";
            this.borrowStatus.HeaderText = "完成状态";
            this.borrowStatus.Name = "borrowStatus";
            this.borrowStatus.ReadOnly = true;
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrow";
            this.Text = "借出界面";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbproname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBorrower;
        private System.Windows.Forms.CheckBox cbReturn;
        private System.Windows.Forms.DateTimePicker dtpBorrowTime;
        private System.Windows.Forms.DateTimePicker dtpReturnTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.ListBox lbSNCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowSNCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowOperatorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowReturnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowStatus;
    }
}