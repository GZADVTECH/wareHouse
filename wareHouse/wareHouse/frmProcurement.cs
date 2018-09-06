using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wareHouse
{
    public partial class frmProcurement : Form
    {
        private static string username;
        public frmProcurement()
        {
            InitializeComponent();
        }
        public frmProcurement(string userName)
        {
            InitializeComponent();
            username = userName;
        }

        private void frmProcurement_Load(object sender, EventArgs e)
        {
            UserName.Text = username;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否新建？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                    if (item is CheckBox)
                    {
                        CheckBox cb = item as CheckBox;
                        cb.Checked = false;
                    }
                    if (item is ComboBox)
                    {
                        ComboBox cbb = item as ComboBox;
                        cbb.SelectedIndex = -1;
                    }
                    if (item is DateTimePicker)
                    {
                        DateTimePicker dtp = item as DateTimePicker;
                        dtp.Value = DateTime.Now;
                    }
                    if (item is DataGridView)
                    {
                        DataGridView dgv = item as DataGridView;
                        dgv.Rows.Clear();
                    }
                }
            }
        }
    }
}
