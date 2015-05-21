using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumbers.Model
{
    interface ILotteryNumbersModel
    {
        String RetrieveNumbers(string lotto, int min, int max, int choices);

        String RetrieveNumbers();
    }
}
