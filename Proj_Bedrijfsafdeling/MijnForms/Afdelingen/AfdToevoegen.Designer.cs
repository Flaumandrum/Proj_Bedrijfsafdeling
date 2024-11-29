namespace Proj_Bedrijfsafdeling.MijnForms.Afdelingen
{
    partial class AfdToevoegen
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtAfdHoofd = new System.Windows.Forms.TextBox();
            this.txtAfdNaam = new System.Windows.Forms.TextBox();
            this.lblAfdHoofd = new System.Windows.Forms.Label();
            this.lblAfdNaam = new System.Windows.Forms.Label();
            this.lblInfoTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(188, 114);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(119, 31);
            this.btnTerug.TabIndex = 13;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(16, 114);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(119, 31);
            this.btnToevoegen.TabIndex = 12;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // txtAfdHoofd
            // 
            this.txtAfdHoofd.Location = new System.Drawing.Point(154, 79);
            this.txtAfdHoofd.Name = "txtAfdHoofd";
            this.txtAfdHoofd.Size = new System.Drawing.Size(153, 20);
            this.txtAfdHoofd.TabIndex = 11;
            // 
            // txtAfdNaam
            // 
            this.txtAfdNaam.Location = new System.Drawing.Point(154, 46);
            this.txtAfdNaam.Name = "txtAfdNaam";
            this.txtAfdNaam.Size = new System.Drawing.Size(153, 20);
            this.txtAfdNaam.TabIndex = 10;
            // 
            // lblAfdHoofd
            // 
            this.lblAfdHoofd.AutoSize = true;
            this.lblAfdHoofd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfdHoofd.Location = new System.Drawing.Point(12, 77);
            this.lblAfdHoofd.Name = "lblAfdHoofd";
            this.lblAfdHoofd.Size = new System.Drawing.Size(124, 20);
            this.lblAfdHoofd.TabIndex = 9;
            this.lblAfdHoofd.Text = "Afdelingshoofd :";
            // 
            // lblAfdNaam
            // 
            this.lblAfdNaam.AutoSize = true;
            this.lblAfdNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfdNaam.Location = new System.Drawing.Point(12, 44);
            this.lblAfdNaam.Name = "lblAfdNaam";
            this.lblAfdNaam.Size = new System.Drawing.Size(123, 20);
            this.lblAfdNaam.TabIndex = 8;
            this.lblAfdNaam.Text = "Afdelingsnaam :";
            // 
            // lblInfoTekst
            // 
            this.lblInfoTekst.AutoSize = true;
            this.lblInfoTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTekst.Location = new System.Drawing.Point(12, 9);
            this.lblInfoTekst.Name = "lblInfoTekst";
            this.lblInfoTekst.Size = new System.Drawing.Size(232, 20);
            this.lblInfoTekst.TabIndex = 7;
            this.lblInfoTekst.Text = "Vul onderstaande gegevens in :";
            // 
            // AfdToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 168);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtAfdHoofd);
            this.Controls.Add(this.txtAfdNaam);
            this.Controls.Add(this.lblAfdHoofd);
            this.Controls.Add(this.lblAfdNaam);
            this.Controls.Add(this.lblInfoTekst);
            this.Name = "AfdToevoegen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfdToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtAfdHoofd;
        private System.Windows.Forms.TextBox txtAfdNaam;
        private System.Windows.Forms.Label lblAfdHoofd;
        private System.Windows.Forms.Label lblAfdNaam;
        private System.Windows.Forms.Label lblInfoTekst;
    }
}