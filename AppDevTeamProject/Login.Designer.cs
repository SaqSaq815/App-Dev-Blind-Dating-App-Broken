
namespace AppDevTeamProject
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alertInvalidAccountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Location = new System.Drawing.Point(65, 90);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(318, 20);
            this.loginUsernameTextBox.TabIndex = 2;
            // 
            // loginPasswordTextbox
            // 
            this.loginPasswordTextbox.Location = new System.Drawing.Point(65, 160);
            this.loginPasswordTextbox.Name = "loginPasswordTextbox";
            this.loginPasswordTextbox.Size = new System.Drawing.Size(318, 20);
            this.loginPasswordTextbox.TabIndex = 3;
            this.loginPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(308, 198);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 26);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Login";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alertInvalidAccountLabel
            // 
            this.alertInvalidAccountLabel.AutoSize = true;
            this.alertInvalidAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.alertInvalidAccountLabel.ForeColor = System.Drawing.Color.Red;
            this.alertInvalidAccountLabel.Location = new System.Drawing.Point(65, 198);
            this.alertInvalidAccountLabel.Name = "alertInvalidAccountLabel";
            this.alertInvalidAccountLabel.Size = new System.Drawing.Size(115, 13);
            this.alertInvalidAccountLabel.TabIndex = 6;
            this.alertInvalidAccountLabel.Text = "Account doesn\'t Exist! ";
            this.alertInvalidAccountLabel.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 236);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
            this.Controls.Add(this.alertInvalidAccountLabel);
>>>>>>> Stashed changes
=======
            this.Controls.Add(this.alertInvalidAccountLabel);
>>>>>>> Stashed changes
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.loginPasswordTextbox);
            this.Controls.Add(this.loginUsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Enabled = false;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextbox;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label alertInvalidAccountLabel;
    }
}