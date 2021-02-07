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
    public partial class frmPmts : Form
    {
        private DataTable _dtData;
        public frmPmts()
        {
            _dtData = new DataTable();

            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {
                var strGetData = new StringBuilder();
                strGetData.Append("SELECT  * ");
                strGetData.Append("FROM ");
                strGetData.Append("itemdata ");
                strGetData.Append("WHERE 1=1 ");
                strGetData.Append("AND buyer_name LIKE '%" + txtSearch.Text + "%' ");
                strGetData.Append("OR  buyer_phone LIKE '%" + txtSearch.Text + "%'");

                var sqlIndex = new SqlConnection();
                using (sqlIndex = DB.Open(ref sqlIndex))
                {
                    var sqlGetDataCmd = new SqlCommand(strGetData.ToString(), sqlIndex).ExecuteReader();
                    if (sqlGetDataCmd.HasRows)
                    {
                        _dtData.Load(sqlGetDataCmd);

                        if (_dtData.Rows.Count > 0)
                        {
                            dgvData.DataSource = _dtData;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding index item data" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void btMarkPaid_Click(object sender, EventArgs e)
        {
            MakePayment();
        }

        private void MakePayment()
        {
            try
            {
                var strAddItem = new StringBuilder();
                strAddItem.Append("UPDATE ");
                strAddItem.Append("itemdata ");
                strAddItem.Append("paid_amount = '' ");
                strAddItem.Append("WHERE 1=1 ");
                strAddItem.Append("AND index_number = ");

                var sqlConn = new SqlConnection();
                using (sqlConn = DB.Open(ref sqlConn))
                {
                    var sqlCmd = new SqlCommand(strAddItem.ToString(), sqlConn).ExecuteNonQuery();

                    if (sqlCmd == 0)
                    {
                        MessageBox.Show("Error editing item");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure editing item" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
    }
}
