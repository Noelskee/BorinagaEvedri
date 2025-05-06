using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace BorinagaEvedri
{
    class Mylogs
    {
        Workbook book = new Workbook();

        public void insertLogs(string user, string message)
        {
            book.LoadFromFile(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx");
            Worksheet sheet2 = book.Worksheets[1];

            // Find the next empty row
            int row = sheet2.LastRow + 1; // Get the next empty row

            sheet2.Range[row, 1].Value = user;
            sheet2.Range[row, 2].Value = message;
            sheet2.Range[row, 3].Value = DateTime.Now.ToString("MM/dd/yyyy");
            sheet2.Range[row, 4].Value = DateTime.Now.ToString("hh:mm:ss tt");

            book.SaveToFile(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx", ExcelVersion.Version2016);
        }
        public DataTable LoadLogs()
        {
            book.LoadFromFile(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx");
            Worksheet sheet2 = book.Worksheets[1];
            DataTable dataTable = new DataTable();

            // Define columns
            dataTable.Columns.Add("User");
            dataTable.Columns.Add("Message");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Time");

            int rowCount = sheet2.LastRow; // Use LastRow to get the correct count
            for (int row = 2; row <= rowCount; row++) // Assuming first row is header
            {
                var user = sheet2.Range[row, 1].Value;
                var message = sheet2.Range[row, 2].Value;

                // Debugging output
                Console.WriteLine($"Row {row}: User={user}, Message={message}");

                if (user != null)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["User"] = user;
                    dataRow["Message"] = message;
                    dataRow["Date"] = sheet2.Range[row, 3].Value;
                    dataRow["Time"] = sheet2.Range[row, 4].Value;
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        public void UpdateLog(int logId, string newLogValue)
        {
            //book.LoadFromFile(@"C:\Users\ACT-STUDENT\Downloads\WindowsApp1_BORINAGAEve\WindowsApp1_BORINAGAEve\Book1(1).xlsx");
            book.LoadFromFile(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx");
            Worksheet sheet2 = book.Worksheets[1];

            // Assuming logId corresponds to the row index, adjust as necessary
            for (int row = 2; row <= sheet2.LastRow; row++) // Assuming first row is the header
            {
                if (sheet2.Range[row, 1].Value == logId.ToString()) // Assuming ID is in the first column
                {
                    // Update the log message in the second column (adjust as necessary)
                    sheet2.Range[row, 2].Value = newLogValue; // Assuming the message is in the second column
                    break; // Exit loop after updating the log
                }
            }

            //book.SaveToFile(@"C:\Users\ACT-STUDENT\Downloads\WindowsApp1_BORINAGAEve\WindowsApp1_BORINAGAEve\Book1(1).xlsx", ExcelVersion.Version2016);
            book.SaveToFile(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx", ExcelVersion.Version2016);
        }

        public void DeleteLog(int logId)
        {
            //book.LoadFromFile(@"C:\Users\ACT-STUDENT\Downloads\WindowsApp1_BORINAGAEve\WindowsApp1_BORINAGAEve\Book1(1).xlsx");
            book.LoadFromFile(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx");
            Worksheet sheet2 = book.Worksheets[1];

            // Assuming logId corresponds to the row index, adjust as necessary
            for (int row = 2; row <= sheet2.LastRow; row++) // Assuming first row is the header
            {
                if (sheet2.Range[row, 1].Value == logId.ToString()) // Assuming ID is in the first column
                {
                    // Remove the row using DeleteRow
                    sheet2.DeleteRow(row); // Correct method to delete a row
                    break; // Exit loop after deleting the log
                }
            }

            //book.SaveToFile(@"C:\Users\ACT-STUDENT\Downloads\WindowsApp1_BORINAGAEve\WindowsApp1_BORINAGAEve\Book1(1).xlsx", ExcelVersion.Version2016);
            book.SaveToFile(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx", ExcelVersion.Version2016);
        }

    }
}
