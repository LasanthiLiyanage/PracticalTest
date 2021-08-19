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
    public partial class Home : Form
    {
        private readonly Demo2016Entities _db;
        public Home()
        {
            InitializeComponent();
            _db = new Demo2016Entities();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //this.Close();
            SalseOrder salseOrder = new SalseOrder();
            salseOrder.Show();
        }

        private void plHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadAllSalseDetails()
        {
            var saveSales = _db.ClientDetails.Join(_db.Clients,
                            a => a.ClientId, c => c.DCLink,
                            (a, c) => new
                            {
                                CustomerName = c.Name,
                                InvoiceNo = a.InvoiceNo,
                                InvoiceDate = a.InvoiceDate,
                                RefNo = a.RefNo,
                                TotalExclAmount = a.TotalExclAmount,
                                TotalInclAmount = a.TotalInclAmount,
                                TotalTaxAmount =  a.TotalTaxAmount,
                                Id = a.Id
                            }).ToList();            
            dgvHomeView.DataSource = saveSales;
            dgvHomeView.Columns[0].HeaderText = "Client Name";
            dgvHomeView.Columns[1].HeaderText = "Invoice No";
            dgvHomeView.Columns[2].HeaderText = "Invoice Date";
            dgvHomeView.Columns[3].HeaderText = "Ref No";
            dgvHomeView.Columns[4].HeaderText = "Total Excl";
            dgvHomeView.Columns[5].HeaderText = "Total Incl";
            dgvHomeView.Columns[6].HeaderText = "Total Tax";
            dgvHomeView.Columns[7].Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadAllSalseDetails();
        }

        private void dgvHomeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // get Id selected
            var id = (int)dgvHomeView.SelectedRows[0].Cells["Id"].Value;

            var clientD = _db.ClientDetails.Where(c => c.Id == id).FirstOrDefault();

            var salseOrder = new SalseOrder(clientD);
            salseOrder.ShowDialog();


        }
    }
}
