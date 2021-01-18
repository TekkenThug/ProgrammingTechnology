using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;


namespace DLLProjectMassiv
{
    public class Massiv
    {
        // Заполнение массива
        public static void zapolnitMassiv(int[] Chisla, int dlinaMassiva)
        {
            Random random = new Random();

            for (int i = 0; i < Chisla.Length; i++)
            {
                Chisla[i] = random.Next(-100, 101);
            }
        }

        // Заполнение таблицы
        public static void zapolnitDataGridView(int[] Chisla, DataGridView Table)
        {
            Table.Rows.Clear();
            Table.ColumnCount = Chisla.Length;
            Table.RowCount = 2;
            for (int i = 0; i < Chisla.Length; i++)
            {
                Table.Rows[0].Cells[i].Value = "[" + i + "]";
                Table.Rows[1].Cells[i].Value = Chisla[i];
            }
        }

        // Количество пар по условию
        public static int Raschet(int[] Chisla)
        {
            int count = 0;

            for (int i = 0; i < Chisla.Length - 1; i++)
            {
                if (((Chisla[i] * Chisla[i + 1]) % 2 != 0) && ((Chisla[i] + Chisla[i + 1]) >= 0))
                {
                    count++;
                }
            }

            return count;
        }

        // Формирование результирующего массива согласно критерию
        public static int[] RaschetMassiva(int[] Chisla, int[] newChisla, int count)
        {
            for (int i = 0; i < newChisla.Length; i++)
            {
                newChisla[i] = Chisla[i] + count;
            }

            return newChisla;
        }


        /* Работа с текстовыми документами */

        // Добавить в PDF
        public static void Add_pdf(int lenght, int[] mas, int[] rezmas)
        {

            var Document = new Document();
            var Zap = PdfWriter.GetInstance(Document, new System.IO.FileStream("Massivs.pdf", System.IO.FileMode.Create));
            Document.Open();
            var Shrift = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\times.ttf", "CP1251", BaseFont.EMBEDDED);

            var ft = new Font(Shrift, 12, Font.NORMAL, BaseColor.DARK_GRAY);
            var tabl = new PdfPTable(2);
            var cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            cell.Colspan = 2;
            cell.Border = 0;
            cell.FixedHeight = 20.0F;
            cell.Phrase = new Phrase("Одномерные массивы", ft);
            tabl.AddCell(cell);

            cell.Colspan = 1;
            cell.Phrase = new Phrase("Исходный массив", ft);
            tabl.AddCell(cell);

            cell.Colspan = 1;
            cell.Phrase = new Phrase("Результирующий массив", ft);
            tabl.AddCell(cell);

            cell.BackgroundColor = BaseColor.WHITE;
            cell.Colspan = 1;
            cell.Border = 15;

            for (int i = 0; i < lenght; i++)
            {
                cell.Phrase = new Phrase(mas[i].ToString(), ft);
                tabl.AddCell(cell);

                cell.Phrase = new Phrase(rezmas[i].ToString(), ft);
                tabl.AddCell(cell);
            }

            tabl.TotalWidth = Document.PageSize.Width - 50;
            tabl.WriteSelectedRows(0, -1, 40, Document.PageSize.Height - 30, Zap.DirectContent);

            Document.Close(); 
            Zap.Close();
 
            System.Diagnostics.Process.Start("IExplore.exe", System.IO.Directory.GetCurrentDirectory() + @"\Massivs.pdf");
        }
        
        // Добавить в TXT
        public static void ZapisBloknot(int length, int[] mas, string fileName)
        {
            var path = @"..\" +  fileName + ".txt";

            if (File.Exists(path))
                File.Delete(path);

            StreamWriter txtFile = File.CreateText(path);

            for (int i = 0; i < length; i++)
            {
                txtFile.WriteLine(mas[i]);
            }

            txtFile.Close();
            System.Diagnostics.Process.Start(path);
        }

