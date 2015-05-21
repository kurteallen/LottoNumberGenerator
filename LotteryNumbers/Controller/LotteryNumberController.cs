using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotteryNumbers.View;
using LotteryNumbers.Model;

namespace LotteryNumbers.Controller
{
    public class LotteryNumberController
    {
        LotteryForm view;

        public LotteryNumberController(LotteryForm view)
        {
            this.view = view;
        }

        public string RetrieveNumbers(string lotto, int min, int max, int choices)
        {
            LotteryNumbersModel model = new LotteryNumbersModel();
            return model.RetrieveNumbers(lotto, min, max, choices);
            
        }

        public string RetrieveNumbers()
        {
            LotteryNumbersModel model = new LotteryNumbersModel();
            return model.RetrieveNumbers();
        }


    }
}
