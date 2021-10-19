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
        }

        private void TeamsList()
        {
            dgvTeams.Rows.Clear();

            foreach (var item in db.Teams)
            {
                dgvTeams.Rows.Add(item.Id, item.TeamName);
            }
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTeams.CurrentRow.Cells[0].Value;
            var delete = db.Teams.Where(x => x.Id == id).FirstOrDefault();

            if (dgvTeams.Rows.Count > -1 )
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
            dgvColors.Rows.Clear();

            foreach (var item in db.Colors)
            {
                dgvColors.Rows.Add(item.ColorName);
            }
        }

        private void lblColors1_MouseClick(object sender, MouseEventArgs e)
        {
            lblColors1.BackColor = System.Drawing.Color.White;
            int id = (int)dgvColors.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (lblColors1.BackColor == System.Drawing.Color.White)
                {
                    if (id == item.Id)
                    {
                        lblColors1.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Blue, item.Green);
                    }
                }
            }
        }

        private void lblColors2_Click(object sender, EventArgs e)
        {
            lblColors2.BackColor = System.Drawing.Color.White;
            int id = (int)dgvColors.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (lblColors2.BackColor == System.Drawing.Color.White)
                {
                    if (id == item.Id)
                    {
                        lblColors2.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Blue, item.Green);
                    }
                }
            }
        } 
    }
}
