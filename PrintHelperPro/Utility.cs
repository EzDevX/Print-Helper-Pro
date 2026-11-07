using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfiumViewer;
using System.Drawing.Printing;

namespace PrintHelperPro
{
    static public class Utility
    {
        static public int GetPdfTotalPages(string FileName)
        {
            int Pages = 0;

            PdfDocument pdfFile = PdfDocument.Load(FileName);

            Pages = pdfFile.PageCount;

            pdfFile.Dispose();

            return Pages;

        }

    }
}
