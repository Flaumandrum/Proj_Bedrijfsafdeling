namespace Proj_Bedrijfsafdeling.MijnForms.Afdelingen
{
    partial class AfdVerwijderen
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
            this.cmbKiesAfd = new System.Windows.Forms.ComboBox();
            this.lblKiesAfd = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKiesAfd
            // 
            this.cmbKiesAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKiesAfd.FormattingEnabled = true;
            this.cmbKiesAfd.Location = new System.Drawing.Point(16, 42);
            this.cmbKiesAfd.Name = "cmbKiesAfd";
            this.cmbKiesAfd.Size = new System.Drawing.Size(319, 28);
            this.cmbKiesAfd.TabIndex = 3;
            // 
            // lblKiesAfd
            // 
            this.lblKiesAfd.AutoSize = true;
            this.lblKiesAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiesAfd.Location = new System.Drawing.Point(12, 9);
            this.lblKiesAfd.Name = "lblKiesAfd";
            this.lblKiesAfd.Size = new System.Drawing.Size(323, 20);
            this.lblKiesAfd.TabIndex = 2;
            this.lblKiesAfd.Text = "Kies de Afdeling die je zou willen aanpassen:";
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(216, 91);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(119, 31);
            this.btnTerug.TabIndex = 22;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.Location = new System.Drawing.Point(16, 91);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(119, 31);
            this.btnVerwijderen.TabIndex = 21;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // AfdVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 142);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.cmbKiesAfd);
            this.Controls.Add(this.lblKiesAfd);
            this.Name = "AfdVerwijderen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfdVerwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKiesAfd;
        private System.Windows.Forms.Label lblKiesAfd;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}