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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxHolder1 = new System.Windows.Forms.GroupBox();
            this.gbxPga = new System.Windows.Forms.GroupBox();
            this.btnSavePga = new System.Windows.Forms.Button();
            this.btnViewPga = new System.Windows.Forms.Button();
            this.cbxPga = new System.Windows.Forms.ComboBox();
            this.gbxNfl = new System.Windows.Forms.GroupBox();
            this.btnViewNfl = new System.Windows.Forms.Button();
            this.btnSaveFavTeam = new System.Windows.Forms.Button();
            this.cbxNflTeams = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLoginCreate = new System.Windows.Forms.Button();
            this.lblNavBar = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.pgA_PlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter();
            this.nfL_PLAYER_STATSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.lblAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxHolder1.SuspendLayout();
            this.gbxPga.SuspendLayout();
            this.gbxNfl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbxHolder1
            // 
            this.gbxHolder1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxHolder1.Controls.Add(this.gbxPga);
            this.gbxHolder1.Controls.Add(this.gbxNfl);
            this.gbxHolder1.Controls.Add(this.pictureBox2);
            this.gbxHolder1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxHolder1.Location = new System.Drawing.Point(129, 88);
            this.gbxHolder1.Name = "gbxHolder1";
            this.gbxHolder1.Size = new System.Drawing.Size(1144, 518);
            this.gbxHolder1.TabIndex = 1;
            this.gbxHolder1.TabStop = false;
            // 
            // gbxPga
            // 
            this.gbxPga.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxPga.Controls.Add(this.btnSavePga);
            this.gbxPga.Controls.Add(this.btnViewPga);
            this.gbxPga.Controls.Add(this.cbxPga);
            this.gbxPga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxPga.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPga.Location = new System.Drawing.Point(623, 102);
            this.gbxPga.Name = "gbxPga";
            this.gbxPga.Size = new System.Drawing.Size(410, 295);
            this.gbxPga.TabIndex = 5;
            this.gbxPga.TabStop = false;
            this.gbxPga.Text = "Choose your Favorite PGA Player:";
            this.gbxPga.Visible = false;
            // 
            // btnSavePga
            // 
            this.btnSavePga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePga.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePga.Location = new System.Drawing.Point(109, 137);
            this.btnSavePga.Name = "btnSavePga";
            this.btnSavePga.Size = new System.Drawing.Size(178, 37);
            this.btnSavePga.TabIndex = 3;
            this.btnSavePga.Text = "Save Favorite Player";
            this.toolTipMainForm.SetToolTip(this.btnSavePga, "Click to save your favorite player");
            this.btnSavePga.UseVisualStyleBackColor = true;
            this.btnSavePga.Click += new System.EventHandler(this.btnSavePga_Click);
            // 
            // btnViewPga
            // 
            this.btnViewPga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewPga.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPga.Location = new System.Drawing.Point(130, 190);
            this.btnViewPga.Name = "btnViewPga";
            this.btnViewPga.Size = new System.Drawing.Size(141, 36);
            this.btnViewPga.TabIndex = 2;
            this.btnViewPga.Text = "View PGA Details";
            this.toolTipMainForm.SetToolTip(this.btnViewPga, "Click to view pga details");
            this.btnViewPga.UseVisualStyleBackColor = true;
            this.btnViewPga.Click += new System.EventHandler(this.btnViewPga_Click);
            // 
            // cbxPga
            // 
            this.cbxPga.FormattingEnabled = true;
            this.cbxPga.Location = new System.Drawing.Point(79, 78);
            this.cbxPga.Name = "cbxPga";
            this.cbxPga.Size = new System.Drawing.Size(246, 28);
            this.cbxPga.TabIndex = 0;
            this.toolTipMainForm.SetToolTip(this.cbxPga, "Please Select your Favorite PGA Player");
            // 
            // gbxNfl
            // 
            this.gbxNfl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNfl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxNfl.Controls.Add(this.btnViewNfl);
            this.gbxNfl.Controls.Add(this.btnSaveFavTeam);
            this.gbxNfl.Controls.Add(this.cbxNflTeams);
            this.gbxNfl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxNfl.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNfl.Location = new System.Drawing.Point(105, 102);
            this.gbxNfl.Name = "gbxNfl";
            this.gbxNfl.Size = new System.Drawing.Size(410, 295);
            this.gbxNfl.TabIndex = 4;
            this.gbxNfl.TabStop = false;
            this.gbxNfl.Text = "Choose your Favorite NFL Team:";
            this.gbxNfl.Visible = false;
            // 
            // btnViewNfl
            // 
            this.btnViewNfl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewNfl.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNfl.Location = new System.Drawing.Point(128, 190);
            this.btnViewNfl.Name = "btnViewNfl";
            this.btnViewNfl.Size = new System.Drawing.Size(136, 36);
            this.btnViewNfl.TabIndex = 2;
            this.btnViewNfl.Text = "View NFL Details";
            this.toolTipMainForm.SetToolTip(this.btnViewNfl, "Click to view nfl details");
            this.btnViewNfl.UseVisualStyleBackColor = true;
            this.btnViewNfl.Click += new System.EventHandler(this.btnViewNfl_Click);
            // 
            // btnSaveFavTeam
            // 
            this.btnSaveFavTeam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveFavTeam.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFavTeam.Location = new System.Drawing.Point(118, 137);
            this.btnSaveFavTeam.Name = "btnSaveFavTeam";
            this.btnSaveFavTeam.Size = new System.Drawing.Size(153, 37);
            this.btnSaveFavTeam.TabIndex = 1;
            this.btnSaveFavTeam.Text = "Save Favorite Team";
            this.toolTipMainForm.SetToolTip(this.btnSaveFavTeam, "cClick to save your favorite team");
            this.btnSaveFavTeam.UseVisualStyleBackColor = true;
            this.btnSaveFavTeam.Click += new System.EventHandler(this.btnSaveFavTeam_Click);
            // 
            // cbxNflTeams
            // 
            this.cbxNflTeams.FormattingEnabled = true;
            this.cbxNflTeams.Location = new System.Drawing.Point(79, 78);
            this.cbxNflTeams.Name = "cbxNflTeams";
            this.cbxNflTeams.Size = new System.Drawing.Size(246, 28);
            this.cbxNflTeams.TabIndex = 0;
            this.toolTipMainForm.SetToolTip(this.cbxNflTeams, "Please Select your Favorite NFL Team");
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
            // btnLoginCreate
            // 
            this.btnLoginCreate.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCreate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLoginCreate.Location = new System.Drawing.Point(1256, 60);
            this.btnLoginCreate.Name = "btnLoginCreate";
            this.btnLoginCreate.Size = new System.Drawing.Size(188, 39);
            this.btnLoginCreate.TabIndex = 6;
            this.btnLoginCreate.Text = "Log In/Create Account";
            this.toolTipMainForm.SetToolTip(this.btnLoginCreate, "Click to Log in or Create account");
            this.btnLoginCreate.UseVisualStyleBackColor = true;
            this.btnLoginCreate.Click += new System.EventHandler(this.btnLoginCreate_Click);
            // 
            // lblNavBar
            // 
            this.lblNavBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNavBar.Location = new System.Drawing.Point(-10, 51);
            this.lblNavBar.Name = "lblNavBar";
            this.lblNavBar.Size = new System.Drawing.Size(1466, 55);
            this.lblNavBar.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(659, 657);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.toolTipMainForm.SetToolTip(this.btnExit, "Click to Exit WorldWideSports");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pgA_PlayersTableAdapter
            // 
            this.pgA_PlayersTableAdapter.ClearBeforeFill = true;
            // 
            // nfL_PLAYER_STATSTableAdapter
            // 
            this.nfL_PLAYER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAccount.Location = new System.Drawing.Point(1256, 19);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(185, 23);
            this.lblAccount.TabIndex = 8;
            this.lblAccount.Text = "Account: ";
            this.lblAccount.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1453, 696);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoginCreate);
            this.Controls.Add(this.lblNavBar);
            this.Controls.Add(this.gbxHolder1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Wide Sports";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxHolder1.ResumeLayout(false);
            this.gbxPga.ResumeLayout(false);
            this.gbxNfl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxHolder1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbxNfl;
        private System.Windows.Forms.Button btnSaveFavTeam;
        private System.Windows.Forms.ComboBox cbxNflTeams;
        private System.Windows.Forms.Button btnViewNfl;
        private System.Windows.Forms.GroupBox gbxPga;
        private System.Windows.Forms.Button btnViewPga;
        private System.Windows.Forms.ComboBox cbxPga;
        private System.Windows.Forms.Button btnSavePga;
        private System.Windows.Forms.Button btnLoginCreate;
        private System.Windows.Forms.Label lblNavBar;
        private System.Windows.Forms.Button btnExit;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter pgA_PlayersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter nfL_PLAYER_STATSTableAdapter;
        private System.Windows.Forms.ToolTip toolTipMainForm;
        private System.Windows.Forms.Label lblAccount;
    }
}