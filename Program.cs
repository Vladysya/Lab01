using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company("Oracle", 1, 2500000000, 31.01);
            Company company2 = new Company("IBM", 3, 2400000000, 29.25);
            Company company3 = new Company("Microsoft", 2, 1000000000, 13.01);
            Console.WriteLine("Фiрма     Кiлькiсть продуктiв    Рiчний об'єм    Частина ринку");
            Console.WriteLine(company1.Details());
            Console.WriteLine(company2.Details());
            Console.WriteLine(company3.Details());
        }
    }

    class Company
    {
        public string company { get; set; }

        public int amount { get; set; }

        public uint sells { get; set; }

        public double percent { get; set; }

        public Company(Company previousCompany)
        {
            company = previousCompany.company;
            amount = previousCompany.amount;
            sells = previousCompany.sells;
            percent = previousCompany.percent;
        }

        public Company(string Company, int Amount, uint Sells, double Percent)
        {
            company = Company;
            amount = Amount;
            sells = Sells;
            percent = Percent;
        }

        public string Details()
        {
            return company + "      " + amount + "        " + sells.ToString() + "              " + percent.ToString();
        }
    }
}