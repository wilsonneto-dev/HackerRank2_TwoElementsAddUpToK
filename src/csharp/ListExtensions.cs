using System.Collections.Generic;

namespace csharp 
{
    public static class ListExtensions 
    {
        public static bool TwoElementsAddUpToK(this List<int> list,  int k)
        {
            HashSet<int> passedNumbers = new HashSet<int>();
            // O(n)
            foreach (int num in list)
            {
                if(num > k)
                    continue;

                int perfectMatch = k - num;
                
                if(num == perfectMatch)
                    continue;

                // o(1)
                if(passedNumbers.Contains(perfectMatch))
                    return true;

                passedNumbers.Add(num);

                // O(n)
                // if(list.Contains(perfectMatch))
                    // return true;

            }

            return false;
        }
    }
}