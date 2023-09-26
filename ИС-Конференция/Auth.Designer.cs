using System.Drawing;

namespace ИС_Конференция
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputId = new System.Windows.Forms.TextBox();
            this.MainTextStr = new System.Windows.Forms.Label();
            this.MainAuthStr = new System.Windows.Forms.Label();
            this.InputIdStr = new System.Windows.Forms.Label();
            this.InputPasswordStr = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.ButtonOnLogin = new System.Windows.Forms.Button();
            this.RememberMeCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // InputId
            // 
            this.InputId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputId.Location = new System.Drawing.Point(325, 122);
            this.InputId.Name = "InputId";
            this.InputId.Size = new System.Drawing.Size(333, 31);
            this.InputId.TabIndex = 0;
            // 
            // MainTextStr
            // 
            this.MainTextStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextStr.Location = new System.Drawing.Point(12, 23);
            this.MainTextStr.Name = "MainTextStr";
            this.MainTextStr.Size = new System.Drawing.Size(646, 39);
            this.MainTextStr.TabIndex = 1;
            this.MainTextStr.Text = "ИС-Конференция";
            this.MainTextStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainAuthStr
            // 
            this.MainAuthStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainAuthStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainAuthStr.Location = new System.Drawing.Point(12, 62);
            this.MainAuthStr.Name = "MainAuthStr";
            this.MainAuthStr.Size = new System.Drawing.Size(646, 39);
            this.MainAuthStr.TabIndex = 2;
            this.MainAuthStr.Text = "Авторизация";
            this.MainAuthStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputIdStr
            // 
            this.InputIdStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputIdStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIdStr.Location = new System.Drawing.Point(13, 122);
            this.InputIdStr.Name = "InputIdStr";
            this.InputIdStr.Size = new System.Drawing.Size(306, 31);
            this.InputIdStr.TabIndex = 3;
            this.InputIdStr.Text = "Введите полностью ФИО";
            this.InputIdStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputPasswordStr
            // 
            this.InputPasswordStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPasswordStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPasswordStr.Location = new System.Drawing.Point(13, 159);
            this.InputPasswordStr.Name = "InputPasswordStr";
            this.InputPasswordStr.Size = new System.Drawing.Size(306, 31);
            this.InputPasswordStr.TabIndex = 5;
            this.InputPasswordStr.Text = "Введите свой пароль";
            this.InputPasswordStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputPassword
            // 
            this.InputPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPassword.Location = new System.Drawing.Point(325, 159);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(333, 31);
            this.InputPassword.TabIndex = 4;
            // 
            // ButtonOnLogin
            // 
            this.ButtonOnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOnLogin.Location = new System.Drawing.Point(160, 240);
            this.ButtonOnLogin.Name = "ButtonOnLogin";
            this.ButtonOnLogin.Size = new System.Drawing.Size(333, 31);
            this.ButtonOnLogin.TabIndex = 6;
            this.ButtonOnLogin.Text = "Войти";
            this.ButtonOnLogin.UseVisualStyleBackColor = true;
            this.ButtonOnLogin.Click += new System.EventHandler(this.ButtonOnLogin_Click);
            // 
            // RememberMeCheckbox
            // 
            this.RememberMeCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RememberMeCheckbox.Checked = true;
            this.RememberMeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberMeCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RememberMeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RememberMeCheckbox.Location = new System.Drawing.Point(17, 193);
            this.RememberMeCheckbox.Name = "RememberMeCheckbox";
            this.RememberMeCheckbox.Size = new System.Drawing.Size(333, 38);
            this.RememberMeCheckbox.TabIndex = 7;
            this.RememberMeCheckbox.Text = "Запомнить меня";
            this.RememberMeCheckbox.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 287);
            this.Controls.Add(this.RememberMeCheckbox);
            this.Controls.Add(this.ButtonOnLogin);
            this.Controls.Add(this.InputPasswordStr);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputIdStr);
            this.Controls.Add(this.MainAuthStr);
            this.Controls.Add(this.MainTextStr);
            this.Controls.Add(this.InputId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.ShowIcon = false;
            this.Text = "Авторизация : ИС-Конференция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label MainTextStr;
        private System.Windows.Forms.Label MainAuthStr;
        private System.Windows.Forms.Label InputIdStr;
        private System.Windows.Forms.Label InputPasswordStr;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Button ButtonOnLogin;
        private System.Windows.Forms.CheckBox RememberMeCheckbox;
    }
}

