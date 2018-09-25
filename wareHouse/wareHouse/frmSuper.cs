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
    public partial class frmSuper : Form
    {
        private static string UNAME;
        public frmSuper()
        {
            InitializeComponent();
        }
        public frmSuper(string uname)
        {
            InitializeComponent();
            UNAME = uname;
        }

        private void frmSuper_Load(object sender, EventArgs e)
        {

        }
    }
}
