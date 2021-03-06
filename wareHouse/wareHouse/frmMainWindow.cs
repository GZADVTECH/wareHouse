﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHMODELS;

namespace wareHouse
{
    public partial class frmMainWindow : Form
    {
        private static string userID;//用户编号
        private static string userName;//用户姓名
        private static int userLimit;//用户权限
        public frmMainWindow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public frmMainWindow(userMessage um)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            userID = um.userID;
            userName = um.userName;
            userLimit = um.userLimit;
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            switch (userLimit)
            {
                case 2:tsbProcurement.Visible = false;tsbFinance.Visible = false;tsbSuper.Visible = false;break;
                case 3:tsbStorage.Visible = false;tsbDelivery.Visible = false;tsbFinance.Visible = false;tsbInventory.Visible = false;tsbRepair.Visible = false;tsbSuper.Visible = false;break;
                case 4: tsbProcurement.Visible = false; tsbStorage.Visible = false; tsbDelivery.Visible = false;tsbClient.Visible = false;tsbInventory.Visible = false;tsbSupplier.Visible = false;tsbRepair.Visible = false;tsbSuper.Visible = false;break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 窗体关闭时关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 客户管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmClient frmclient = new frmClient(userID,userName);
            frmclient.MdiParent = this;
            frmclient.Show();
        }
        /// <summary>
        /// 采购管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbProcurement_Click(object sender, EventArgs e)
        {
            frmProcurement procurement = new frmProcurement(userName,userID);
            procurement.MdiParent = this;
            procurement.Show();
        }
        /// <summary>
        /// 入库管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbStorage_Click(object sender, EventArgs e)
        {
            frmStorage frmstorage = new frmStorage(userID);
            frmstorage.MdiParent = this;
            frmstorage.Show();
        }
        /// <summary>
        /// 出库管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelivery_Click(object sender, EventArgs e)
        {
            frmDelivery frmdelivery = new frmDelivery(userID,userName);
            frmdelivery.MdiParent = this;
            frmdelivery.Show();
        }
        /// <summary>
        /// 财务管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbFinance_Click(object sender, EventArgs e)
        {
            frmFinance frmfinance = new frmFinance(userID);
            frmfinance.MdiParent = this;
            frmfinance.Show();
        }
        /// <summary>
        /// 库存管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbInventory_Click(object sender, EventArgs e)
        {
            frmInventory frmInentory = new frmInventory(userID);
            frmInentory.MdiParent = this;
            frmInentory.Show();
        }
        /// <summary>
        /// 超级管理员窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSuper_Click(object sender, EventArgs e)
        {
            frmSuper frmSuper = new frmSuper(userID);
            frmSuper.MdiParent = this;
            frmSuper.Show();
        }
        /// <summary>
        /// 维修管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMaintenance main = new frmMaintenance(userID);
            main.MdiParent = this;
            main.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier(userID);
            supplier.MdiParent = this;
            supplier.Show();
        }

        private void tsbBorrow_Click(object sender, EventArgs e)
        {
            frmBorrow borrow = new frmBorrow(userID);
            borrow.MdiParent = this;
            borrow.Show();
        }
    }
}
