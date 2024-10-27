using System;

namespace Model;

public class Csv
{
    //private readonly string _lineBreak;
    
    public string[] Header {get; private set;}

    public List<List<string>> Data {get; private set;} = new List<List<string>>();

    public int[] Key {get; private set;}

    public Csv(string content, bool firstRowHeader = true)
    {
        //TODO: line break
        var rows = content.Split('\n');

        //TODO: empty line
        if (firstRowHeader)
        {
            Header = rows[0].Split(';');
            //TODO: ranges
            var dataRowsCount = rows.Count() - 1;
            for (int i = 1; i < rows.Count(); i++)
            {
                Data.Add(rows[i].Split(';').ToList());
            }
        }
        else
        {
            //TODO: linq
            string headerString = string.Empty;
            var count = rows[0].Split(';').Count();
            for (int i = 0; i < count; i++)
            {
                headerString += $"column{i + 1}";
                if (i != count - 1)
                {
                    headerString += ";";
                }
            }
            Header = headerString.Split(';');
            var dataRowsCount = rows.Count() - 1;
            for (int i = 0; i < rows.Count(); i++)
            {
                Data.Add(rows[i].Split(';').ToList());
            }
        }
    }

    //TODO: validation
    public void SetKeys(params int[] keys)
    {
        Key = keys;
    }

    /*private void SetLineBreak()
    {
        var os = System.Environment.OSVersion.Platform;
        switch (os)
        {
            case PlatformID.Win32NT:
            case PlatformID.Win32S:
            case PlatformID.Win32Windows:
            case PlatformID.WinCE:
            {
                _lineBreak = "\n\r";
                break;
            }
        }
    }*/
}
