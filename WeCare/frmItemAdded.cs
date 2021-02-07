using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCare
{
    public partial class frmItemAdded : Form
    {
        private string _index = string.Empty;
        private string _keyword = string.Empty;
        public frmItemAdded(string iIndex, string iKeyword)
        {
            _index = iIndex;
            _keyword = iKeyword;

            InitializeComponent();

            ShowResult();
        }

        private void ShowResult()
        {
            lblText.Text = _keyword + " added successfully with Item Index #" + _index;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btClone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
