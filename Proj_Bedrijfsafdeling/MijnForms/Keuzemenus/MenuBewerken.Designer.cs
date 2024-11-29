namespace Proj_Bedrijfsafdeling.MijnForms.Keuzemenus
{
    partial class MenuBewerken
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
            this.btnBewerkMw = new System.Windows.Forms.Button();
            this.btnBewerkAfd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(12, 84);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(198, 30);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnBewerkMw
            // 
            this.btnBewerkMw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewerkMw.Location = new System.Drawing.Point(12, 48);
            this.btnBewerkMw.Name = "btnBewerkMw";
            this.btnBewerkMw.Size = new System.Drawing.Size(198, 30);
            this.btnBewerkMw.TabIndex = 6;
            this.btnBewerkMw.Text = "Medewerkers bewerken";
            this.btnBewerkMw.UseVisualStyleBackColor = true;
            this.btnBewerkMw.Click += new System.EventHandler(this.btnBewerkMw_Click);
            // 
            // btnBewerkAfd
            // 
            this.btnBewerkAfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewerkAfd.Location = new System.Drawing.Point(12, 12);
            this.btnBewerkAfd.Name = "btnBewerkAfd";
            this.btnBewerkAfd.Size = new System.Drawing.Size(198, 30);
            this.btnBewerkAfd.TabIndex = 5;
            this.btnBewerkAfd.Text = "Afdelingen bewerken";
            this.btnBewerkAfd.UseVisualStyleBackColor = true;
            this.btnBewerkAfd.Click += new System.EventHandler(this.btnBewerkAfd_Click);
            // 
            // MenuBewerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 126);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBewerkMw);
            this.Controls.Add(this.btnBewerkAfd);
            this.Name = "MenuBewerken";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuBewerken";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnBewerkMw;
        private System.Windows.Forms.Button btnBewerkAfd;
    }
}