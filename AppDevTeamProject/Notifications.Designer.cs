
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
            this.SuspendLayout();
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsLabel.Location = new System.Drawing.Point(58, 33);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(210, 24);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "You have ## Matches";
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
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 158);
            this.Controls.Add(this.notificationsCancelBtn);
            this.Controls.Add(this.notificationsViewBtn);
            this.Controls.Add(this.notificationsLabel);
            this.Name = "Notifications";
            this.Text = "Notifications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Button notificationsViewBtn;
        private System.Windows.Forms.Button notificationsCancelBtn;
    }
}