
namespace SPILPracticalTest
{
    partial class SalseOrder
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
            this.plSalseOrder = new System.Windows.Forms.Panel();
            this.plSelseDetails = new System.Windows.Forms.Panel();
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.txtTotalIncl = new System.Windows.Forms.TextBox();
            this.txtTotalExcl = new System.Windows.Forms.TextBox();
            this.liblTotalIncl = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTotalExcl = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtRefNumber = new System.Windows.Forms.TextBox();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtSubrb = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.ItemCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plSalseOrder.SuspendLayout();
            this.plSelseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // plSalseOrder
            // 
            this.plSalseOrder.Controls.Add(this.plSelseDetails);
            this.plSalseOrder.Controls.Add(this.btnSaveOrder);
            this.plSalseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSalseOrder.Location = new System.Drawing.Point(0, 0);
            this.plSalseOrder.Name = "plSalseOrder";
            this.plSalseOrder.Size = new System.Drawing.Size(917, 693);
            this.plSalseOrder.TabIndex = 0;
            // 
            // plSelseDetails
            // 
            this.plSelseDetails.AutoSize = true;
            this.plSelseDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSelseDetails.Controls.Add(this.dtInvoiceDate);
            this.plSelseDetails.Controls.Add(this.txtTotalTax);
            this.plSelseDetails.Controls.Add(this.txtTotalIncl);
            this.plSelseDetails.Controls.Add(this.txtTotalExcl);
            this.plSelseDetails.Controls.Add(this.liblTotalIncl);
            this.plSelseDetails.Controls.Add(this.lblTotalTax);
            this.plSelseDetails.Controls.Add(this.lblTotalExcl);
            this.plSelseDetails.Controls.Add(this.dgvSales);
            this.plSelseDetails.Controls.Add(this.txtNote);
            this.plSelseDetails.Controls.Add(this.lblNote);
            this.plSelseDetails.Controls.Add(this.txtRefNumber);
            this.plSelseDetails.Controls.Add(this.lblRefNo);
            this.plSelseDetails.Controls.Add(this.lblInvoiceDate);
            this.plSelseDetails.Controls.Add(this.txtInvoiceNo);
            this.plSelseDetails.Controls.Add(this.lblInvoiceNo);
            this.plSelseDetails.Controls.Add(this.txtPostCode);
            this.plSelseDetails.Controls.Add(this.txtSubrb);
            this.plSelseDetails.Controls.Add(this.txtState);
            this.plSelseDetails.Controls.Add(this.txtAddress3);
            this.plSelseDetails.Controls.Add(this.txtAddress2);
            this.plSelseDetails.Controls.Add(this.txtAddress1);
            this.plSelseDetails.Controls.Add(this.cmbCustomerName);
            this.plSelseDetails.Controls.Add(this.lblPostCode);
            this.plSelseDetails.Controls.Add(this.lblState);
            this.plSelseDetails.Controls.Add(this.lblSuburb);
            this.plSelseDetails.Controls.Add(this.lblAddress3);
            this.plSelseDetails.Controls.Add(this.lblAddress2);
            this.plSelseDetails.Controls.Add(this.lblAddress1);
            this.plSelseDetails.Controls.Add(this.lblCustomerName);
            this.plSelseDetails.Location = new System.Drawing.Point(3, 65);
            this.plSelseDetails.Name = "plSelseDetails";
            this.plSelseDetails.Size = new System.Drawing.Size(908, 616);
            this.plSelseDetails.TabIndex = 2;
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.Location = new System.Drawing.Point(589, 49);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(260, 22);
            this.dtInvoiceDate.TabIndex = 31;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Location = new System.Drawing.Point(589, 509);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.Size = new System.Drawing.Size(260, 22);
            this.txtTotalTax.TabIndex = 30;
            // 
            // txtTotalIncl
            // 
            this.txtTotalIncl.Location = new System.Drawing.Point(589, 545);
            this.txtTotalIncl.Name = "txtTotalIncl";
            this.txtTotalIncl.Size = new System.Drawing.Size(260, 22);
            this.txtTotalIncl.TabIndex = 29;
            // 
            // txtTotalExcl
            // 
            this.txtTotalExcl.Location = new System.Drawing.Point(589, 480);
            this.txtTotalExcl.Name = "txtTotalExcl";
            this.txtTotalExcl.Size = new System.Drawing.Size(260, 22);
            this.txtTotalExcl.TabIndex = 28;
            // 
            // liblTotalIncl
            // 
            this.liblTotalIncl.AutoSize = true;
            this.liblTotalIncl.Location = new System.Drawing.Point(459, 545);
            this.liblTotalIncl.Name = "liblTotalIncl";
            this.liblTotalIncl.Size = new System.Drawing.Size(65, 17);
            this.liblTotalIncl.TabIndex = 27;
            this.liblTotalIncl.Text = "Total Incl";
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Location = new System.Drawing.Point(459, 514);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(67, 17);
            this.lblTotalTax.TabIndex = 26;
            this.lblTotalTax.Text = "Total Tax";
            // 
            // lblTotalExcl
            // 
            this.lblTotalExcl.AutoSize = true;
            this.lblTotalExcl.Location = new System.Drawing.Point(459, 480);
            this.lblTotalExcl.Name = "lblTotalExcl";
            this.lblTotalExcl.Size = new System.Drawing.Size(69, 17);
            this.lblTotalExcl.TabIndex = 25;
            this.lblTotalExcl.Text = "Total Excl";
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.Description,
            this.Note,
            this.Qty,
            this.Price,
            this.Tax,
            this.ExclAmount,
            this.TaxAmount,
            this.InclAmount,
            this.Id});
            this.dgvSales.Location = new System.Drawing.Point(22, 287);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(864, 175);
            this.dgvSales.TabIndex = 24;
            this.dgvSales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellEndEdit);
            this.dgvSales.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSales_EditingControlShowing);
            this.dgvSales.Click += new System.EventHandler(this.dgvSales_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(589, 132);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(260, 129);
            this.txtNote.TabIndex = 23;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(459, 132);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(38, 17);
            this.lblNote.TabIndex = 22;
            this.lblNote.Text = "Note";
            // 
            // txtRefNumber
            // 
            this.txtRefNumber.Location = new System.Drawing.Point(589, 91);
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.Size = new System.Drawing.Size(260, 22);
            this.txtRefNumber.TabIndex = 21;
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Location = new System.Drawing.Point(459, 91);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(96, 17);
            this.lblRefNo.TabIndex = 20;
            this.lblRefNo.Text = "Reference No";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(459, 54);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(86, 17);
            this.lblInvoiceDate.TabIndex = 18;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(589, 18);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(260, 22);
            this.txtInvoiceNo.TabIndex = 17;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(459, 18);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(78, 17);
            this.lblInvoiceNo.TabIndex = 16;
            this.lblInvoiceNo.Text = "Invoice No.";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(149, 239);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(260, 22);
            this.txtPostCode.TabIndex = 15;
            // 
            // txtSubrb
            // 
            this.txtSubrb.Location = new System.Drawing.Point(149, 165);
            this.txtSubrb.Name = "txtSubrb";
            this.txtSubrb.Size = new System.Drawing.Size(260, 22);
            this.txtSubrb.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(149, 201);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(260, 22);
            this.txtState.TabIndex = 13;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(149, 127);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(260, 22);
            this.txtAddress3.TabIndex = 12;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(149, 86);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(260, 22);
            this.txtAddress2.TabIndex = 11;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(149, 49);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(260, 22);
            this.txtAddress1.TabIndex = 3;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(149, 11);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(260, 24);
            this.cmbCustomerName.TabIndex = 10;
            this.cmbCustomerName.SelectedValueChanged += new System.EventHandler(this.cmbCustomerName_SelectedValueChanged);
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(19, 239);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(73, 17);
            this.lblPostCode.TabIndex = 9;
            this.lblPostCode.Text = "Post Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(19, 206);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(19, 170);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(54, 17);
            this.lblSuburb.TabIndex = 7;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Location = new System.Drawing.Point(19, 132);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(72, 17);
            this.lblAddress3.TabIndex = 6;
            this.lblAddress3.Text = "Address 3";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(19, 91);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(72, 17);
            this.lblAddress2.TabIndex = 5;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(19, 54);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(72, 17);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address 1";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(19, 18);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Location = new System.Drawing.Point(12, 12);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(142, 35);
            this.btnSaveOrder.TabIndex = 1;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemCode.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Description.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quntity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 70;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Tax";
            this.Tax.MinimumWidth = 6;
            this.Tax.Name = "Tax";
            this.Tax.Width = 70;
            // 
            // ExclAmount
            // 
            this.ExclAmount.HeaderText = "ExclAmount";
            this.ExclAmount.MinimumWidth = 6;
            this.ExclAmount.Name = "ExclAmount";
            this.ExclAmount.Width = 125;
            // 
            // TaxAmount
            // 
            this.TaxAmount.HeaderText = "TaxAmount";
            this.TaxAmount.MinimumWidth = 6;
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.Width = 125;
            // 
            // InclAmount
            // 
            this.InclAmount.HeaderText = "Incl Amount";
            this.InclAmount.MinimumWidth = 6;
            this.InclAmount.Name = "InclAmount";
            this.InclAmount.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // SalseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 693);
            this.Controls.Add(this.plSalseOrder);
            this.MinimizeBox = false;
            this.Name = "SalseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salse Order";
            this.Load += new System.EventHandler(this.SalseOrder_Load);
            this.plSalseOrder.ResumeLayout(false);
            this.plSalseOrder.PerformLayout();
            this.plSelseDetails.ResumeLayout(false);
            this.plSelseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plSalseOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Panel plSelseDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtSubrb;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtRefNumber;
        private System.Windows.Forms.Label lblRefNo;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.TextBox txtTotalIncl;
        private System.Windows.Forms.TextBox txtTotalExcl;
        private System.Windows.Forms.Label liblTotalIncl;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTotalExcl;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExclAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InclAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

