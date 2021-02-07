using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCare
{
    public partial class frmItemMgr : Form
    {
        private string _index;
        public frmItemMgr()
        {
            InitializeComponent();

            ClearForm();

        }

        private void ClearForm()
        {
            _index = string.Empty;

            txtIndex.Enabled = false;
            txtIndex.Text = string.Empty;

            txtKeyword.Enabled = false;
            txtKeyword.Text = string.Empty;

            txtDonorName.Enabled = false;
            txtDonorName.Text = string.Empty;

            txtDescription.Enabled = false;
            txtDescription.Text = string.Empty;

            txtLot.Enabled = false;
            txtLot.Text = string.Empty;

            txtItem.Enabled = false;
            txtItem.Text = string.Empty;

            txtBuyerName.Enabled = false;
            txtBuyerName.Text = string.Empty;

            txtCompany.Enabled = false;
            txtCompany.Text = string.Empty;

            txtPhone.Enabled = false;
            txtPhone.Text = string.Empty;

            txtBidPrice.Enabled = false;
            txtBidPrice.Text = string.Empty;

            txtAmountPaid.Enabled = false;
            txtAmountPaid.Text = string.Empty;

            btClone.Enabled = false;
            btDelete.Enabled = false;
            btSave.Enabled = false;
            btCancel.Enabled = false;

            btAdd.Enabled = true;
            btEdit.Enabled = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddSQLPlaceHolder();
            AddNewItem();
        }

        private void AddSQLPlaceHolder()
        {
            try
            {
                var strGetIndex = new StringBuilder();
                strGetIndex.Append("SELECT TOP 1 ");
                strGetIndex.Append("index_number ");
                strGetIndex.Append("FROM ");
                strGetIndex.Append("itemdata ");
                strGetIndex.Append("ORDER BY index_number DESC ");

                var sqlIndex = new SqlConnection();
                using (sqlIndex = DB.Open(ref sqlIndex))
                {
                    var sqlGetIndexCmd = new SqlCommand(strGetIndex.ToString(), sqlIndex).ExecuteReader();
                    if (sqlGetIndexCmd.HasRows)
                    {
                        while (sqlGetIndexCmd.Read())
                        {
                            _index = sqlGetIndexCmd["index_number"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to create index");
                        return;
                    }
                }

                _index = (Convert.ToInt32(_index) + 1 ).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating index" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
                return;
            }

            var strInsertPlaceHolder = new StringBuilder();
            strInsertPlaceHolder.Append("INSERT INTO ");
            strInsertPlaceHolder.Append("itemdata ");
            strInsertPlaceHolder.Append("( ");
            strInsertPlaceHolder.Append("edit_lock,");
            strInsertPlaceHolder.Append("keyword,");
            strInsertPlaceHolder.Append("donor_name, ");
            strInsertPlaceHolder.Append("description ");
            strInsertPlaceHolder.Append(") ");
            strInsertPlaceHolder.Append("VALUES ");
            strInsertPlaceHolder.Append("(");
            strInsertPlaceHolder.Append("0,");
            strInsertPlaceHolder.Append("'" + _index + "',");
            strInsertPlaceHolder.Append("'" + _index + "',");
            strInsertPlaceHolder.Append("'" + _index + "'");
            strInsertPlaceHolder.Append(")");

            var sqlPlaceHolder = new SqlConnection();
            try
            {
                using (sqlPlaceHolder = DB.Open(ref sqlPlaceHolder))
                {
                    var sqlPlaceHolderCmd = new SqlCommand(strInsertPlaceHolder.ToString(), sqlPlaceHolder).ExecuteNonQuery();

                    if (sqlPlaceHolderCmd == 0)
                    {
                        MessageBox.Show("Error creating placeholder");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure creating placeholder" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void AddNewItem()
        {
            txtKeyword.Enabled = true;
            txtDonorName.Enabled = true;
            txtDescription.Enabled = true;

            btSave.Enabled = true;
            btCancel.Enabled = true;
            btAnon.Enabled = true;

            btAdd.Enabled = false;

            btEdit.Enabled = false;
        }

        private void btAnon_Click(object sender, EventArgs e)
        {
            if (txtDonorName.Enabled)
            {
                txtDonorName.Text = "ANONYMOUS";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIndex.Text))
            {
                try
                {
                    var strAddItem = new StringBuilder();
                    strAddItem.Append("UPDATE ");
                    strAddItem.Append("itemdata ");
                    strAddItem.Append("SET keyword = '" + txtKeyword.Text + "',");
                    strAddItem.Append("index_number = " + _index + ",");
                    strAddItem.Append("donor_name = '" + txtDonorName.Text + "', ");
                    strAddItem.Append("description = '" + txtDescription.Text + "' ");
                    strAddItem.Append("WHERE 1=1 ");
                    strAddItem.Append("AND keyword = '" + _index + "'");

                    var sqlConn = new SqlConnection();
                    using (sqlConn = DB.Open(ref sqlConn))
                    {
                        var sqlCmd = new SqlCommand(strAddItem.ToString(), sqlConn).ExecuteNonQuery();

                        if (sqlCmd == 0)
                        {
                            MessageBox.Show("Error adding item");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failure adding item" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
                }

                var addedWindow = new frmItemAdded(_index, txtKeyword.Text);
                if (addedWindow.ShowDialog(this) == DialogResult.Yes)
                {
                    ClearForm();
                    btAdd.PerformClick();
                }
            }
            else
            {
                try
                {
                    var strAddItem = new StringBuilder();
                    strAddItem.Append("UPDATE ");
                    strAddItem.Append("itemdata ");
                    strAddItem.Append("SET keyword = '" + txtKeyword.Text + "',");
                    strAddItem.Append("donor_name = '" + txtDonorName.Text + "',");
                    strAddItem.Append("description = '" + txtDescription.Text + "',");
                    strAddItem.Append("lot = '" + txtLot.Text + "',");
                    strAddItem.Append("item = '" + txtItem.Text + "',");
                    strAddItem.Append("buyer_name = '" + txtBuyerName.Text + "',");
                    strAddItem.Append("company = '" + txtCompany.Text + "',");
                    strAddItem.Append("buyer_phone = '" + txtPhone.Text + "',");
                    strAddItem.Append("bid_price = '" + txtBidPrice.Text + "',");
                    strAddItem.Append("paid_amount = '" + txtAmountPaid.Text + "' ");
                    strAddItem.Append("WHERE 1=1 ");
                    strAddItem.Append("AND index_number = " + txtIndex.Text + "");

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
                ClearForm();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btCancel.Enabled = true;

            btAdd.Enabled = false;
            btAnon.Enabled = false;

            txtIndex.Enabled = true;
            txtIndex.Focus();
        }

        private void txtIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                if(!string.IsNullOrEmpty(txtIndex.Text))
                    SearchItem(txtIndex.Text);
            }
        }

        private void SearchItem(string iIndex)
        {
            try
            {
                var strGetIndex = new StringBuilder();
                strGetIndex.Append("SELECT ");
                strGetIndex.Append("keyword,");
                strGetIndex.Append("donor_name,");
                strGetIndex.Append("description,");
                strGetIndex.Append("lot,");
                strGetIndex.Append("item,");
                strGetIndex.Append("buyer_name,");
                strGetIndex.Append("company,");
                strGetIndex.Append("buyer_phone,");
                strGetIndex.Append("bid_price,");
                strGetIndex.Append("paid_amount ");
                strGetIndex.Append("FROM ");
                strGetIndex.Append("itemdata ");
                strGetIndex.Append("WHERE index_number = " + iIndex);

                var sqlIndex = new SqlConnection();
                using (sqlIndex = DB.Open(ref sqlIndex))
                {
                    var sqlGetIndexCmd = new SqlCommand(strGetIndex.ToString(), sqlIndex).ExecuteReader();
                    if (sqlGetIndexCmd.HasRows)
                    {
                        while (sqlGetIndexCmd.Read())
                        {
                            txtKeyword.Text = sqlGetIndexCmd["keyword"].ToString();
                            txtDescription.Text = sqlGetIndexCmd["description"].ToString();
                            txtDonorName.Text = sqlGetIndexCmd["donor_name"].ToString();
                            txtLot.Text = sqlGetIndexCmd["lot"].ToString();
                            txtItem.Text = sqlGetIndexCmd["item"].ToString();
                            txtBuyerName.Text = sqlGetIndexCmd["buyer_name"].ToString();
                            txtCompany.Text = sqlGetIndexCmd["company"].ToString();
                            txtPhone.Text = sqlGetIndexCmd["buyer_phone"].ToString();
                            txtBidPrice.Text = sqlGetIndexCmd["bid_price"].ToString();
                            txtAmountPaid.Text = sqlGetIndexCmd["paid_amount"].ToString();
                        }

                        EnableEditing();
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

        private void EnableEditing()
        {
            txtDonorName.Select();
            txtDonorName.Enabled = true;
            txtKeyword.Enabled = true;
            txtDescription.Enabled = true;
            txtLot.Enabled = true;
            txtItem.Enabled = true;
            txtBuyerName.Enabled = true;
            txtCompany.Enabled = true;
            txtPhone.Enabled = true;
            txtBidPrice.Enabled = true;
            txtAmountPaid.Enabled = true;

            btSave.Enabled = true;
            btCancel.Enabled = true;
            btAnon.Enabled = true;

            btAdd.Enabled = false;

            txtIndex.Enabled = false;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
