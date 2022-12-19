using System;
using System.Linq;

namespace vanhack
{
    public class CSharpChallengeTwo
    {
        public string OrderWeight(string str)
        {
            var list = str.Split(' ').Select(number =>
            {
                var weight = number.ToCharArray().Select(c => int.Parse(c.ToString())).Sum();

                return new
                {
                    Weight = weight,
                    Number = number
                };
            });

            var orderedList = list.OrderBy(e => e.Weight).ThenBy(e => e.Number);

            return string.Join(' ', orderedList.Select(e => e.Number));
        }
    }
}
