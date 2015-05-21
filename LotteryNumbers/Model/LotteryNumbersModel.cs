using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumbers.Model
{
    public class LotteryNumbersModel : ILotteryNumbersModel
    {
        #region ILotteryNumbersModel Members
        string s;
        public string RetrieveNumbers(string lotto, int min, int max, int choices)
        {
            s = RandomNumberGenerator(min, max, choices);
            return s;
            
        }
        #endregion

        private string RandomNumberGenerator(int min, int max, int choices)
        {
            //Generate randome numberstring based on min and max. numbers must be unique
            //so add them to a list checking to see if the number is already in the list
            List<int> list = new List<int>();
            Random r = new Random();
            string s = null;
            int j;
            while (list.Count < choices)
            {
                j = r.Next(min, max + 1);
                if (!list.Contains(j))
                    list.Add(j);
            }
            
            //Convert the list into an array and then convert the array to a string
            //seperate the elements in the array by a space " "
            list.Sort();
            s = string.Join(" ", list.ToArray());
            return s;
        }

        #region ILotteryNumbersModel Members


        public string RetrieveNumbers()
        {
            //Select 7 random numbers to make up an encore selection
            string s = null;
            Random r = new Random();
            for (int j = 0; j < 7; j++)
                s += r.Next(0, 10); 
            return  s;
        }

        #endregion
    }
}
