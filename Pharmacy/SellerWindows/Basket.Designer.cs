
namespace Pharmacy.SellerWindows
{
    partial class Basket
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
            this.CreateBuyerOrder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BackWindows = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.TotalPriceOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateBuyerOrder
            // 
            this.CreateBuyerOrder.BackColor = System.Drawing.Color.MistyRose;
            this.CreateBuyerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBuyerOrder.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.CreateBuyerOrder.Location = new System.Drawing.Point(41, 232);
            this.CreateBuyerOrder.Name = "CreateBuyerOrder";
            this.CreateBuyerOrder.Size = new System.Drawing.Size(149, 44);
            this.CreateBuyerOrder.TabIndex = 8;
            this.CreateBuyerOrder.Text = "Оплата";
            this.CreateBuyerOrder.UseVisualStyleBackColor = false;
            this.CreateBuyerOrder.Click += new System.EventHandler(this.CreateBuyerOrder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(374, 26);
            this.comboBox1.TabIndex = 9;
            // 
            // BackWindows
            // 
            this.BackWindows.BackColor = System.Drawing.Color.Gainsboro;
            this.BackWindows.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BackWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackWindows.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.BackWindows.Location = new System.Drawing.Point(2, 1);
            this.BackWindows.Name = "BackWindows";
            this.BackWindows.Size = new System.Drawing.Size(48, 40);
            this.BackWindows.TabIndex = 16;
            this.BackWindows.Text = "←";
            this.BackWindows.UseVisualStyleBackColor = false;
            this.BackWindows.Click += new System.EventHandler(this.BackWindows_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrder.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteOrder.Location = new System.Drawing.Point(425, 72);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(149, 36);
            this.DeleteOrder.TabIndex = 17;
            this.DeleteOrder.Text = "Убрать";
            this.DeleteOrder.UseVisualStyleBackColor = false;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // TotalPriceOrder
            // 
            this.TotalPriceOrder.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TotalPriceOrder.Location = new System.Drawing.Point(299, 239);
            this.TotalPriceOrder.Multiline = true;
            this.TotalPriceOrder.Name = "TotalPriceOrder";
            this.TotalPriceOrder.Size = new System.Drawing.Size(160, 27);
            this.TotalPriceOrder.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.Location = new System.Drawing.Point(216, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Итого";
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(594, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalPriceOrder);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.BackWindows);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CreateBuyerOrder);
            this.Name = "Basket";
            this.Text = "Basket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBuyerOrder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BackWindows;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.TextBox TotalPriceOrder;
        private System.Windows.Forms.Label label1;
    }
}