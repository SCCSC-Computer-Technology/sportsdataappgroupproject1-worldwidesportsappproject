using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldWideSports.WorldWideSportsDBDataSetTableAdapters;
using static WorldWideSports.WorldWideSportsDBDataSet;

namespace WorldWideSports
{
    public partial class PGADetailedForm : Form
    {
        public PGADetailedForm()
        {
            InitializeComponent();
        }

        private void PGADetailedForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS' table. You can move, or remove it, as needed.
            this.pGA_ALL_TOURNAMENTSTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.PGA_PLAYER_STATS' table. You can move, or remove it, as needed.
            this.pGA_PLAYER_STATSTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_PLAYER_STATS);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.PGA_Players' table. You can move, or remove it, as needed.
            this.pGA_PlayersTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_Players);
            
            //this fills the combo box with pga player names
            cmbBoxPlayers.DataSource = worldWideSportsDBDataSet.PGA_PLAYER_STATS;
            cmbBoxPlayers.DisplayMember = "player_name";
            cmbBoxPlayers.Text = "Select Player";
            rchTxtBoxStats.Clear();
            rchTxtBoxTournament.Clear();
        }

        private void pGA_PlayersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pGA_PlayersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldWideSportsDBDataSet);

        }


        private void cmbBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Makes sure to clear TxtBox before outputing the players stats
            //rchTxtBoxStats.Clear();
            rchTxtBoxTournament.Clear();
            //Creates a PGAPlayer stats variable :D
            PGAPlayerStats stats = new PGAPlayerStats();
            PGATournament tournament = new PGATournament();
            //Makes sure something is selected and that its not the starter Message 
            if (cmbBoxPlayers.SelectedIndex != -1 && cmbBoxPlayers.SelectedItem != "Select Player")
            {
                //Looks at datagrid view of the PGA player stats table and gets the info from it
                var row = (WorldWideSportsDBDataSet.PGA_PLAYER_STATSRow)
                ((DataRowView)cmbBoxPlayers.SelectedItem).Row;
                stats.PlayerName= row.player_name.ToString();
                stats.Season = row.season;
                stats.Wins = row.wins;
                stats.TopTenFinish = row.top10_finishes;
                stats.AverageScore = row.avg_score;
                stats.EventsPlayed = row.events_played;
                stats.TotalEarnings = row.total_earnings;
                stats.TotalFedXPoints = row.total_earnings;
                //Outputs the stats into txtBox
                rchTxtBoxStats.Text = stats.ToString();

                //This Sets up the Tournament info 
                foreach (WorldWideSportsDBDataSet.PGA_ALL_TOURNAMENTSRow row2 in worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS.Rows)
                {
                    if (row2.name.ToString() == cmbBoxPlayers.Text)
                    {
                        tournament.Season = row2.season;
                        tournament.Tournament = row2.tournament;
                        tournament.Location = row2.location;
                        tournament.Position = row2.position;
                        tournament.Score = row2.score;
                        //Checks if coloumn is null and gives it a zero
                        //COol stuff i found checks for nulls and puts a value 👍
                        tournament.Round1 = row2.Isround1Null() ? 0: row2.round1;
                        tournament.Round2 = row2.Isround2Null() ? 0 : row2.round2;
                        tournament.Round3 = row2.Isround3Null() ? 0 : row2.round3;
                        tournament.Round4 = row2.Isround4Null() ? 0 : row2.round4;
                        tournament.Total = row2.total;
                        tournament.Earnings = row2.IsearningsNull() ? 0 : row2.earnings;
                        tournament.FedXPoints = row2.Isfedex_pointsNull() ? 0 : row2.fedex_points;
                        rchTxtBoxTournament.AppendText(tournament.ToString() +"\n\n");

                    }
                }
                

            }
        }
    }
}
