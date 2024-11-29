namespace Proj_Bedrijfsafdeling.MijnForms.Medewerkers
{
    partial class MwAanpassen
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
            this.lblKiesMw = new System.Windows.Forms.Label();
            this.cmbKiesMw = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKiesAfd = new System.Windows.Forms.ComboBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblInfoTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKiesMw
            // 
            this.lblKiesMw.AutoSize = true;
            this.lblKiesMw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiesMw.Location = new System.Drawing.Point(22, 25);
            this.lblKiesMw.Name = "lblKiesMw";
            this.lblKiesMw.Size = new System.Drawing.Size(310, 20);
            this.lblKiesMw.TabIndex = 0;
            this.lblKiesMw.Text = "Kies de medewerker die je wilt aanpassen :";
            // 
            // cmbKiesMw
            // 
            this.cmbKiesMw.FormattingEnabled = true;
            this.cmbKiesMw.Location = new System.Drawing.Point(25, 48);
            this.cmbKiesMw.Name = "cmbKiesMw";
            this.cmbKiesMw.Size = new System.Drawing.Size(307, 21);
            this.cmbKiesMw.TabIndex = 1;
            this.cmbKiesMw.SelectedIndexChanged += new System.EventHandler(this.cmbKiesMw_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Link deze medewerker aan een afdeling :";
            // 
            // cmbKiesAfd
            // 
            this.cmbKiesAfd.FormattingEnabled = true;
            this.cmbKiesAfd.Location = new System.Drawing.Point(26, 234);
            this.cmbKiesAfd.Name = "cmbKiesAfd";
            this.cmbKiesAfd.Size = new System.Drawing.Size(306, 21);
            this.cmbKiesAfd.TabIndex = 16;
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(213, 270);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(119, 31);
            this.btnTerug.TabIndex = 15;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAanpassen.Location = new System.Drawing.Point(26, 270);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(119, 31);
            this.btnAanpassen.TabIndex = 14;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(164, 169);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(168, 20);
            this.txtAchternaam.TabIndex = 13;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(164, 136);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(168, 20);
            this.txtVoornaam.TabIndex = 12;
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchternaam.Location = new System.Drawing.Point(22, 167);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(104, 20);
            this.lblAchternaam.TabIndex = 11;
            this.lblAchternaam.Text = "Achternaam :";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(22, 134);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(91, 20);
            this.lblVoornaam.TabIndex = 10;
            this.lblVoornaam.Text = "Voornaam :";
            // 
            // lblInfoTekst
            // 
            this.lblInfoTekst.AutoSize = true;
            this.lblInfoTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTekst.Location = new System.Drawing.Point(22, 99);
            this.lblInfoTekst.Name = "lblInfoTekst";
            this.lblInfoTekst.Size = new System.Drawing.Size(205, 20);
            this.lblInfoTekst.TabIndex = 9;
            this.lblInfoTekst.Text = "Vul de nieuwe gegevens in :";
            // 
            // MwAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKiesAfd);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblInfoTekst);
            this.Controls.Add(this.cmbKiesMw);
            this.Controls.Add(this.lblKiesMw);
            this.Name = "MwAanpassen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MwAanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKiesMw;
        private System.Windows.Forms.ComboBox cmbKiesMw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKiesAfd;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblInfoTekst;
    }
}