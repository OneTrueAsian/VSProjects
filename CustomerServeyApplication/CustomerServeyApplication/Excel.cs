using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CustomerServeyApplication
{
    class Excel
    {
        String path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        // Opens the path and reads the work book
        public Excel(String path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets[sheet];
        }

        // reads cell values 
        public String ReadCell(int row, int col)
        {
            row++;
            col++;

            // check to see if there is a vlues in cell
            if (ws.Cells[row, col].Value2 != null)
            {
                return ws.Cells[row, col].Value2;
            }
            else {
                return "";
            }
        }

        // Write to cell with values
        public void WriteToCell(int row, int col, string value)
        {
            row++;
            col++;

            // values at row x and col x
            ws.Cells[row, col].Value2 = value;
        }

        // Saves files.. duh
        public void SaveFile()
        {
            wb.Save();
        }

        public void NextEmptyCell()
        {
            var col = ws.UsedRange.Columns["C:C", Type.Missing];

            foreach (Excel.Range item in col.Cells)
            {

            }
        }

        // Saves as new xlsx file
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        // closes the file
        public void Close()
        {
            wb.Close();
        }
    }
}
