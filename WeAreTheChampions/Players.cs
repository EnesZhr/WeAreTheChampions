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
    public partial class Players : Form
    {
        WeAreTheChamphionsDbContext db;
        public Players(WeAreTheChamphionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
            PlayerList();
            FormReset();
        }

        private void FormReset()
        {
            txtPlayerName.Clear();
            cboPlayerTeams.SelectedIndex = -1;
        }

        private void PlayerList()
        {
            dgvPlayer.Rows.Clear();

            foreach (var item in db.Players)
            {
                dgvPlayer.Rows.Add(item.PlayerName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();
            var team = cboPlayerTeams.SelectedIndex + 1;

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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectLine = dgvPlayer.CurrentRow.Cells[0].Value.ToString();
            var delete = db.Players.Where(x => x.PlayerName == selectLine).FirstOrDefault();
            db.Players.Remove(delete);
            db.SaveChanges();
            PlayerList();
            FormReset();
        }

        private void cboPlayerTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPlayerTeams.Items.Clear();
            foreach (var item in db.Teams)
            {
                cboPlayerTeams.Items.Add(item.TeamName);
            }
        }

        private void Players_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Teams)
            {
                cboPlayerTeams.Items.Add(item.TeamName);
                cboTeams.Items.Add(item.TeamName);
            }
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTeamsFilter.Rows.Clear();
            int id = 0;
            string teams = "";
            foreach (var item in db.Teams)
            {
                if (cboTeams.Text == item.TeamName)
                {
                    id = item.Id;
                    teams = item.TeamName;
                }
            }

            foreach (var item in db.Players)
            {
                if (id == item.TeamId)
                {
                    dgvTeamsFilter.Rows.Add(item.PlayerName);
                }
            }
        }
    }
}
