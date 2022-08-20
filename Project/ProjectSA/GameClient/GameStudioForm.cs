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
    public partial class GameStudioForm : Form
    {
        public GameStudioForm()
        {
            InitializeComponent();
        }

        private void GameStudioForm_Load(object sender, EventArgs e)
        {
            List<Studio> studios = new StudioBUS().GetAll();
            dgvStudio.DataSource = studios;
        }

        private void dgvStudio_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudio.SelectedRows.Count > 0)
            {
                int code = int.Parse(dgvStudio.SelectedRows[0].Cells["StudioID"].Value.ToString());
                Studio studio = new StudioBUS().GetDetails(code);
                if (studio != null)
                {
                    txtID.Text = studio.StudioID.ToString();
                    txtName.Text = studio.StudioName;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Studio> studios = new StudioBUS().Search(keyword);
            dgvStudio.DataSource = studios;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Studio newStudio = new Studio()
            {
                StudioID = 0,
                StudioName = txtName.Text.Trim(),
            };
            bool result = new StudioBUS().AddNew(newStudio);
            if (result)
            {
                List<Studio> studios = new StudioBUS().GetAll();
                dgvStudio.DataSource = studios;
            }
            else
            {
                MessageBox.Show("SORRY BABY :<<< !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Studio newStudio = new Studio()
            {
                StudioID = int.Parse(txtID.Text.Trim()),
                StudioName = txtName.Text.Trim(),
            };
            bool result = new StudioBUS().Update(newStudio);
            if (result)
            {
                List<Studio> studios = new StudioBUS().GetAll();
                dgvStudio.DataSource = studios;
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
                bool result = new StudioBUS().Delete(id);
                if (result)
                {
                    List<Studio> studios = new StudioBUS().GetAll();
                    dgvStudio.DataSource = studios;
                }
                else
                {
                    MessageBox.Show("SORRY BABY :<<<<< !!!");
                }
            }
        }
    }
}
