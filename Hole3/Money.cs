using System;

namespace Hole3
{
    public class Money
    {
        public readonly int value;
        public readonly String currency;

        public Money(int value, String currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public Money Plus(Money other)
        {
            if (!currency.Equals(other.currency))
            {
                throw new Incalculable();
            }

            return new Money(other.value + value, currency);
        }
    }
}