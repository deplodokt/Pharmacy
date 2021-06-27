
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddMedicationTovar
            // 
            this.AddMedicationTovar.BackColor = System.Drawing.Color.MistyRose;
            this.AddMedicationTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMedicationTovar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.AddMedicationTovar.Location = new System.Drawing.Point(716, 12);
            this.AddMedicationTovar.Name = "AddMedicationTovar";
            this.AddMedicationTovar.Size = new System.Drawing.Size(300, 44);
            this.AddMedicationTovar.TabIndex = 7;
            this.AddMedicationTovar.Text = "Добавить препарат";
            this.AddMedicationTovar.UseVisualStyleBackColor = false;
            this.AddMedicationTovar.Click += new System.EventHandler(this.AddMedicationTovar_Click);
            // 
            // SuppliersWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1028, 512);
            this.Controls.Add(this.AddMedicationTovar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuppliersWindows";
            this.Text = "SuppliersWindows";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddMedicationTovar;
    }
}