using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCare
{
    public partial class frmMain : Form
    {
        public frmBidMgr _bidMgr;
        public frmItemMgr _itemMgr;
        public frmPmts _pmts;

        public frmMain()
        {
            InitializeComponent();
            LoadForms();

            //SqlTest();
        }

        private void SqlTest()
        {
            SqlConnection sqlConn = new SqlConnection();
            DB.Open(ref sqlConn);
        }

        private void LoadForms()
        {
            _bidMgr = new frmBidMgr
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };

            _itemMgr = new frmItemMgr
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };

            _pmts = new frmPmts
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
        }

        private void btItemMgr_Click(object sender, EventArgs e)
        {
            _itemMgr.Show();
            _itemMgr.BringToFront();
        }

        private void btBidMgr_Click(object sender, EventArgs e)
        {
            _bidMgr.Show();
            _bidMgr.BringToFront();
        }

        private void btPmts_Click(object sender, EventArgs e)
        {
            _pmts.Show();
            _pmts.BringToFront();
        }
    }
}
