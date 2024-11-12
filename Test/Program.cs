using Model;
using Utils;
using System.IO;
using System.Text;

/*string line;
StringBuilder sb = new StringBuilder();
try
{
    StreamReader sr = new StreamReader("/home/dmitry/Загрузки/testCsvWithoutHeader.csv");
    line = sr.ReadLine();
    while(line != null)
    {
        sb.AppendLine(line);
        line = sr.ReadLine();
    }
    sr.Close();

    //System.Console.WriteLine(sb.ToString());

    Csv csv = new Csv(sb.ToString(), false);

    System.Console.WriteLine(string.Join(";", csv.Header));
    System.Console.WriteLine(string.Join(";", csv.Data[0]));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.ReadLine();
}
*/

var csvSample = CsvCreator.CreateSampleCsv();

File.WriteAllText(@"/home/dmitry/sample.csv", csvSample.ToString());

Console.ReadLine();
