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
    public partial class New_Match : Form
    {
        WeAreTheChamphionsDbContext db;
        List<Team> allTeams;
        NewUpdateMatchModel statesModel;
        Match matchUpdate;
        public New_Match(WeAreTheChamphionsDbContext db, NewUpdateMatchModel statesModel)
        {
            this.statesModel = statesModel;
            this.db = db;
            InitializeComponent();
            LoadAllData();

        }

        private void LoadAllData()
        {
           
            StateControl();

        }
        private void StateControl()
        {
             GetTeams();
            if (statesModel.States == States.Add)
            {
                btnMatchAdd.Text = "Match Add";
                nudHomeTeamScore.Visible = false;
                nudAwayTeamScore.Visible = false;
                label2.Visible = false;
           
                ListHomeTeams();
                ListAwayTeams();
            }
            else if (statesModel.States == States.Update)
            {
                cboHomeTeams.DataSource = allTeams;
                cboAwayTeams.DataSource = allTeams;
                
                btnMatchAdd.Text = "Update";
                nudHomeTeamScore.Visible = true;
                nudAwayTeamScore.Visible = true;
                label2.Visible = true;
                cboHomeTeams.Enabled = false;
                cboAwayTeams.Enabled = false;
                dtpDate.Enabled = false;
                GetMatch();
                cboHomeTeams.SelectedValue = matchUpdate.HomeTeamId;
                cboAwayTeams.SelectedValue = matchUpdate.AwayTeamId;
                dtpDate.Value = (DateTime)matchUpdate.MatchTime;


            }

        }
        private void GetMatch()
        {
            if (statesModel.States != States.Update || (statesModel.MatchId < 1 || statesModel.MatchId == null))
            {
                MessageBox.Show("Bir hata oluştu tekrar deneyiniz.!");
                Close();
                return;
            }

            matchUpdate = db.Matches.Where(x => x.Id == statesModel.MatchId).FirstOrDefault();

        }
        /// <summary>
        /// Gets all teams
        /// </summary>
        private void GetTeams()
        {
            allTeams = db.Teams.ToList();
        }

        private void ListHomeTeams()
        {
            cboHomeTeams.DataSource = allTeams;
        }

        private void ListAwayTeams()
        {
            cboAwayTeams.DataSource = allTeams.Where(x => x.Id != (int)cboHomeTeams.SelectedValue).ToList();
        }

        private void cboHomeTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAwayTeams();
        }

        private void btnMatchAdd_Click(object sender, EventArgs e)
        {
            if (statesModel.States == States.Add)
            {
                AddMatch();
            }
            else if(statesModel.States == States.Update)
            {
                UpdateMatch();
            }
            Close();
            
        }
        private void AddMatch()
        {
            var match = new Match()
            {
                HomeTeamId = (int)cboHomeTeams.SelectedValue,
                AwayTeamId = (int)cboAwayTeams.SelectedValue,
                MatchTime = dtpDate.Value
            };
            db.Matches.Add(match);
            db.SaveChanges();
            MessageBox.Show("Maç Eklendi","Yeni Maç Ekle",MessageBoxButtons.OK,MessageBoxIcon.Information );
        }
        
        private void UpdateMatch ()
        {
            matchUpdate.Score1 = (int)nudHomeTeamScore.Value;
            matchUpdate.Score2 = (int)nudAwayTeamScore.Value;
            matchUpdate.Result = matchUpdate.Score1 > matchUpdate.Score2 ? Result.Team1Win : (matchUpdate.Score1 < matchUpdate.Score2 ? Result.Team2Win : Result.Draw);
            db.SaveChanges();
            
        }
    }
}
