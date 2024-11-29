namespace Proj_Bedrijfsafdeling.MijnForms.Medewerkers
{
    partial class RaadpleegMedewerkers
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
            this.txtGegevens = new System.Windows.Forms.TextBox();
            this.lblGegevens = new System.Windows.Forms.Label();
            this.lblKiesMw = new System.Windows.Forms.Label();
            this.cmbKiesMw = new System.Windows.Forms.ComboBox();
            this.lblInfoTekst = new System.Windows.Forms.Label();
            this.grbRadiobtn = new System.Windows.Forms.GroupBox();
            this.rbAfdVanMw = new System.Windows.Forms.RadioButton();
            this.rbAlleMw = new System.Windows.Forms.RadioButton();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnBevestingen = new System.Windows.Forms.Button();
            this.grbRadiobtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGegevens
            // 
            this.txtGegevens.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGegevens.Location = new System.Drawing.Point(15, 218);
            this.txtGegevens.Multiline = true;
            this.txtGegevens.Name = "txtGegevens";
            this.txtGegevens.ReadOnly = true;
            this.txtGegevens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGegevens.Size = new System.Drawing.Size(381, 167);
            this.txtGegevens.TabIndex = 17;
            // 
            // lblGegevens
            // 
            this.lblGegevens.AutoSize = true;
            this.lblGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGegevens.Location = new System.Drawing.Point(12, 195);
            this.lblGegevens.Name = "lblGegevens";
            this.lblGegevens.Size = new System.Drawing.Size(86, 20);
            this.lblGegevens.TabIndex = 16;
            this.lblGegevens.Text = "Gegevens:";
            // 
            // lblKiesMw
            // 
            this.lblKiesMw.AutoSize = true;
            this.lblKiesMw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiesMw.Location = new System.Drawing.Point(13, 106);
            this.lblKiesMw.Name = "lblKiesMw";
            this.lblKiesMw.Size = new System.Drawing.Size(169, 20);
            this.lblKiesMw.TabIndex = 15;
            this.lblKiesMw.Text = "Kies een medewerker :";
            // 
            // cmbKiesMw
            // 
            this.cmbKiesMw.FormattingEnabled = true;
            this.cmbKiesMw.Location = new System.Drawing.Point(215, 108);
            this.cmbKiesMw.Name = "cmbKiesMw";
            this.cmbKiesMw.Size = new System.Drawing.Size(182, 21);
            this.cmbKiesMw.TabIndex = 14;
            // 
            // lblInfoTekst
            // 
            this.lblInfoTekst.AutoSize = true;
            this.lblInfoTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTekst.Location = new System.Drawing.Point(12, 9);
            this.lblInfoTekst.Name = "lblInfoTekst";
            this.lblInfoTekst.Size = new System.Drawing.Size(138, 20);
            this.lblInfoTekst.TabIndex = 12;
            this.lblInfoTekst.Text = "Maak een keuze : ";
            // 
            // grbRadiobtn
            // 
            this.grbRadiobtn.Controls.Add(this.rbAfdVanMw);
            this.grbRadiobtn.Controls.Add(this.rbAlleMw);
            this.grbRadiobtn.Location = new System.Drawing.Point(16, 22);
            this.grbRadiobtn.Name = "grbRadiobtn";
            this.grbRadiobtn.Size = new System.Drawing.Size(381, 69);
            this.grbRadiobtn.TabIndex = 13;
            this.grbRadiobtn.TabStop = false;
            // 
            // rbAfdVanMw
            // 
            this.rbAfdVanMw.AutoSize = true;
            this.rbAfdVanMw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAfdVanMw.Location = new System.Drawing.Point(6, 43);
            this.rbAfdVanMw.Name = "rbAfdVanMw";
            this.rbAfdVanMw.Size = new System.Drawing.Size(349, 24);
            this.rbAfdVanMw.TabIndex = 1;
            this.rbAfdVanMw.TabStop = true;
            this.rbAfdVanMw.Text = "Toon afdeling van een specifieke medewerker";
            this.rbAfdVanMw.UseVisualStyleBackColor = true;
            // 
            // rbAlleMw
            // 
            this.rbAlleMw.AutoSize = true;
            this.rbAlleMw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlleMw.Location = new System.Drawing.Point(6, 19);
            this.rbAlleMw.Name = "rbAlleMw";
            this.rbAlleMw.Size = new System.Drawing.Size(190, 24);
            this.rbAlleMw.TabIndex = 0;
            this.rbAlleMw.TabStop = true;
            this.rbAlleMw.Text = "Toon alle medewerkers";
            this.rbAlleMw.UseVisualStyleBackColor = true;
            this.rbAlleMw.CheckedChanged += new System.EventHandler(this.rbAlleMw_CheckedChanged);
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(263, 145);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(134, 32);
            this.btnTerug.TabIndex = 19;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnBevestingen
            // 
            this.btnBevestingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestingen.Location = new System.Drawing.Point(16, 145);
            this.btnBevestingen.Name = "btnBevestingen";
            this.btnBevestingen.Size = new System.Drawing.Size(134, 32);
            this.btnBevestingen.TabIndex = 18;
            this.btnBevestingen.Text = "Bevestigen";
            this.btnBevestingen.UseVisualStyleBackColor = true;
            this.btnBevestingen.Click += new System.EventHandler(this.btnBevestingen_Click);
            // 
            // RaadpleegMedewerkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 408);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBevestingen);
            this.Controls.Add(this.txtGegevens);
            this.Controls.Add(this.lblGegevens);
            this.Controls.Add(this.lblKiesMw);
            this.Controls.Add(this.cmbKiesMw);
            this.Controls.Add(this.lblInfoTekst);
            this.Controls.Add(this.grbRadiobtn);
            this.Name = "RaadpleegMedewerkers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaadpleegMedewerkers";
            this.grbRadiobtn.ResumeLayout(false);
            this.grbRadiobtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGegevens;
        private System.Windows.Forms.Label lblGegevens;
        private System.Windows.Forms.Label lblKiesMw;
        private System.Windows.Forms.ComboBox cmbKiesMw;
        private System.Windows.Forms.Label lblInfoTekst;
        private System.Windows.Forms.GroupBox grbRadiobtn;
        private System.Windows.Forms.RadioButton rbAfdVanMw;
        private System.Windows.Forms.RadioButton rbAlleMw;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnBevestingen;
    }
}