
namespace Pharmacy
{
    partial class Entrance
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
            this.LoginEntrance = new System.Windows.Forms.TextBox();
            this.PasswordEntrance = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnterSystem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginEntrance
            // 
            this.LoginEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginEntrance.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.LoginEntrance.Location = new System.Drawing.Point(221, 394);
            this.LoginEntrance.Multiline = true;
            this.LoginEntrance.Name = "LoginEntrance";
            this.LoginEntrance.Size = new System.Drawing.Size(300, 25);
            this.LoginEntrance.TabIndex = 0;
            // 
            // PasswordEntrance
            // 
            this.PasswordEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordEntrance.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.PasswordEntrance.Location = new System.Drawing.Point(221, 456);
            this.PasswordEntrance.Multiline = true;
            this.PasswordEntrance.Name = "PasswordEntrance";
            this.PasswordEntrance.PasswordChar = '*';
            this.PasswordEntrance.Size = new System.Drawing.Size(300, 25);
            this.PasswordEntrance.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(340, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EnterSystem
            // 
            this.EnterSystem.BackColor = System.Drawing.Color.MistyRose;
            this.EnterSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterSystem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.EnterSystem.Location = new System.Drawing.Point(221, 502);
            this.EnterSystem.Name = "EnterSystem";
            this.EnterSystem.Size = new System.Drawing.Size(300, 44);
            this.EnterSystem.TabIndex = 3;
            this.EnterSystem.Text = "Войти";
            this.EnterSystem.UseVisualStyleBackColor = false;
            this.EnterSystem.Click += new System.EventHandler(this.EnterSystem_Click);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(726, 576);
            this.Controls.Add(this.EnterSystem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordEntrance);
            this.Controls.Add(this.LoginEntrance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Entrance";
            this.Text = "Entrance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginEntrance;
        private System.Windows.Forms.TextBox PasswordEntrance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EnterSystem;
    }
}