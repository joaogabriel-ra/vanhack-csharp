using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanhack
{
    public class CSharpChallengeThree
    {
        public string FindRoutes(List<List<string>> routes)
        {
            Dictionary<string, string> destinations = new Dictionary<string, string>();

            foreach (List<string> route in routes)
            {
                destinations[route[0]] = route[1];
            }

            string result = "";
            string currentDestination = "";

            foreach (KeyValuePair<string, string> destination in destinations)
            {
                if (!destinations.Values.Contains(destination.Key))
                {
                    result = destination.Key;
                    currentDestination = destination.Value;
                }
            }

            if (destinations.Count == 1) return result + ", " + currentDestination;

            bool firstDestination = true;

            while (destinations.ContainsKey(currentDestination))
            {
                if (firstDestination)
                {
                    result = result + ", " + currentDestination;
                    firstDestination = false;
                }
                else
                {
                    currentDestination = destinations[currentDestination];
                    result += ", " + currentDestination;
                }
            }

            return result;
        }
    }
}
