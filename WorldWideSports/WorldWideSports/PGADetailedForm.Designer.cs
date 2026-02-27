namespace WorldWideSports
{
    partial class PGADetailedForm
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
            this.grpBoxStats = new System.Windows.Forms.GroupBox();
            this.rchTxtBoxTournament = new System.Windows.Forms.RichTextBox();
            this.rchTxtBoxStats = new System.Windows.Forms.RichTextBox();
            this.cmbBoxPlayers = new System.Windows.Forms.ComboBox();
            this.btnSelectPlayer = new System.Windows.Forms.Button();
            this.lblPGATitle = new System.Windows.Forms.Label();
            this.pGA_ALL_TOURNAMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.pGA_PLAYER_STATSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pGA_PlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pGA_PlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter();
            this.tableAdapterManager = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager();
            this.pGA_PLAYER_STATSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_PLAYER_STATSTableAdapter();
            this.pGA_ALL_TOURNAMENTSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_ALL_TOURNAMENTSTableAdapter();
            this.grpBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_ALL_TOURNAMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PLAYER_STATSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PlayersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxStats
            // 
            this.grpBoxStats.Controls.Add(this.rchTxtBoxTournament);
            this.grpBoxStats.Controls.Add(this.rchTxtBoxStats);
            this.grpBoxStats.Location = new System.Drawing.Point(12, 70);
            this.grpBoxStats.Name = "grpBoxStats";
            this.grpBoxStats.Size = new System.Drawing.Size(1091, 580);
            this.grpBoxStats.TabIndex = 0;
            this.grpBoxStats.TabStop = false;
            this.grpBoxStats.Text = "Stats";
            // 
            // rchTxtBoxTournament
            // 
            this.rchTxtBoxTournament.Location = new System.Drawing.Point(463, 21);
            this.rchTxtBoxTournament.Name = "rchTxtBoxTournament";
            this.rchTxtBoxTournament.ReadOnly = true;
            this.rchTxtBoxTournament.Size = new System.Drawing.Size(622, 551);
            this.rchTxtBoxTournament.TabIndex = 2;
            this.rchTxtBoxTournament.Text = "";
            // 
            // rchTxtBoxStats
            // 
            this.rchTxtBoxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBoxStats.Location = new System.Drawing.Point(6, 21);
            this.rchTxtBoxStats.Name = "rchTxtBoxStats";
            this.rchTxtBoxStats.ReadOnly = true;
            this.rchTxtBoxStats.Size = new System.Drawing.Size(439, 551);
            this.rchTxtBoxStats.TabIndex = 0;
            this.rchTxtBoxStats.Text = "";
            // 
            // cmbBoxPlayers
            // 
            this.cmbBoxPlayers.FormattingEnabled = true;
            this.cmbBoxPlayers.Items.AddRange(new object[] {
            "SelectPlayer"});
            this.cmbBoxPlayers.Location = new System.Drawing.Point(13, 40);
            this.cmbBoxPlayers.Name = "cmbBoxPlayers";
            this.cmbBoxPlayers.Size = new System.Drawing.Size(209, 24);
            this.cmbBoxPlayers.TabIndex = 1;
            this.cmbBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPlayers_SelectedIndexChanged);
            // 
            // btnSelectPlayer
            // 
            this.btnSelectPlayer.Location = new System.Drawing.Point(228, 40);
            this.btnSelectPlayer.Name = "btnSelectPlayer";
            this.btnSelectPlayer.Size = new System.Drawing.Size(75, 24);
            this.btnSelectPlayer.TabIndex = 3;
            this.btnSelectPlayer.Text = "Select";
            this.btnSelectPlayer.UseVisualStyleBackColor = true;
            // 
            // lblPGATitle
            // 
            this.lblPGATitle.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGATitle.Location = new System.Drawing.Point(451, 9);
            this.lblPGATitle.Name = "lblPGATitle";
            this.lblPGATitle.Size = new System.Drawing.Size(184, 39);
            this.lblPGATitle.TabIndex = 4;
            this.lblPGATitle.Text = "PGA Details";
            // 
            // pGA_ALL_TOURNAMENTSBindingSource
            // 
            this.pGA_ALL_TOURNAMENTSBindingSource.DataMember = "PGA_ALL_TOURNAMENTS";
            this.pGA_ALL_TOURNAMENTSBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pGA_PLAYER_STATSBindingSource
            // 
            this.pGA_PLAYER_STATSBindingSource.DataMember = "PGA_PLAYER_STATS";
            this.pGA_PLAYER_STATSBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // pGA_PlayersBindingSource
            // 
            this.pGA_PlayersBindingSource.DataMember = "PGA_Players";
            this.pGA_PlayersBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // pGA_PlayersTableAdapter
            // 
            this.pGA_PlayersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FavoriteNFLTeamsTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayers_NewTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayersTableAdapter = null;
            this.tableAdapterManager.NFL_GamesTableAdapter = null;
            this.tableAdapterManager.NFL_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_ALL_TOURNAMENTSTableAdapter = null;
            this.tableAdapterManager.PGA_PLAYER_STATSTableAdapter = this.pGA_PLAYER_STATSTableAdapter;
            this.tableAdapterManager.PGA_PlayersTableAdapter = this.pGA_PlayersTableAdapter;
            this.tableAdapterManager.PGA_TOURNAMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // pGA_PLAYER_STATSTableAdapter
            // 
            this.pGA_PLAYER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // pGA_ALL_TOURNAMENTSTableAdapter
            // 
            this.pGA_ALL_TOURNAMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // PGADetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 654);
            this.Controls.Add(this.lblPGATitle);
            this.Controls.Add(this.btnSelectPlayer);
            this.Controls.Add(this.cmbBoxPlayers);
            this.Controls.Add(this.grpBoxStats);
            this.Name = "PGADetailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGADetailedForm";
            this.Load += new System.EventHandler(this.PGADetailedForm_Load);
            this.grpBoxStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pGA_ALL_TOURNAMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PLAYER_STATSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PlayersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStats;
        private System.Windows.Forms.ComboBox cmbBoxPlayers;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private System.Windows.Forms.BindingSource pGA_PlayersBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter pGA_PlayersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private WorldWideSportsDBDataSetTableAdapters.PGA_PLAYER_STATSTableAdapter pGA_PLAYER_STATSTableAdapter;
        private System.Windows.Forms.BindingSource pGA_PLAYER_STATSBindingSource;
        private System.Windows.Forms.Button btnSelectPlayer;
        private System.Windows.Forms.RichTextBox rchTxtBoxStats;
        private System.Windows.Forms.Label lblPGATitle;
        private System.Windows.Forms.BindingSource pGA_ALL_TOURNAMENTSBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.PGA_ALL_TOURNAMENTSTableAdapter pGA_ALL_TOURNAMENTSTableAdapter;
        private System.Windows.Forms.RichTextBox rchTxtBoxTournament;
    }
}