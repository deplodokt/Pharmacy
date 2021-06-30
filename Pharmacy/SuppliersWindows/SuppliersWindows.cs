using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.SuppliersWindows
{
    public partial class SuppliersWindows : Form
    {
        public void UpTable()
        {
            PharmacyBDContext pharmacyBDContext = new PharmacyBDContext();
            dataGridView1.DataSource = pharmacyBDContext.Medication.
                Select(medication => new
                {
                    medication.NameMedication,
                    medication.Barcode,
                    medication.ProductionDate,
                    medication.ExperienceDate,
                    medication.WhithReceipt,
                    medication.Price,
                    medication.Quantity,
                    medication.IdsuppliersNavigation.NameSuppliers
                }
                ).ToList();
        }
        public void UpSuppliers()
        {
            PharmacyBDContext pharmacy = new PharmacyBDContext();
            var two = pharmacy.Medication.Where(f => f.IdsuppliersNavigation.NameSuppliers == Suppliers.SuppliersNameCurrent.NameSupplirs).Select(
                medication => new
                {
                    medication.NameMedication,
                    medication.Barcode,
                    medication.ProductionDate,
                    medication.ExperienceDate,
                    medication.WhithReceipt,
                    medication.Price,
                    medication.Quantity,
                    medication.IdsuppliersNavigation.NameSuppliers
                }
                ).ToList();
            dataGridView1.DataSource = two;
        }

        public void UpSearchName()
        {
            PharmacyBDContext pharmacy = new PharmacyBDContext();
            var two = pharmacy.Medication.Where(f => f.NameMedication == SearchTable.Text).Select(
                medication => new
                {
                    medication.NameMedication,
                    medication.Barcode,
                    medication.ProductionDate,
                    medication.ExperienceDate,
                    medication.WhithReceipt,
                    medication.Price,
                    medication.Quantity,
                    medication.IdsuppliersNavigation.NameSuppliers
                }
                ).ToList();
            dataGridView1.DataSource = two;
        }

        public SuppliersWindows()
        {
            InitializeComponent();
            this.Text = "Окно постовщяка";
            UpTable();
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Баркод";
            dataGridView1.Columns[2].HeaderText = "Дата производства";
            dataGridView1.Columns[3].HeaderText = "Годен до";
            dataGridView1.Columns[4].HeaderText = "Рецепт";
            dataGridView1.Columns[5].HeaderText = "Цена";
            dataGridView1.Columns[6].HeaderText = "Количество";
            dataGridView1.Columns[7].HeaderText = "Постовщик";
            dataGridView1.AutoResizeColumns();
            comboBox1.SelectedIndex = 0;
        }
        private void AddMedicationTovar_Click(object sender, EventArgs e)
        {

            AddMedication medication = new AddMedication();
            medication.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                UpTable();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                UpSuppliers();

            }
        }

        private void SearchTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    UpSearchName();
                    SearchTable.Clear();
                }
            }
        }
        public void WriteInFile(DataGridView dataGridView, string path)
        {
            var xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                Debug.WriteLine("Ошибка");
                return;
            }

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            TransferDataIntoExcel(dataGridView1, xlWorkSheet);

            xlWorkBook.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        public void TransferDataIntoExcel(DataGridView dataGridView, Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet)
        {
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                string path = @"D:\КПиЯП\Pharmacy\Pharmacy\SuppliersWindows\SuppliersReport\"+ Suppliers.SuppliersNameCurrent.NameSupplirs+" от "+ DateTime.Now.ToString("d") + ".xls";
                WriteInFile(dataGridView1, path);
            }
        }
    }
}

