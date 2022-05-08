
namespace AppDevTeamProject
{
    partial class matchProfile
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.matchedPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mpReportBtn = new System.Windows.Forms.Button();
            this.matchedAcceptBtn = new System.Windows.Forms.Button();
            this.matchedDeclineBtn = new System.Windows.Forms.Button();
            this.matchedProfSendBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchedLocationTextBox = new System.Windows.Forms.TextBox();
            this.matchedGenderTextBox = new System.Windows.Forms.TextBox();
            this.matchedAgeTextBox = new System.Windows.Forms.TextBox();
            this.matchedLastNameTextBox = new System.Windows.Forms.TextBox();
            this.locationlbl = new System.Windows.Forms.Label();
            this.matchedFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.genderlbl = new System.Windows.Forms.Label();
            this.matchedTraitsTextBox = new System.Windows.Forms.TextBox();
            this.matchedLikesTextBox = new System.Windows.Forms.TextBox();
            this.agelbl = new System.Windows.Forms.Label();
            this.traitslbl = new System.Windows.Forms.Label();
            this.likeslbl = new System.Windows.Forms.Label();
            this.lNamelbl = new System.Windows.Forms.Label();
            this.fNamelbl = new System.Windows.Forms.Label();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchedPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.matchedPictureBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 253);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // matchedPictureBox
            // 
            this.matchedPictureBox.Location = new System.Drawing.Point(22, 4);
            this.matchedPictureBox.Name = "matchedPictureBox";
            this.matchedPictureBox.Size = new System.Drawing.Size(314, 243);
            this.matchedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.matchedPictureBox.TabIndex = 0;
            this.matchedPictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // mpReportBtn
            // 
            this.mpReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpReportBtn.Location = new System.Drawing.Point(713, 12);
            this.mpReportBtn.Name = "mpReportBtn";
            this.mpReportBtn.Size = new System.Drawing.Size(75, 26);
            this.mpReportBtn.TabIndex = 19;
            this.mpReportBtn.Text = "Report";
            this.mpReportBtn.UseVisualStyleBackColor = true;
            this.mpReportBtn.Click += new System.EventHandler(this.mpReportBtn_Click);
            // 
            // matchedAcceptBtn
            // 
            this.matchedAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchedAcceptBtn.Location = new System.Drawing.Point(707, 482);
            this.matchedAcceptBtn.Name = "matchedAcceptBtn";
            this.matchedAcceptBtn.Size = new System.Drawing.Size(81, 32);
            this.matchedAcceptBtn.TabIndex = 20;
            this.matchedAcceptBtn.Text = "Accept";
            this.matchedAcceptBtn.UseVisualStyleBackColor = true;
            this.matchedAcceptBtn.Click += new System.EventHandler(this.thumbsDownBtn_Click);
            // 
            // matchedDeclineBtn
            // 
            this.matchedDeclineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchedDeclineBtn.Location = new System.Drawing.Point(597, 482);
            this.matchedDeclineBtn.Name = "matchedDeclineBtn";
            this.matchedDeclineBtn.Size = new System.Drawing.Size(79, 32);
            this.matchedDeclineBtn.TabIndex = 21;
            this.matchedDeclineBtn.Text = "Decline";
            this.matchedDeclineBtn.UseVisualStyleBackColor = true;
            this.matchedDeclineBtn.Click += new System.EventHandler(this.thumbsUpBtn_Click);
            // 
            // matchedProfSendBtn
            // 
            this.matchedProfSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchedProfSendBtn.Location = new System.Drawing.Point(34, 481);
            this.matchedProfSendBtn.Name = "matchedProfSendBtn";
            this.matchedProfSendBtn.Size = new System.Drawing.Size(173, 32);
            this.matchedProfSendBtn.TabIndex = 20;
            this.matchedProfSendBtn.Text = "Send a message";
            this.matchedProfSendBtn.UseVisualStyleBackColor = true;
            this.matchedProfSendBtn.Click += new System.EventHandler(this.matchedProfSendBtnNow);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.matchedLocationTextBox);
            this.groupBox1.Controls.Add(this.matchedGenderTextBox);
            this.groupBox1.Controls.Add(this.matchedAgeTextBox);
            this.groupBox1.Controls.Add(this.matchedLastNameTextBox);
            this.groupBox1.Controls.Add(this.locationlbl);
            this.groupBox1.Controls.Add(this.matchedFirstNameTextBox);
            this.groupBox1.Controls.Add(this.genderlbl);
            this.groupBox1.Controls.Add(this.matchedTraitsTextBox);
            this.groupBox1.Controls.Add(this.matchedLikesTextBox);
            this.groupBox1.Controls.Add(this.agelbl);
            this.groupBox1.Controls.Add(this.traitslbl);
            this.groupBox1.Controls.Add(this.likeslbl);
            this.groupBox1.Controls.Add(this.lNamelbl);
            this.groupBox1.Controls.Add(this.fNamelbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(426, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 422);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // matchedLocationTextBox
            // 
            this.matchedLocationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.matchedLocationTextBox.Location = new System.Drawing.Point(117, 143);
            this.matchedLocationTextBox.Name = "matchedLocationTextBox";
            this.matchedLocationTextBox.ReadOnly = true;
            this.matchedLocationTextBox.Size = new System.Drawing.Size(228, 22);
            this.matchedLocationTextBox.TabIndex = 16;
            // 
            // matchedGenderTextBox
            // 
            this.matchedGenderTextBox.Location = new System.Drawing.Point(117, 115);
            this.matchedGenderTextBox.Name = "matchedGenderTextBox";
            this.matchedGenderTextBox.ReadOnly = true;
            this.matchedGenderTextBox.Size = new System.Drawing.Size(77, 22);
            this.matchedGenderTextBox.TabIndex = 16;
            // 
            // matchedAgeTextBox
            // 
            this.matchedAgeTextBox.Location = new System.Drawing.Point(117, 84);
            this.matchedAgeTextBox.Name = "matchedAgeTextBox";
            this.matchedAgeTextBox.ReadOnly = true;
            this.matchedAgeTextBox.Size = new System.Drawing.Size(77, 22);
            this.matchedAgeTextBox.TabIndex = 16;
            // 
            // matchedLastNameTextBox
            // 
            this.matchedLastNameTextBox.Location = new System.Drawing.Point(117, 54);
            this.matchedLastNameTextBox.Name = "matchedLastNameTextBox";
            this.matchedLastNameTextBox.ReadOnly = true;
            this.matchedLastNameTextBox.Size = new System.Drawing.Size(228, 22);
            this.matchedLastNameTextBox.TabIndex = 16;
            // 
            // locationlbl
            // 
            this.locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationlbl.Location = new System.Drawing.Point(8, 146);
            this.locationlbl.Name = "locationlbl";
            this.locationlbl.Size = new System.Drawing.Size(82, 19);
            this.locationlbl.TabIndex = 7;
            this.locationlbl.Text = "Location:";
            // 
            // matchedFirstNameTextBox
            // 
            this.matchedFirstNameTextBox.Location = new System.Drawing.Point(117, 20);
            this.matchedFirstNameTextBox.Name = "matchedFirstNameTextBox";
            this.matchedFirstNameTextBox.ReadOnly = true;
            this.matchedFirstNameTextBox.Size = new System.Drawing.Size(228, 22);
            this.matchedFirstNameTextBox.TabIndex = 16;
            // 
            // genderlbl
            // 
            this.genderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlbl.Location = new System.Drawing.Point(8, 118);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(59, 19);
            this.genderlbl.TabIndex = 7;
            this.genderlbl.Text = "Gender:";
            // 
            // matchedTraitsTextBox
            // 
            this.matchedTraitsTextBox.Location = new System.Drawing.Point(10, 200);
            this.matchedTraitsTextBox.Multiline = true;
            this.matchedTraitsTextBox.Name = "matchedTraitsTextBox";
            this.matchedTraitsTextBox.ReadOnly = true;
            this.matchedTraitsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matchedTraitsTextBox.Size = new System.Drawing.Size(315, 92);
            this.matchedTraitsTextBox.TabIndex = 15;
            // 
            // matchedLikesTextBox
            // 
            this.matchedLikesTextBox.Location = new System.Drawing.Point(10, 318);
            this.matchedLikesTextBox.Multiline = true;
            this.matchedLikesTextBox.Name = "matchedLikesTextBox";
            this.matchedLikesTextBox.ReadOnly = true;
            this.matchedLikesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matchedLikesTextBox.Size = new System.Drawing.Size(315, 92);
            this.matchedLikesTextBox.TabIndex = 15;
            // 
            // agelbl
            // 
            this.agelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelbl.Location = new System.Drawing.Point(8, 87);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(85, 19);
            this.agelbl.TabIndex = 7;
            this.agelbl.Text = "Age:";
            // 
            // traitslbl
            // 
            this.traitslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traitslbl.Location = new System.Drawing.Point(6, 177);
            this.traitslbl.Name = "traitslbl";
            this.traitslbl.Size = new System.Drawing.Size(84, 19);
            this.traitslbl.TabIndex = 6;
            this.traitslbl.Text = "Traits:";
            // 
            // likeslbl
            // 
            this.likeslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeslbl.Location = new System.Drawing.Point(6, 295);
            this.likeslbl.Name = "likeslbl";
            this.likeslbl.Size = new System.Drawing.Size(84, 19);
            this.likeslbl.TabIndex = 6;
            this.likeslbl.Text = "Likes";
            // 
            // lNamelbl
            // 
            this.lNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNamelbl.Location = new System.Drawing.Point(6, 57);
            this.lNamelbl.Name = "lNamelbl";
            this.lNamelbl.Size = new System.Drawing.Size(87, 19);
            this.lNamelbl.TabIndex = 4;
            this.lNamelbl.Text = "Last Name";
            // 
            // fNamelbl
            // 
            this.fNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNamelbl.Location = new System.Drawing.Point(6, 23);
            this.fNamelbl.Name = "fNamelbl";
            this.fNamelbl.Size = new System.Drawing.Size(87, 19);
            this.fNamelbl.TabIndex = 4;
            this.fNamelbl.Text = "First Name";
            // 
            // bioTextBox
            // 
            this.bioTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bioTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioTextBox.Location = new System.Drawing.Point(28, 293);
            this.bioTextBox.Multiline = true;
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bioTextBox.Size = new System.Drawing.Size(349, 123);
            this.bioTextBox.TabIndex = 23;
            // 
            // matchProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 534);
            this.Controls.Add(this.bioTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchedProfSendBtn);
            this.Controls.Add(this.matchedDeclineBtn);
            this.Controls.Add(this.matchedAcceptBtn);
            this.Controls.Add(this.mpReportBtn);
            this.Controls.Add(this.groupBox2);
            this.Name = "matchProfile";
            this.Text = "Matched Profile";
            this.Load += new System.EventHandler(this.matchProfile_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchedPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button mpReportBtn;
        private System.Windows.Forms.Button matchedAcceptBtn;
        private System.Windows.Forms.Button matchedDeclineBtn;
        private System.Windows.Forms.PictureBox matchedPictureBox;
        private System.Windows.Forms.Button matchedProfSendBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox matchedLocationTextBox;
        private System.Windows.Forms.TextBox matchedGenderTextBox;
        private System.Windows.Forms.TextBox matchedAgeTextBox;
        private System.Windows.Forms.TextBox matchedLastNameTextBox;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.TextBox matchedFirstNameTextBox;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.TextBox matchedTraitsTextBox;
        private System.Windows.Forms.TextBox matchedLikesTextBox;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label traitslbl;
        private System.Windows.Forms.Label likeslbl;
        private System.Windows.Forms.Label lNamelbl;
        private System.Windows.Forms.Label fNamelbl;
        private System.Windows.Forms.TextBox bioTextBox;
    }
}