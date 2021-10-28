using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampionsData;
using WeAreTheChampionsData.Models;

namespace WeAreTheChampions
{
    public partial class Players : Form
    {
        WeAreTheChamphionsDbContext db;
        public Players(WeAreTheChamphionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
            PropertySettings();
            PlayerList();
            FormReset();
        }

        private void PropertySettings()
        {
            dgvPlayer.AutoGenerateColumns = false;
            dgvTeamsFilter.AutoGenerateColumns = false;
        }

        private void FormReset()
        {
            txtPlayerName.Clear();
        }
         
        private void PlayerList()
        {
            dgvPlayer.DataSource = db.Players.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboPlayerTeams.SelectedIndex < 0)
                return;
            string playerName = txtPlayerName.Text.Trim();
            
            var team = ((WeAreTheChampionsData.Team)cboPlayerTeams.SelectedItem).Id;

            if(txtPlayerName.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

            db.Players.Add(new WeAreTheChampionsData.Player()
            {
                PlayerName = playerName,
               TeamId = team
            });

            db.SaveChanges();
            PlayerList();
            FormReset();
            ListFilterPlayers();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlayer.SelectedRows.Count != 1)
                return;
            var selectLine = ((WeAreTheChampionsData.Player)dgvPlayer.SelectedRows[0].DataBoundItem).Id;
            var delete = db.Players.Where(x => x.Id == selectLine).FirstOrDefault();
            db.Players.Remove(delete);
            db.SaveChanges();
            PlayerList();
            FormReset();
            ListFilterPlayers();
        }

        private void Players_Load(object sender, EventArgs e)
        {
            List<Team> teams = db.Teams.ToList();
            cboPlayerTeams.DataSource = db.Teams.ToList();
            ListFilterPlayers();
            
        }
        private void ListFilterPlayers ()
        {
            cboTeams.DataSource = db.Teams.ToList();
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTeams.SelectedIndex < 0)
                return;
            int teamId = (int)cboTeams.SelectedValue;
            var players = db.Players.Where(x => x.TeamId == teamId).ToList();
            dgvTeamsFilter.DataSource = players;
        }
    }
}
