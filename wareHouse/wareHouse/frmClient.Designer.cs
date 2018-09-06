namespace wareHouse
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.txtCWay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.autoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSC = new System.Windows.Forms.Button();
            this.txtSCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.rtbAddress);
            this.groupBox1.Controls.Add(this.txtCWay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(359, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户信息";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(70, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(62, 21);
            this.txtID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "客户编号";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(70, 70);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(286, 86);
            this.rtbAddress.TabIndex = 3;
            this.rtbAddress.Text = "";
            // 
            // txtCWay
            // 
            this.txtCWay.Location = new System.Drawing.Point(70, 43);
            this.txtCWay.MaxLength = 20;
            this.txtCWay.Name = "txtCWay";
            this.txtCWay.Size = new System.Drawing.Size(121, 21);
            this.txtCWay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "联系地址";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(196, 14);
            this.txtCName.MaxLength = 20;
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(160, 21);
            this.txtCName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "联系方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "客户名称";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoID,
            this.cName,
            this.cway,
            this.cAddress});
            this.dgvClient.Location = new System.Drawing.Point(8, 12);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowTemplate.Height = 23;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(345, 256);
            this.dgvClient.TabIndex = 1;
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellContentClick);
            // 
            // autoID
            // 
            this.autoID.DataPropertyName = "autoID";
            this.autoID.HeaderText = "自动编号";
            this.autoID.Name = "autoID";
            this.autoID.Visible = false;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "cName";
            this.cName.HeaderText = "客户名称";
            this.cName.Name = "cName";
            // 
            // cway
            // 
            this.cway.DataPropertyName = "cway";
            this.cway.HeaderText = "联系方式";
            this.cway.Name = "cway";
            // 
            // cAddress
            // 
            this.cAddress.DataPropertyName = "cAddress";
            this.cAddress.HeaderText = "联系地址";
            this.cAddress.Name = "cAddress";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSC);
            this.groupBox2.Controls.Add(this.txtSCName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(360, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // btnSC
            // 
            this.btnSC.Location = new System.Drawing.Point(247, 20);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(75, 23);
            this.btnSC.TabIndex = 5;
            this.btnSC.Text = "查询";
            this.btnSC.UseVisualStyleBackColor = true;
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // txtSCName
            // 
            this.txtSCName.Location = new System.Drawing.Point(101, 20);
            this.txtSCName.MaxLength = 20;
            this.txtSCName.Name = "txtSCName";
            this.txtSCName.Size = new System.Drawing.Size(127, 21);
            this.txtSCName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "客户名称";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClient";
            this.Text = "客户管理";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.TextBox txtCWay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.TextBox txtSCName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cway;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
    }
}