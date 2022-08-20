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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listGame_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void listStudioGame_Click(object sender, EventArgs e)
        {
            GameStudioForm gamestudioForm = new GameStudioForm();
            gamestudioForm.Show();
        }

        private void listCategoryGame_Click(object sender, EventArgs e)
        {
            CategoryGameForm categorygameForm = new CategoryGameForm();
            categorygameForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
