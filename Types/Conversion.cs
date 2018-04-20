using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class Conversion
    {

        public static void DoSomeConversion()
        {
            Money m = new Money(2000.2m);
            Console.WriteLine(m.ToString());

            decimal d = m;
            Console.WriteLine(d);

            int i = (int)m;
            Console.WriteLine(i);
        }

    }

    public class Money
    {
        public Money(Decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; set; }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }

        public override string ToString()
        {
            return "Money: " + Amount;
        }
    }
}
