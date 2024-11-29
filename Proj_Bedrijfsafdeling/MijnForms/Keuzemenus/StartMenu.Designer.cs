namespace Proj_Bedrijfsafdeling
{
    partial class StartMenu
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
            this.btnRaadplegen = new System.Windows.Forms.Button();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRaadplegen
            // 
            this.btnRaadplegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaadplegen.Location = new System.Drawing.Point(12, 12);
            this.btnRaadplegen.Name = "btnRaadplegen";
            this.btnRaadplegen.Size = new System.Drawing.Size(187, 30);
            this.btnRaadplegen.TabIndex = 0;
            this.btnRaadplegen.Text = "Gegevens raadplegen";
            this.btnRaadplegen.UseVisualStyleBackColor = true;
            this.btnRaadplegen.Click += new System.EventHandler(this.btnRaadplegen_Click);
            // 
            // btnBewerken
            // 
            this.btnBewerken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewerken.Location = new System.Drawing.Point(12, 48);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(187, 30);
            this.btnBewerken.TabIndex = 1;
            this.btnBewerken.Text = "Gegevens bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 90);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnRaadplegen);
            this.Name = "StartMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaadplegen;
        private System.Windows.Forms.Button btnBewerken;
    }
}

