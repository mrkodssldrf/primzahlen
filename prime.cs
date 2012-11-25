using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace primzahlen
{
    class Prime
    {
        private int number;
        private bool isPrime; 

        public Prime(int number, bool isPrime) 
        {
            this.number = number;
            this.isPrime = isPrime; 
        }

        public int Number
        {
            get { return number; } 
            set { number = value; } 
        }

        public bool IsPrime
        {
            get { return isPrime; }
            set { isPrime = value; }
        }
    }
}
