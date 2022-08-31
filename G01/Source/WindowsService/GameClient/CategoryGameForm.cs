using GameShared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClient
{
    public partial class CategoryGameForm : Form
    {
        const String URL = "tcp://127.0.0.1:6789/Category";
        ICategoryBUS categoryBUS = (ICategoryBUS)Activator.GetObject(typeof(ICategoryBUS), URL);
        public CategoryGameForm()
        {
            InitializeComponent();
        }

        private void CategoryGameForm_Load(object sender, EventArgs e)
        {
            List<Category> categorygames = categoryBUS.GetAll();
            dgvCategory.DataSource = categorygames;
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                int code = int.Parse(dgvCategory.SelectedRows[0].Cells["CategoryID"].Value.ToString());
                Category category = categoryBUS.GetDetails(code);
                if (category != null)
                {
                    txtID.Text = category.CategoryID.ToString();
                    txtName.Text = category.CategoryName;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Category> categories = categoryBUS.Search(keyword);
            dgvCategory.DataSource = categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category()
            {
                CategoryID = 0,
                CategoryName = txtName.Text.Trim(),

            };
            bool result = categoryBUS.AddNew(newCategory);
            if (result)
            {
                List<Category> categories = categoryBUS.GetAll();
                dgvCategory.DataSource = categories;
            }
            else
            {
                MessageBox.Show("SORRY BABY :<<< !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category()
            {
                CategoryID = int.Parse(txtID.Text.Trim()),
                CategoryName = txtName.Text.Trim(),
            };
            bool result = categoryBUS.Update(newCategory);
            if (result)
            {
                List<Category> categories = categoryBUS.GetAll();
                dgvCategory.DataSource = categories;
            }
            else
            {
                MessageBox.Show("Faild!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(txtID.Text.Trim());
                bool result = categoryBUS.Delete(id);
                if (result)
                {
                    List<Category> categories = categoryBUS.GetAll();
                    dgvCategory.DataSource = categories;
                }
                else
                {
                    MessageBox.Show("SORRY BABY :<<<<< !!!");
                }
            }
        }
    }
}
