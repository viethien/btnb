using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddSupplier : Form
    {
        private ISupplierService supplierService = new SupplierService();
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                epName.SetError(txtName, "Name error");
            }
            else
            {
                string name = txtName.Text;
                Supplier supplier = new Supplier()
                {
                    CompanyName = name,
                };
                supplierService.Add(supplier);
                this.Close();
            }
        }
    }

}
