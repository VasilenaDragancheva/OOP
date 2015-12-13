using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem2.Contracts;
using Problem2.Enums;

namespace Problem2
{
    class Customer : ICustomer, ICloneable
    {

        private List<IPayment> payments;
      
        public Customer(string firstName, string middleName, string lastName, string ID, string mail,
            string mobilePhone, string permanentAddress, CustomerType customerType,List<IPayment> payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = ID;
            this.Mail = mail;
            this.MobilePhone = mobilePhone;
            this.PermanentAddress = permanentAddress;
            this.CustomerType = customerType;
            this.payments = new List<IPayment>();
            this.AddPayments(payments);            
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string ID { get; set; }


        public string Mail { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public IEnumerable<IPayment> Payments
        {
            get { return this.payments; }
        }
        public CustomerType CustomerType { get; set; }

        private void AddPayments(List<IPayment> payments)
        {
           
            if (payments.Count() != 0)
            {
                this.payments = payments.ToList();
            }
        }
        public void AddPayment(IPayment payment)
        {
            if(payment!=null)
            {
                this.payments.Add(payment);
            }
        }
        public decimal TotalPayments()
        {
            decimal total = this.Payments.Sum(payment => payment.Price);
            return total;
        }
        public override bool Equals(object obj)
        {
            var anotherCustomer = obj as Customer;
            if (anotherCustomer == null)
            {
                return false;
            }
            else
            {
                if (this.ID == anotherCustomer.ID)
                {
                    return true;
                }
            }
            return false;

        }
        
        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.FirstName.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder toStringOverride = new StringBuilder();

            toStringOverride.AppendFormat("{0} {1}{2}",
                this.FirstName,
                this.LastName,
                Environment.NewLine);
            toStringOverride.AppendFormat("is {0} made  {1} number of payments for  {2} BGN",
                this.CustomerType,
                this.Payments.Count(),
                this.TotalPayments());

            return toStringOverride.ToString();
        }
        public static bool operator ==(Customer a, Customer b)
        {
            if (a.ID != b.ID)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Customer a, Customer b)
        {
            if (a.ID == b.ID)
            {
                return false;
            }
            return true;
        }

        public object Clone()
        {
            List<IPayment> clonedPayments = new List<IPayment>();
            foreach (var payment in this.Payments)
            {
                var clonedPayment = new Payment(payment.ProductName, payment.Price);
                clonedPayments.Add(clonedPayment);
            }
            Customer cloned = new Customer(this.FirstName, this.MiddleName, this.LastName,
                this.ID, this.Mail, this.MobilePhone, this.PermanentAddress, this.CustomerType, clonedPayments);
            return cloned;



        }


  
    }
}
