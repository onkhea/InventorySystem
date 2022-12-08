using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;

namespace InventorySystem.Helper
{
    
    public  class Myhelp
    {
        
        public static string Sql = @"Data Source=192.168.1.100\BCDB;Initial Catalog=testBC;Persist Security Info=True;User ID=sa;Password=@1p2m3g4";
        public static string Type { get; set; }
        public static void Export(GridView gridView)
        {
             var saveDialog = new System.Windows.Forms.SaveFileDialog
            {
                Filter =
                    @"Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html",
                FileName = ""
            };
            if (saveDialog.ShowDialog() == DialogResult.Cancel) return;
            var exportFilePath = saveDialog.FileName;
            var fileExtenstion = new FileInfo(exportFilePath).Extension;

            switch (fileExtenstion)
            {
                case ".xls":
                    gridView.ExportToXls(exportFilePath);
                    break;
                case ".xlsx":
                    gridView.ExportToXlsx(exportFilePath);
                    break;
                case ".rtf":
                    gridView.ExportToRtf(exportFilePath);
                    break;
                case ".pdf":
                    gridView.ExportToPdf(exportFilePath);
                    break;
                case ".html":
                    gridView.ExportToHtml(exportFilePath);
                    break;
                case ".mht":
                    gridView.ExportToMht(exportFilePath);
                    break;
            }

            if (File.Exists(exportFilePath))
            {
                try
                {
                    //Try to open the file and let windows decide how to open it.
                    Process.Start(exportFilePath);
                }
                catch
                {
                    var msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine +
                              "Path: " + exportFilePath;
                    MessageBox.Show(msg, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine +
                          "Path: " + exportFilePath;
                MessageBox.Show(msg, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
