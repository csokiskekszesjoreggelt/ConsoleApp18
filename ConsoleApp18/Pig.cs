using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18;

internal class Pig
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public double weight { get; set; }


    public Pig(string[] data)
    {
        Name = data[0];
        Age = int.Parse(data[3]);
        Gender = data[1];
        weight = double.Parse(data[2]);
    }


    public override string ToString()
    {
        return $"name:{Name} \n age:{Age} \n gender:{Gender} \n weight {weight}";
    }

    public string Rename(string newName)
    {
        Name = newName;
        return $"the new name is: {Name}";
    }
    public double Feed(double amount)
    {
        weight = weight*1.01;
        return weight;
    }
}
