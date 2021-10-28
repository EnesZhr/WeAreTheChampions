using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampionsData.Models;

namespace WeAreTheChampions
{
    public partial class Teams : Form
    {
        WeAreTheChamphionsDbContext db;


        public Teams(WeAreTheChamphionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
            TeamsList();
        }

        private void btnTeamAdd_Click(object sender, EventArgs e)
        {
            db.Teams.Add(new WeAreTheChampionsData.Team()
            {
                TeamName = txtTeamName.Text.Trim(),
            });
            db.SaveChanges();
            TeamsList();
            FormReset();
        }

        private void FormReset()
        {
            txtTeamName.Clear();
            lblColors1.BackColor = System.Drawing.Color.White;
            lblColors2.BackColor = System.Drawing.Color.White;
        }

        private void TeamsList()
        {
            dgvTeams.AutoGenerateColumns = false;
            dgvTeams.DataSource = db.Teams.ToList();
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count != 1)
                return;
            var id = ((WeAreTheChampionsData.Team)dgvTeams.SelectedRows[0].DataBoundItem).Id;
            var delete = db.Teams.Where(x => x.Id == id).FirstOrDefault();

            if (dgvTeams.Rows.Count > -1)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Seçilen Veri Silinsin Mi?", "Emin Misiniz.", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.Teams.Remove(delete);
                    db.SaveChanges();
                    TeamsList();
                }
            }
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            dgvColors.AutoGenerateColumns = false;
            List<WeAreTheChampionsData.Color> allColors = db.Colors.ToList();
            dgvColors.DataSource = allColors;

        }

        private void lblColors1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
                return;

            lblColors1.BackColor = System.Drawing.Color.White;
            var id = ((WeAreTheChampionsData.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;


            foreach (var item in db.Colors)
            {

                if (id == item.Id)
                {
                    lblColors1.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }

            }
        }

        private void lblColors2_Click(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
                return;

            lblColors2.BackColor = System.Drawing.Color.White;
            var id = ((WeAreTheChampionsData.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;

            foreach (var item in db.Colors)
            {

                if (id == item.Id)
                {
                    lblColors2.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }

            }
        }
    }
}
