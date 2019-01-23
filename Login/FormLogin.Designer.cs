namespace Login
{
    partial class FormLogin
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRep = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRep = new System.Windows.Forms.Label();
            this.buttonAbrechen = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(134, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(200, 20);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(134, 28);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxPasswordRep
            // 
            this.textBoxPasswordRep.Location = new System.Drawing.Point(134, 54);
            this.textBoxPasswordRep.Name = "textBoxPasswordRep";
            this.textBoxPasswordRep.PasswordChar = '*';
            this.textBoxPasswordRep.Size = new System.Drawing.Size(200, 20);
            this.textBoxPasswordRep.TabIndex = 2;
            this.textBoxPasswordRep.Visible = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 5);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(78, 13);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Benutzername:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 35);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Passwort:";
            // 
            // labelPasswordRep
            // 
            this.labelPasswordRep.AutoSize = true;
            this.labelPasswordRep.Location = new System.Drawing.Point(12, 57);
            this.labelPasswordRep.Name = "labelPasswordRep";
            this.labelPasswordRep.Size = new System.Drawing.Size(116, 13);
            this.labelPasswordRep.TabIndex = 5;
            this.labelPasswordRep.Text = "Passwort Wiederholen:";
            this.labelPasswordRep.Visible = false;
            // 
            // buttonAbrechen
            // 
            this.buttonAbrechen.Location = new System.Drawing.Point(178, 94);
            this.buttonAbrechen.Name = "buttonAbrechen";
            this.buttonAbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrechen.TabIndex = 6;
            this.buttonAbrechen.Text = "Abrechen";
            this.buttonAbrechen.UseVisualStyleBackColor = true;
            this.buttonAbrechen.Click += new System.EventHandler(this.buttonAbrechen_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(259, 94);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 138);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonAbrechen);
            this.Controls.Add(this.labelPasswordRep);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPasswordRep);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordRep;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordRep;
        private System.Windows.Forms.Button buttonAbrechen;
        private System.Windows.Forms.Button buttonOK;
    }
}

