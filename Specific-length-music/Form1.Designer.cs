namespace Specific_length_music
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_FilesSelector = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.TB_Liste = new System.Windows.Forms.TextBox();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.NUD_H = new System.Windows.Forms.NumericUpDown();
            this.NUD_M = new System.Windows.Forms.NumericUpDown();
            this.NUD_S = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_S)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_FilesSelector
            // 
            this.BTN_FilesSelector.Location = new System.Drawing.Point(12, 12);
            this.BTN_FilesSelector.Name = "BTN_FilesSelector";
            this.BTN_FilesSelector.Size = new System.Drawing.Size(75, 23);
            this.BTN_FilesSelector.TabIndex = 0;
            this.BTN_FilesSelector.Text = "Parcourir";
            this.BTN_FilesSelector.UseVisualStyleBackColor = true;
            this.BTN_FilesSelector.Click += new System.EventHandler(this.BTN_FilesSelector_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.Multiselect = true;
            // 
            // TB_Liste
            // 
            this.TB_Liste.AcceptsReturn = true;
            this.TB_Liste.AcceptsTab = true;
            this.TB_Liste.Location = new System.Drawing.Point(348, 44);
            this.TB_Liste.Multiline = true;
            this.TB_Liste.Name = "TB_Liste";
            this.TB_Liste.ReadOnly = true;
            this.TB_Liste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Liste.Size = new System.Drawing.Size(316, 288);
            this.TB_Liste.TabIndex = 1;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(348, 12);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(75, 23);
            this.BTN_Refresh.TabIndex = 2;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // NUD_H
            // 
            this.NUD_H.Location = new System.Drawing.Point(28, 82);
            this.NUD_H.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUD_H.Name = "NUD_H";
            this.NUD_H.Size = new System.Drawing.Size(39, 20);
            this.NUD_H.TabIndex = 3;
            // 
            // NUD_M
            // 
            this.NUD_M.Location = new System.Drawing.Point(73, 82);
            this.NUD_M.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUD_M.Name = "NUD_M";
            this.NUD_M.Size = new System.Drawing.Size(39, 20);
            this.NUD_M.TabIndex = 4;
            // 
            // NUD_S
            // 
            this.NUD_S.Location = new System.Drawing.Point(118, 82);
            this.NUD_S.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUD_S.Name = "NUD_S";
            this.NUD_S.Size = new System.Drawing.Size(39, 20);
            this.NUD_S.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "H      :      M      :      S";
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Location = new System.Drawing.Point(28, 109);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(129, 23);
            this.BTN_Generate.TabIndex = 7;
            this.BTN_Generate.Text = "Générer";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 382);
            this.Controls.Add(this.BTN_Generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_S);
            this.Controls.Add(this.NUD_M);
            this.Controls.Add(this.NUD_H);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.TB_Liste);
            this.Controls.Add(this.BTN_FilesSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_FilesSelector;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TextBox TB_Liste;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.NumericUpDown NUD_H;
        private System.Windows.Forms.NumericUpDown NUD_M;
        private System.Windows.Forms.NumericUpDown NUD_S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Generate;
    }
}

