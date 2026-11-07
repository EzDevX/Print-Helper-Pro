namespace PrintHelperPro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListViewFiles = new System.Windows.Forms.ListView();
            this.ColumnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelFilesList = new System.Windows.Forms.Label();
            this.ButtonAddFiles = new System.Windows.Forms.Button();
            this.GroupBoxColor = new System.Windows.Forms.GroupBox();
            this.RadioButtonColor = new System.Windows.Forms.RadioButton();
            this.RadioButtonBlack = new System.Windows.Forms.RadioButton();
            this.GroupBoxSize = new System.Windows.Forms.GroupBox();
            this.RadioButtonA3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonA4 = new System.Windows.Forms.RadioButton();
            this.GroupBoxOrientation = new System.Windows.Forms.GroupBox();
            this.RadioButtonAuto = new System.Windows.Forms.RadioButton();
            this.RadioButtonPortrait = new System.Windows.Forms.RadioButton();
            this.RadioButtonLandscape = new System.Windows.Forms.RadioButton();
            this.GroupBoxSided = new System.Windows.Forms.GroupBox();
            this.RadioButtonDoubleSided = new System.Windows.Forms.RadioButton();
            this.RadionButtonOneSide = new System.Windows.Forms.RadioButton();
            this.GroupBoxEdge = new System.Windows.Forms.GroupBox();
            this.RadioButtonLongEdge = new System.Windows.Forms.RadioButton();
            this.RadioButtonShortEdge = new System.Windows.Forms.RadioButton();
            this.LabelPrinterName = new System.Windows.Forms.Label();
            this.ComboBoxPrinterName = new System.Windows.Forms.ComboBox();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.PagesPerSheet = new System.Windows.Forms.Label();
            this.ComboBoxPagesPerSheet = new System.Windows.Forms.ComboBox();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.GroupBoxColor.SuspendLayout();
            this.GroupBoxSize.SuspendLayout();
            this.GroupBoxOrientation.SuspendLayout();
            this.GroupBoxSided.SuspendLayout();
            this.GroupBoxEdge.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewFiles
            // 
            this.ListViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderFileName,
            this.ColumnPages});
            this.ListViewFiles.Location = new System.Drawing.Point(12, 55);
            this.ListViewFiles.Name = "ListViewFiles";
            this.ListViewFiles.Size = new System.Drawing.Size(440, 415);
            this.ListViewFiles.TabIndex = 0;
            this.ListViewFiles.UseCompatibleStateImageBehavior = false;
            this.ListViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaderFileName
            // 
            this.ColumnHeaderFileName.Text = "File Name";
            this.ColumnHeaderFileName.Width = 78;
            // 
            // ColumnPages
            // 
            this.ColumnPages.Text = "Pages";
            // 
            // LabelFilesList
            // 
            this.LabelFilesList.AutoSize = true;
            this.LabelFilesList.Location = new System.Drawing.Point(12, 26);
            this.LabelFilesList.Name = "LabelFilesList";
            this.LabelFilesList.Size = new System.Drawing.Size(53, 13);
            this.LabelFilesList.TabIndex = 1;
            this.LabelFilesList.Text = "Files List :";
            // 
            // ButtonAddFiles
            // 
            this.ButtonAddFiles.Location = new System.Drawing.Point(327, 12);
            this.ButtonAddFiles.Name = "ButtonAddFiles";
            this.ButtonAddFiles.Size = new System.Drawing.Size(125, 27);
            this.ButtonAddFiles.TabIndex = 2;
            this.ButtonAddFiles.Text = "Add Files";
            this.ButtonAddFiles.UseVisualStyleBackColor = true;
            this.ButtonAddFiles.Click += new System.EventHandler(this.ButtonAddFiles_Click);
            // 
            // GroupBoxColor
            // 
            this.GroupBoxColor.Controls.Add(this.RadioButtonColor);
            this.GroupBoxColor.Controls.Add(this.RadioButtonBlack);
            this.GroupBoxColor.Location = new System.Drawing.Point(469, 55);
            this.GroupBoxColor.Name = "GroupBoxColor";
            this.GroupBoxColor.Size = new System.Drawing.Size(195, 89);
            this.GroupBoxColor.TabIndex = 3;
            this.GroupBoxColor.TabStop = false;
            this.GroupBoxColor.Text = "Color :";
            // 
            // RadioButtonColor
            // 
            this.RadioButtonColor.AutoSize = true;
            this.RadioButtonColor.Location = new System.Drawing.Point(15, 54);
            this.RadioButtonColor.Name = "RadioButtonColor";
            this.RadioButtonColor.Size = new System.Drawing.Size(49, 17);
            this.RadioButtonColor.TabIndex = 4;
            this.RadioButtonColor.TabStop = true;
            this.RadioButtonColor.Text = "Color";
            this.RadioButtonColor.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBlack
            // 
            this.RadioButtonBlack.AutoSize = true;
            this.RadioButtonBlack.Location = new System.Drawing.Point(15, 28);
            this.RadioButtonBlack.Name = "RadioButtonBlack";
            this.RadioButtonBlack.Size = new System.Drawing.Size(104, 17);
            this.RadioButtonBlack.TabIndex = 4;
            this.RadioButtonBlack.TabStop = true;
            this.RadioButtonBlack.Text = "Black and White";
            this.RadioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSize
            // 
            this.GroupBoxSize.Controls.Add(this.RadioButtonA3);
            this.GroupBoxSize.Controls.Add(this.RadioButtonA4);
            this.GroupBoxSize.Location = new System.Drawing.Point(695, 55);
            this.GroupBoxSize.Name = "GroupBoxSize";
            this.GroupBoxSize.Size = new System.Drawing.Size(195, 56);
            this.GroupBoxSize.TabIndex = 3;
            this.GroupBoxSize.TabStop = false;
            this.GroupBoxSize.Text = "Paper Size :";
            // 
            // RadioButtonA3
            // 
            this.RadioButtonA3.AutoSize = true;
            this.RadioButtonA3.Location = new System.Drawing.Point(81, 24);
            this.RadioButtonA3.Name = "RadioButtonA3";
            this.RadioButtonA3.Size = new System.Drawing.Size(38, 17);
            this.RadioButtonA3.TabIndex = 4;
            this.RadioButtonA3.TabStop = true;
            this.RadioButtonA3.Text = "A3";
            this.RadioButtonA3.UseVisualStyleBackColor = true;
            // 
            // RadioButtonA4
            // 
            this.RadioButtonA4.AutoSize = true;
            this.RadioButtonA4.Location = new System.Drawing.Point(15, 24);
            this.RadioButtonA4.Name = "RadioButtonA4";
            this.RadioButtonA4.Size = new System.Drawing.Size(38, 17);
            this.RadioButtonA4.TabIndex = 4;
            this.RadioButtonA4.TabStop = true;
            this.RadioButtonA4.Text = "A4";
            this.RadioButtonA4.UseVisualStyleBackColor = true;
            // 
            // GroupBoxOrientation
            // 
            this.GroupBoxOrientation.Controls.Add(this.RadioButtonAuto);
            this.GroupBoxOrientation.Controls.Add(this.RadioButtonPortrait);
            this.GroupBoxOrientation.Controls.Add(this.RadioButtonLandscape);
            this.GroupBoxOrientation.Location = new System.Drawing.Point(469, 160);
            this.GroupBoxOrientation.Name = "GroupBoxOrientation";
            this.GroupBoxOrientation.Size = new System.Drawing.Size(195, 117);
            this.GroupBoxOrientation.TabIndex = 3;
            this.GroupBoxOrientation.TabStop = false;
            this.GroupBoxOrientation.Text = "Orientation :";
            // 
            // RadioButtonAuto
            // 
            this.RadioButtonAuto.AutoSize = true;
            this.RadioButtonAuto.Location = new System.Drawing.Point(15, 81);
            this.RadioButtonAuto.Name = "RadioButtonAuto";
            this.RadioButtonAuto.Size = new System.Drawing.Size(47, 17);
            this.RadioButtonAuto.TabIndex = 4;
            this.RadioButtonAuto.TabStop = true;
            this.RadioButtonAuto.Text = "Auto";
            this.RadioButtonAuto.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPortrait
            // 
            this.RadioButtonPortrait.AutoSize = true;
            this.RadioButtonPortrait.Location = new System.Drawing.Point(15, 54);
            this.RadioButtonPortrait.Name = "RadioButtonPortrait";
            this.RadioButtonPortrait.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonPortrait.TabIndex = 4;
            this.RadioButtonPortrait.TabStop = true;
            this.RadioButtonPortrait.Text = "Portrait";
            this.RadioButtonPortrait.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLandscape
            // 
            this.RadioButtonLandscape.AutoSize = true;
            this.RadioButtonLandscape.Location = new System.Drawing.Point(15, 28);
            this.RadioButtonLandscape.Name = "RadioButtonLandscape";
            this.RadioButtonLandscape.Size = new System.Drawing.Size(78, 17);
            this.RadioButtonLandscape.TabIndex = 4;
            this.RadioButtonLandscape.TabStop = true;
            this.RadioButtonLandscape.Text = "Landscape";
            this.RadioButtonLandscape.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSided
            // 
            this.GroupBoxSided.Controls.Add(this.RadioButtonDoubleSided);
            this.GroupBoxSided.Controls.Add(this.RadionButtonOneSide);
            this.GroupBoxSided.Location = new System.Drawing.Point(695, 160);
            this.GroupBoxSided.Name = "GroupBoxSided";
            this.GroupBoxSided.Size = new System.Drawing.Size(195, 60);
            this.GroupBoxSided.TabIndex = 3;
            this.GroupBoxSided.TabStop = false;
            this.GroupBoxSided.Text = "Sided :";
            // 
            // RadioButtonDoubleSided
            // 
            this.RadioButtonDoubleSided.AutoSize = true;
            this.RadioButtonDoubleSided.Location = new System.Drawing.Point(102, 24);
            this.RadioButtonDoubleSided.Name = "RadioButtonDoubleSided";
            this.RadioButtonDoubleSided.Size = new System.Drawing.Size(89, 17);
            this.RadioButtonDoubleSided.TabIndex = 4;
            this.RadioButtonDoubleSided.TabStop = true;
            this.RadioButtonDoubleSided.Text = "Double Sided";
            this.RadioButtonDoubleSided.UseVisualStyleBackColor = true;
            this.RadioButtonDoubleSided.CheckedChanged += new System.EventHandler(this.RadioButtonDoubleSided_CheckedChanged);
            // 
            // RadionButtonOneSide
            // 
            this.RadionButtonOneSide.AutoSize = true;
            this.RadionButtonOneSide.Location = new System.Drawing.Point(15, 24);
            this.RadionButtonOneSide.Name = "RadionButtonOneSide";
            this.RadionButtonOneSide.Size = new System.Drawing.Size(69, 17);
            this.RadionButtonOneSide.TabIndex = 4;
            this.RadionButtonOneSide.TabStop = true;
            this.RadionButtonOneSide.Text = "One Side";
            this.RadionButtonOneSide.UseVisualStyleBackColor = true;
            this.RadionButtonOneSide.CheckedChanged += new System.EventHandler(this.RadionButtonOneSide_CheckedChanged);
            // 
            // GroupBoxEdge
            // 
            this.GroupBoxEdge.Controls.Add(this.RadioButtonLongEdge);
            this.GroupBoxEdge.Controls.Add(this.RadioButtonShortEdge);
            this.GroupBoxEdge.Enabled = false;
            this.GroupBoxEdge.Location = new System.Drawing.Point(695, 226);
            this.GroupBoxEdge.Name = "GroupBoxEdge";
            this.GroupBoxEdge.Size = new System.Drawing.Size(195, 51);
            this.GroupBoxEdge.TabIndex = 3;
            this.GroupBoxEdge.TabStop = false;
            this.GroupBoxEdge.Text = "Edge :";
            // 
            // RadioButtonLongEdge
            // 
            this.RadioButtonLongEdge.AutoSize = true;
            this.RadioButtonLongEdge.Location = new System.Drawing.Point(100, 24);
            this.RadioButtonLongEdge.Name = "RadioButtonLongEdge";
            this.RadioButtonLongEdge.Size = new System.Drawing.Size(77, 17);
            this.RadioButtonLongEdge.TabIndex = 4;
            this.RadioButtonLongEdge.TabStop = true;
            this.RadioButtonLongEdge.Text = "Long Edge";
            this.RadioButtonLongEdge.UseVisualStyleBackColor = true;
            // 
            // RadioButtonShortEdge
            // 
            this.RadioButtonShortEdge.AutoSize = true;
            this.RadioButtonShortEdge.Location = new System.Drawing.Point(15, 24);
            this.RadioButtonShortEdge.Name = "RadioButtonShortEdge";
            this.RadioButtonShortEdge.Size = new System.Drawing.Size(78, 17);
            this.RadioButtonShortEdge.TabIndex = 4;
            this.RadioButtonShortEdge.TabStop = true;
            this.RadioButtonShortEdge.Text = "Short Edge";
            this.RadioButtonShortEdge.UseVisualStyleBackColor = true;
            // 
            // LabelPrinterName
            // 
            this.LabelPrinterName.AutoSize = true;
            this.LabelPrinterName.Location = new System.Drawing.Point(468, 296);
            this.LabelPrinterName.Name = "LabelPrinterName";
            this.LabelPrinterName.Size = new System.Drawing.Size(76, 13);
            this.LabelPrinterName.TabIndex = 1;
            this.LabelPrinterName.Text = "Select Printer :";
            // 
            // ComboBoxPrinterName
            // 
            this.ComboBoxPrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPrinterName.FormattingEnabled = true;
            this.ComboBoxPrinterName.Location = new System.Drawing.Point(550, 293);
            this.ComboBoxPrinterName.Name = "ComboBoxPrinterName";
            this.ComboBoxPrinterName.Size = new System.Drawing.Size(340, 21);
            this.ComboBoxPrinterName.TabIndex = 4;
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonPrint.Enabled = false;
            this.ButtonPrint.Location = new System.Drawing.Point(469, 404);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(421, 66);
            this.ButtonPrint.TabIndex = 5;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = false;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // PagesPerSheet
            // 
            this.PagesPerSheet.AutoSize = true;
            this.PagesPerSheet.Location = new System.Drawing.Point(696, 126);
            this.PagesPerSheet.Name = "PagesPerSheet";
            this.PagesPerSheet.Size = new System.Drawing.Size(93, 13);
            this.PagesPerSheet.TabIndex = 1;
            this.PagesPerSheet.Text = "Pages Per Sheet :";
            // 
            // ComboBoxPagesPerSheet
            // 
            this.ComboBoxPagesPerSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPagesPerSheet.FormattingEnabled = true;
            this.ComboBoxPagesPerSheet.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.ComboBoxPagesPerSheet.Location = new System.Drawing.Point(795, 123);
            this.ComboBoxPagesPerSheet.Name = "ComboBoxPagesPerSheet";
            this.ComboBoxPagesPerSheet.Size = new System.Drawing.Size(95, 21);
            this.ComboBoxPagesPerSheet.TabIndex = 4;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Location = new System.Drawing.Point(467, 360);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(423, 38);
            this.ButtonApply.TabIndex = 6;
            this.ButtonApply.Text = "Apply Settings";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 518);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.ComboBoxPagesPerSheet);
            this.Controls.Add(this.ComboBoxPrinterName);
            this.Controls.Add(this.GroupBoxSize);
            this.Controls.Add(this.GroupBoxEdge);
            this.Controls.Add(this.GroupBoxSided);
            this.Controls.Add(this.GroupBoxOrientation);
            this.Controls.Add(this.GroupBoxColor);
            this.Controls.Add(this.PagesPerSheet);
            this.Controls.Add(this.ButtonAddFiles);
            this.Controls.Add(this.LabelPrinterName);
            this.Controls.Add(this.LabelFilesList);
            this.Controls.Add(this.ListViewFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxColor.ResumeLayout(false);
            this.GroupBoxColor.PerformLayout();
            this.GroupBoxSize.ResumeLayout(false);
            this.GroupBoxSize.PerformLayout();
            this.GroupBoxOrientation.ResumeLayout(false);
            this.GroupBoxOrientation.PerformLayout();
            this.GroupBoxSided.ResumeLayout(false);
            this.GroupBoxSided.PerformLayout();
            this.GroupBoxEdge.ResumeLayout(false);
            this.GroupBoxEdge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewFiles;
        private System.Windows.Forms.ColumnHeader ColumnHeaderFileName;
        private System.Windows.Forms.ColumnHeader ColumnPages;
        private System.Windows.Forms.Label LabelFilesList;
        private System.Windows.Forms.Button ButtonAddFiles;
        private System.Windows.Forms.GroupBox GroupBoxColor;
        private System.Windows.Forms.RadioButton RadioButtonColor;
        private System.Windows.Forms.RadioButton RadioButtonBlack;
        private System.Windows.Forms.GroupBox GroupBoxSize;
        private System.Windows.Forms.RadioButton RadioButtonA3;
        private System.Windows.Forms.RadioButton RadioButtonA4;
        private System.Windows.Forms.GroupBox GroupBoxOrientation;
        private System.Windows.Forms.RadioButton RadioButtonAuto;
        private System.Windows.Forms.RadioButton RadioButtonPortrait;
        private System.Windows.Forms.RadioButton RadioButtonLandscape;
        private System.Windows.Forms.GroupBox GroupBoxSided;
        private System.Windows.Forms.RadioButton RadioButtonDoubleSided;
        private System.Windows.Forms.RadioButton RadionButtonOneSide;
        private System.Windows.Forms.GroupBox GroupBoxEdge;
        private System.Windows.Forms.RadioButton RadioButtonLongEdge;
        private System.Windows.Forms.RadioButton RadioButtonShortEdge;
        private System.Windows.Forms.Label LabelPrinterName;
        private System.Windows.Forms.ComboBox ComboBoxPrinterName;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Label PagesPerSheet;
        private System.Windows.Forms.ComboBox ComboBoxPagesPerSheet;
        private System.Windows.Forms.Button ButtonApply;
    }
}

