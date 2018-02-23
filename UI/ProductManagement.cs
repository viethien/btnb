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
    public partial class ProductManagement : Form
    {
        private int selectedRow;
        private IProductService productService = new ProductService();
        private ICategoryService categoryService = new CategoryService();
        private ISupplierService supplierService = new SupplierService();
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadListProduct(productService.GetAll());
            LoadListCategory();
            LoadListSupplier();
        }

        void LoadListProduct(List<Product> list)
        {
            List<Category> listCate = new List<Category>();
            List<Supplier> listSup = new List<Supplier>();
            listCate = categoryService.GetAll();
            listSup = supplierService.GetAll();
            foreach (var item in list)
            {
                Category cate = listCate.FirstOrDefault(c => c.CategoryID == item.CategoryID);
                Supplier supplier = listSup.FirstOrDefault(s => s.SupplierID == item.SupplierID);
                item.Supplier = supplier;
                item.Category = cate;
            }
            foreach (var item in list)
            {
                dtList.Rows.Add(item.ProductID, item.ProductName, item.Category.CategoryName, item.Supplier.CompanyName, item.QuantityPerUnit, item.UnitPrice, item.UnitsInStock, item.UnitsOnOrder, item.ReorderLevel, item.Discontinued);
            }
        }
        void LoadListCategory()
        {
            List<Category> listCate = new List<Category>();
            listCate = categoryService.GetAll();
            cbCate.DataSource = listCate;
            cbCate.DisplayMember = "CategoryName";
            cbCate.ValueMember = "CategoryID";
        }
        void LoadListSupplier()
        {
            List<Supplier> listSupplier = new List<Supplier>();
            listSupplier = supplierService.GetAll();
            cbSupplier.DataSource = listSupplier;
            cbSupplier.DisplayMember = "CompanyName";
            cbSupplier.ValueMember = "SupplierID";
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
        void AddProduct()
        {
            string name = txtName.Text;
            string qpu = txtQPU.Text;
            var supplierId = cbSupplier.SelectedValue;
            var cateId = cbCate.SelectedValue;
            decimal price = numPrice.Value;
            int uis = (int)numUIS.Value;
            int uoo = (int)numUOO.Value;
            int level = (int)numROL.Value;
            bool dis = true;
            if (rdContinued.Checked)
            {
                dis = false;
            }
            if (CheckEmpty(name, qpu))
            {
                Product product = new Product()
                {
                    ProductName = name,
                    CategoryID = (int)cateId,
                    SupplierID = (int)supplierId,
                    QuantityPerUnit = qpu,
                    UnitPrice = price,
                    UnitsInStock = uis,
                    UnitsOnOrder = uoo,
                    ReorderLevel = level,
                    Discontinued = dis
                };
                try
                {
                    productService.Add(product);
                    LoadListProduct(productService.GetAll());
                    Clear();
                    MessageBox.Show("Saved Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong!. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        void Clear()
        {
            txtName.Text = string.Empty;
            txtQPU.Text = string.Empty;
            numPrice.Value = 0;
            numROL.Value = 0;
            numUIS.Value = 0;
            numUOO.Value = 0;
        }
        bool CheckEmpty(string name, string qpu)
        {
            int i = 0;
            if (string.IsNullOrEmpty(name))
            {
                epName.SetError(txtName, "Error");
                i--;
            }
            else
            {
                epName.Clear();
            }
            if (string.IsNullOrEmpty(qpu))
            {
                epQpu.SetError(txtQPU, "Error");
                i--;
            }
            else
            {
                epQpu.Clear();
            }
            return i == 0;
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = e.RowIndex;
                btnUpdate.Enabled = true;
                lbId.Text = dtList.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = (string)dtList.Rows[e.RowIndex].Cells[1].Value;
                var category = (string)dtList.Rows[e.RowIndex].Cells[2].Value;
                var sup = (string)dtList.Rows[e.RowIndex].Cells[3].Value;
                txtQPU.Text = (string)dtList.Rows[e.RowIndex].Cells[4].Value;
                numPrice.Value = (decimal)dtList.Rows[e.RowIndex].Cells[5].Value;
                numUIS.Value = (int)dtList.Rows[e.RowIndex].Cells[6].Value;
                numUOO.Value = (int)dtList.Rows[e.RowIndex].Cells[7].Value;
                numROL.Value = (int)dtList.Rows[e.RowIndex].Cells[8].Value;
                bool dis = (bool)dtList.Rows[e.RowIndex].Cells[9].Value;
                if (dis)
                {
                    rdDiscontinued.Select();
                }
                else
                {
                    rdContinued.Select();
                }
                cbCate.SelectedIndex = cbCate.FindStringExact(category);
                cbSupplier.SelectedIndex = cbSupplier.FindStringExact(sup);
                btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnNewCate_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
        }

        private void ProductManagement_Activated(object sender, EventArgs e)
        {
            LoadListProduct(productService.GetAll());
            LoadListCategory();
            LoadListSupplier();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbId.Text);
            string name = txtName.Text;
            string qpu = txtQPU.Text;
            var supplierId = cbSupplier.SelectedValue;
            var cateId = cbCate.SelectedValue;
            decimal price = numPrice.Value;
            int uis = (int)numUIS.Value;
            int uoo = (int)numUOO.Value;
            int level = (int)numROL.Value;
            bool dis = true;
            if (rdContinued.Checked)
            {
                dis = false;
            }
            if (CheckEmpty(name, qpu))
            {
                Product product = new Product()
                {
                    ProductID = id,
                    ProductName = name,
                    CategoryID = (int)cateId,
                    SupplierID = (int)supplierId,
                    QuantityPerUnit = qpu,
                    UnitPrice = price,
                    UnitsInStock = uis,
                    UnitsOnOrder = uoo,
                    ReorderLevel = level,
                    Discontinued = dis
                };
                try
                {
                    productService.Update(product);
                    DataGridViewRow viewRow = dtList.Rows[selectedRow];
                    viewRow.Cells[1].Value = product.ProductName;
                    viewRow.Cells[0].Value = product.ProductID;
                    Category cate = cbCate.SelectedItem as Category;
                    Supplier supplier = cbSupplier.SelectedItem as Supplier;
                    viewRow.Cells[2].Value = cate.CategoryName;
                    viewRow.Cells[3].Value =supplier.CompanyName;
                    viewRow.Cells[4].Value = qpu;
                    viewRow.Cells[5].Value = price;
                    viewRow.Cells[6].Value = uis;
                    viewRow.Cells[7].Value = uoo;
                    viewRow.Cells[8].Value = level;
                    viewRow.Cells[9].Value = dis;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong!. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {    
                DataGridViewRow viewRow = dtList.Rows[selectedRow];
                int id = (int)viewRow.Cells[0].Value;
                productService.Delete(id);
                LoadListProduct(productService.GetAll());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                epSearch.SetError(txtSearch, "error");
                LoadListProduct(productService.GetAll());
            }
            else
            {
                string word = txtSearch.Text;
                List<Product> listSearch= productService.GetAll().Where(p => p.ProductName.ToUpper().Contains(word.ToUpper()) == true).ToList();
                if (listSearch != null) {
                    dtList.Rows.Clear();
                    LoadListProduct(listSearch);
                }
                else
                {
                    dtList.Rows.Clear();
                }
                
            }
        }
    }
}
