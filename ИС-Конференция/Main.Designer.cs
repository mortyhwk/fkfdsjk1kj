namespace ИС_Конференция
{
    partial class Main
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
            this.MainTextStr = new System.Windows.Forms.Label();
            this.ButtonGetEvents = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTextStr
            // 
            this.MainTextStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextStr.Location = new System.Drawing.Point(12, 9);
            this.MainTextStr.Name = "MainTextStr";
            this.MainTextStr.Size = new System.Drawing.Size(544, 41);
            this.MainTextStr.TabIndex = 3;
            this.MainTextStr.Text = "ИС-Конференция";
            this.MainTextStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonGetEvents
            // 
            this.ButtonGetEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGetEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGetEvents.Location = new System.Drawing.Point(12, 62);
            this.ButtonGetEvents.Name = "ButtonGetEvents";
            this.ButtonGetEvents.Size = new System.Drawing.Size(544, 54);
            this.ButtonGetEvents.TabIndex = 8;
            this.ButtonGetEvents.Text = "Открыть мероприятия";
            this.ButtonGetEvents.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(544, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Приступить к авторизации";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonGetEvents);
            this.Controls.Add(this.MainTextStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "ИС-Конференция";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainTextStr;
        private System.Windows.Forms.Button ButtonGetEvents;
        private System.Windows.Forms.Button button1;
    }
}