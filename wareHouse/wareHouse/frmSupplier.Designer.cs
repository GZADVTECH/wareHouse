namespace wareHouse
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止供应ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIperatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierNumber,
            this.supplierName,
            this.supplierInfo,
            this.supplierRemark,
            this.supplierStatus,
            this.supplierIperatorID});
            this.dgvSupplier.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSupplier.Location = new System.Drawing.Point(13, 96);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowTemplate.Height = 23;
            this.dgvSupplier.Size = new System.Drawing.Size(652, 319);
            this.dgvSupplier.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.停止供应ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 停止供应ToolStripMenuItem
            // 
            this.停止供应ToolStripMenuItem.Name = "停止供应ToolStripMenuItem";
            this.停止供应ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.停止供应ToolStripMenuItem.Text = "停止供应";
            this.停止供应ToolStripMenuItem.Click += new System.EventHandler(this.停止供应ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相关信息";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(559, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(78, 45);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(463, 21);
            this.txtMessage.TabIndex = 1;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(437, 17);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(209, 21);
            this.txtRemark.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "备注";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "供应商名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "供应商信息";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(78, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商编号";
            // 
            // supplierNumber
            // 
            this.supplierNumber.DataPropertyName = "supplierNumber";
            this.supplierNumber.HeaderText = "供应商编号";
            this.supplierNumber.Name = "supplierNumber";
            this.supplierNumber.ReadOnly = true;
            this.supplierNumber.Visible = false;
            // 
            // supplierName
            // 
            this.supplierName.DataPropertyName = "supplierName";
            this.supplierName.HeaderText = "供应商名称";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            // 
            // supplierInfo
            // 
            this.supplierInfo.DataPropertyName = "supplierInfo";
            this.supplierInfo.HeaderText = "供应商信息";
            this.supplierInfo.Name = "supplierInfo";
            this.supplierInfo.ReadOnly = true;
            this.supplierInfo.Width = 300;
            // 
            // supplierRemark
            // 
            this.supplierRemark.DataPropertyName = "supplierRemark";
            this.supplierRemark.HeaderText = "备注";
            this.supplierRemark.Name = "supplierRemark";
            this.supplierRemark.ReadOnly = true;
            this.supplierRemark.Width = 200;
            // 
            // supplierStatus
            // 
            this.supplierStatus.DataPropertyName = "supplierStatus";
            this.supplierStatus.HeaderText = "供应商状态";
            this.supplierStatus.Name = "supplierStatus";
            this.supplierStatus.ReadOnly = true;
            this.supplierStatus.Visible = false;
            // 
            // supplierIperatorID
            // 
            this.supplierIperatorID.DataPropertyName = "supplierIperatorID";
            this.supplierIperatorID.HeaderText = "操作员编号";
            this.supplierIperatorID.Name = "supplierIperatorID";
            this.supplierIperatorID.ReadOnly = true;
            this.supplierIperatorID.Visible = false;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSupplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplier";
            this.Text = "供应商管理";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止供应ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIperatorID;
    }
}