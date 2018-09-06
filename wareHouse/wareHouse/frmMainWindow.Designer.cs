namespace wareHouse
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbProcurement = new System.Windows.Forms.ToolStripButton();
            this.tsbStorage = new System.Windows.Forms.ToolStripButton();
            this.tsbDelivery = new System.Windows.Forms.ToolStripButton();
            this.tsbClient = new System.Windows.Forms.ToolStripButton();
            this.tsbFinance = new System.Windows.Forms.ToolStripButton();
            this.tsbInventory = new System.Windows.Forms.ToolStripButton();
            this.tsbSuper = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProcurement,
            this.tsbStorage,
            this.tsbDelivery,
            this.tsbClient,
            this.tsbFinance,
            this.tsbInventory,
            this.tsbSuper});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1306, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbProcurement
            // 
            this.tsbProcurement.Image = ((System.Drawing.Image)(resources.GetObject("tsbProcurement.Image")));
            this.tsbProcurement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProcurement.Name = "tsbProcurement";
            this.tsbProcurement.Size = new System.Drawing.Size(76, 22);
            this.tsbProcurement.Text = "采购管理";
            this.tsbProcurement.Click += new System.EventHandler(this.tsbProcurement_Click);
            // 
            // tsbStorage
            // 
            this.tsbStorage.Image = ((System.Drawing.Image)(resources.GetObject("tsbStorage.Image")));
            this.tsbStorage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStorage.Name = "tsbStorage";
            this.tsbStorage.Size = new System.Drawing.Size(76, 22);
            this.tsbStorage.Text = "入库管理";
            this.tsbStorage.Click += new System.EventHandler(this.tsbStorage_Click);
            // 
            // tsbDelivery
            // 
            this.tsbDelivery.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelivery.Image")));
            this.tsbDelivery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelivery.Name = "tsbDelivery";
            this.tsbDelivery.Size = new System.Drawing.Size(76, 22);
            this.tsbDelivery.Text = "出库管理";
            this.tsbDelivery.Click += new System.EventHandler(this.tsbDelivery_Click);
            // 
            // tsbClient
            // 
            this.tsbClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbClient.Image")));
            this.tsbClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClient.Name = "tsbClient";
            this.tsbClient.Size = new System.Drawing.Size(76, 22);
            this.tsbClient.Text = "客户管理";
            this.tsbClient.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsbFinance
            // 
            this.tsbFinance.Image = ((System.Drawing.Image)(resources.GetObject("tsbFinance.Image")));
            this.tsbFinance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFinance.Name = "tsbFinance";
            this.tsbFinance.Size = new System.Drawing.Size(76, 22);
            this.tsbFinance.Text = "财务管理";
            this.tsbFinance.Click += new System.EventHandler(this.tsbFinance_Click);
            // 
            // tsbInventory
            // 
            this.tsbInventory.Image = ((System.Drawing.Image)(resources.GetObject("tsbInventory.Image")));
            this.tsbInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInventory.Name = "tsbInventory";
            this.tsbInventory.Size = new System.Drawing.Size(76, 22);
            this.tsbInventory.Text = "库存管理";
            this.tsbInventory.Click += new System.EventHandler(this.tsbInventory_Click);
            // 
            // tsbSuper
            // 
            this.tsbSuper.Image = ((System.Drawing.Image)(resources.GetObject("tsbSuper.Image")));
            this.tsbSuper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuper.Name = "tsbSuper";
            this.tsbSuper.Size = new System.Drawing.Size(76, 22);
            this.tsbSuper.Text = "超级管理";
            this.tsbSuper.Click += new System.EventHandler(this.tsbSuper_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 763);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMainWindow";
            this.Text = "希创管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainWindow_FormClosing);
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStorage;
        private System.Windows.Forms.ToolStripButton tsbDelivery;
        private System.Windows.Forms.ToolStripButton tsbClient;
        private System.Windows.Forms.ToolStripButton tsbFinance;
        private System.Windows.Forms.ToolStripButton tsbInventory;
        private System.Windows.Forms.ToolStripButton tsbSuper;
        private System.Windows.Forms.ToolStripButton tsbProcurement;
    }
}