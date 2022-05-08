
namespace AppDevTeamProject
{
    partial class Notifications
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
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.notificationsViewBtn = new System.Windows.Forms.Button();
            this.notificationsCancelBtn = new System.Windows.Forms.Button();
            this.notifMatchCounLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsLabel.Location = new System.Drawing.Point(106, 33);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(77, 24);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "Found:";
            // 
            // notificationsViewBtn
            // 
            this.notificationsViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsViewBtn.Location = new System.Drawing.Point(59, 98);
            this.notificationsViewBtn.Name = "notificationsViewBtn";
            this.notificationsViewBtn.Size = new System.Drawing.Size(89, 27);
            this.notificationsViewBtn.TabIndex = 1;
            this.notificationsViewBtn.Text = "View";
            this.notificationsViewBtn.UseVisualStyleBackColor = true;
            this.notificationsViewBtn.Click += new System.EventHandler(this.notificationsViewBtn_Click);
            // 
            // notificationsCancelBtn
            // 
            this.notificationsCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsCancelBtn.Location = new System.Drawing.Point(178, 98);
            this.notificationsCancelBtn.Name = "notificationsCancelBtn";
            this.notificationsCancelBtn.Size = new System.Drawing.Size(89, 27);
            this.notificationsCancelBtn.TabIndex = 2;
            this.notificationsCancelBtn.Text = "Cancel";
            this.notificationsCancelBtn.UseVisualStyleBackColor = true;
            this.notificationsCancelBtn.Click += new System.EventHandler(this.notificationsCancelBtn_Click);
            // 
            // notifMatchCounLabel
            // 
            this.notifMatchCounLabel.AutoSize = true;
            this.notifMatchCounLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifMatchCounLabel.Location = new System.Drawing.Point(199, 33);
            this.notifMatchCounLabel.Name = "notifMatchCounLabel";
            this.notifMatchCounLabel.Size = new System.Drawing.Size(21, 24);
            this.notifMatchCounLabel.TabIndex = 0;
            this.notifMatchCounLabel.Text = "0";
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 158);
            this.Controls.Add(this.notificationsCancelBtn);
            this.Controls.Add(this.notificationsViewBtn);
            this.Controls.Add(this.notifMatchCounLabel);
            this.Controls.Add(this.notificationsLabel);
            this.Name = "Notifications";
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Button notificationsViewBtn;
        private System.Windows.Forms.Button notificationsCancelBtn;
        private System.Windows.Forms.Label notifMatchCounLabel;
    }
}