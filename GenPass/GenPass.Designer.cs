namespace PwdGenerator
{
    partial class GenPass
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenPass));
            this.CaracLabel = new System.Windows.Forms.Label();
            this.PwdGenLabel = new System.Windows.Forms.Label();
            this.genBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.genLetterMajBtn = new System.Windows.Forms.Button();
            this.genNbBtn = new System.Windows.Forms.Button();
            this.nbCaracTxtBox = new System.Windows.Forms.TextBox();
            this.pwdGenTxtBox = new System.Windows.Forms.TextBox();
            this.genLetterMinBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaracLabel
            // 
            this.CaracLabel.AutoSize = true;
            this.CaracLabel.Location = new System.Drawing.Point(50, 50);
            this.CaracLabel.Name = "CaracLabel";
            this.CaracLabel.Size = new System.Drawing.Size(118, 13);
            this.CaracLabel.TabIndex = 0;
            this.CaracLabel.Text = "Nombre de caractères :";
            // 
            // PwdGenLabel
            // 
            this.PwdGenLabel.AutoSize = true;
            this.PwdGenLabel.Location = new System.Drawing.Point(50, 100);
            this.PwdGenLabel.Name = "PwdGenLabel";
            this.PwdGenLabel.Size = new System.Drawing.Size(113, 13);
            this.PwdGenLabel.TabIndex = 0;
            this.PwdGenLabel.Text = "Mot de passe généré :";
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(300, 150);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(150, 25);
            this.genBtn.TabIndex = 1;
            this.genBtn.Text = "Générer";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(50, 150);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(150, 25);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quitter";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // genLetterMajBtn
            // 
            this.genLetterMajBtn.Location = new System.Drawing.Point(50, 225);
            this.genLetterMajBtn.Name = "genLetterMajBtn";
            this.genLetterMajBtn.Size = new System.Drawing.Size(400, 25);
            this.genLetterMajBtn.TabIndex = 1;
            this.genLetterMajBtn.Text = "Générer lettres majuscules";
            this.genLetterMajBtn.UseVisualStyleBackColor = true;
            this.genLetterMajBtn.Click += new System.EventHandler(this.genLetterBtn_Click);
            // 
            // genNbBtn
            // 
            this.genNbBtn.Location = new System.Drawing.Point(50, 300);
            this.genNbBtn.Name = "genNbBtn";
            this.genNbBtn.Size = new System.Drawing.Size(400, 25);
            this.genNbBtn.TabIndex = 1;
            this.genNbBtn.Text = "Générer chiffres";
            this.genNbBtn.UseVisualStyleBackColor = true;
            this.genNbBtn.Click += new System.EventHandler(this.genNbBtn_Click);
            // 
            // nbCaracTxtBox
            // 
            this.nbCaracTxtBox.Location = new System.Drawing.Point(178, 48);
            this.nbCaracTxtBox.Name = "nbCaracTxtBox";
            this.nbCaracTxtBox.Size = new System.Drawing.Size(272, 20);
            this.nbCaracTxtBox.TabIndex = 2;
            // 
            // pwdGenTxtBox
            // 
            this.pwdGenTxtBox.Location = new System.Drawing.Point(177, 98);
            this.pwdGenTxtBox.Name = "pwdGenTxtBox";
            this.pwdGenTxtBox.Size = new System.Drawing.Size(273, 20);
            this.pwdGenTxtBox.TabIndex = 2;
            this.pwdGenTxtBox.UseSystemPasswordChar = true;
            // 
            // genLetterMinBtn
            // 
            this.genLetterMinBtn.Location = new System.Drawing.Point(50, 260);
            this.genLetterMinBtn.Name = "genLetterMinBtn";
            this.genLetterMinBtn.Size = new System.Drawing.Size(400, 25);
            this.genLetterMinBtn.TabIndex = 1;
            this.genLetterMinBtn.Text = "Générer lettres minuscules";
            this.genLetterMinBtn.UseVisualStyleBackColor = true;
            this.genLetterMinBtn.Click += new System.EventHandler(this.genLetterMinBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "***";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwdGenTxtBox);
            this.Controls.Add(this.nbCaracTxtBox);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.genNbBtn);
            this.Controls.Add(this.genLetterMinBtn);
            this.Controls.Add(this.genLetterMajBtn);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.PwdGenLabel);
            this.Controls.Add(this.CaracLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Générateur de mots de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaracLabel;
        private System.Windows.Forms.Label PwdGenLabel;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button genLetterMajBtn;
        private System.Windows.Forms.Button genNbBtn;
        private System.Windows.Forms.TextBox nbCaracTxtBox;
        private System.Windows.Forms.TextBox pwdGenTxtBox;
        private System.Windows.Forms.Button genLetterMinBtn;
        private System.Windows.Forms.Button button1;
    }
}

