
namespace AppDevTeamProject
{
    partial class Welcome
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
            this.newUserBtn = new System.Windows.Forms.Button();
            this.alreadyMemberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(56, 81);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(121, 45);
            this.newUserBtn.TabIndex = 0;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = true;
            // 
            // alreadyMemberBtn
            // 
            this.alreadyMemberBtn.Location = new System.Drawing.Point(230, 81);
            this.alreadyMemberBtn.Name = "alreadyMemberBtn";
            this.alreadyMemberBtn.Size = new System.Drawing.Size(121, 45);
            this.alreadyMemberBtn.TabIndex = 1;
            this.alreadyMemberBtn.Text = "Already a Member";
            this.alreadyMemberBtn.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 206);
            this.Controls.Add(this.alreadyMemberBtn);
            this.Controls.Add(this.newUserBtn);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Button alreadyMemberBtn;
    }
}

