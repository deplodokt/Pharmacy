
namespace Pharmacy.SuppliersWindows
{
    partial class SuppliersWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersWindows));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddMedicationTovar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddMedicationTovar
            // 
            this.AddMedicationTovar.BackColor = System.Drawing.Color.MistyRose;
            this.AddMedicationTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMedicationTovar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.AddMedicationTovar.Location = new System.Drawing.Point(874, 12);
            this.AddMedicationTovar.Name = "AddMedicationTovar";
            this.AddMedicationTovar.Size = new System.Drawing.Size(300, 44);
            this.AddMedicationTovar.TabIndex = 7;
            this.AddMedicationTovar.Text = "Добавить препарат";
            this.AddMedicationTovar.UseVisualStyleBackColor = false;
            this.AddMedicationTovar.Click += new System.EventHandler(this.AddMedicationTovar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Склад",
            "Поставщик"});
            this.comboBox1.Location = new System.Drawing.Point(12, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 26);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SearchTable
            // 
            this.SearchTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTable.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.SearchTable.Location = new System.Drawing.Point(451, 26);
            this.SearchTable.Multiline = true;
            this.SearchTable.Name = "SearchTable";
            this.SearchTable.Size = new System.Drawing.Size(276, 25);
            this.SearchTable.TabIndex = 34;
            this.SearchTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTable_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(329, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Название:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(756, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuppliersWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1186, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddMedicationTovar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuppliersWindows";
            this.Text = "SuppliersWindows";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddMedicationTovar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SearchTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}