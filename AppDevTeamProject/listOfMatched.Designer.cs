
namespace AppDevTeamProject
{
    partial class listOfMatched
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
            this.matchProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.matchNameLabel = new System.Windows.Forms.Label();
            this.matchPrevBtn = new System.Windows.Forms.Button();
            this.matchVisitBtn = new System.Windows.Forms.Button();
            this.matchNextBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are matched with";
            // 
            // matchProfilePictureBox
            // 
            this.matchProfilePictureBox.Location = new System.Drawing.Point(46, 65);
            this.matchProfilePictureBox.Name = "matchProfilePictureBox";
            this.matchProfilePictureBox.Size = new System.Drawing.Size(341, 231);
            this.matchProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.matchProfilePictureBox.TabIndex = 2;
            this.matchProfilePictureBox.TabStop = false;
            // 
            // matchNameLabel
            // 
            this.matchNameLabel.AutoEllipsis = true;
            this.matchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchNameLabel.Location = new System.Drawing.Point(89, 9);
            this.matchNameLabel.Name = "matchNameLabel";
            this.matchNameLabel.Size = new System.Drawing.Size(161, 20);
            this.matchNameLabel.TabIndex = 3;
            this.matchNameLabel.Text = "name";
            this.matchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchPrevBtn
            // 
            this.matchPrevBtn.Location = new System.Drawing.Point(46, 352);
            this.matchPrevBtn.Name = "matchPrevBtn";
            this.matchPrevBtn.Size = new System.Drawing.Size(84, 44);
            this.matchPrevBtn.TabIndex = 4;
            this.matchPrevBtn.Text = "Previous";
            this.matchPrevBtn.UseVisualStyleBackColor = true;
            this.matchPrevBtn.Click += new System.EventHandler(this.matchPrevBtn_Click);
            // 
            // matchVisitBtn
            // 
            this.matchVisitBtn.Location = new System.Drawing.Point(165, 352);
            this.matchVisitBtn.Name = "matchVisitBtn";
            this.matchVisitBtn.Size = new System.Drawing.Size(84, 44);
            this.matchVisitBtn.TabIndex = 4;
            this.matchVisitBtn.Text = "visit profile";
            this.matchVisitBtn.UseVisualStyleBackColor = true;
            this.matchVisitBtn.Click += new System.EventHandler(this.matchVisitBtn_Click);
            // 
            // matchNextBtn
            // 
            this.matchNextBtn.Location = new System.Drawing.Point(303, 352);
            this.matchNextBtn.Name = "matchNextBtn";
            this.matchNextBtn.Size = new System.Drawing.Size(84, 44);
            this.matchNextBtn.TabIndex = 4;
            this.matchNextBtn.Text = "Next";
            this.matchNextBtn.UseVisualStyleBackColor = true;
            this.matchNextBtn.Click += new System.EventHandler(this.matchNextBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matchNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(46, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 32);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // listOfMatched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchNextBtn);
            this.Controls.Add(this.matchVisitBtn);
            this.Controls.Add(this.matchPrevBtn);
            this.Controls.Add(this.matchProfilePictureBox);
            this.Controls.Add(this.label1);
            this.Name = "listOfMatched";
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.ListOfMatched_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox matchProfilePictureBox;
        private System.Windows.Forms.Label matchNameLabel;
        private System.Windows.Forms.Button matchPrevBtn;
        private System.Windows.Forms.Button matchVisitBtn;
        private System.Windows.Forms.Button matchNextBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}