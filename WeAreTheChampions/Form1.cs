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
            dgvScore.AutoGenerateColumns = false;
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
            var frmNewMatch = new New_Match(db, new NewUpdateMatchModel { States = States.Add });
            frmNewMatch.ShowDialog();
            TeamsList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TeamsList();
        }

        private void TeamsList()
        {
            dgvScore.DataSource = db.Matches.ToList();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvScore.SelectedRows.Count != 1)
                return;

            int id = ((WeAreTheChampionsData.Match)dgvScore.SelectedRows[0].DataBoundItem).Id;
            var delete = db.Matches.Where(x => x.Id == id).FirstOrDefault();

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Seçilen Veri Silinsin Mi?", "Emin Misiniz.", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                db.Matches.Remove(delete);
                db.SaveChanges();
            }
            TeamsList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvScore.SelectedRows.Count != 1)
            {
                MessageBox.Show("Maç Seçiniz!!");
                return;
            }

            var id = ((WeAreTheChampionsData.Match)dgvScore.SelectedRows[0].DataBoundItem).Id;

            var frmUpdateMatch = new New_Match(db, new NewUpdateMatchModel { States = States.Update , MatchId = id});
            frmUpdateMatch.ShowDialog();
            TeamsList();
        }

        private void chkDisableMatches_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisableMatches.Checked)
            {
                dgvScore.DataSource = db.Matches.Where(x => x.Score1 == null).ToList();
                return;
            }
            TeamsList();
        }
    }
}
