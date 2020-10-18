using win32 = Microsoft.Win32;
using System.Windows;
using System.Windows.Forms;

namespace WPFParser.Tools
{
    class FileSystem : IFFileSystemInterface
    {
        public string GetFileSystem(string iFileType)
        {
            // -----------------------------------------------------------------------------------------------------------
            // Public Function to get the Part List
            // -----------------------------------------------------------------------------------------------------------

            // Operations
            // -----------------------------------------------------------------------------------------
            string fileName = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
                      
                openFileDialog.Title = "Bitte wählen Sie die File";

                openFileDialog.Filter = GetFileType(iFileType);
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    fileName = openFileDialog.FileName;
           
           
            return fileName;
        }

        string GetFileType(string iType)
        {
            switch (iType)
            {
                case "Excel":
                    return "Excel Files|*.xls;*.xlsm;*.xlsx";
                case "Access":
                    return "Access Files|*.mdb;*.accdb";
                case "Text":
                    return "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                default:
                    return null;
            }
        }

    }
}
