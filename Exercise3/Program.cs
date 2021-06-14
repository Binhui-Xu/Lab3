using System;
using System.Collections.Generic;

namespace Exercise3
{
    class HouseholdAccounts
    {
        public string Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Amount { get; set; }
        public override string ToString()
        {
            return Date + "\t" + Description + "\t" + Category + "\t" + Amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static List<HouseholdAccounts> CreateExpense()
        {
            return new List<HouseholdAccounts>
            {
                new HouseholdAccounts{ Date="06/06/2021",Description="buy cat toy",Category="life",Amount=-30.00},
                new HouseholdAccounts{ Date="06/07/2021",Description="salary",Category="life",Amount=10000.00},
                new HouseholdAccounts{ Date="06/08/2021",Description="tuition",Category="study",Amount=-20000.00},
                new HouseholdAccounts{ Date="07/07/2021",Description="super market",Category="life",Amount=-100.00},
            };
        }
        public void AddExpense()
        {

        }
        public void ShowExpense()
        {

        }

    }
}
