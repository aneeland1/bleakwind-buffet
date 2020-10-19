/*
 * Author: Amy Neeland
 * Class: RegisterViewModel.cs
 * Purpose: This class represents the Register
 */

using System;
using System.Collections.Generic;
using System.Text;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// class to represent properties and methods of a cash register
    /// </summary>
    public class RegisterViewModel
    {
        /// <summary>
        /// private variables for properties
        /// </summary>
        private int inHundreds = 0;
        private int inFifties = 0;
        private int inTwenties = 0;
        private int inTens = 0;
        private int inFives = 0;
        private int inTwos = 0;
        private int inOnes = 0;
        private int inDollars = 0;
        private int inHalfDollars = 0;
        private int inQuarters = 0;
        private int inDimes = 0;
        private int inNickels = 0;
        private int inPennies = 0;
        private int outHundreds = 0;
        private int outFifties = 0;
        private int outTwenties = 0;
        private int outTens = 0;
        private int outFives = 0;
        private int outTwos = 0;
        private int outOnes = 0;
        private int outDollars = 0;
        private int outHalfDollars = 0;
        private int outQuarters = 0;
        private int outDimes = 0;
        private int outNickels = 0;
        private int outPennies = 0;

        /// <summary>
        /// property for hundreds in drawer
        /// </summary>
        public static int Hundreds { get; set; } = 0;

        /// <summary>
        /// property for fifties in drawer
        /// </summary>
        public static int Fifties { get; set; } = 0;

        /// <summary>
        /// property for twenties in drawer
        /// </summary>
        public static int Twenties { get; set; } = 0;

        /// <summary>
        /// property for tens in drawer
        /// </summary>
        public static int Tens { get; set; } = 1;

        /// <summary>
        /// property for fives in drawer
        /// </summary>
        public static int Fives { get; set; } = 10;

        /// <summary>
        /// property for twos in drawer
        /// </summary>
        public static int Twos { get; set; } = 0;

        /// <summary>
        /// property for ones in drawer
        /// </summary>
        public static int Ones { get; set; } = 22;

        /// <summary>
        /// property for dolar coins in drawer
        /// </summary>
        public static int Dollars { get; set; } = 0;

        /// <summary>
        /// property for half in drawer
        /// </summary>
        public static int HalfDollars { get; set; } = 0;

        /// <summary>
        /// property for quarters in drawer
        /// </summary>
        public static int Quarters { get; set; } = 40;

        /// <summary>
        /// property for dimes in drawer
        /// </summary>
        public static int Dimes { get; set; } = 50;

        /// <summary>
        /// property for nickels in drawer
        /// </summary>
        public static int Nickels { get; set; } = 40;

        /// <summary>
        /// property for pennies in drawer
        /// </summary>
        public static int Pennies { get; set; } = 100;

        /// <summary>
        /// property for hundreds from customer
        /// </summary>
        public int InHundreds
        {
            get
            {
                return inHundreds;
            }
            set
            {
                inHundreds = value;
                Hundreds += value;
            }
        }

        /// <summary>
        /// property for fifties from customer
        /// </summary>
        public int InFifties
        {
            get
            {
                return inFifties;
            }
            set
            {
                inFifties = value;
                Fifties += value;
            }
        }

        /// <summary>
        /// property for twenties from customer
        /// </summary>
        public int InTwenties
        {
            get
            {
                return inTwenties;
            }
            set
            {
                inTwenties = value;
                Twenties += value;
            }
        }

        /// <summary>
        /// property for tens from customer
        /// </summary>
        public int InTens
        {
            get
            {
                return inTens;
            }
            set
            {
                inTens = value;
                Tens += value;
            }
        }

        /// <summary>
        /// property for fives from customer
        /// </summary>
        public int InFives
        {
            get
            {
                return inFives;
            }
            set
            {
                inFives = value;
                Fives += value;
            }
        }

        /// <summary>
        /// property for twos from customer
        /// </summary>
        public int InTwos
        {
            get
            {
                return inTwos;
            }
            set
            {
                inTwos = value;
                Twos += value;
            }
        }

        /// <summary>
        /// property for ones from customer
        /// </summary>
        public int InOnes
        {
            get
            {
                return inOnes;
            }
            set
            {
                inOnes = value;
                Ones += value;
            }
        }

        /// <summary>
        /// property for dollar coins from customer
        /// </summary>
        public int InDollars
        {
            get
            {
                return inDollars;
            }
            set
            {
                inDollars = value;
                Dollars += value;
            }
        }

        /// <summary>
        /// property for half dollar coins from customer
        /// </summary>
        public int InHalfDollars
        {
            get
            {
                return inHalfDollars;
            }
            set
            {
                inHalfDollars = value;
                HalfDollars += value;
            }
        }

        /// <summary>
        /// property for quarters from customer
        /// </summary>
        public int InQuarters
        {
            get
            {
                return inQuarters;
            }
            set
            {
                inQuarters = value;
                Quarters += value;
            }
        }

        /// <summary>
        /// property for dimes from customer
        /// </summary>
        public int InDimes
        {
            get
            {
                return inDimes;
            }
            set
            {
                inDimes = value;
                Dimes += value;
            }
        }

        /// <summary>
        /// property for nickels from customer
        /// </summary>
        public int InNickels
        {
            get
            {
                return inNickels;
            }
            set
            {
                inNickels = value;
                Nickels += value;
            }
        }

        /// <summary>
        /// property for pennies from customer
        /// </summary>
        public int InPennies
        {
            get
            {
                return inPennies;
            }
            set
            {
                inPennies = value;
                Pennies += value;
            }
        }

        /// <summary>
        /// property for hundreds to customer
        /// </summary>
        public int OutHundreds
        {
            get
            {
                return outHundreds;
            }
            set
            {
                outHundreds = value;
                Hundreds -= value;
            }
        }

        /// <summary>
        /// property for fifties to customer
        /// </summary>
        public int OutFifties
        {
            get
            {
                return outFifties;
            }
            set
            {
                outFifties = value;
                Fifties -= value;
            }
        }

        /// <summary>
        /// property for twenties to customer
        /// </summary>
        public int OutTwenties
        {
            get
            {
                return outTwenties;
            }
            set
            {
                outTwenties = value;
                Twenties -= value;
            }
        }

        /// <summary>
        /// property for tens to customer
        /// </summary>
        public int OutTens
        {
            get
            {
                return outTens;
            }
            set
            {
                outTens = value;
                Tens -= value;
            }
        }

        /// <summary>
        /// property for fives to customer
        /// </summary>
        public int OutFives
        {
            get
            {
                return outFives;
            }
            set
            {
                outFives = value;
                Fives -= value;
            }
        }

        /// <summary>
        /// property for twos to customer
        /// </summary>
        public int OutTwos
        {
            get
            {
                return outTwos;
            }
            set
            {
                outTwos = value;
                Twos -= value;
            }
        }

        /// <summary>
        /// property for ones to customer
        /// </summary>
        public int OutOnes
        {
            get
            {
                return outOnes;
            }
            set
            {
                outOnes = value;
                Ones -= value;
            }
        }

        /// <summary>
        /// property for dollar coins to customer
        /// </summary>
        public int OutDollars
        {
            get
            {
                return outDollars;
            }
            set
            {
                outDollars = value;
                Dollars -= value;
            }
        }

        /// <summary>
        /// property for half dollar coins to customer
        /// </summary>
        public int OutHalfDollars
        {
            get
            {
                return outHalfDollars;
            }
            set
            {
                outHalfDollars = value;
                HalfDollars -= value;
            }
        }

        /// <summary>
        /// property for quarters to customer
        /// </summary>
        public int OutQuarters
        {
            get
            {
                return outQuarters;
            }
            set
            {
                outQuarters = value;
                Quarters -= value;
            }
        }

        /// <summary>
        /// property for dimes to customer
        /// </summary>
        public int OutDimes
        {
            get
            {
                return outDimes;
            }
            set
            {
                outDimes = value;
                Dimes -= value;
            }
        }

        /// <summary>
        /// property for nickels to customer
        /// </summary>
        public int OutNickels
        {
            get
            {
                return outNickels;
            }
            set
            {
                outNickels = value;
                Nickels -= value;
            }
        }

        /// <summary>
        /// property for pennies to customer
        /// </summary>
        public int OutPennies
        {
            get
            {
                return outPennies;
            }
            set
            {
                outPennies = value;
                Pennies -= value;
            }
        }

        /// <summary>
        /// Used to process a credit card
        /// </summary>
        /// <param name="amount">amount to charge to credit of debit card</param>
        /// <returns>result of transaction</returns>
        public CardTransactionResult RunCard(double amount)
        {
            return (CardTransactionResult)CardReader.RunCard(amount);
        }

        /// <summary>
        /// Possible results of a card transaction
        /// </summary>
        public enum CardTransactionResult
        {
            Approved,
            Declined,
            InsufficientFunds,
            IncorrectPin,
            ReadError,
        }

        /// <summary>
        /// items to print on a credit card receipt
        /// </summary>
        /// <param name="text">text to print</param>
        public void PrintLine(string text)
        {
            RecieptPrinter.PrintLine(text);
        }

        /// <summary>
        /// cut register tape to remove
        /// </summary>
        public void CutTape()
        {
            RecieptPrinter.CutTape();
        }
                
        /// <summary>
        /// calculates change to go to customer
        /// </summary>
        /// <param name="total">total of order</param>
        public void CalculateChange(double total)
        {
            double payment = (InHundreds * 100.0) + (InFifties * 50) + (InTwenties * 20) + (InTens * 10) + (InFives * 5) + (InTwos * 2) + (InOnes * 1) + (InDollars * 1) +
                (inHalfDollars * .5) + (InQuarters * .25) + (InDimes * .1) + (InNickels * .05) + (InPennies * .01);  //payment made by customer
            double change = payment - total; //change due to the customer
            CashDrawer.OpenDrawer(); //opens the cash drawer
            if (Hundreds > 0 && change >= 100) //checks if there are 100s and the change due is greater than 100
            {
                int count = (int)Math.Floor(change / 100); //calculate 100s needed
                while(Hundreds > 0 && count >= Hundreds) //loop while there are 100s & the qty of 100s needed is greater than qty of 100s  
                {
                    change -= 100;
                    OutHundreds++;
                    Hundreds--;
                    count--;
                }
            } 
            if (Fifties > 0 && change >= 50) //checks if there are 50s and the change due is greater than 50
            {
                int count = (int)Math.Floor(change / 50); //calculate 50s needed
                while (Fifties > 0 && count >= Fifties) //loop while there are 50s & qty need is greater than qty
                { 
                    change -= 50;
                    OutFifties++;
                    OutFifties--;
                    count--;
                }
            }
            if (Twenties > 0 && change >= 20) //checks if there are 20s and the change due is greater than 20
            {
                int count = (int)Math.Floor(change / 20); //calculate 20s needed
                while (Twenties > 0 && count >= Twenties) //loop while there are 20s & the qty of 20s needed is greater than qty of 20s
                {
                    change -= 20;
                    OutTwenties++;
                    Twenties--;
                    count--;
                }
            }
            if (Tens > 0 && change >= 10) //checks if there are 10s and the change due is greater than 10
            {
                int count = (int)Math.Floor(change / 10); //calculate 10s needed
                while (Tens > 0 && count >= Tens) //loop while there are 10s & the qty of 10s needed is greater than qty of 10s
                {
                    change -= 10;
                    OutTens++;
                    Tens--;
                    count--;
                }
            }
            if (Fives > 0 && change >= 5) //checks if there are 5s and the change due is greater than 5
            {
                int count = (int)Math.Floor(change / 5); //calculate 5s needed
                while (Fives > 0 && count >= Fives) //loop while there are 5s & the qty of 5s needed is greater than qty of 5s
                {
                    change -= 5;
                    OutFives++;
                    Fives--;
                    count--;
                }
            }            
            if (Twos > 0 && change >= 2) //checks if there are 2s and the change due is greater than 2
            {
                int count = (int)Math.Floor(change / 2); //calculate 2s needed
                while (Twos > 0 && count >= Twos) //loop while there are 2s & the qty of 2s needed is greater than qty of 2s
                {
                    change -= 2;
                    OutTwos++;
                    Twos--;
                    count--;
                }
            }
            if (Ones > 0 && change >= 1) //checks if there are 1s and the change due is greater than 1
            {
                int count = (int)Math.Floor(change / 1); //calculate 1s needed
                while (Ones > 0 && count >= Ones) //loop while there are 2s & the qty of 1s needed is greater than qty of 1s
                {
                    change -= 1;
                    OutOnes++;
                    Ones--;
                    count--;
                }
            }
            if (Dollars > 0 && change >= 1) //checks if there are 1s and the change due is greater than 1
            {
                int count = (int)Math.Floor(change / 1); //calculate 1s needed
                while (Dollars > 0 && count >= Dollars) //loop while there are 1s & the qty of 1s needed is greater than qty of 1s
                {
                    change -= 1;
                    OutDollars++;
                    Dollars--;
                    count--;
                }
            }
            if (HalfDollars > 0 && change >= .5) //checks if there are .50s and the change due is greater than .5
            {
                int count = (int)Math.Floor(change / .5); //calculate .5s needed
                while (HalfDollars > 0 && count >= HalfDollars) //loop while there are .5s & the qty of .5s needed is greater than qty of .5s
                {
                    change -= .5;
                    OutHalfDollars++;
                    HalfDollars--;
                    count--;
                }
            }
            if (Quarters > 0 && change >= .25) //checks if there are quarters and the change due is greater than quarters
            {
                int count = (int)Math.Floor(change / .5); //calculate quarters needed
                while (Quarters > 0 && count >= Quarters) //loop while there are quarters & the qty of quarters needed is greater than qty of quarters
                {
                    change -= .25;
                    OutQuarters++;
                    Quarters--;
                    count--;
                }
            }
            if (Dimes > 0 && change >= .10) //checks if there are dimes and the change due is greater than dimes
            {
                int count = (int)Math.Floor(change / .10); //calculate dimes needed
                while (Dimes > 0 && count >= Dimes) //loop while there are dimes & the qty of dimes needed is greater than qty of dimes
                {
                    change -= .10;
                    OutDimes++;
                    Dimes--;
                    count--;
                }
            }
            if (Nickels > 0 && change >= .05) //checks if there are nickels and the change due is greater than nickels
            {
                int count = (int)Math.Floor(change / .05); //calculate nickels needed
                while (Nickels > 0 && count >= Nickels) //loop while there are nickels & the qty of nickels needed is greater than qty of nickels
                {
                    change -= .05;
                    OutNickels++;
                    Nickels--;
                    count--;
                }
            }
            if (Pennies > 0 && change >= .01) //checks if there are pennies and the change due is greater than pennies
            {
                int count = (int)Math.Floor(change / .01); //calculate pennies needed
                while (Pennies > 0 && count >= Pennies) //loop while there are pennies & the qty of pennies needed is greater than qty of pennies
                {
                    change -= .01;
                    OutPennies++;
                    Pennies--;
                    count--;
                }
            }
        }

        public void ResetTransaction()
        {
            inHundreds = 0;
            inFifties = 0;
            inTwenties = 0;
            inTens = 0;
            inFives = 0;
            inTwos = 0;
            inOnes = 0;
            inDollars = 0;
            inHalfDollars = 0;
            inQuarters = 0;
            inDimes = 0;
            inNickels = 0;
            inPennies = 0;
            outHundreds = 0;
            outFifties = 0;
            outTwenties = 0;
            outTens = 0;
            outFives = 0;
            outTwos = 0;
            outOnes = 0;
            outDollars = 0;
            outHalfDollars = 0;
            outQuarters = 0;
            outDimes = 0;
            outNickels = 0;
            outPennies = 0;
        }

        /// <summary>
        /// resets the cash drawer to a default state
        /// </summary>
        public void ResetDrawer()
        {
            Hundreds = 0;
            Fifties = 0;
            Twenties = 0;
            Tens = 1;
            Fives = 10;
            Twos = 0;
            Ones = 22;
            Dollars = 0;
            HalfDollars = 0;
            Quarters = 40;
            Dimes = 50;
            Nickels = 40;
            Pennies = 100;
            inHundreds = 0;
            inFifties = 0;
            inTwenties = 0;
            inTens = 0;
            inFives = 0;
            inTwos = 0;
            inOnes = 0;
            inDollars = 0;
            inHalfDollars = 0;
            inQuarters = 0;
            inDimes = 0;
            inNickels = 0;
            inPennies = 0;
            outHundreds = 0;
            outFifties = 0;
            outTwenties = 0;
            outTens = 0;
            outFives = 0;
            outTwos = 0;
            outOnes = 0;
            outDollars = 0;
            outHalfDollars = 0;
            outQuarters = 0;
            outDimes = 0;
            outNickels = 0;
            outPennies = 0;
        }    
    }
}
