using System.IO;
using System;
using Aspose.Cells;
using Aspose.Cells.Rendering;
using System.Drawing.Imaging;

namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class ExportToHTMLWithGridLines
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            // Create your workbook
            Workbook wb = new Workbook();

            // Access first worksheet
            Worksheet ws = wb.Worksheets[0];

            // Fill worksheet with some integer values
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    ws.Cells[r, c].PutValue(r * 1);
                }
            }

            // Save your workbook in HTML format and export gridlines
            HtmlSaveOptions opts = new HtmlSaveOptions();
            opts.ExportGridLines = true;
            wb.Save(dataDir + "ExportToHTMLWithGridLines_out_.html", opts);
            // ExEnd:1           
            
        }
    }
}
