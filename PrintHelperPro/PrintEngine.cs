using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfiumViewer;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;

namespace PrintHelperPro
{

    public class AllPrintingSettings
    {
        public PrinterSettings MainSettings;
        public int NumberPagesPerSheet;

    }

    public class PrintEngine
    {

        PdfDocument PdfFile;

        private string ConvertPdfToNup(string FileName , int NumberOfPagesPerSheet , string PaperSize , string Orientation)
        {
            string ProgramPath = Path.Combine(Program.GetMainAppPath(), "Tools", "pdfcpu.exe");
            string NewFile = Path.GetDirectoryName(FileName) + "\\" + Path.GetFileNameWithoutExtension(FileName)+"TEMPEZZX.pdf";

            string Args = "nup" + " \"Form:" + PaperSize + Orientation + "\"" + " " + "\"" + NewFile + "\"" + " " + NumberOfPagesPerSheet.ToString() + " " + "\"" + FileName + "\"";
            Debug.WriteLine(Args);

            ProcessStartInfo Pros = new ProcessStartInfo();
            Pros.FileName = ProgramPath;
            Pros.UseShellExecute = false;
            Pros.CreateNoWindow = true;
            Pros.Arguments = Args;

            Process Pro = Process.Start(Pros);
            Pro.WaitForExit();
            Pro.Dispose();
            

            return NewFile;


        }

        public void PrintNup(string FileName , AllPrintingSettings Settings)
        {

            int PagesPerSheet = Settings.NumberPagesPerSheet;
            string PaperSize = Settings.MainSettings.DefaultPageSettings.PaperSize.PaperName;
            string Orientation = "P";

            if (Settings.MainSettings.DefaultPageSettings.Landscape == true)
            {
                Orientation = "L";
            }
            else if (Settings.MainSettings.DefaultPageSettings.Landscape == false)
            {
                Orientation = "P";
            }

            string NewFile = ConvertPdfToNup(FileName, PagesPerSheet, PaperSize, Orientation);

            Settings.NumberPagesPerSheet = 1;

            PrintFile(NewFile, Settings);

        }

        public void PrintFile(string FileName , AllPrintingSettings Settings)
        {

            PdfFile = PdfDocument.Load(FileName);
            PrintDocument Doc = PdfFile.CreatePrintDocument();
            Doc.PrinterSettings = Settings.MainSettings;

            if (Settings.NumberPagesPerSheet == 1)
            {

                Doc.Print();
                Doc.Dispose();


            }
            else if(Settings.NumberPagesPerSheet > 1)
            {
                Doc.Dispose();
                PrintNup(FileName, Settings);
                
            }


            PdfFile.Dispose();


        }


    }
}
