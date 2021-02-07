namespace WeCare
{
    partial class frmItemMgr
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btClone = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblBidPrice = new System.Windows.Forms.Label();
            this.txtBidPrice = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblLot = new System.Windows.Forms.Label();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.lblDesription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDonorName = new System.Windows.Forms.Label();
            this.txtDonorName = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btAnon = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(545, 353);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(169, 64);
            this.btDelete.TabIndex = 51;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            // 
            // btClone
            // 
            this.btClone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClone.Location = new System.Drawing.Point(545, 251);
            this.btClone.Name = "btClone";
            this.btClone.Size = new System.Drawing.Size(169, 64);
            this.btClone.TabIndex = 50;
            this.btClone.Text = "Clone";
            this.btClone.UseVisualStyleBackColor = true;
            this.btClone.Visible = false;
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(545, 135);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(169, 64);
            this.btEdit.TabIndex = 49;
            this.btEdit.Text = "Search / Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(545, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(169, 64);
            this.btAdd.TabIndex = 48;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(63, 562);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(73, 13);
            this.lblAmountPaid.TabIndex = 47;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(145, 559);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 22);
            this.txtAmountPaid.TabIndex = 46;
            // 
            // lblBidPrice
            // 
            this.lblBidPrice.AutoSize = true;
            this.lblBidPrice.Location = new System.Drawing.Point(63, 528);
            this.lblBidPrice.Name = "lblBidPrice";
            this.lblBidPrice.Size = new System.Drawing.Size(51, 13);
            this.lblBidPrice.TabIndex = 45;
            this.lblBidPrice.Text = "Bid Price";
            // 
            // txtBidPrice
            // 
            this.txtBidPrice.Location = new System.Drawing.Point(145, 525);
            this.txtBidPrice.Name = "txtBidPrice";
            this.txtBidPrice.Size = new System.Drawing.Size(100, 22);
            this.txtBidPrice.TabIndex = 44;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(63, 494);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 13);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Phone No.";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(145, 491);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 22);
            this.txtPhone.TabIndex = 42;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(63, 460);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(55, 13);
            this.lblCompany.TabIndex = 41;
            this.lblCompany.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(145, 457);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(348, 22);
            this.txtCompany.TabIndex = 40;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Location = new System.Drawing.Point(63, 426);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(76, 13);
            this.lblBuyerName.TabIndex = 39;
            this.lblBuyerName.Text = "Buyer\'s Name";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(145, 423);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(348, 22);
            this.txtBuyerName.TabIndex = 38;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(318, 342);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(39, 13);
            this.lblItem.TabIndex = 37;
            this.lblItem.Text = "Item #";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(362, 339);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 22);
            this.txtItem.TabIndex = 36;
            // 
            // lblLot
            // 
            this.lblLot.AutoSize = true;
            this.lblLot.Location = new System.Drawing.Point(150, 342);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(33, 13);
            this.lblLot.TabIndex = 35;
            this.lblLot.Text = "Lot #";
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(194, 339);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(100, 22);
            this.txtLot.TabIndex = 34;
            // 
            // lblDesription
            // 
            this.lblDesription.AutoSize = true;
            this.lblDesription.Location = new System.Drawing.Point(31, 204);
            this.lblDesription.Name = "lblDesription";
            this.lblDesription.Size = new System.Drawing.Size(66, 13);
            this.lblDesription.TabIndex = 33;
            this.lblDesription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(34, 220);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(459, 105);
            this.txtDescription.TabIndex = 32;
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.Location = new System.Drawing.Point(40, 81);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(80, 13);
            this.lblDonorName.TabIndex = 31;
            this.lblDonorName.Text = "Donor\'s Name";
            // 
            // txtDonorName
            // 
            this.txtDonorName.Location = new System.Drawing.Point(126, 78);
            this.txtDonorName.Multiline = true;
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.Size = new System.Drawing.Size(367, 96);
            this.txtDonorName.TabIndex = 30;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(243, 25);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(51, 13);
            this.lblKeyword.TabIndex = 29;
            this.lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(300, 20);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(193, 22);
            this.txtKeyword.TabIndex = 28;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(31, 25);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(45, 13);
            this.lblIndex.TabIndex = 27;
            this.lblIndex.Text = "Index #";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(82, 20);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(42, 22);
            this.txtIndex.TabIndex = 26;
            this.txtIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIndex_KeyPress);
            // 
            // btAnon
            // 
            this.btAnon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnon.Location = new System.Drawing.Point(9, 118);
            this.btAnon.Name = "btAnon";
            this.btAnon.Size = new System.Drawing.Size(111, 22);
            this.btAnon.TabIndex = 52;
            this.btAnon.Text = "ANONYMOUS";
            this.btAnon.UseVisualStyleBackColor = true;
            this.btAnon.Click += new System.EventHandler(this.btAnon_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(545, 451);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(169, 64);
            this.btSave.TabIndex = 53;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(545, 531);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(169, 64);
            this.btCancel.TabIndex = 54;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmItemMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 608);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAnon);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btClone);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblBidPrice);
            this.Controls.Add(this.txtBidPrice);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblBuyerName);
            this.Controls.Add(this.txtBuyerName);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblLot);
            this.Controls.Add(this.txtLot);
            this.Controls.Add(this.lblDesription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDonorName);
            this.Controls.Add(this.txtDonorName);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.txtIndex);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemMgr";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmItemMgr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClone;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblBidPrice;
        private System.Windows.Forms.TextBox txtBidPrice;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label lblDesription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDonorName;
        private System.Windows.Forms.TextBox txtDonorName;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btAnon;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}