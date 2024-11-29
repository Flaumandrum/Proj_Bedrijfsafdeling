namespace Proj_Bedrijfsafdeling.MijnForms.Afdelingen
{
    partial class AfdAanpassen
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
            this.lblKiesAfd = new System.Windows.Forms.Label();
            this.cmbKiesAfd = new System.Windows.Forms.ComboBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtAfdHoofd = new System.Windows.Forms.TextBox();
            this.txtAfdNaam = new System.Windows.Forms.TextBox();
            this.lblAfdHoofd = new System.Windows.Forms.Label();
            this.lblAfdNaam = new System.Windows.Forms.Label();
            this.lblInfoTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKiesAfd
            // 
            this.lblKiesAfd.AutoSize = true;
            this.lblKiesAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiesAfd.Location = new System.Drawing.Point(13, 13);
            this.lblKiesAfd.Name = "lblKiesAfd";
            this.lblKiesAfd.Size = new System.Drawing.Size(323, 20);
            this.lblKiesAfd.TabIndex = 0;
            this.lblKiesAfd.Text = "Kies de Afdeling die je zou willen aanpassen:";
            // 
            // cmbKiesAfd
            // 
            this.cmbKiesAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKiesAfd.FormattingEnabled = true;
            this.cmbKiesAfd.Location = new System.Drawing.Point(17, 46);
            this.cmbKiesAfd.Name = "cmbKiesAfd";
            this.cmbKiesAfd.Size = new System.Drawing.Size(319, 28);
            this.cmbKiesAfd.TabIndex = 1;
            this.cmbKiesAfd.SelectedIndexChanged += new System.EventHandler(this.cmbKiesAfd_SelectedIndexChanged);
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(217, 194);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(119, 31);
            this.btnTerug.TabIndex = 20;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAanpassen.Location = new System.Drawing.Point(17, 194);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(119, 31);
            this.btnAanpassen.TabIndex = 19;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // txtAfdHoofd
            // 
            this.txtAfdHoofd.Location = new System.Drawing.Point(155, 159);
            this.txtAfdHoofd.Name = "txtAfdHoofd";
            this.txtAfdHoofd.Size = new System.Drawing.Size(181, 20);
            this.txtAfdHoofd.TabIndex = 18;
            // 
            // txtAfdNaam
            // 
            this.txtAfdNaam.Location = new System.Drawing.Point(155, 126);
            this.txtAfdNaam.Name = "txtAfdNaam";
            this.txtAfdNaam.Size = new System.Drawing.Size(181, 20);
            this.txtAfdNaam.TabIndex = 17;
            // 
            // lblAfdHoofd
            // 
            this.lblAfdHoofd.AutoSize = true;
            this.lblAfdHoofd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfdHoofd.Location = new System.Drawing.Point(13, 157);
            this.lblAfdHoofd.Name = "lblAfdHoofd";
            this.lblAfdHoofd.Size = new System.Drawing.Size(124, 20);
            this.lblAfdHoofd.TabIndex = 16;
            this.lblAfdHoofd.Text = "Afdelingshoofd :";
            // 
            // lblAfdNaam
            // 
            this.lblAfdNaam.AutoSize = true;
            this.lblAfdNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfdNaam.Location = new System.Drawing.Point(13, 124);
            this.lblAfdNaam.Name = "lblAfdNaam";
            this.lblAfdNaam.Size = new System.Drawing.Size(123, 20);
            this.lblAfdNaam.TabIndex = 15;
            this.lblAfdNaam.Text = "Afdelingsnaam :";
            // 
            // lblInfoTekst
            // 
            this.lblInfoTekst.AutoSize = true;
            this.lblInfoTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTekst.Location = new System.Drawing.Point(13, 89);
            this.lblInfoTekst.Name = "lblInfoTekst";
            this.lblInfoTekst.Size = new System.Drawing.Size(205, 20);
            this.lblInfoTekst.TabIndex = 14;
            this.lblInfoTekst.Text = "Vul de nieuwe gegevens in :";
            // 
            // AfdAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 239);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtAfdHoofd);
            this.Controls.Add(this.txtAfdNaam);
            this.Controls.Add(this.lblAfdHoofd);
            this.Controls.Add(this.lblAfdNaam);
            this.Controls.Add(this.lblInfoTekst);
            this.Controls.Add(this.cmbKiesAfd);
            this.Controls.Add(this.lblKiesAfd);
            this.Name = "AfdAanpassen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfdAanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKiesAfd;
        private System.Windows.Forms.ComboBox cmbKiesAfd;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtAfdHoofd;
        private System.Windows.Forms.TextBox txtAfdNaam;
        private System.Windows.Forms.Label lblAfdHoofd;
        private System.Windows.Forms.Label lblAfdNaam;
        private System.Windows.Forms.Label lblInfoTekst;
    }
}