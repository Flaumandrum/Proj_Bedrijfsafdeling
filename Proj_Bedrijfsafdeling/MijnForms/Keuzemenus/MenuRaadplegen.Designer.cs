namespace Proj_Bedrijfsafdeling.MijnForms.Keuzemenus
{
    partial class MenuRaadplegen
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
            this.btnRaadplegenMW = new System.Windows.Forms.Button();
            this.btnRaadplegenAfd = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRaadplegenMW
            // 
            this.btnRaadplegenMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaadplegenMW.Location = new System.Drawing.Point(12, 48);
            this.btnRaadplegenMW.Name = "btnRaadplegenMW";
            this.btnRaadplegenMW.Size = new System.Drawing.Size(198, 30);
            this.btnRaadplegenMW.TabIndex = 3;
            this.btnRaadplegenMW.Text = "Medewerkers raadplegen";
            this.btnRaadplegenMW.UseVisualStyleBackColor = true;
            this.btnRaadplegenMW.Click += new System.EventHandler(this.btnRaadplegenMW_Click);
            // 
            // btnRaadplegenAfd
            // 
            this.btnRaadplegenAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaadplegenAfd.Location = new System.Drawing.Point(12, 12);
            this.btnRaadplegenAfd.Name = "btnRaadplegenAfd";
            this.btnRaadplegenAfd.Size = new System.Drawing.Size(198, 30);
            this.btnRaadplegenAfd.TabIndex = 2;
            this.btnRaadplegenAfd.Text = "Afdelingen raadplegen";
            this.btnRaadplegenAfd.UseVisualStyleBackColor = true;
            this.btnRaadplegenAfd.Click += new System.EventHandler(this.btnRaadplegenAfd_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(12, 84);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(198, 30);
            this.btnTerug.TabIndex = 4;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // MenuRaadplegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 125);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRaadplegenMW);
            this.Controls.Add(this.btnRaadplegenAfd);
            this.Name = "MenuRaadplegen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRaadplegen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaadplegenMW;
        private System.Windows.Forms.Button btnRaadplegenAfd;
        private System.Windows.Forms.Button btnTerug;
    }
}