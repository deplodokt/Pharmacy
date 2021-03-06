
namespace Pharmacy.SellerWindows
{
    partial class MedicalSuppliesWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalSuppliesWarehouse));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackWindows = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.SearchTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1293, 450);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BackWindows
            // 
            this.BackWindows.BackColor = System.Drawing.Color.Gainsboro;
            this.BackWindows.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BackWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackWindows.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.BackWindows.Location = new System.Drawing.Point(0, 0);
            this.BackWindows.Name = "BackWindows";
            this.BackWindows.Size = new System.Drawing.Size(65, 42);
            this.BackWindows.TabIndex = 15;
            this.BackWindows.Text = "←";
            this.BackWindows.UseVisualStyleBackColor = false;
            this.BackWindows.Click += new System.EventHandler(this.BackWindows_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label7.Location = new System.Drawing.Point(88, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Количество";
            // 
            // Quantity
            // 
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.Quantity.Location = new System.Drawing.Point(219, 9);
            this.Quantity.Multiline = true;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(200, 25);
            this.Quantity.TabIndex = 31;
            // 
            // SearchTable
            // 
            this.SearchTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTable.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.SearchTable.Location = new System.Drawing.Point(581, 9);
            this.SearchTable.Multiline = true;
            this.SearchTable.Name = "SearchTable";
            this.SearchTable.Size = new System.Drawing.Size(468, 25);
            this.SearchTable.TabIndex = 34;
            this.SearchTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTable_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(454, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Название:";
            // 
            // MedicalSuppliesWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 496);
            this.Controls.Add(this.SearchTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.BackWindows);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicalSuppliesWarehouse";
            this.Text = "MedicalSuppliesWarehouse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackWindows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox SearchTable;
        private System.Windows.Forms.Label label2;
    }
}