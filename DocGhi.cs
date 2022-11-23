using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyCuaHang
{
    public class DocGhi<T> where T : class, new()
    {
        public static void write(List<T> inputList, string fileName)
        {
            var csvFileConfig = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ',',
            };
            var csvContext = new CsvContext();
            csvContext.Write(inputList, fileName,csvFileConfig);
        }
        public static List<T> read(string fileName)
        {
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true,
            };
            CsvContext ctx = new CsvContext();
            var outputList = ctx.Read<T>(fileName, inputFileDescription);
            return outputList.ToList<T>();
        }
    }
}
