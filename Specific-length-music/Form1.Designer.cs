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
            this.NUD_H = new System.Windows.Forms.NumericUpDown();
            this.NUD_M = new System.Windows.Forms.NumericUpDown();
            this.NUD_S = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.LB_TempsRisiduel = new System.Windows.Forms.Label();
            this.BTN_Play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_iteration = new System.Windows.Forms.NumericUpDown();
            this.CB_Alert = new System.Windows.Forms.CheckBox();
            this.LB_TempsTotal = new System.Windows.Forms.Label();
            this.BTN_FolderSelector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_iteration)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_FilesSelector
            // 
            this.BTN_FilesSelector.Location = new System.Drawing.Point(12, 12);
            this.BTN_FilesSelector.Name = "BTN_FilesSelector";
            this.BTN_FilesSelector.Size = new System.Drawing.Size(119, 23);
            this.BTN_FilesSelector.TabIndex = 0;
            this.BTN_FilesSelector.Text = "Parcourir Fichiers";
            this.BTN_FilesSelector.UseVisualStyleBackColor = true;
            this.BTN_FilesSelector.Click += new System.EventHandler(this.BTN_FilesSelector_Click);
            // 
            // OFD
            // 
            this.OFD.Multiselect = true;
            // 
            // FBD
            // 
            this.FBD.ShowNewFolderButton = false;
            // 
            // TB_Liste
            // 
            this.TB_Liste.AcceptsReturn = true;
            this.TB_Liste.AcceptsTab = true;
            this.TB_Liste.Location = new System.Drawing.Point(348, 41);
            this.TB_Liste.Multiline = true;
            this.TB_Liste.Name = "TB_Liste";
            this.TB_Liste.ReadOnly = true;
            this.TB_Liste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Liste.Size = new System.Drawing.Size(316, 288);
            this.TB_Liste.TabIndex = 1;
            // 
            // NUD_H
            // 
            this.NUD_H.Location = new System.Drawing.Point(12, 125);
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
            this.NUD_M.Location = new System.Drawing.Point(57, 125);
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
            this.NUD_S.Location = new System.Drawing.Point(102, 125);
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
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "H      :      M      :      S";
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Location = new System.Drawing.Point(12, 185);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(129, 23);
            this.BTN_Generate.TabIndex = 7;
            this.BTN_Generate.Text = "Générer";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // LB_TempsRisiduel
            // 
            this.LB_TempsRisiduel.AutoSize = true;
            this.LB_TempsRisiduel.Location = new System.Drawing.Point(345, 332);
            this.LB_TempsRisiduel.Name = "LB_TempsRisiduel";
            this.LB_TempsRisiduel.Size = new System.Drawing.Size(39, 13);
            this.LB_TempsRisiduel.TabIndex = 8;
            this.LB_TempsRisiduel.Text = "risiduel";
            // 
            // BTN_Play
            // 
            this.BTN_Play.Location = new System.Drawing.Point(34, 214);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(75, 23);
            this.BTN_Play.TabIndex = 9;
            this.BTN_Play.Text = "Play";
            this.BTN_Play.UseVisualStyleBackColor = true;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre d\'itération:";
            // 
            // NUD_iteration
            // 
            this.NUD_iteration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUD_iteration.Location = new System.Drawing.Point(113, 78);
            this.NUD_iteration.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NUD_iteration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_iteration.Name = "NUD_iteration";
            this.NUD_iteration.Size = new System.Drawing.Size(111, 20);
            this.NUD_iteration.TabIndex = 11;
            this.NUD_iteration.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // CB_Alert
            // 
            this.CB_Alert.AutoSize = true;
            this.CB_Alert.Location = new System.Drawing.Point(147, 126);
            this.CB_Alert.Name = "CB_Alert";
            this.CB_Alert.Size = new System.Drawing.Size(47, 17);
            this.CB_Alert.TabIndex = 12;
            this.CB_Alert.Text = "Alert";
            this.CB_Alert.UseVisualStyleBackColor = true;
            // 
            // LB_TempsTotal
            // 
            this.LB_TempsTotal.AutoSize = true;
            this.LB_TempsTotal.Location = new System.Drawing.Point(345, 345);
            this.LB_TempsTotal.Name = "LB_TempsTotal";
            this.LB_TempsTotal.Size = new System.Drawing.Size(27, 13);
            this.LB_TempsTotal.TabIndex = 13;
            this.LB_TempsTotal.Text = "total";
            // 
            // BTN_FolderSelector
            // 
            this.BTN_FolderSelector.Location = new System.Drawing.Point(137, 12);
            this.BTN_FolderSelector.Name = "BTN_FolderSelector";
            this.BTN_FolderSelector.Size = new System.Drawing.Size(119, 23);
            this.BTN_FolderSelector.TabIndex = 14;
            this.BTN_FolderSelector.Text = "Parcourir dossier";
            this.BTN_FolderSelector.UseVisualStyleBackColor = true;
            this.BTN_FolderSelector.Click += new System.EventHandler(this.BTN_FolderSelector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 428);
            this.Controls.Add(this.BTN_FolderSelector);
            this.Controls.Add(this.LB_TempsTotal);
            this.Controls.Add(this.CB_Alert);
            this.Controls.Add(this.NUD_iteration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Play);
            this.Controls.Add(this.LB_TempsRisiduel);
            this.Controls.Add(this.BTN_Generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_S);
            this.Controls.Add(this.NUD_M);
            this.Controls.Add(this.NUD_H);
            this.Controls.Add(this.TB_Liste);
            this.Controls.Add(this.BTN_FilesSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_iteration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_FilesSelector;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TextBox TB_Liste;
        private System.Windows.Forms.NumericUpDown NUD_H;
        private System.Windows.Forms.NumericUpDown NUD_M;
        private System.Windows.Forms.NumericUpDown NUD_S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.Label LB_TempsRisiduel;
        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUD_iteration;
        private System.Windows.Forms.CheckBox CB_Alert;
        private System.Windows.Forms.Label LB_TempsTotal;
        private System.Windows.Forms.Button BTN_FolderSelector;
    }
}

