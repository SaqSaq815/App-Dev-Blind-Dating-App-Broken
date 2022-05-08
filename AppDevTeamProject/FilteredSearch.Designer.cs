
namespace AppDevTeamProject
{
    partial class FilteredSearch
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
            this.matchPrevBtn = new System.Windows.Forms.Button();
            this.matchProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.matchNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchNextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filteredTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchPrevBtn
            // 
            this.matchPrevBtn.Location = new System.Drawing.Point(27, 331);
            this.matchPrevBtn.Name = "matchPrevBtn";
            this.matchPrevBtn.Size = new System.Drawing.Size(84, 44);
            this.matchPrevBtn.TabIndex = 7;
            this.matchPrevBtn.Text = "Previous";
            this.matchPrevBtn.UseVisualStyleBackColor = true;
            this.matchPrevBtn.Click += new System.EventHandler(this.matchPrevBtn_Click);
            // 
            // matchProfilePictureBox
            // 
            this.matchProfilePictureBox.Location = new System.Drawing.Point(25, 44);
            this.matchProfilePictureBox.Name = "matchProfilePictureBox";
            this.matchProfilePictureBox.Size = new System.Drawing.Size(341, 231);
            this.matchProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.matchProfilePictureBox.TabIndex = 6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matchNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(25, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 32);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // matchNextBtn
            // 
            this.matchNextBtn.Location = new System.Drawing.Point(282, 331);
            this.matchNextBtn.Name = "matchNextBtn";
            this.matchNextBtn.Size = new System.Drawing.Size(84, 44);
            this.matchNextBtn.TabIndex = 8;
            this.matchNextBtn.Text = "Next";
            this.matchNextBtn.UseVisualStyleBackColor = true;
            this.matchNextBtn.Click += new System.EventHandler(this.matchNextBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Searching for";
            // 
            // filteredTag
            // 
            this.filteredTag.AutoSize = true;
            this.filteredTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredTag.Location = new System.Drawing.Point(143, 18);
            this.filteredTag.Name = "filteredTag";
            this.filteredTag.Size = new System.Drawing.Size(48, 20);
            this.filteredTag.TabIndex = 11;
            this.filteredTag.Text = "Trais";
            // 
            // FilteredSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 417);
            this.Controls.Add(this.filteredTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchPrevBtn);
            this.Controls.Add(this.matchProfilePictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchNextBtn);
            this.Name = "FilteredSearch";
            this.Text = "FilteredSearch";
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button matchPrevBtn;
        private System.Windows.Forms.PictureBox matchProfilePictureBox;
        private System.Windows.Forms.Label matchNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button matchNextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filteredTag;
    }
}