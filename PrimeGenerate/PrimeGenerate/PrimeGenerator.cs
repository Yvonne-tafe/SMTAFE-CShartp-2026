using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeGenerate
{
    internal class PrimeGenerator
    {
        private static int CurrentPrimeAmount = 0;
        public  int[] Generator(int n)
        {
            int CurrentNumber = 1;
            int[] PrimeArray = new int[n];
            PrimeArray[CurrentPrimeAmount++] = CurrentNumber ++;
            while (CurrentPrimeAmount < n)
            {
                if (IsPrime(CurrentNumber) == true)
                {
                    //Console.WriteLine(CurrentNumber+ " is a prime");
                    PrimeArray[CurrentPrimeAmount++] = CurrentNumber;
                }
                CurrentNumber++;
            }
            return PrimeArray;

        //throw new NotImplementedException();

        }
        static Boolean IsPrime(int CurrentNumber)
        {
            //Console.WriteLine("currentnumber: "+CurrentNumber);
            for (int i=2; i<= Math.Sqrt(CurrentNumber); i++)
            {
                //Console.WriteLine(CurrentNumber + "can be divided by " + i +"?");
                if (CurrentNumber % i == 0)
                {
                    //Console.WriteLine(CurrentNumber + " can be divided by "+i);
                    return false;
                }
                //Console.WriteLine(CurrentNumber + " cannot be divided by " + i);
            }
            return true;
        }
    }
}
