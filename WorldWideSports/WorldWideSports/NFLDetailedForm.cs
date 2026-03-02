using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWideSports
{

    public partial class NFLDetailedForm : Form
    {
        //initialize variables with class
        DetailedNFlGames games = new DetailedNFlGames();
        NFLPlayers player = new NFLPlayers();
        //Password1!
        //Gets Dictionary from main form
        int user;
        public NFLDetailedForm(Dictionary<string, string> nflTeamNamesGet, int userID)
        {
            InitializeComponent();
            user = userID;
            ///Used main form dictionary to fill the combo box
            cmbBoxTeams.DataSource =new BindingSource(nflTeamNamesGet,null);
            //makes sure it displayes team name out and behind its the abreviation for ease of database use
            cmbBoxTeams.DisplayMember = "value";
            cmbBoxTeams.ValueMember = "key";
            //Sets it to nothing to start the cmbbox at select team
            cmbBoxTeams.SelectedIndex = -1;
            cmbBoxTeams.Text = "Select Team";

            

        }
        private void NFLDetailedForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.FavoriteNFLTeams' table. You can move, or remove it, as needed.
            this.favoriteNFLTeamsTableAdapter.Fill(this.worldWideSportsDBDataSet.FavoriteNFLTeams);
            // TODO: This line of code loads data into the 'worldWideSportsPlayersPlusDataSet.PlayerStats2024' table. You can move, or remove it, as needed.
            this.playerStats2024TableAdapter.Fill(this.worldWideSportsPlayersPlusDataSet.PlayerStats2024);
            // TODO: This line of code loads data into the 'worldWideSportsPlayersPlusDataSet.PlayerStats2023' table. You can move, or remove it, as needed.
            this.playerStats2023TableAdapter.Fill(this.worldWideSportsPlayersPlusDataSet.PlayerStats2023);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.NFL_PLAYER_STATS' table. You can move, or remove it, as needed.
            this.nFL_PLAYER_STATSTableAdapter.Fill(this.worldWideSportsDBDataSet.NFL_PLAYER_STATS);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.NFL_Games' table. You can move, or remove it, as needed.
            this.nFL_GamesTableAdapter.Fill(this.worldWideSportsDBDataSet.NFL_Games);


            //initialize Fav variables with class
            DetailedNFlGames favGames = new DetailedNFlGames();
            //NFLPlayers favPlayer = new NFLPlayers();
            string teamAbrev = "";
            //Fills Favorite Team list on load
            foreach (WorldWideSportsDBDataSet.FavoriteNFLTeamsRow favRow in worldWideSportsDBDataSet.FavoriteNFLTeams.Rows)
            {
                if (favRow.UserId.ToString() == user.ToString())
                {
                    var gamesRow = worldWideSportsDBDataSet.NFL_Games
                        .Where(x => x.home_team.ToString() == favRow.TeamAbbr.ToString() && (x.season == "2023" || x.season == "2024"));//added 2023 and 2024 filter
                    foreach (var game in gamesRow)
                    {
                        //set every class atribute with the column in the table
                        favGames.GameId = game.game_id.ToString();
                        favGames.Season = game.season.ToString();
                        favGames.Week = game.week;
                        favGames.Gameday = game.gameday;
                        favGames.Gametime = game.gametime;
                        favGames.AwayTeam = game.away_team;
                        favGames.HomeTeam = game.home_team;
                        favGames.Stadium = game.stadium;
                        //gets team abrev now to use for fav team
                        teamAbrev = game.home_team;
                        favGames.AwayScore = game.away_score;
                        favGames.HomeScore = game.home_score;
                        favGames.Total = game.total;
                        favGames.OverTime = game.overtime;
                        favGames.AwayCoach = game.away_coach;
                        favGames.HomeCoach = game.home_coach;
                        favGames.Referee = game.referee;
                        rchTxtBoxFavTeams.AppendText(favGames.ToString()+"\n\n");
                    }
                }
            }
            //Players
            var player24Data = worldWideSportsPlayersPlusDataSet.PlayerStats2024
           .Where(x => x.Team.ToString() == teamAbrev.ToString())
           .OrderBy(x => x.Player);
            foreach (var players in player24Data)
            {
                //Outputs the player onto textBox
                rchTxtBoxFavPlayers.AppendText($"{players.Player} \t\tAge:{players.Age} Position:{players.Pos}\n\n");
            }
        }

        private void cmbBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            //initialize variables with class
            DetailedNFlGames games = new DetailedNFlGames();
            NFLPlayers player = new NFLPlayers();
            //Clears combobox when new combo box selection
            rchTxtBoxGames.Clear();
            rchTxtBoxPlayer23.Clear();
            rchTxtBoxPlayer24.Clear();
            if (cmbBoxTeams.SelectedIndex != -1)
            {
                //Add Games
                //this filters the games based on the 2023 and 2024 season and the team selected in the combo box using linq to get the rows that match the criteria
                var filteredGames = worldWideSportsDBDataSet.NFL_Games
                    .Where(x => x.home_team.ToString() == cmbBoxTeams.SelectedValue.ToString() && (x.season == "2023" || x.season == "2024"));
                //sets the values for the class using the columns and outputs them to box for each game that matches the combo box team selection and season selection
                foreach (var gamesRow in filteredGames)
                {
                    //set every class atribute with the column in the table
                    games.GameId = gamesRow.game_id.ToString();
                        games.Season = gamesRow.season.ToString();
                        games.Week = gamesRow.week;
                        games.Gameday = gamesRow.gameday;
                        games.Gametime = gamesRow.gametime;
                        games.AwayTeam = gamesRow.away_team;
                        games.HomeTeam = gamesRow.home_team;
                        games.Stadium = gamesRow.stadium;
                        games.AwayScore = gamesRow.away_score;
                        games.HomeScore = gamesRow.home_score;
                        games.Total = gamesRow.total;
                        games.OverTime = gamesRow.overtime;
                        games.AwayCoach = gamesRow.away_coach;
                        games.HomeCoach = gamesRow.home_coach;
                        games.Referee = gamesRow.referee;

                        rchTxtBoxGames.AppendText($"{games.ToString()}\n\n");
                }//end if


                //players
                //2023
                var player23Data = worldWideSportsPlayersPlusDataSet.PlayerStats2023
                //LINQ get player stats and rows and set them on the player class and outputs them to box
                    .Where(x => x.Team.ToString() == cmbBoxTeams.SelectedValue.ToString())
                    .OrderBy(x => x.Player);
                foreach (var playerrow in player23Data)
                {
                    //sets the values for the class using the columns
                    player.PlayerAge = playerrow.Age.ToString();
                    player.PlayerName = playerrow.Player;
                    player.Position = playerrow.Pos;
                    player.Season = "'23";
                    player.GamesPlayed = playerrow.G.ToString();
                    player.GamesStarted = playerrow.GS.ToString();
                    player.TotalPoints = playerrow.Pts.ToString();
                    player.PointsPerGame = playerrow._Pts_G.ToString();
                    rchTxtBoxPlayer23.AppendText($"{player.ToString()}\n\n");
                }

                //var player2024
                //Lingq to get the players based on teams using the combo box Values which are the team abreviations
                var player24Data = worldWideSportsPlayersPlusDataSet.PlayerStats2024
                    .Where(x => x.Team.ToString() == cmbBoxTeams.SelectedValue.ToString())
                    .OrderBy(x => x.Player);
                foreach (var playerrow in player24Data)
                {
                    //sets the class values
                    player.PlayerAge = playerrow.Age.ToString();
                    player.PlayerName = playerrow.Player;
                    player.Position = playerrow.Pos;
                    player.Season = "'24";
                    player.GamesPlayed = playerrow.G.ToString();
                    player.GamesStarted = playerrow.GS.ToString();
                    player.TotalPoints = playerrow.Pts.ToString();
                    player.PointsPerGame = playerrow._Pts_G.ToString();
                    rchTxtBoxPlayer24.AppendText($"{player.ToString()}\n\n");
                }

            }//end if
            //sets your cursor to the start of the boxes
            rchTxtBoxGames.SelectionStart = 0;
            rchTxtBoxPlayer23.SelectionStart = 0;
            rchTxtBoxPlayer24.SelectionStart = 0;
        }

        private void nFL_GamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nFL_GamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldWideSportsDBDataSet);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //sorry changed this

            //making a variable for the main form and setting it to the owner of this form which is the main form
            MainForm mainForm = (MainForm)this.Owner;

            //close the application and return to the main form
            mainForm.Show();

            //this will close the form and send you back to the main
            this.Close();
        }
    }
}
