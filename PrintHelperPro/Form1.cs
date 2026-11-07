using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace PrintHelperPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public AllPrintingSettings Settings = new AllPrintingSettings();

        public bool AppliedSettings = false;

        public void AddFilesToList()
        {
            OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
            MyOpenFileDialog.Filter = "Pdf Files (*.pdf)|*.pdf";
            MyOpenFileDialog.Multiselect = true;


            DialogResult Result = MyOpenFileDialog.ShowDialog();

            if(Result == DialogResult.OK)
            {
                foreach(string OneFile in MyOpenFileDialog.FileNames)
                {
                    ListViewItem OneItem = new ListViewItem(Path.GetFileName(OneFile));
                    OneItem.SubItems.Add(Utility.GetPdfTotalPages(OneFile).ToString());
                    OneItem.Tag = OneFile;

                    ListViewFiles.Items.Add(OneItem);
                    

                }

                ListViewFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);

                if (ColumnHeaderFileName.Width < 78)
                {
                    ListViewFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

                }
                ListViewFiles.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

                MessageBox.Show("Added Files Successfully!");

            }


        }

        public void LoadAllPrintersNames()
        {
            foreach(string OnePrinter in PrinterSettings.InstalledPrinters)
            {
                ComboBoxPrinterName.Items.Add(OnePrinter);
            }
        }

        public void SelectTheDefaultPrinter()
        {
            PrinterSettings Temp = new PrinterSettings();

            foreach (string OneItem in ComboBoxPrinterName.Items)
            {
                if(OneItem == Temp.PrinterName)
                {
                    ComboBoxPrinterName.SelectedItem = OneItem;
                }
            }
        }

        public void EnableEdgeBox()
        {
            GroupBoxEdge.Enabled = true;
        }

        public void DisableEdgeBox()
        {
            GroupBoxEdge.Enabled = false;
            RadioButtonShortEdge.Checked = false;
            RadioButtonLongEdge.Checked = false;
        }

        public void LoadStartupOptions()
        {
            GroupBoxEdge.Enabled = false;
            ButtonPrint.Enabled = false;
            RadionButtonOneSide.Checked = true;
            RadioButtonBlack.Checked = true;
            RadioButtonA4.Checked = true;
            RadioButtonAuto.Checked = true;

            LoadAllPrintersNames();
            SelectTheDefaultPrinter();

            ComboBoxPagesPerSheet.SelectedIndex = 0;
        }

        public AllPrintingSettings PrepareSettings()
        {
            AllPrintingSettings Settings = new AllPrintingSettings();

            Settings.MainSettings = new PrinterSettings();

            PaperSize A4Size = new PaperSize();
            PaperSize A3Size = new PaperSize();

            Settings.MainSettings.PrinterName = ComboBoxPrinterName.SelectedItem.ToString();

            if (RadioButtonBlack.Checked)
            {
                Settings.MainSettings.DefaultPageSettings.Color = false;
            }
            else if (RadioButtonColor.Checked)
            {
                Settings.MainSettings.DefaultPageSettings.Color = true;

            }

            foreach(PaperSize size in Settings.MainSettings.PaperSizes)
            {
                if(size.Kind == PaperKind.A4)
                {
                    A4Size = size;
                }
                else if(size.Kind == PaperKind.A3)
                {
                    A3Size = size;
                }
            }

            if (RadioButtonA4.Checked)
            {
                Settings.MainSettings.DefaultPageSettings.PaperSize = A4Size;
            }
            else if (RadioButtonA3.Checked)
            {
                Settings.MainSettings.DefaultPageSettings.PaperSize = A3Size;
            }

            if (ComboBoxPagesPerSheet.SelectedItem.ToString() == "1")
            {
                Settings.NumberPagesPerSheet = 1;
            }

            else if(ComboBoxPagesPerSheet.SelectedItem.ToString() == "2")
            {
                Settings.NumberPagesPerSheet = 2;


            }
            else if(ComboBoxPagesPerSheet.SelectedItem.ToString() == "4")
            {
                Settings.NumberPagesPerSheet = 4;

            }


            if (RadioButtonPortrait.Checked)
            {
                Settings.MainSettings.DefaultPageSettings.Landscape = false;
            }
            else if (RadioButtonLandscape.Checked)
            {
                Settings.MainSettings.DefaultPageSettings.Landscape = true;
            }

            if (RadionButtonOneSide.Checked)
            {
                Settings.MainSettings.Duplex = Duplex.Simplex;
            }
            if (RadioButtonDoubleSided.Checked)
            {
                if (RadioButtonLongEdge.Checked)
                {
                    Settings.MainSettings.Duplex = Duplex.Vertical;
                }
                else if (RadioButtonShortEdge.Checked)
                {
                    Settings.MainSettings.Duplex = Duplex.Horizontal;
                }
            }

            return Settings;


        }

        public void Apply()
        {
            Settings = PrepareSettings();
            ButtonPrint.Enabled = true;
            AppliedSettings = true;

            MessageBox.Show("Applied New Settings Sucessfully!");
        }

        public bool IsThereFiles()
        {
            if(ListViewFiles.Items.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool IsSettingsApplied()
        {
            if (AppliedSettings)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if(IsThereFiles() == false)
            {
                MessageBox.Show("Please Add Files First!");
                return;
            }
            else if (IsSettingsApplied() == false)
            {
                MessageBox.Show("Please Apply Settings First!");
                return;
            }

            PrintEngine MyPrintEngine = new PrintEngine();

            foreach(ListViewItem OneItem in ListViewFiles.Items)
            {
                MyPrintEngine.PrintFile(OneItem.Tag.ToString(), Settings);

            }

            MessageBox.Show("Printing Finished!");

        }


        private void ButtonAddFiles_Click(object sender, EventArgs e)
        {
            AddFilesToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStartupOptions();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void RadioButtonDoubleSided_CheckedChanged(object sender, EventArgs e)
        {
            EnableEdgeBox();
        }

        private void RadionButtonOneSide_CheckedChanged(object sender, EventArgs e)
        {
            DisableEdgeBox();
        }
    }
}
