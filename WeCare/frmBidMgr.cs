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
    public partial class frmBidMgr : Form
    {
        private DataTable _dtData;
        public frmBidMgr()
        {
            _dtData = new DataTable();

            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var strGetData = new StringBuilder();
                strGetData.Append("SELECT  * ");
                strGetData.Append("FROM ");
                strGetData.Append("itemdata ");

                var sqlIndex = new SqlConnection();
                using (sqlIndex = DB.Open(ref sqlIndex))
                {
                    var sqlGetDataCmd = new SqlCommand(strGetData.ToString(), sqlIndex).ExecuteReader();
                    if (sqlGetDataCmd.HasRows)
                    {
                        _dtData.Load(sqlGetDataCmd);
                    }
                    else
                    {
                        MessageBox.Show("Unable to find index item data");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding index item data" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
    }
}
