using Model;
using Utils;

namespace Model
{
    public static class CsvComparer
    {
        public static Csv placeholder(Csv baseFile, string columnName, params Csv[] csvs)
        {

        }

        private static Csv placeholder2(string columnName, params Csv[] csvs)
        {
            // merge data from key columns of every csv
            var newHeader = string.Empty;
            foreach (var column in csvs[0].Key)
            {
                newHeader += csvs[0].Header[column] + ";";
            }
            //newHeader.TrimEnd(';');
            // append new column (columnName)
            newHeader += columnName;
            // create one big csv with only keys
            var newData = new List<List<string>>();
            // sort this csv
        }
    }
}