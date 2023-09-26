namespace ИС_Конференция.Interfaces.AuthBoxes
{
    partial class Organizer
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
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.MainTextStr = new System.Windows.Forms.Label();
            this.MainMemberStr = new System.Windows.Forms.Label();
            this.ButtonGetEvents = new System.Windows.Forms.Button();
            this.ButtonGetMembers = new System.Windows.Forms.Button();
            this.ButtonGetJury = new System.Windows.Forms.Button();
            this.GetMyProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarImage
            // 
            this.avatarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarImage.Location = new System.Drawing.Point(12, 12);
            this.avatarImage.Name = "avatarImage";
            this.avatarImage.Size = new System.Drawing.Size(200, 200);
            this.avatarImage.TabIndex = 0;
            this.avatarImage.TabStop = false;
            // 
            // MainTextStr
            // 
            this.MainTextStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextStr.Location = new System.Drawing.Point(218, 12);
            this.MainTextStr.Name = "MainTextStr";
            this.MainTextStr.Size = new System.Drawing.Size(337, 39);
            this.MainTextStr.TabIndex = 2;
            this.MainTextStr.Text = "Доброе утро!";
            this.MainTextStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMemberStr
            // 
            this.MainMemberStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMemberStr.Location = new System.Drawing.Point(218, 51);
            this.MainMemberStr.Name = "MainMemberStr";
            this.MainMemberStr.Size = new System.Drawing.Size(337, 39);
            this.MainMemberStr.TabIndex = 3;
            this.MainMemberStr.Text = "Казанцев Михаил Олегович";
            this.MainMemberStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonGetEvents
            // 
            this.ButtonGetEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGetEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGetEvents.Location = new System.Drawing.Point(218, 98);
            this.ButtonGetEvents.Name = "ButtonGetEvents";
            this.ButtonGetEvents.Size = new System.Drawing.Size(337, 54);
            this.ButtonGetEvents.TabIndex = 7;
            this.ButtonGetEvents.Text = "Мероприятия";
            this.ButtonGetEvents.UseVisualStyleBackColor = true;
            // 
            // ButtonGetMembers
            // 
            this.ButtonGetMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGetMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGetMembers.Location = new System.Drawing.Point(218, 158);
            this.ButtonGetMembers.Name = "ButtonGetMembers";
            this.ButtonGetMembers.Size = new System.Drawing.Size(337, 54);
            this.ButtonGetMembers.TabIndex = 8;
            this.ButtonGetMembers.Text = "Участники";
            this.ButtonGetMembers.UseVisualStyleBackColor = true;
            // 
            // ButtonGetJury
            // 
            this.ButtonGetJury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGetJury.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGetJury.Location = new System.Drawing.Point(218, 218);
            this.ButtonGetJury.Name = "ButtonGetJury";
            this.ButtonGetJury.Size = new System.Drawing.Size(337, 54);
            this.ButtonGetJury.TabIndex = 9;
            this.ButtonGetJury.Text = "Жюри";
            this.ButtonGetJury.UseVisualStyleBackColor = true;
            // 
            // GetMyProfile
            // 
            this.GetMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetMyProfile.Location = new System.Drawing.Point(12, 218);
            this.GetMyProfile.Name = "GetMyProfile";
            this.GetMyProfile.Size = new System.Drawing.Size(200, 54);
            this.GetMyProfile.TabIndex = 10;
            this.GetMyProfile.Text = "Мой профиль";
            this.GetMyProfile.UseVisualStyleBackColor = true;
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 285);
            this.Controls.Add(this.GetMyProfile);
            this.Controls.Add(this.ButtonGetJury);
            this.Controls.Add(this.ButtonGetMembers);
            this.Controls.Add(this.ButtonGetEvents);
            this.Controls.Add(this.MainMemberStr);
            this.Controls.Add(this.MainTextStr);
            this.Controls.Add(this.avatarImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Organizer";
            this.ShowIcon = false;
            this.Text = "Окно организатора";
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarImage;
        private System.Windows.Forms.Label MainTextStr;
        private System.Windows.Forms.Label MainMemberStr;
        private System.Windows.Forms.Button ButtonGetEvents;
        private System.Windows.Forms.Button ButtonGetMembers;
        private System.Windows.Forms.Button ButtonGetJury;
        private System.Windows.Forms.Button GetMyProfile;
    }
}