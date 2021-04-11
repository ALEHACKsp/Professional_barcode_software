using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace ExcelToPdf
{
    public class ExcelApplicationWrapper : IDisposable
    {
        public Application ExcelApplication { get; }

        public ExcelApplicationWrapper()
        {
            ExcelApplication = new Application();
        }

        public void Dispose()
        {
            // Each file I open is locked by the background EXCEL.exe until it is quitted
            ExcelApplication.Quit();
            Marshal.ReleaseComObject(ExcelApplication);
        }
    }

public class ExcelInteropExcelToPdfConverter
{
    public void ConvertToPdf(IEnumerable<string> excelFilesPathToConvert)
    {
            using (var excelApplication = new ExcelApplicationWrapper())
            {
                foreach (var excelFilePath in excelFilesPathToConvert)
                {
                    var thisFileWorkbook = excelApplication.ExcelApplication.Workbooks.Open(excelFilePath);
                    string newPdfFilePath = Path.Combine(
                        Path.GetDirectoryName(excelFilePath),
                        $"{Path.GetFileNameWithoutExtension(excelFilePath)}.pdf");

                    thisFileWorkbook.ExportAsFixedFormat(
                        Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
                        newPdfFilePath);

                    thisFileWorkbook.Close(false, excelFilePath);
                    Marshal.ReleaseComObject(thisFileWorkbook);
                }
            }
        }
    }

}
