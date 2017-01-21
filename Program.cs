using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMagnolias = int.Parse(Console.ReadLine());
            int numHyacinths = int.Parse(Console.ReadLine());

            int numRoses = int.Parse(Console.ReadLine());
            int numCactuses = int.Parse(Console.ReadLine());
            double inputPriceForGift = double.Parse(Console.ReadLine());

            double priceForOneMagnolias = 3.25;
            double priceForOneHyacinths = 4;
            double priceForOneRoses = 3.50;
            double priceForOneCactuses = 8;

            double orderForMagnolias = numMagnolias * priceForOneMagnolias;
            double orderForHyacinths = numHyacinths * priceForOneHyacinths;
            double orderForRoses = numRoses * priceForOneRoses;
            double orderForCactuses = numCactuses * priceForOneCactuses;

            double allPriceForOrder = orderForMagnolias + orderForHyacinths + orderForRoses + orderForCactuses;
            double sum = allPriceForOrder * 0.05;
            double allPriceForOrdersAftherPayments = allPriceForOrder - sum ;
            double difference = allPriceForOrdersAftherPayments - inputPriceForGift ;
            double result = Math.Abs(difference);
            


            if (difference < 0 )
            {
                double finalResult = Math.Ceiling(result);
                Console.WriteLine("She will have to borrow {0} leva.", finalResult) ;
                
            }
            else
            {
                double finalResult = Math.Floor(result);
                Console.WriteLine("She is left with {0} leva.", finalResult);

            }
        }
    }
}
