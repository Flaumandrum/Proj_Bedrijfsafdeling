namespace Proj_Bedrijfsafdeling.MijnForms.Medewerkers
{
    partial class MwVerwijderen
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
            this.cmbKiesMw = new System.Windows.Forms.ComboBox();
            this.lblKiesMw = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKiesMw
            // 
            this.cmbKiesMw.FormattingEnabled = true;
            this.cmbKiesMw.Location = new System.Drawing.Point(15, 43);
            this.cmbKiesMw.Name = "cmbKiesMw";
            this.cmbKiesMw.Size = new System.Drawing.Size(307, 21);
            this.cmbKiesMw.TabIndex = 3;
            // 
            // lblKiesMw
            // 
            this.lblKiesMw.AutoSize = true;
            this.lblKiesMw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiesMw.Location = new System.Drawing.Point(12, 20);
            this.lblKiesMw.Name = "lblKiesMw";
            this.lblKiesMw.Size = new System.Drawing.Size(310, 20);
            this.lblKiesMw.TabIndex = 2;
            this.lblKiesMw.Text = "Kies de medewerker die je wilt verwijderen :";
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(203, 81);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(119, 31);
            this.btnTerug.TabIndex = 17;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.Location = new System.Drawing.Point(16, 81);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(119, 31);
            this.btnVerwijderen.TabIndex = 16;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // MwVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 128);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.cmbKiesMw);
            this.Controls.Add(this.lblKiesMw);
            this.Name = "MwVerwijderen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MwVerwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKiesMw;
        private System.Windows.Forms.Label lblKiesMw;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}