using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RNG
{
    class RandomNumberGenerator
    {
        public static int DefaultErrorNumber = 0;
        public static int DefaultMinNumber = 0;
        public static int DefaultMaxNumber = 10;
        
        private Random Random;

        public int GetRandomNumber(int MinNumber, int MaxNumber)
        {
            int number;

            if (Random is null)
            {
                InitRandom();
            }

            try
            {
                number = Random.Next(MinNumber, MaxNumber + 1);
            }
            catch (Exception e)
            {
                throw e;
            }

            return number;
        }

        private void InitRandom()
        {
            Random = new Random();
        }
    }
}
