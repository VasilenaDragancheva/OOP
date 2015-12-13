using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.Enums;
using Problem2.Contracts;
namespace Problem2
{
    class TestingCustomerProgram
    {
        static void Main(string[] args)
        {
            IPayment kebab = new Payment("kebabcheta", 6);
            IPayment kufte = new Payment("kifteta", 6);
            List<IPayment> pokupki = new List<IPayment>();
            pokupki.Add(kebab);
            pokupki.Add(kufte);
            Customer a = new Customer("Pepa", "Petrova", "Pitkova", "8101111120",
                "pepka@abv.bg", "0989888888", "gr.Sofia,kv. Zaharna fabrika", CustomerType.Diamond,pokupki);
            Customer b = a.Clone() as Customer;
            IEnumerable<IPayment> payB = b.Payments;
            IPayment pastyrmichka = new Payment("pastyrma", 15);
            b.AddPayment(pastyrmichka);
            Console.WriteLine(a.Payments.Count());
            Console.WriteLine(b.Payments.Count());

        }
    }
}
