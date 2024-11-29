namespace Proj_Bedrijfsafdeling.MijnForms.Afdelingen
{
    partial class RaadpleegAfdeling
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
            this.lblKiesAfd = new System.Windows.Forms.Label();
            this.cmbKiesAfd = new System.Windows.Forms.ComboBox();
            this.lblInfoTekst = new System.Windows.Forms.Label();
            this.grbRadiobtn = new System.Windows.Forms.GroupBox();
            this.rbMwVanAfd = new System.Windows.Forms.RadioButton();
            this.rbAlleAfd = new System.Windows.Forms.RadioButton();
            this.btnBevestingen = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.grbRadiobtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGegevens
            // 
            this.txtGegevens.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGegevens.Location = new System.Drawing.Point(16, 197);
            this.txtGegevens.Multiline = true;
            this.txtGegevens.Name = "txtGegevens";
            this.txtGegevens.ReadOnly = true;
            this.txtGegevens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGegevens.Size = new System.Drawing.Size(371, 150);
            this.txtGegevens.TabIndex = 11;
            // 
            // lblGegevens
            // 
            this.lblGegevens.AutoSize = true;
            this.lblGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGegevens.Location = new System.Drawing.Point(12, 174);
            this.lblGegevens.Name = "lblGegevens";
            this.lblGegevens.Size = new System.Drawing.Size(86, 20);
            this.lblGegevens.TabIndex = 10;
            this.lblGegevens.Text = "Gegevens:";
            // 
            // lblKiesAfd
            // 
            this.lblKiesAfd.AutoSize = true;
            this.lblKiesAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiesAfd.Location = new System.Drawing.Point(12, 142);
            this.lblKiesAfd.Name = "lblKiesAfd";
            this.lblKiesAfd.Size = new System.Drawing.Size(138, 20);
            this.lblKiesAfd.TabIndex = 9;
            this.lblKiesAfd.Text = "Kies een afdeling :";
            // 
            // cmbKiesAfd
            // 
            this.cmbKiesAfd.FormattingEnabled = true;
            this.cmbKiesAfd.Location = new System.Drawing.Point(180, 144);
            this.cmbKiesAfd.Name = "cmbKiesAfd";
            this.cmbKiesAfd.Size = new System.Drawing.Size(207, 21);
            this.cmbKiesAfd.TabIndex = 8;
            // 
            // lblInfoTekst
            // 
            this.lblInfoTekst.AutoSize = true;
            this.lblInfoTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTekst.Location = new System.Drawing.Point(12, 9);
            this.lblInfoTekst.Name = "lblInfoTekst";
            this.lblInfoTekst.Size = new System.Drawing.Size(138, 20);
            this.lblInfoTekst.TabIndex = 6;
            this.lblInfoTekst.Text = "Maak een keuze : ";
            // 
            // grbRadiobtn
            // 
            this.grbRadiobtn.Controls.Add(this.rbMwVanAfd);
            this.grbRadiobtn.Controls.Add(this.rbAlleAfd);
            this.grbRadiobtn.Location = new System.Drawing.Point(16, 22);
            this.grbRadiobtn.Name = "grbRadiobtn";
            this.grbRadiobtn.Size = new System.Drawing.Size(371, 69);
            this.grbRadiobtn.TabIndex = 7;
            this.grbRadiobtn.TabStop = false;
            // 
            // rbMwVanAfd
            // 
            this.rbMwVanAfd.AutoSize = true;
            this.rbMwVanAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMwVanAfd.Location = new System.Drawing.Point(6, 43);
            this.rbMwVanAfd.Name = "rbMwVanAfd";
            this.rbMwVanAfd.Size = new System.Drawing.Size(361, 24);
            this.rbMwVanAfd.TabIndex = 1;
            this.rbMwVanAfd.TabStop = true;
            this.rbMwVanAfd.Text = "Toon medewerkers van een specifieke afdeling ";
            this.rbMwVanAfd.UseVisualStyleBackColor = true;
            // 
            // rbAlleAfd
            // 
            this.rbAlleAfd.AutoSize = true;
            this.rbAlleAfd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbAlleAfd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbAlleAfd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbAlleAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlleAfd.Location = new System.Drawing.Point(6, 19);
            this.rbAlleAfd.Name = "rbAlleAfd";
            this.rbAlleAfd.Size = new System.Drawing.Size(175, 25);
            this.rbAlleAfd.TabIndex = 0;
            this.rbAlleAfd.TabStop = true;
            this.rbAlleAfd.Text = "Toon alle afdelingen";
            this.rbAlleAfd.UseVisualStyleBackColor = true;
            this.rbAlleAfd.CheckedChanged += new System.EventHandler(this.rbAlleAfd_CheckedChanged);
            // 
            // btnBevestingen
            // 
            this.btnBevestingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestingen.Location = new System.Drawing.Point(16, 98);
            this.btnBevestingen.Name = "btnBevestingen";
            this.btnBevestingen.Size = new System.Drawing.Size(134, 32);
            this.btnBevestingen.TabIndex = 12;
            this.btnBevestingen.Text = "Bevestigen";
            this.btnBevestingen.UseVisualStyleBackColor = true;
            this.btnBevestingen.Click += new System.EventHandler(this.btnBevestingen_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(253, 98);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(134, 32);
            this.btnTerug.TabIndex = 13;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // RaadpleegAfdeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 375);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBevestingen);
            this.Controls.Add(this.txtGegevens);
            this.Controls.Add(this.lblGegevens);
            this.Controls.Add(this.lblKiesAfd);
            this.Controls.Add(this.cmbKiesAfd);
            this.Controls.Add(this.lblInfoTekst);
            this.Controls.Add(this.grbRadiobtn);
            this.Name = "RaadpleegAfdeling";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaadpleegAfdeling";
            this.grbRadiobtn.ResumeLayout(false);
            this.grbRadiobtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGegevens;
        private System.Windows.Forms.Label lblGegevens;
        private System.Windows.Forms.Label lblKiesAfd;
        private System.Windows.Forms.ComboBox cmbKiesAfd;
        private System.Windows.Forms.Label lblInfoTekst;
        private System.Windows.Forms.GroupBox grbRadiobtn;
        private System.Windows.Forms.RadioButton rbMwVanAfd;
        private System.Windows.Forms.RadioButton rbAlleAfd;
        private System.Windows.Forms.Button btnBevestingen;
        private System.Windows.Forms.Button btnTerug;
    }
}