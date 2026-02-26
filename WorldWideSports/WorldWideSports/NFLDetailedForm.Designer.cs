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
            this.cmbBoxPlayers = new System.Windows.Forms.ComboBox();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmbBoxPlayers
            // 
            this.cmbBoxPlayers.FormattingEnabled = true;
            this.cmbBoxPlayers.Location = new System.Drawing.Point(12, 12);
            this.cmbBoxPlayers.Name = "cmbBoxPlayers";
            this.cmbBoxPlayers.Size = new System.Drawing.Size(147, 24);
            this.cmbBoxPlayers.TabIndex = 3;
            // 
            // grpBox
            // 
            this.grpBox.Location = new System.Drawing.Point(12, 42);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(776, 396);
            this.grpBox.TabIndex = 2;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Stats";
            // 
            // NFLDetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBoxPlayers);
            this.Controls.Add(this.grpBox);
            this.Name = "NFLDetailedForm";
            this.Text = "NFLDetailedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxPlayers;
        private System.Windows.Forms.GroupBox grpBox;
    }
}