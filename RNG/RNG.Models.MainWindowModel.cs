using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RNG.Models
{
    class MainWindowModel
    {
        private TextBox MinNumber;
        private TextBox MaxNumber;
        private Label RandomNumber;
        private RandomNumberGenerator RNG;

        

        public MainWindowModel(
            TextBox MinNumber,
            TextBox MaxNumber,
            Label RandomNumber
            )
        {
            this.MinNumber = MinNumber;
            this.MaxNumber = MaxNumber;
            this.RandomNumber = RandomNumber;

            RNG = new RandomNumberGenerator();
        }

        public void Calc()
        {
            int minNumber = RandomNumberGenerator.DefaultMinNumber;
            int maxNumber = RandomNumberGenerator.DefaultMaxNumber;
            int randomNumber;

            if (
                int.TryParse(this.MinNumber.Text, out minNumber) &&
                int.TryParse(this.MaxNumber.Text, out maxNumber)
                )
            {
                try
                {
                    randomNumber = RNG.GetRandomNumber(minNumber, maxNumber);
                }
                catch
                {
                    randomNumber = RandomNumberGenerator.DefaultErrorNumber;
                    WrongNumberWarn();
                }

                RandomNumber.Content = randomNumber.ToString();
            }
            else
            {
                WrongNumberWarn();
            }

        }

        public void WrongNumberWarn()
        {
            RandomNumber.Content = RandomNumberGenerator.DefaultErrorNumber.ToString();
            MessageBox.Show("Podano nieprawidłowe liczby");
        }
    }
}
