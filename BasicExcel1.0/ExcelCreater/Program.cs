using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML;
using ClosedXML.Excel;

namespace ExcelCreater
{
    class Program
    {
        static void Main(string[] args)
        {

            // start the excel machine.
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("SheetName");
            var ws = workbook.Worksheet("SheetName");

            ws.Cell("A1").Value = "Hello World!";

            var fileName = @"C:\test\abc.xlsx";
            var fi = new FileInfo(fileName);
            if (fi.Exists) File.Delete(fileName);

            workbook.SaveAs(fileName);
        }
    }
}
