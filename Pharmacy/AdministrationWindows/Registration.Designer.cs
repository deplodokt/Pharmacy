
namespace Pharmacy.AdministrationWindows
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
            this.EnterSystem = new System.Windows.Forms.Button();
            this.PasswordEntrance = new System.Windows.Forms.TextBox();
            this.LoginEntrance = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackWindows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterSystem
            // 
            this.EnterSystem.BackColor = System.Drawing.Color.MistyRose;
            this.EnterSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterSystem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.EnterSystem.Location = new System.Drawing.Point(175, 286);
            this.EnterSystem.Name = "EnterSystem";
            this.EnterSystem.Size = new System.Drawing.Size(300, 44);
            this.EnterSystem.TabIndex = 6;
            this.EnterSystem.Text = "Зарегистрировать";
            this.EnterSystem.UseVisualStyleBackColor = false;
            this.EnterSystem.Click += new System.EventHandler(this.EnterSystem_Click);
            // 
            // PasswordEntrance
            // 
            this.PasswordEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordEntrance.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.PasswordEntrance.Location = new System.Drawing.Point(175, 240);
            this.PasswordEntrance.Multiline = true;
            this.PasswordEntrance.Name = "PasswordEntrance";
            this.PasswordEntrance.PasswordChar = '*';
            this.PasswordEntrance.Size = new System.Drawing.Size(300, 25);
            this.PasswordEntrance.TabIndex = 5;
            // 
            // LoginEntrance
            // 
            this.LoginEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginEntrance.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.LoginEntrance.Location = new System.Drawing.Point(175, 178);
            this.LoginEntrance.Multiline = true;
            this.LoginEntrance.Name = "LoginEntrance";
            this.LoginEntrance.Size = new System.Drawing.Size(300, 25);
            this.LoginEntrance.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.FirstName.Location = new System.Drawing.Point(175, 122);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(300, 25);
            this.FirstName.TabIndex = 8;
            // 
            // LastName
            // 
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.LastName.Location = new System.Drawing.Point(175, 60);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(300, 25);
            this.LastName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.Location = new System.Drawing.Point(69, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label2.Location = new System.Drawing.Point(109, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label3.Location = new System.Drawing.Point(91, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label4.Location = new System.Drawing.Point(81, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Пароль";
            // 
            // BackWindows
            // 
            this.BackWindows.BackColor = System.Drawing.Color.Gainsboro;
            this.BackWindows.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BackWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackWindows.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.BackWindows.Location = new System.Drawing.Point(3, 2);
            this.BackWindows.Name = "BackWindows";
            this.BackWindows.Size = new System.Drawing.Size(42, 36);
            this.BackWindows.TabIndex = 13;
            this.BackWindows.Text = "←";
            this.BackWindows.UseVisualStyleBackColor = false;
            this.BackWindows.Click += new System.EventHandler(this.BackWindows_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(523, 382);
            this.Controls.Add(this.BackWindows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.EnterSystem);
            this.Controls.Add(this.PasswordEntrance);
            this.Controls.Add(this.LoginEntrance);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterSystem;
        private System.Windows.Forms.TextBox PasswordEntrance;
        private System.Windows.Forms.TextBox LoginEntrance;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackWindows;
    }
}