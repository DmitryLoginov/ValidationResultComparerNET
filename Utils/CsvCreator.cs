using System.IO;
using System.Text.Json;

using Model;

namespace Utils;

public static class CsvCreator
{
    public static void CreateCheckResultCsv(int records)
    {
        if (records <= 0)
        {
            return;
        }

        Csv csv= new Csv();
        
        for (int i = 0; i < records; i++)
        {

        }
    }
}
