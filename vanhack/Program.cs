using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanhack
{
    public static class Program
    {
        public static void Main()
        {
            CSharpChallengeOne cSharpChallengeOne = new CSharpChallengeOne();
            var result = cSharpChallengeOne.ParseCsv("1\t2\t3\n4\t5\t6", "\t", "\"");
            foreach (var r in result)
            {
                foreach (var c in r)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            //CSharpChallengeTwo cSharpChallengeTwo = new CSharpChallengeTwo();
            //Console.WriteLine(cSharpChallengeTwo.OrderWeight("11 44444444 2000 9999 1234000 123 22 10003"));

            //CSharpChallengeThree cSharpChallengeThree = new CSharpChallengeThree();
            //Console.WriteLine(cSharpChallengeThree.FindRoutes(new List<List<string>> { new List<string> { "MNL", "TAG" }, new List<string> { "CEB", "TAC" }, new List<string> { "TAG", "CEB" }, new List<string> { "TAC", "BOR" } }));
        }
    }
}
