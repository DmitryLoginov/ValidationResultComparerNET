using System;

namespace Model;

public class Csv
{
    public string[] Header {get; set;} = [];

    public string[][] Data {get; set;} = [];

    public int[] Key {get; set;} = [];
}
