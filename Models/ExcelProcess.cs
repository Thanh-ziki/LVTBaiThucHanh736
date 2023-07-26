using System.Data;
using OfficeOpenXml;
namespace MvcMovie.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string strPath)
        {
            FileInfo fi = new FileInfo(strPath);
            ExcelPackage excelPackage = new ExcelPackage(fi);
            DataTable dt=new DataTable();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
            if (worksheet.Dimension == null)
            {
                return dt;
            }
            List<string> columnNames =new List<string>();
            int currentColumn = 1;
            foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
            {
                string columnName = cell.Text.Trim();
                if (cell.Start.Column != currentColumn)
                {
                    columnNames.Add("header_" + currentColumn);
                    dt.Columns.Add("Header_" + currentColumn);
                    currentColumn++;
                }
                columnNames.Add(columnName);
                int occrrences = columnName.Count(x => x.Equals(columnName));
                {
                    columnName = columnName + "=" + occrrences;
                }
                dt.Columns.Add(columnName);
                currentColumn++;
            }
            
        }
    }
}