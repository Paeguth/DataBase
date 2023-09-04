
namespace woksajapp
{
    partial class Authorization
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
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.TXTpassword = new System.Windows.Forms.TextBox();
            this.LBpassword = new System.Windows.Forms.Label();
            this.BTNentry = new System.Windows.Forms.Button();
            this.BTNregistration = new System.Windows.Forms.Button();
            this.BTNexit = new System.Windows.Forms.Button();
            this.LBusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTusername
            // 
            this.TXTusername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXTusername.Location = new System.Drawing.Point(12, 38);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(319, 31);
            this.TXTusername.TabIndex = 0;
            // 
            // TXTpassword
            // 
            this.TXTpassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXTpassword.Location = new System.Drawing.Point(12, 98);
            this.TXTpassword.Name = "TXTpassword";
            this.TXTpassword.PasswordChar = '*';
            this.TXTpassword.Size = new System.Drawing.Size(319, 31);
            this.TXTpassword.TabIndex = 1;
            // 
            // LBpassword
            // 
            this.LBpassword.AutoSize = true;
            this.LBpassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBpassword.Location = new System.Drawing.Point(130, 72);
            this.LBpassword.Name = "LBpassword";
            this.LBpassword.Size = new System.Drawing.Size(70, 23);
            this.LBpassword.TabIndex = 3;
            this.LBpassword.Text = "Пароль";
            // 
            // BTNentry
            // 
            this.BTNentry.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNentry.Location = new System.Drawing.Point(224, 135);
            this.BTNentry.Name = "BTNentry";
            this.BTNentry.Size = new System.Drawing.Size(107, 30);
            this.BTNentry.TabIndex = 4;
            this.BTNentry.Text = "Вход";
            this.BTNentry.UseVisualStyleBackColor = true;
            this.BTNentry.Click += new System.EventHandler(this.BTNentry_Click);
            // 
            // BTNregistration
            // 
            this.BTNregistration.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNregistration.Location = new System.Drawing.Point(12, 135);
            this.BTNregistration.Name = "BTNregistration";
            this.BTNregistration.Size = new System.Drawing.Size(123, 30);
            this.BTNregistration.TabIndex = 5;
            this.BTNregistration.Text = "Регистрация";
            this.BTNregistration.UseVisualStyleBackColor = true;
            this.BTNregistration.Click += new System.EventHandler(this.BTNregistration_Click);
            // 
            // BTNexit
            // 
            this.BTNexit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNexit.Location = new System.Drawing.Point(141, 134);
            this.BTNexit.Name = "BTNexit";
            this.BTNexit.Size = new System.Drawing.Size(77, 32);
            this.BTNexit.TabIndex = 6;
            this.BTNexit.Text = "Выход";
            this.BTNexit.UseVisualStyleBackColor = true;
            this.BTNexit.Click += new System.EventHandler(this.BTNexit_Click);
            // 
            // LBusername
            // 
            this.LBusername.AutoSize = true;
            this.LBusername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBusername.Location = new System.Drawing.Point(90, 12);
            this.LBusername.Name = "LBusername";
            this.LBusername.Size = new System.Drawing.Size(158, 23);
            this.LBusername.TabIndex = 7;
            this.LBusername.Text = "Имя пользователя";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.LBusername);
            this.Controls.Add(this.BTNexit);
            this.Controls.Add(this.BTNregistration);
            this.Controls.Add(this.BTNentry);
            this.Controls.Add(this.LBpassword);
            this.Controls.Add(this.TXTpassword);
            this.Controls.Add(this.TXTusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация пользователя";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.TextBox TXTpassword;
        private System.Windows.Forms.Label LBpassword;
        private System.Windows.Forms.Button BTNentry;
        private System.Windows.Forms.Button BTNregistration;
        private System.Windows.Forms.Button BTNexit;
        private System.Windows.Forms.Label LBusername;
    }
}

