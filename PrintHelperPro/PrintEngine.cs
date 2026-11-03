using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfiumViewer;

namespace PrintHelperPro
{
    public class PrintEngine
    {
        public void Test(string Input , string Output)
        {

            PdfSharp.Pdf.PdfDocument Document = PdfReader.Open(Input, PdfDocumentOpenMode.Modify);
            Document.Save(Output);
            Document.Close();

        }

    }
}
