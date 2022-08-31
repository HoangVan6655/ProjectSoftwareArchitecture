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
    public partial class GameForm : Form
    {
        const String URL = "tcp://127.0.0.1:6789/Game";
        IGameBUS gameBUS = (IGameBUS)Activator.GetObject(typeof(IGameBUS), URL);
        ICategoryBUS categoryBUS = (ICategoryBUS)Activator.GetObject(typeof(ICategoryBUS), URL);
        IStudioBUS studioBUS = (IStudioBUS)Activator.GetObject(typeof(IStudioBUS), URL);
        private BindingSource bs = new BindingSource();
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            List<Game> games = gameBUS.GetAll();
            dgvGame.DataSource = games;
            cbxCategory.DataSource = gameBUS.getAllCategory().Tables[0];
            cbxCategory.DisplayMember = "CategoryGameName";
            cbxCategory.ValueMember = "CategoryGameID";


            cbxStudio.DataSource = gameBUS.getAllStudio().Tables[0];
            cbxStudio.DisplayMember = "StudioName";
            cbxStudio.ValueMember = "StudioID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Game> games = gameBUS.Search(keyword);
            dgvGame.DataSource = games;
        }

        private void dgvGame_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGame.SelectedRows.Count > 0)
            {
                int code = int.Parse(dgvGame.SelectedRows[0].Cells["GameID"].Value.ToString());
                Game game = gameBUS.GetDetails(code);
                if (game != null)
                {
                    txtID.Text = game.GameID.ToString();
                    txtName.Text = game.GameName;
                    cbxCategory.SelectedValue = game.CategoryID;
                    cbxStudio.SelectedValue = game.StudioID;
                    txtPrice.Text = game.GamePrice.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Game newGame = new Game()
            {
                GameID = 0,
                GameName = txtName.Text.Trim(),
                CategoryID = int.Parse(cbxCategory.SelectedValue.ToString()),
                StudioID = int.Parse(cbxStudio.SelectedValue.ToString()),
                GamePrice = int.Parse(txtPrice.Text.Trim()),
            };
            bool result = gameBUS.AddNew(newGame);
            if (result)
            {
                List<Game> games = gameBUS.GetAll();
                dgvGame.DataSource = games;
            }
            else
            {
                MessageBox.Show("SORRY BABY :<<< !!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Game newGame = new Game()
            {
                GameID = int.Parse(txtID.Text.Trim()),
                GameName = txtName.Text.Trim(),
                CategoryID = int.Parse(cbxCategory.SelectedValue.ToString()),
                StudioID = int.Parse(cbxStudio.SelectedValue.ToString()),
                GamePrice = int.Parse(txtPrice.Text.Trim()),
            };
            bool result = gameBUS.Update(newGame);
            if (result)
            {
                List<Game> games = gameBUS.GetAll();
                dgvGame.DataSource = games;
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
                bool result = gameBUS.Delete(id);
                if (result)
                {
                    List<Game> games = gameBUS.GetAll();
                    dgvGame.DataSource = games;
                }
                else
                {
                    MessageBox.Show("SORRY BABY :<<<<< !!!");
                }
            }
        }
    }
}
