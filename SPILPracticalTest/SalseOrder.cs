using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPILPracticalTest
{
    public partial class SalseOrder : Form
    {
        private readonly Demo2016Entities _db;
        private bool isEdit =  false;
        private int editClientDetailsId;

        ClientDetail EditClientDetail = new ClientDetail();

        ComboBox editGridCellComboBox = new ComboBox();
        public SalseOrder()
        {
            InitializeComponent();
            _db = new Demo2016Entities();
        }

        public SalseOrder(ClientDetail clientDetail)
        {
            // Edit
            InitializeComponent();
            _db = new Demo2016Entities();
            isEdit = true;
            EditClientDetail = clientDetail;
            editClientDetailsId = clientDetail.Id;
        }

        private void SalseOrder_Load(object sender, EventArgs e)
        {
            selectClinetData();
            loadItemCode();
            if (isEdit)
                getAllDataFromId(EditClientDetail);
        }
        private void selectClinetData()
        {
            var client = _db.Clients.ToList();
            cmbCustomerName.DisplayMember = "Name";
            cmbCustomerName.ValueMember = "DCLink";
            cmbCustomerName.DataSource = client;
        }
        private void loadItemCode()
        {
            var items = _db.StkItems.ToList();
            this.ItemCode.DisplayMember = "Code";
            this.ItemCode.ValueMember = "StockLink";
            this.ItemCode.DataSource = items;

            this.Description.DisplayMember = "Description_1";
            this.Description.ValueMember = "StockLink";
            this.Description.DataSource = items;
        }     

        private void getAllDataFromId(ClientDetail EditClientDetail)
        {            
            selectCustomerCombo((int)EditClientDetail.ClientId);

            dtInvoiceDate.Text = EditClientDetail.InvoiceDate.ToString();
            txtInvoiceNo.Text = EditClientDetail.InvoiceNo.ToString();
            txtNote.Text = EditClientDetail.ToString();
            txtRefNumber.Text = EditClientDetail.Note.ToString();
            txtTotalExcl.Text = EditClientDetail.TotalExclAmount.ToString();
            txtTotalIncl.Text = EditClientDetail.TotalInclAmount.ToString();
            txtTotalTax.Text = EditClientDetail.TotalTaxAmount.ToString();

            var salseDetail = _db.SalseDetails
                .Where(a => a.ClientDetailId == EditClientDetail.Id).OrderByDescending(a => a.Id).ToList();
           
            dgvSales.DataSource = salseDetail;

        }
        
        private void selectCustomerCombo(int value)
        {           
            var clients = _db.Clients.Where(a => a.DCLink == value).FirstOrDefault();
            txtAddress1.Text = clients.Physical1;
            txtAddress2.Text = clients.Physical2;
            txtAddress3.Text = clients.Physical3;
            txtSubrb.Text = clients.Physical4;
            txtState.Text = clients.Physical5;
            txtPostCode.Text = clients.PhysicalPC;
            cmbCustomerName.Text = clients.Name;
        }
        private void cmbCustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedValue != null)
            {
                selectCustomerCombo(Convert.ToInt32(cmbCustomerName.SelectedValue));
            }
            // var tt = cmbCustomerName.SelectedValue.ToString();
        }        

        public void saveClientDetails(int index)
        {
            if (isEdit)
            {
                var clientDetails = _db.ClientDetails.FirstOrDefault(a => a.Id == editClientDetailsId);

                clientDetails.InvoiceDate = dtInvoiceDate.Value;
                clientDetails.InvoiceNo = txtInvoiceNo.Text;
                clientDetails.Note = txtNote.Text;
                clientDetails.RefNo = txtRefNumber.Text;
                clientDetails.TotalExclAmount = Convert.ToDecimal(txtTotalExcl.Text);
                clientDetails.TotalInclAmount = Convert.ToDecimal(txtTotalIncl.Text);
                clientDetails.TotalTaxAmount = Convert.ToDecimal(txtTotalTax.Text);
                clientDetails.ClientId = (int)cmbCustomerName.SelectedValue;

                _db.SaveChanges();
            }
            else
            {
                var clientDetails = new ClientDetail
                {
                    Id = index,
                    InvoiceDate = dtInvoiceDate.Value,
                    InvoiceNo = txtInvoiceNo.Text,
                    Note = txtNote.Text,
                    RefNo = txtRefNumber.Text,
                    TotalExclAmount = Convert.ToDecimal(txtTotalExcl.Text),
                    TotalInclAmount = Convert.ToDecimal(txtTotalIncl.Text),
                    TotalTaxAmount = Convert.ToDecimal(txtTotalTax.Text),
                    ClientId = (int)cmbCustomerName.SelectedValue
                };
                _db.ClientDetails.Add(clientDetails);
                _db.SaveChanges();
            }
              
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {         

            var client = _db.ClientDetails.OrderByDescending(c => c.Id).FirstOrDefault();
            int index = 0;
            // save data to Client Detais Table
            if (client != null)
            {
                index = client.Id + 1;
                saveClientDetails(index);            
            }
            else
            {
                index = index++;
                saveClientDetails(index);
            }
            if (isEdit)
            {

            }
            else
            {
                // save data to Client Detais Table
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    int StockLink = Convert.ToInt32(row.Cells["ItemCode"].Value.ToString());
                    var items = _db.StkItems.Where(a => a.StockLink == StockLink).FirstOrDefault();
                    var salesItemDetails = new SalseDetail();


                    salesItemDetails.StkItemId = (int)row.Cells["ItemCode"].Value;
                    salesItemDetails.Note1 = row.Cells["Note"].Value.ToString();
                    salesItemDetails.ClientDetailId = index;
                    salesItemDetails.Qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    salesItemDetails.tax = Convert.ToDecimal(row.Cells["Tax"].Value);
                    salesItemDetails.TaxAmount = Convert.ToDecimal(row.Cells["TaxAmount"].Value);
                    salesItemDetails.InclAmount = Convert.ToDecimal(row.Cells["InclAmount"].Value);
                    salesItemDetails.ExclAmount = Convert.ToDecimal(row.Cells["ExclAmount"].Value);
                    salesItemDetails.Price = Convert.ToDecimal(row.Cells["Price"].Value);

                    _db.SalseDetails.Add(salesItemDetails);
                    _db.SaveChanges();
                }
            }
           
            
        }

        private void dgvSales_Click(object sender, EventArgs e)
        {
           
        }


        private void dgvSales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int colIndex;
            int rowIndex;
            var txtBox = e.Control as TextBox;
            var cmb = e.Control as ComboBox;
            colIndex = dgvSales.CurrentCell.ColumnIndex;
            rowIndex = dgvSales.CurrentCell.RowIndex;
            if (e.Control is TextBox)
            {
                if (txtBox != null)
                {

                    txtBox.CharacterCasing = CharacterCasing.Upper;
                    txtBox.TextChanged += new EventHandler(ItemTxtBox_TextChanged);
                    txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;                 
                }
            }
            else if(e.Control is ComboBox)
            {               
                //cmb.TextChanged += new EventHandler(ItemcmBox_cmbChanged);
                //cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
                //cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;                
            }

            

        }

        void ItemTxtBox_TextChanged(object sender, EventArgs e)
        {
            //if ((sender as TextBox).Text != null && (sender as TextBox).Text.Trim() != "")
            //{
            //    MessageBox.Show((sender as TextBox).Text);
            //}
        }

        double TotalTaxAmount;
        double TotalInclAmount;
        double totalExclAmount;

        private void dgvSales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex;
            int rowIndex;           
            colIndex = dgvSales.CurrentCell.ColumnIndex;
            rowIndex = dgvSales.CurrentCell.RowIndex;

            if (colIndex >= 5)
            {
                double TaxAmount;
                double InclAmount;
                double ExclAmount;                

                double qty = Convert.ToDouble(dgvSales.Rows[e.RowIndex].Cells[3].Value);
                double price = Convert.ToDouble(dgvSales.Rows[e.RowIndex].Cells[4].Value);
                double tax = Convert.ToDouble(dgvSales.Rows[e.RowIndex].Cells[5].Value);
                ExclAmount = qty * price;
                TaxAmount = ExclAmount * tax / 100;
                InclAmount = ExclAmount + TaxAmount;

                dgvSales.Rows[e.RowIndex].Cells[6].Value = ExclAmount;
                dgvSales.Rows[e.RowIndex].Cells[7].Value = TaxAmount;
                dgvSales.Rows[e.RowIndex].Cells[8].Value = InclAmount;

                totalExclAmount = totalExclAmount + ExclAmount;
                TotalTaxAmount = TotalTaxAmount + TaxAmount;
                TotalInclAmount = TotalInclAmount + InclAmount;

                txtTotalExcl.Text = totalExclAmount.ToString();
                txtTotalTax.Text = TotalTaxAmount.ToString();
                txtTotalIncl.Text = TotalInclAmount.ToString();

            }
        }
    }
}
