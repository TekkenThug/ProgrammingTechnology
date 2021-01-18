using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;

namespace Test
{
    public class Methods
    {
        /* Объявление глобальных переменных */

        private static int PravilniyeOtveti;     // Количество правильных ответов
        private static int SchetchikVoprosov;    // Счетчик вопросов
        private static bool[] MassivOtvetov;     // Массив ответов пользователя с верно/неверно

        /* Запуск теста */
        public static void NachaloTesta(int kolvoVoprosov)
        {
            PravilniyeOtveti = 0;
            SchetchikVoprosov = kolvoVoprosov;
            MassivOtvetov = new bool[kolvoVoprosov];
        }

        /* Обработка ответов */
        public static void OtvetNaVopros(string questionNumber, string value)
        {
            if (value == "Верно")
            {

                Soobcheniye(questionNumber, "Вы ответили правильно");
                PravilniyeOtveti++;
                MassivOtvetov[int.Parse(questionNumber) - 1] = true;

            } else if (value == "Неверно") {

                Soobcheniye(questionNumber, "Вы ответили неправильно");
                MassivOtvetov[int.Parse(questionNumber) - 1] = false;

            } else
            {

                Soobcheniye(questionNumber, "Надо ответить на вопрос!");

            }
        }

        /* Переход на следующую форму */
        public static void PerehodNaFormu(Form thisForm, Form nextForm)
        {
    
            thisForm.Hide();
            nextForm.Show();
        }

        /* Вывод итоговых результатов */
        public static void VivodResult(DataGridView Result, Label label)
        {
            label.Text = "Ваш результат: " + Convert.ToString(PravilniyeOtveti) + " из " + Convert.ToString(SchetchikVoprosov);

            int length = MassivOtvetov.Length;

            Result.Rows.Clear();
            Result.ColumnCount = 2;
            Result.RowCount = length + 1;

            Result.Rows[0].Cells[0].Value = "№ вопроса";
            Result.Rows[0].Cells[1].Value = "Результат";

            for (int i = 0; i < length; i++)
            {
                Result.Rows[i + 1].Cells[0].Value = i + 1;

                if (MassivOtvetov[i])
                {
                    Result.Rows[i + 1].Cells[1].Style.ForeColor = Color.Green;
                    Result.Rows[i + 1].Cells[1].Value = "Верно";
                }
                else
                {
                    Result.Rows[i + 1].Cells[1].Style.ForeColor = Color.Red;
                    Result.Rows[i + 1].Cells[1].Value = "Ошибка";
                }
                
            }
        }

        /* Вывод сообщения  */
        public static void Soobcheniye(string NomerVoprosa, string otvet)
        {
            MessageBox.Show(otvet, "Вопрос " + NomerVoprosa, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Экспорт результатов теста в PDF */
        public static void ExportPDF()
        {

            var Document = new Document();
            var Zap = PdfWriter.GetInstance(Document, new System.IO.FileStream("TestResult.pdf", System.IO.FileMode.Create));
            Document.Open();
            var Shrift = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\times.ttf", "CP1251", BaseFont.EMBEDDED);

            var ft = new iTextSharp.text.Font(Shrift, 12, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
            var tabl = new PdfPTable(2);
            var cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            cell.Colspan = 2;
            cell.Border = 0;
            cell.FixedHeight = 20.0F;
            cell.Phrase = new Phrase("Тест по теме «Платежные карты»", ft);
            tabl.AddCell(cell);

            cell.Colspan = 1;
            cell.Phrase = new Phrase("№ вопроса", ft);
            tabl.AddCell(cell);

            cell.Colspan = 1;
            cell.Phrase = new Phrase("Результат", ft);
            tabl.AddCell(cell);

            cell.BackgroundColor = BaseColor.WHITE;
            cell.Colspan = 1;
            cell.Border = 15;

            for (int i = 0; i < MassivOtvetov.Length; i++)
            {
                cell.Phrase = new Phrase(Convert.ToString(i + 1), ft);
                tabl.AddCell(cell);

                if (MassivOtvetov[i])
                {
                    cell.Phrase = new Phrase("Правильно", ft);
                    tabl.AddCell(cell);
                }
                else
                {
                    cell.Phrase = new Phrase("Ошибка", ft);
                    tabl.AddCell(cell);
                }

            }

            tabl.TotalWidth = Document.PageSize.Width - 50;
            tabl.WriteSelectedRows(0, -1, 40, Document.PageSize.Height - 30, Zap.DirectContent);

            Document.Close();
            Zap.Close();

            System.Diagnostics.Process.Start("IExplore.exe", System.IO.Directory.GetCurrentDirectory() + @"\TestResult.pdf");
        }

        /* Экспорт результатов в БД */
        public static void createDB()
        {
            var db = new ADOX.Catalog();

            try
            {
                db.Create(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='.\TestResult.accdb';");
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

        public static void createUserResultDB()
        {
            var db = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='.\TestResult.accdb';");
            db.Open();

            string username = (Interaction.InputBox("Введите имя пользователя, проходившего тест", "Ввод", "", -1));

            var c = new OleDbCommand("CREATE TABLE [" + username + "]([№ вопроса] char(200), [Результат] char(200))", db);

            try
            {
                c.ExecuteNonQuery();
                MessageBox.Show("Таблица в БД создана");
            }
            catch (Exception situation)
            {
                MessageBox.Show(situation.Message);
            }

            for (int i = 0; i < MassivOtvetov.Length; i++)
            {

                string result;

                if (MassivOtvetov[i])
                    result = "Правильно";
                else
                    result = "Ошибка";

                var questionQuery = new OleDbCommand(
                    "INSERT INTO [" + username + "]([№ вопроса], [Результат]) VALUES('" + (i + 1) + "' , '" + result + "')");

                questionQuery.Connection = db;
                questionQuery.ExecuteNonQuery();
              
            }

            db.Close();

            MessageBox.Show("Результаты теста для пользователя " + username + " занесены в БД", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

    }
}
