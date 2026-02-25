using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWideSports
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoginCreate_Click(object sender, EventArgs e)
        {
            if (btnLoginCreate.Text == "Logout")
            {
                //this will log the user out by hiding the group boxes and resetting the account label and changing the button text back to login
                gbxNfl.Visible = false;
                gbxPga.Visible = false;
                lblAccount.Text = "";
                lblAccount.Visible = false;
                btnLoginCreate.Text = "Login/Create Account";
                MessageBox.Show("You have been logged out.");
                return;
            }
            //this takes the user to the login form where they can either log in or create an account
            LoginForm loginForm = new LoginForm();
            //this will make the main form the owner of the login form
            loginForm.Owner = this;
            loginForm.Show();
            //this will hide the main form while the login form is open
            this.Hide();
        }
        public void ShowGroupBoxes()
        {
            //show the group boxes to save the favorite teams and players only when the user logs in successfully
            gbxNfl.Visible = true;
            gbxPga.Visible = true;
        }

        private void btnSaveFavTeam_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePga_Click(object sender, EventArgs e)
        {

        }

        private void btnViewNfl_Click(object sender, EventArgs e)
        {

        }

        private void btnViewPga_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //loads the NFL player stats into the DataSet
            this.nfL_PLAYER_STATSTableAdapter.Fill(this.worldWideSportsDBDataSet.NFL_PLAYER_STATS);

            // Pulls the nfl teams from the NFL_PLAYER_STATS table, and orders them alphabetically, and removes duplicates, and converts it to a list for the combo box
            var nflTeams = this.worldWideSportsDBDataSet.NFL_PLAYER_STATS
                .Select("", "team")
                .Select(r => r["team"].ToString())
                .Distinct()
                .OrderBy(t => t)
                .ToList()
                //this will replace the team abbreviations with the full team names in the combo box
                .Select(abbr => nflTeamNames.ContainsKey(abbr) ? nflTeamNames[abbr] : abbr)
                .OrderBy(t => t)
                .ToList();


            // this binds the nfl teams to the combo box
            cbxNflTeams.DataSource = nflTeams;

            // load all PGA players into the DataSet
            this.pgA_PlayersTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_Players);

            // this binds PGA players to the combo box
            cbxPga.DataSource = this.worldWideSportsDBDataSet.PGA_Players;
            cbxPga.DisplayMember = "PlayerName";
            cbxPga.ValueMember = "PlayerId";
        }

        //this is the dictionary that will be used to replace the team abbreviations with the full team names in the combo box
        private Dictionary<string, string> nflTeamNames = new Dictionary<string, string>
        {
            {"ARI", "Arizona Cardinals"},
            {"ATL", "Atlanta Falcons"},
            {"BAL", "Baltimore Ravens"},
            {"BUF", "Buffalo Bills"},
            {"CAR", "Carolina Panthers"},
            {"CHI", "Chicago Bears"},
            {"CIN", "Cincinnati Bengals"},
            {"CLE", "Cleveland Browns"},
            {"DAL", "Dallas Cowboys"},
            {"DEN", "Denver Broncos"},
            {"DET", "Detroit Lions"},
            {"GB",  "Green Bay Packers"},
            {"HOU", "Houston Texans"},
            {"IND", "Indianapolis Colts"},
            {"JAX", "Jacksonville Jaguars"},
            {"KC",  "Kansas City Chiefs"},
            {"LA",  "Los Angeles Rams"},
            {"LAC", "Los Angeles Chargers"},
            {"LV",  "Las Vegas Raiders"},
            {"MIA", "Miami Dolphins"},
            {"MIN", "Minnesota Vikings"},
            {"NE",  "New England Patriots"},
            {"NO",  "New Orleans Saints"},
            {"NYG", "New York Giants"},
            {"NYJ", "New York Jets"},
            {"PHI", "Philadelphia Eagles"},
            {"PIT", "Pittsburgh Steelers"},
            {"SEA", "Seattle Seahawks"},
            {"SF",  "San Francisco 49ers"},
            {"TB",  "Tampa Bay Buccaneers"},
            {"TEN", "Tennessee Titans"},
            {"WAS", "Washington Commanders"}
        };

        public void SetAccount(string username)
        {
            //this will get the username from the login form and display it on the main form, and change the login button to a logout button
            lblAccount.Text = "Account: " + username;
            lblAccount.Visible = true;
            btnLoginCreate.Text = "Logout";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using World Wide Sports! Goodbye!");
            this.Close();
        }
    }
}
