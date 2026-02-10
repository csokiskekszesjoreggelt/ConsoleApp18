using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18;

internal class FileManager
{
    public static List<Pig> fileRead(string filename)
    {
        List<Pig> pigs = new List<Pig>();
        foreach(string lines in File.ReadAllLines(filename, Encoding.UTF8).Skip(1))
        {
            try
            {
                pigs.Add(new Pig(lines.Replace(".",",").Split(';')));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return pigs;
    }
}
