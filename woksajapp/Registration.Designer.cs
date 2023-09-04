
namespace woksajapp
{
    partial class Registration
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
            this.LBusername = new System.Windows.Forms.Label();
            this.LBpassword1 = new System.Windows.Forms.Label();
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.TXTpassword1 = new System.Windows.Forms.TextBox();
            this.LBpassword2 = new System.Windows.Forms.Label();
            this.TXTpassword2 = new System.Windows.Forms.TextBox();
            this.BTNback = new System.Windows.Forms.Button();
            this.BTNregistration = new System.Windows.Forms.Button();
            this.LBnotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBusername
            // 
            this.LBusername.AutoSize = true;
            this.LBusername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBusername.Location = new System.Drawing.Point(13, 17);
            this.LBusername.Name = "LBusername";
            this.LBusername.Size = new System.Drawing.Size(158, 23);
            this.LBusername.TabIndex = 0;
            this.LBusername.Text = "Имя пользователя";
            // 
            // LBpassword1
            // 
            this.LBpassword1.AutoSize = true;
            this.LBpassword1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBpassword1.Location = new System.Drawing.Point(13, 79);
            this.LBpassword1.Name = "LBpassword1";
            this.LBpassword1.Size = new System.Drawing.Size(70, 23);
            this.LBpassword1.TabIndex = 1;
            this.LBpassword1.Text = "Пароль";
            // 
            // TXTusername
            // 
            this.TXTusername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXTusername.Location = new System.Drawing.Point(17, 43);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(340, 31);
            this.TXTusername.TabIndex = 2;
            // 
            // TXTpassword1
            // 
            this.TXTpassword1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXTpassword1.Location = new System.Drawing.Point(17, 105);
            this.TXTpassword1.Name = "TXTpassword1";
            this.TXTpassword1.PasswordChar = '*';
            this.TXTpassword1.Size = new System.Drawing.Size(340, 31);
            this.TXTpassword1.TabIndex = 3;
            // 
            // LBpassword2
            // 
            this.LBpassword2.AutoSize = true;
            this.LBpassword2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBpassword2.Location = new System.Drawing.Point(13, 144);
            this.LBpassword2.Name = "LBpassword2";
            this.LBpassword2.Size = new System.Drawing.Size(156, 23);
            this.LBpassword2.TabIndex = 4;
            this.LBpassword2.Text = "Повторите пароль";
            // 
            // TXTpassword2
            // 
            this.TXTpassword2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXTpassword2.Location = new System.Drawing.Point(17, 170);
            this.TXTpassword2.Name = "TXTpassword2";
            this.TXTpassword2.PasswordChar = '*';
            this.TXTpassword2.Size = new System.Drawing.Size(340, 31);
            this.TXTpassword2.TabIndex = 5;
            // 
            // BTNback
            // 
            this.BTNback.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNback.Location = new System.Drawing.Point(17, 268);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(95, 37);
            this.BTNback.TabIndex = 6;
            this.BTNback.Text = "Назад";
            this.BTNback.UseVisualStyleBackColor = true;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // BTNregistration
            // 
            this.BTNregistration.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNregistration.Location = new System.Drawing.Point(118, 268);
            this.BTNregistration.Name = "BTNregistration";
            this.BTNregistration.Size = new System.Drawing.Size(239, 37);
            this.BTNregistration.TabIndex = 7;
            this.BTNregistration.Text = "Регистрация пользователя";
            this.BTNregistration.UseVisualStyleBackColor = true;
            this.BTNregistration.Click += new System.EventHandler(this.BTNregistration_Click);
            // 
            // LBnotice
            // 
            this.LBnotice.AutoSize = true;
            this.LBnotice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBnotice.Location = new System.Drawing.Point(43, 219);
            this.LBnotice.Name = "LBnotice";
            this.LBnotice.Size = new System.Drawing.Size(286, 46);
            this.LBnotice.TabIndex = 8;
            this.LBnotice.Text = "Использование символов !@#$%^&\r\nв пароле недопустимо";
            this.LBnotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.LBnotice);
            this.Controls.Add(this.BTNregistration);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.TXTpassword2);
            this.Controls.Add(this.LBpassword2);
            this.Controls.Add(this.TXTpassword1);
            this.Controls.Add(this.TXTusername);
            this.Controls.Add(this.LBpassword1);
            this.Controls.Add(this.LBusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registration_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBusername;
        private System.Windows.Forms.Label LBpassword1;
        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.TextBox TXTpassword1;
        private System.Windows.Forms.Label LBpassword2;
        private System.Windows.Forms.TextBox TXTpassword2;
        private System.Windows.Forms.Button BTNback;
        private System.Windows.Forms.Button BTNregistration;
        private System.Windows.Forms.Label LBnotice;
    }
}