        // Запись в Word
        public static void ZapisWordIsx(int length, int[] mas, string title)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var Wrd = new Microsoft.Office.Interop.Word.Application();
            Wrd.Visible = true;
            var inf = Type.Missing;
            String str;
            var Doc = Wrd.Documents.Add(inf, inf, inf, inf); Wrd.Selection.TypeText(title);
            Object t1 = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
            Microsoft.Office.Interop.Word.Table tbl = Wrd.ActiveDocument.Tables.Add(Wrd.Selection.Range, 2, length, t1, t2);
            for (int i = 0; i < length; i++)
            {
                tbl.Cell(1, i + 1).Range.InsertAfter("[" + Convert.ToString(i) + "]");
                str = String.Format("{0:f0}", mas[i]); tbl.Cell(2, i + 1).Range.InsertAfter(str);
            }
        }



        //Оформление таблицы Excel
        public static void ZapisExcel(int[] mas, int[] rezmas)
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            workBook = excelApp.Workbooks.Open(@"C:\Users\Вадим\source\repos\Theory\bin\massiv.xlsm");
            workSheet = workBook.Worksheets["Лист1"];
            workSheet.UsedRange.Clear();

            workSheet.Cells[1, 1] = "Исходный массив";
            workSheet.Cells[6, 1] = "Результирующий массив";
            workSheet.Range["A10"].Select();

            for (int i = 0; i < mas.Length; i++)
            {
                workSheet.Cells[2, i + 1] = "[" + i + "]";
                workSheet.Cells[3, i + 1] = mas[i];

                workSheet.Cells[7, i + 1] = "[" + i + "]";
                workSheet.Cells[8, i + 1] = rezmas[i];
            }

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        public static void FormatExcel(int length)
        {
            TableConstruct(1, length);
            TableConstruct(6, length);
        }

        private static void TableConstruct(int nachalo, int konec)
        {
            Microsoft.Office.Interop.Excel.Range rangeHeader = workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[2, 2]];
            rangeHeader.Cells.Font.Name = "Times New Roman";
            rangeHeader.Cells.Font.Size = 18;

            Microsoft.Office.Interop.Excel.Range rangeElement = workSheet.Range[workSheet.Cells[0 + 1, 1], workSheet.Cells[0 + 2, 9]];
            rangeElement.Cells.Font.Name = "Times New Roman";
            rangeElement.Cells.Font.Size = 18;

            rangeElement.Cells.Columns.AutoFit();
            rangeElement.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            rangeElement.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            rangeElement.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            rangeElement.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            rangeElement.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
        }

        private static Microsoft.Office.Interop.Excel.Application excelApp;
        private static Microsoft.Office.Interop.Excel.Workbook workBook;
        private static Microsoft.Office.Interop.Excel.Worksheet workSheet;


        /* Методы для работы с БД */

        // Создание БД
        public static void createDB()
        {
            var db = new ADOX.Catalog();

            try
            {
                db.Create(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='..\Massiv.accdb';");
                MessageBox.Show("БД успешно создана");
            }
            catch (System.Runtime.InteropServices.COMException sit)
            {
                MessageBox.Show(sit.Message);
            }
            finally
            {
                db = null;
            }

        }

        // Создание таблицы в БД
        public static void createTableDB()
        {
            var db = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='..\Massiv.accdb';");
            db.Open();

            var c = new OleDbCommand("CREATE TABLE [MASSIVS]([Индекс элемента] char(200), [Исходный массив] char(200), [Результирующий массив] char(200))", db);

            try
            {
                c.ExecuteNonQuery();
                MessageBox.Show("Таблица в БД создана");
            }
            catch (Exception situation)
            {
                MessageBox.Show(situation.Message);
            }

            db.Close();
        }

        // Внесение записей в БД
        public static void addNoteDB(int[] massiv, int[] rezmassiv)
        {
            var db = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='..\Massiv.accdb';");
            db.Open();


            // Очистка таблицы с записями
            var clearAll = new OleDbCommand("DELETE FROM [MASSIVS]");
            clearAll.Connection = db;
            clearAll.ExecuteNonQuery();
            db.Close();

            for (int i = 0; i < massiv.Length; i++)
            {
                db.Open();
                var c = new OleDbCommand("INSERT INTO [MASSIVS]([Индекс элемента], [Исходный массив], [Результирующий массив]) VALUES('" + i + "' , '" + massiv[i] + "' , '" + rezmassiv[i] + "')");
                c.Connection = db;
                c.ExecuteNonQuery();
                db.Close();
            }
            MessageBox.Show("В таблицу БД была добавлена запись", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }   
}
