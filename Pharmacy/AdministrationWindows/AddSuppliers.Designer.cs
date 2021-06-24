
namespace Pharmacy.AdministrationWindows
{
    partial class AddSuppliers
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
            this.BackWindows = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameSuppliers = new System.Windows.Forms.TextBox();
            this.AddSupplier = new System.Windows.Forms.Button();
            this.PasswordEntrance = new System.Windows.Forms.TextBox();
            this.LoginEntrance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackWindows
            // 
            this.BackWindows.BackColor = System.Drawing.Color.Gainsboro;
            this.BackWindows.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BackWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackWindows.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.BackWindows.Location = new System.Drawing.Point(4, 3);
            this.BackWindows.Name = "BackWindows";
            this.BackWindows.Size = new System.Drawing.Size(42, 36);
            this.BackWindows.TabIndex = 21;
            this.BackWindows.Text = "←";
            this.BackWindows.UseVisualStyleBackColor = false;
            this.BackWindows.Click += new System.EventHandler(this.BackWindows_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label4.Location = new System.Drawing.Point(166, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label3.Location = new System.Drawing.Point(176, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.Location = new System.Drawing.Point(48, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название поставщика";
            // 
            // NameSuppliers
            // 
            this.NameSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameSuppliers.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.NameSuppliers.Location = new System.Drawing.Point(259, 95);
            this.NameSuppliers.Multiline = true;
            this.NameSuppliers.Name = "NameSuppliers";
            this.NameSuppliers.Size = new System.Drawing.Size(300, 25);
            this.NameSuppliers.TabIndex = 17;
            // 
            // AddSupplier
            // 
            this.AddSupplier.BackColor = System.Drawing.Color.MistyRose;
            this.AddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplier.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.AddSupplier.Location = new System.Drawing.Point(259, 234);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(300, 44);
            this.AddSupplier.TabIndex = 16;
            this.AddSupplier.Text = "Зарегистрировать";
            this.AddSupplier.UseVisualStyleBackColor = false;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // PasswordEntrance
            // 
            this.PasswordEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordEntrance.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.PasswordEntrance.Location = new System.Drawing.Point(259, 188);
            this.PasswordEntrance.Multiline = true;
            this.PasswordEntrance.Name = "PasswordEntrance";
            this.PasswordEntrance.PasswordChar = '*';
            this.PasswordEntrance.Size = new System.Drawing.Size(300, 25);
            this.PasswordEntrance.TabIndex = 15;
            // 
            // LoginEntrance
            // 
            this.LoginEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginEntrance.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.LoginEntrance.Location = new System.Drawing.Point(259, 144);
            this.LoginEntrance.Multiline = true;
            this.LoginEntrance.Name = "LoginEntrance";
            this.LoginEntrance.Size = new System.Drawing.Size(300, 25);
            this.LoginEntrance.TabIndex = 14;
            // 
            // AddSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(571, 318);
            this.Controls.Add(this.BackWindows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameSuppliers);
            this.Controls.Add(this.AddSupplier);
            this.Controls.Add(this.PasswordEntrance);
            this.Controls.Add(this.LoginEntrance);
            this.Name = "AddSuppliers";
            this.Text = "AddSuppliers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackWindows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameSuppliers;
        private System.Windows.Forms.Button AddSupplier;
        private System.Windows.Forms.TextBox PasswordEntrance;
        private System.Windows.Forms.TextBox LoginEntrance;
    }
}