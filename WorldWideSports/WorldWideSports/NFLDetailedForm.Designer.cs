namespace WorldWideSports
{
    partial class NFLDetailedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFLDetailedForm));
            this.cmbBoxTeams = new System.Windows.Forms.ComboBox();
            this.grpBoxPlayer23 = new System.Windows.Forms.GroupBox();
            this.rchTxtBoxPlayer23 = new System.Windows.Forms.RichTextBox();
            this.rchTxtBoxGames = new System.Windows.Forms.RichTextBox();
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.nFL_GamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFL_GamesTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_GamesTableAdapter();
            this.tableAdapterManager = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager();
            this.nFL_PLAYER_STATSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFL_PLAYER_STATSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter();
            this.worldWideSportsPlayersPlusDataSet = new WorldWideSports.WorldWideSportsPlayersPlusDataSet();
            this.playerStats2023BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerStats2023TableAdapter = new WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2023TableAdapter();
            this.tableAdapterManager1 = new WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.TableAdapterManager();
            this.playerStats2024TableAdapter = new WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2024TableAdapter();
            this.playerStats2024BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rchTxtBoxPlayer24 = new System.Windows.Forms.RichTextBox();
            this.grpBoxPlayer24 = new System.Windows.Forms.GroupBox();
            this.grpBoxTeams = new System.Windows.Forms.GroupBox();
            this.grpBoxFavorite = new System.Windows.Forms.GroupBox();
            this.rchTxtBoxFavPlayers = new System.Windows.Forms.RichTextBox();
            this.rchTxtBoxFavTeams = new System.Windows.Forms.RichTextBox();
            this.favoriteNFLTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteNFLTeamsTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTipNFLDetails = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxPlayer23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_PLAYER_STATSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsPlayersPlusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2023BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2024BindingSource)).BeginInit();
            this.grpBoxPlayer24.SuspendLayout();
            this.grpBoxTeams.SuspendLayout();
            this.grpBoxFavorite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNFLTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxTeams
            // 
            this.cmbBoxTeams.FormattingEnabled = true;
            this.cmbBoxTeams.Location = new System.Drawing.Point(652, 14);
            this.cmbBoxTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxTeams.Name = "cmbBoxTeams";
            this.cmbBoxTeams.Size = new System.Drawing.Size(217, 24);
            this.cmbBoxTeams.TabIndex = 3;
            this.toolTipNFLDetails.SetToolTip(this.cmbBoxTeams, "Select NFL Team");
            this.cmbBoxTeams.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTeams_SelectedIndexChanged);
            // 
            // grpBoxPlayer23
            // 
            this.grpBoxPlayer23.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxPlayer23.Controls.Add(this.rchTxtBoxPlayer23);
            this.grpBoxPlayer23.Location = new System.Drawing.Point(12, 73);
            this.grpBoxPlayer23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxPlayer23.Name = "grpBoxPlayer23";
            this.grpBoxPlayer23.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxPlayer23.Size = new System.Drawing.Size(485, 453);
            this.grpBoxPlayer23.TabIndex = 2;
            this.grpBoxPlayer23.TabStop = false;
            this.grpBoxPlayer23.Text = "Player Stats 2023";
            // 
            // rchTxtBoxPlayer23
            // 
            this.rchTxtBoxPlayer23.Location = new System.Drawing.Point(5, 21);
            this.rchTxtBoxPlayer23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchTxtBoxPlayer23.Name = "rchTxtBoxPlayer23";
            this.rchTxtBoxPlayer23.ReadOnly = true;
            this.rchTxtBoxPlayer23.Size = new System.Drawing.Size(472, 422);
            this.rchTxtBoxPlayer23.TabIndex = 0;
            this.rchTxtBoxPlayer23.Text = "";
            // 
            // rchTxtBoxGames
            // 
            this.rchTxtBoxGames.Location = new System.Drawing.Point(5, 25);
            this.rchTxtBoxGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchTxtBoxGames.Name = "rchTxtBoxGames";
            this.rchTxtBoxGames.ReadOnly = true;
            this.rchTxtBoxGames.Size = new System.Drawing.Size(472, 422);
            this.rchTxtBoxGames.TabIndex = 1;
            this.rchTxtBoxGames.Text = "";
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nFL_GamesBindingSource
            // 
            this.nFL_GamesBindingSource.DataMember = "NFL_Games";
            this.nFL_GamesBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // nFL_GamesTableAdapter
            // 
            this.nFL_GamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FavoriteNFLTeamsTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayers_NewTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayersTableAdapter = null;
            this.tableAdapterManager.NFL_GamesTableAdapter = this.nFL_GamesTableAdapter;
            this.tableAdapterManager.NFL_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_ALL_TOURNAMENTSTableAdapter = null;
            this.tableAdapterManager.PGA_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_PlayersTableAdapter = null;
            this.tableAdapterManager.PGA_TOURNAMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nFL_PLAYER_STATSBindingSource
            // 
            this.nFL_PLAYER_STATSBindingSource.DataMember = "NFL_PLAYER_STATS";
            this.nFL_PLAYER_STATSBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // nFL_PLAYER_STATSTableAdapter
            // 
            this.nFL_PLAYER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // worldWideSportsPlayersPlusDataSet
            // 
            this.worldWideSportsPlayersPlusDataSet.DataSetName = "WorldWideSportsPlayersPlusDataSet";
            this.worldWideSportsPlayersPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerStats2023BindingSource
            // 
            this.playerStats2023BindingSource.DataMember = "PlayerStats2023";
            this.playerStats2023BindingSource.DataSource = this.worldWideSportsPlayersPlusDataSet;
            // 
            // playerStats2023TableAdapter
            // 
            this.playerStats2023TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PlayerStats2023TableAdapter = this.playerStats2023TableAdapter;
            this.tableAdapterManager1.PlayerStats2024TableAdapter = this.playerStats2024TableAdapter;
            this.tableAdapterManager1.UpdateOrder = WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerStats2024TableAdapter
            // 
            this.playerStats2024TableAdapter.ClearBeforeFill = true;
            // 
            // playerStats2024BindingSource
            // 
            this.playerStats2024BindingSource.DataMember = "PlayerStats2024";
            this.playerStats2024BindingSource.DataSource = this.worldWideSportsPlayersPlusDataSet;
            // 
            // rchTxtBoxPlayer24
            // 
            this.rchTxtBoxPlayer24.Location = new System.Drawing.Point(5, 21);
            this.rchTxtBoxPlayer24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchTxtBoxPlayer24.Name = "rchTxtBoxPlayer24";
            this.rchTxtBoxPlayer24.ReadOnly = true;
            this.rchTxtBoxPlayer24.Size = new System.Drawing.Size(472, 422);
            this.rchTxtBoxPlayer24.TabIndex = 2;
            this.rchTxtBoxPlayer24.Text = "";
            // 
            // grpBoxPlayer24
            // 
            this.grpBoxPlayer24.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxPlayer24.Controls.Add(this.rchTxtBoxPlayer24);
            this.grpBoxPlayer24.Location = new System.Drawing.Point(12, 532);
            this.grpBoxPlayer24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxPlayer24.Name = "grpBoxPlayer24";
            this.grpBoxPlayer24.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxPlayer24.Size = new System.Drawing.Size(488, 453);
            this.grpBoxPlayer24.TabIndex = 4;
            this.grpBoxPlayer24.TabStop = false;
            this.grpBoxPlayer24.Text = "Player Stats 2024";
            // 
            // grpBoxTeams
            // 
            this.grpBoxTeams.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxTeams.Controls.Add(this.rchTxtBoxGames);
            this.grpBoxTeams.Location = new System.Drawing.Point(517, 73);
            this.grpBoxTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxTeams.Name = "grpBoxTeams";
            this.grpBoxTeams.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxTeams.Size = new System.Drawing.Size(483, 453);
            this.grpBoxTeams.TabIndex = 5;
            this.grpBoxTeams.TabStop = false;
            this.grpBoxTeams.Text = "Teams Stats";
            // 
            // grpBoxFavorite
            // 
            this.grpBoxFavorite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxFavorite.Controls.Add(this.rchTxtBoxFavPlayers);
            this.grpBoxFavorite.Controls.Add(this.rchTxtBoxFavTeams);
            this.grpBoxFavorite.Location = new System.Drawing.Point(517, 532);
            this.grpBoxFavorite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxFavorite.Name = "grpBoxFavorite";
            this.grpBoxFavorite.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxFavorite.Size = new System.Drawing.Size(488, 453);
            this.grpBoxFavorite.TabIndex = 6;
            this.grpBoxFavorite.TabStop = false;
            this.grpBoxFavorite.Text = "Favorite Team Stats";
            // 
            // rchTxtBoxFavPlayers
            // 
            this.rchTxtBoxFavPlayers.Location = new System.Drawing.Point(5, 258);
            this.rchTxtBoxFavPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchTxtBoxFavPlayers.Name = "rchTxtBoxFavPlayers";
            this.rchTxtBoxFavPlayers.Size = new System.Drawing.Size(472, 186);
            this.rchTxtBoxFavPlayers.TabIndex = 3;
            this.rchTxtBoxFavPlayers.Text = "";
            // 
            // rchTxtBoxFavTeams
            // 
            this.rchTxtBoxFavTeams.Location = new System.Drawing.Point(5, 21);
            this.rchTxtBoxFavTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchTxtBoxFavTeams.Name = "rchTxtBoxFavTeams";
            this.rchTxtBoxFavTeams.ReadOnly = true;
            this.rchTxtBoxFavTeams.Size = new System.Drawing.Size(472, 230);
            this.rchTxtBoxFavTeams.TabIndex = 2;
            this.rchTxtBoxFavTeams.Text = "";
            // 
            // favoriteNFLTeamsBindingSource
            // 
            this.favoriteNFLTeamsBindingSource.DataMember = "FavoriteNFLTeams";
            this.favoriteNFLTeamsBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // favoriteNFLTeamsTableAdapter
            // 
            this.favoriteNFLTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(339, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 29);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "NFL Details";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlBackground.Controls.Add(this.btnExit);
            this.pnlBackground.Controls.Add(this.lblTitle);
            this.pnlBackground.Controls.Add(this.pictureBox1);
            this.pnlBackground.Controls.Add(this.cmbBoxTeams);
            this.pnlBackground.Location = new System.Drawing.Point(12, 12);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1005, 55);
            this.pnlBackground.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(893, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "< &Back";
            this.toolTipNFLDetails.SetToolTip(this.btnExit, "Exit Detailed View");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NFLDetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1029, 942);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.grpBoxFavorite);
            this.Controls.Add(this.grpBoxTeams);
            this.Controls.Add(this.grpBoxPlayer24);
            this.Controls.Add(this.grpBoxPlayer23);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NFLDetailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFLDetailedForm";
            this.Load += new System.EventHandler(this.NFLDetailedForm_Load);
            this.grpBoxPlayer23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_GamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_PLAYER_STATSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsPlayersPlusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2023BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2024BindingSource)).EndInit();
            this.grpBoxPlayer24.ResumeLayout(false);
            this.grpBoxTeams.ResumeLayout(false);
            this.grpBoxFavorite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNFLTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxTeams;
        private System.Windows.Forms.GroupBox grpBoxPlayer23;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private System.Windows.Forms.BindingSource nFL_GamesBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.NFL_GamesTableAdapter nFL_GamesTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource nFL_PLAYER_STATSBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter nFL_PLAYER_STATSTableAdapter;
        private System.Windows.Forms.RichTextBox rchTxtBoxPlayer23;
        private System.Windows.Forms.RichTextBox rchTxtBoxGames;
        private WorldWideSportsPlayersPlusDataSet worldWideSportsPlayersPlusDataSet;
        private System.Windows.Forms.BindingSource playerStats2023BindingSource;
        private WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2023TableAdapter playerStats2023TableAdapter;
        private WorldWideSportsPlayersPlusDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2024TableAdapter playerStats2024TableAdapter;
        private System.Windows.Forms.BindingSource playerStats2024BindingSource;
        private System.Windows.Forms.RichTextBox rchTxtBoxPlayer24;
        private System.Windows.Forms.GroupBox grpBoxPlayer24;
        private System.Windows.Forms.GroupBox grpBoxTeams;
        private System.Windows.Forms.GroupBox grpBoxFavorite;
        private System.Windows.Forms.RichTextBox rchTxtBoxFavPlayers;
        private System.Windows.Forms.RichTextBox rchTxtBoxFavTeams;
        private System.Windows.Forms.BindingSource favoriteNFLTeamsBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter favoriteNFLTeamsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTipNFLDetails;
    }
}