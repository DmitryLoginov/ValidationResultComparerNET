using System.IO;
using System.Text;
using System.Text.Json;

using Model;

namespace Utils;

public static class CsvCreator
{
    /*public static void CreateCheckResultCsv(int records)
    {
        if (records <= 0)
        {
            return;
        }

        Csv csv= new Csv();
        
        for (int i = 0; i < records; i++)
        {

        }
    }*/

    public static StringBuilder CreateSampleCsv()
    {
        var header = new string[] { "firstColumn", "secondColumn", "thirdColumn" };

        var data = new List<List<string>>();

        for (int i = 0; i < 10; i++)
        {
            var rowData = new List<string>();

            for (int j = 0; j < 3; j++)
            {
                rowData.Add($"data-{i}-{j}");
            }

            data.Add(rowData);
        }

        var sb = new StringBuilder();
        sb.AppendLine($"{string.Join(";", header)}");
        foreach (var row in data)
        {
            sb.AppendLine(string.Join(";", row));
        }

        return sb;
    }
}
