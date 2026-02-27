namespace WorldWideSports
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewNfl = new System.Windows.Forms.Button();
            this.btnViewPga = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnLoginCreate = new System.Windows.Forms.Button();
            this.lblNavBar = new System.Windows.Forms.Label();
            this.gbxPga = new System.Windows.Forms.GroupBox();
            this.btnSavePga = new System.Windows.Forms.Button();
            this.cbxPga = new System.Windows.Forms.ComboBox();
            this.gbxHolder1 = new System.Windows.Forms.GroupBox();
            this.gbxNfl = new System.Windows.Forms.GroupBox();
            this.btnSaveFavTeam = new System.Windows.Forms.Button();
            this.cbxNflTeams = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.favoriteNFLTeamsTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter();
            this.favoritePGAPlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoritePGAPlayersTableAdapter();
            this.pgA_PlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter();
            this.nfL_PLAYER_STATSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter();
            this.mainFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnPgaAndNflUpcoming = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxPga.SuspendLayout();
            this.gbxHolder1.SuspendLayout();
            this.gbxNfl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1265, 486);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewNfl
            // 
            this.btnViewNfl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewNfl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewNfl.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNfl.Location = new System.Drawing.Point(400, 52);
            this.btnViewNfl.Name = "btnViewNfl";
            this.btnViewNfl.Size = new System.Drawing.Size(180, 44);
            this.btnViewNfl.TabIndex = 11;
            this.btnViewNfl.Text = "View NFL Details";
            this.btnViewNfl.UseVisualStyleBackColor = false;
            this.btnViewNfl.Visible = false;
            this.btnViewNfl.Click += new System.EventHandler(this.btnViewNfl_Click);
            // 
            // btnViewPga
            // 
            this.btnViewPga.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPga.Location = new System.Drawing.Point(619, 52);
            this.btnViewPga.Name = "btnViewPga";
            this.btnViewPga.Size = new System.Drawing.Size(187, 44);
            this.btnViewPga.TabIndex = 12;
            this.btnViewPga.Text = "View PGA Details";
            this.btnViewPga.UseVisualStyleBackColor = true;
            this.btnViewPga.Visible = false;
            this.btnViewPga.Click += new System.EventHandler(this.btnViewPga_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAccount.Location = new System.Drawing.Point(1217, 14);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(204, 23);
            this.lblAccount.TabIndex = 16;
            this.lblAccount.Text = "Account: ";
            this.lblAccount.Visible = false;
            // 
            // btnLoginCreate
            // 
            this.btnLoginCreate.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCreate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLoginCreate.Location = new System.Drawing.Point(1221, 55);
            this.btnLoginCreate.Name = "btnLoginCreate";
            this.btnLoginCreate.Size = new System.Drawing.Size(231, 39);
            this.btnLoginCreate.TabIndex = 14;
            this.btnLoginCreate.Text = "Log In/Create Account";
            this.btnLoginCreate.UseVisualStyleBackColor = true;
            this.btnLoginCreate.Click += new System.EventHandler(this.btnLoginCreate_Click);
            // 
            // lblNavBar
            // 
            this.lblNavBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNavBar.Location = new System.Drawing.Point(-5, 46);
            this.lblNavBar.Name = "lblNavBar";
            this.lblNavBar.Size = new System.Drawing.Size(1482, 55);
            this.lblNavBar.TabIndex = 13;
            // 
            // gbxPga
            // 
            this.gbxPga.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxPga.Controls.Add(this.btnSavePga);
            this.gbxPga.Controls.Add(this.cbxPga);
            this.gbxPga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxPga.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPga.Location = new System.Drawing.Point(301, 164);
            this.gbxPga.Name = "gbxPga";
            this.gbxPga.Size = new System.Drawing.Size(247, 206);
            this.gbxPga.TabIndex = 5;
            this.gbxPga.TabStop = false;
            this.gbxPga.Text = "Choose your Favorite PGA Player:";
            this.gbxPga.Visible = false;
            // 
            // btnSavePga
            // 
            this.btnSavePga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePga.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePga.Location = new System.Drawing.Point(32, 137);
            this.btnSavePga.Name = "btnSavePga";
            this.btnSavePga.Size = new System.Drawing.Size(188, 37);
            this.btnSavePga.TabIndex = 3;
            this.btnSavePga.Text = "Save Favorite Player";
            this.btnSavePga.UseVisualStyleBackColor = true;
            this.btnSavePga.Click += new System.EventHandler(this.btnSavePga_Click);
            // 
            // cbxPga
            // 
            this.cbxPga.FormattingEnabled = true;
            this.cbxPga.Location = new System.Drawing.Point(16, 78);
            this.cbxPga.Name = "cbxPga";
            this.cbxPga.Size = new System.Drawing.Size(225, 28);
            this.cbxPga.TabIndex = 0;
            // 
            // gbxHolder1
            // 
            this.gbxHolder1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxHolder1.Controls.Add(this.gbxNfl);
            this.gbxHolder1.Controls.Add(this.gbxPga);
            this.gbxHolder1.Controls.Add(this.pictureBox2);
            this.gbxHolder1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxHolder1.Location = new System.Drawing.Point(155, 128);
            this.gbxHolder1.Name = "gbxHolder1";
            this.gbxHolder1.Size = new System.Drawing.Size(1144, 518);
            this.gbxHolder1.TabIndex = 10;
            this.gbxHolder1.TabStop = false;
            // 
            // gbxNfl
            // 
            this.gbxNfl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNfl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxNfl.Controls.Add(this.btnSaveFavTeam);
            this.gbxNfl.Controls.Add(this.cbxNflTeams);
            this.gbxNfl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxNfl.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNfl.Location = new System.Drawing.Point(588, 164);
            this.gbxNfl.Name = "gbxNfl";
            this.gbxNfl.Size = new System.Drawing.Size(247, 206);
            this.gbxNfl.TabIndex = 4;
            this.gbxNfl.TabStop = false;
            this.gbxNfl.Text = "Choose your Favorite NFL Team:";
            this.gbxNfl.Visible = false;
            // 
            // btnSaveFavTeam
            // 
            this.btnSaveFavTeam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveFavTeam.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFavTeam.Location = new System.Drawing.Point(26, 136);
            this.btnSaveFavTeam.Name = "btnSaveFavTeam";
            this.btnSaveFavTeam.Size = new System.Drawing.Size(207, 37);
            this.btnSaveFavTeam.TabIndex = 1;
            this.btnSaveFavTeam.Text = "Save Favorite Team";
            this.btnSaveFavTeam.UseVisualStyleBackColor = true;
            this.btnSaveFavTeam.Click += new System.EventHandler(this.btnSaveFavTeam_Click);
            // 
            // cbxNflTeams
            // 
            this.cbxNflTeams.FormattingEnabled = true;
            this.cbxNflTeams.Location = new System.Drawing.Point(16, 79);
            this.cbxNflTeams.Name = "cbxNflTeams";
            this.cbxNflTeams.Size = new System.Drawing.Size(225, 28);
            this.cbxNflTeams.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(675, 688);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 27);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // favoriteNFLTeamsTableAdapter
            // 
            this.favoriteNFLTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // favoritePGAPlayersTableAdapter
            // 
            this.favoritePGAPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // pgA_PlayersTableAdapter
            // 
            this.pgA_PlayersTableAdapter.ClearBeforeFill = true;
            // 
            // nfL_PLAYER_STATSTableAdapter
            // 
            this.nfL_PLAYER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // btnPgaAndNflUpcoming
            // 
            this.btnPgaAndNflUpcoming.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPgaAndNflUpcoming.Location = new System.Drawing.Point(844, 53);
            this.btnPgaAndNflUpcoming.Name = "btnPgaAndNflUpcoming";
            this.btnPgaAndNflUpcoming.Size = new System.Drawing.Size(181, 43);
            this.btnPgaAndNflUpcoming.TabIndex = 13;
            this.btnPgaAndNflUpcoming.Text = "Upcoming Fixtures";
            this.btnPgaAndNflUpcoming.UseVisualStyleBackColor = true;
            this.btnPgaAndNflUpcoming.Visible = false;
            this.btnPgaAndNflUpcoming.Click += new System.EventHandler(this.btnPgaAndNflUpcoming_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1477, 751);
            this.Controls.Add(this.btnViewNfl);
            this.Controls.Add(this.btnPgaAndNflUpcoming);
            this.Controls.Add(this.btnViewPga);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnLoginCreate);
            this.Controls.Add(this.lblNavBar);
            this.Controls.Add(this.gbxHolder1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Wide Sports";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbxPga.ResumeLayout(false);
            this.gbxHolder1.ResumeLayout(false);
            this.gbxNfl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewNfl;
        private System.Windows.Forms.Button btnViewPga;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnLoginCreate;
        private System.Windows.Forms.Label lblNavBar;
        private System.Windows.Forms.GroupBox gbxPga;
        private System.Windows.Forms.Button btnSavePga;
        private System.Windows.Forms.ComboBox cbxPga;
        private System.Windows.Forms.GroupBox gbxHolder1;
        private System.Windows.Forms.GroupBox gbxNfl;
        private System.Windows.Forms.Button btnSaveFavTeam;
        private System.Windows.Forms.ComboBox cbxNflTeams;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter favoriteNFLTeamsTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.FavoritePGAPlayersTableAdapter favoritePGAPlayersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter pgA_PlayersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter nfL_PLAYER_STATSTableAdapter;
        private System.Windows.Forms.ToolTip mainFormToolTip;
        private System.Windows.Forms.Button btnPgaAndNflUpcoming;
    }
}