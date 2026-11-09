using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Core.DesignPatterns
{
    public class Decorator
    {
        public void Run()
        {
            IPay p = new CardPayment();
            p.Pay(100.5m);
        }
    }

    public interface IPay
    {
        public void Pay(decimal amount);
    }

    public class CardPayment : IPay
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Payment made via card");
        }
    }

    public abstract class PaymentAdapter : IPay
    {
        private readonly IPay _pay;
        public PaymentAdapter(IPay pay)
        {
            _pay = pay;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine("mail sending logic")
            _pay.Pay(amount);
        }
    }
}
