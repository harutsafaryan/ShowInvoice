
namespace ShowInvoice.Forms
{
    partial class InvoicesForm
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
            this.grdInvoices = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblInvoiceLines = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInvoices
            // 
            this.grdInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.PaidDate,
            this.TotalAmount});
            this.grdInvoices.Location = new System.Drawing.Point(44, 63);
            this.grdInvoices.Name = "grdInvoices";
            this.grdInvoices.ReadOnly = true;
            this.grdInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoices.Size = new System.Drawing.Size(648, 150);
            this.grdInvoices.TabIndex = 0;
            this.grdInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdInvoices_CellClick);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Invoice Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // PaidDate
            // 
            this.PaidDate.DataPropertyName = "PaidDate";
            this.PaidDate.HeaderText = "Paid Date";
            this.PaidDate.Name = "PaidDate";
            this.PaidDate.ReadOnly = true;
            this.PaidDate.Width = 200;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 200;
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(44, 293);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.ReadOnly = true;
            this.grdProducts.Size = new System.Drawing.Size(648, 204);
            this.grdProducts.TabIndex = 1;
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoices.Location = new System.Drawing.Point(51, 32);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(67, 20);
            this.lblInvoices.TabIndex = 2;
            this.lblInvoices.Text = "Invoices";
            // 
            // lblInvoiceLines
            // 
            this.lblInvoiceLines.AutoSize = true;
            this.lblInvoiceLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceLines.Location = new System.Drawing.Point(51, 259);
            this.lblInvoiceLines.Name = "lblInvoiceLines";
            this.lblInvoiceLines.Size = new System.Drawing.Size(101, 20);
            this.lblInvoiceLines.TabIndex = 3;
            this.lblInvoiceLines.Text = "Invoice Lines";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(537, 23);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(105, 20);
            this.lblLoggedUser.TabIndex = 4;
            this.lblLoggedUser.Text = "Logged User:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(648, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 20);
            this.lblUser.TabIndex = 5;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 549);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblInvoiceLines);
            this.Controls.Add(this.lblInvoices);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.grdInvoices);
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInvoices;
        private System.Windows.Forms.DataGridView grdProducts;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Label lblInvoiceLines;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Label lblUser;
    }
}