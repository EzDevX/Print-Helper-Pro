# PrintHelper Pro

PrintHelper Pro is a Windows desktop application built with C# and Windows Forms to simplify PDF printing and page arrangement.

The application allows users to configure printing options and print multiple PDF files using a selected printer.

## 🚀 Features

- Add multiple PDF files to the printing queue.
- Display PDF file names and page counts.
- Select an installed printer.
- Choose between A4 and A3 paper sizes.
- Choose Portrait or Landscape orientation.
- Print in Color or Black and White.
- Support for One-Sided and Double-Sided printing.
- Choose Long Edge or Short Edge duplex printing.
- N-up printing: 1, 2, or 4 pages per sheet.
- PDF processing using pdfcpu.
- PDF printing using PdfiumViewer.

## 🛠️ Technologies & Dependencies

- C#
- Windows Forms
- .NET Framework 4.5.2
- Visual Studio 2015
- PdfiumViewer 2.13.0.0
- PdfiumViewer Native 2018.4.8.256
- pdfcpu

## 📋 Requirements

- Windows 64-bit.
- .NET Framework 4.5.2 or compatible runtime.
- An installed printer.
- A printer that supports the selected paper size and duplex settings when needed.

## ▶️ How to Use

1. Launch PrintHelper Pro.
2. Click **Add Files** to select PDF documents.
3. Select your printer.
4. Configure the printing settings.
5. Click **Apply Settings**.
6. Click **Print** to start printing.

## 🏗️ Building the Project

1. Clone or download this repository.
2. Open `PrintHelperPro.sln` using Visual Studio 2015.
3. Restore the required NuGet packages.
4. Build the solution.
5. Run the application.

The pdfcpu executable is included in:

`PrintHelperPro/Tools/pdfcpu.exe`

## ⚠️ Project Status

**Current Version: 0.1.0-alpha**

This project is in its early Alpha stage and is actively being developed.

It may contain bugs, incomplete functionality, and unexpected behavior.

Features and implementation details may change in future releases.

## 🐛 Known Issues

- Error handling is still limited.
- Some printing configurations may behave differently depending on the printer.
- Temporary PDF files generated during N-up processing are not automatically cleaned up.
- Multiple queued files with N-up enabled may not all use the selected pages-per-sheet setting correctly.

## 💬 Feedback & Bug Reports

Bug reports, suggestions, and feature requests are welcome.

Please use the GitHub Issues section to report problems or suggest improvements.

## 📜 License

See the LICENSE file for licensing information.