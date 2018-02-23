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
    public partial class AddCategory : Form
    {
        private ICategoryService categoryService = new CategoryService();
        public AddCategory()
        {
            InitializeComponent();
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                epName.SetError(txtName, "Name error");
            }
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
                string descrip = txtDescription.Text;
                Category category = new Category()
                {
                    CategoryName = name,
                    Description = descrip
                };
                categoryService.Add(category);
                this.Close();
            }
        }
    }

}
