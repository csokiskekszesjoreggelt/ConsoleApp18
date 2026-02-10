namespace ConsoleApp18;

internal class Program
{
    static void Main(string[] args)
    {
        List<Pig> pigs = FileManager.fileRead("disznok.csv");
        foreach (Pig pig in pigs)
        {
            Console.WriteLine(pig);
        }
        int oldestPig = 0;
        foreach (Pig pig in pigs)
        {
            if (pig.Age > pigs[oldestPig].Age)
            {
                oldestPig = pigs.IndexOf(pig);
            }
        }
        Console.WriteLine(oldestPig);
        double heaviestpig = 0;
        for (int i = 0; i < pigs.Count; i++)
        {
            if (pigs[i].weight > heaviestpig)
            {
                heaviestpig = pigs[i].weight;
            }
        }
        Console.WriteLine(heaviestpig);

        foreach (Pig pig in pigs)
        {
            if (pig.Gender == "kan")
            {
                Console.WriteLine(pig);
            }
        }
        int longestNamePig = 0;
        foreach (Pig pig in pigs)
        {
            if (pig.Name.Length > pigs[longestNamePig].Name.Length)
            {
                longestNamePig = pigs.IndexOf(pig);
            }
        }
        Console.WriteLine(longestNamePig);

        int femalePigs = 0;
        foreach (Pig pig in pigs)
        {
            if (pig.Gender == "koca")
            {
                femalePigs++;
            }
        }
        Console.WriteLine(femalePigs);

        double averageMaleWeight = 0;
        foreach (Pig pig in pigs)
        {
            if (pig.Gender == "kan")
            {
                averageMaleWeight += pig.weight;
            }
        }
        int malePigs = 0;
        foreach (Pig pig in pigs)
        {
            if (pig.Gender == "kan")
            {
                malePigs++;
            }
        }
        Console.WriteLine(averageMaleWeight/malePigs);

        int avgerageFemaleAge = 0;
        foreach (Pig pig in pigs)
        {
            if (pig.Gender == "koca")
            {
                avgerageFemaleAge += pig.Age;
            }
        }
        Console.WriteLine(avgerageFemaleAge/femalePigs);
        double averageWeight = 0;
        foreach (Pig pig in pigs)
        {
            averageWeight += pig.weight;
        }
        Console.WriteLine(averageWeight/pigs.Count);

       
    }
}
