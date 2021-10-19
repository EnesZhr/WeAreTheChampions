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
    public partial class Form1 : Form
    {
        WeAreTheChamphionsDbContext db = new WeAreTheChamphionsDbContext();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            var frmTeams = new Teams(db);
            frmTeams.ShowDialog();
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            var frmColors = new Colors(db);
            frmColors.ShowDialog();
        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            var frmPlayer = new Players(db);
            frmPlayer.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmNewMatch = new New_Match(db);
            frmNewMatch.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TeamsList();
        }

        private void TeamsList()
        {
            dgvScore.Rows.Clear();

            foreach (var item in db.Matches)
            {
                dgvScore.Rows.Add(item.Id, item.HomeTeam, item.AwayTeam, item.MatchTime, item.Score1, item.Score2, item.Result);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvScore.CurrentRow.Cells[0].Value;
            var delete = db.Matches.Where(x => x.Id == id).FirstOrDefault();

            if (dgvScore.Rows.Count > -1)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Seçilen Veri Silinsin Mi?", "Emin Misiniz.", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.Matches.Remove(delete);
                    db.SaveChanges();
                }
            }

            TeamsList();
        }
    }
}
