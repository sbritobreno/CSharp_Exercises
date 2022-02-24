using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week5
{
//    2. Create a class named Taxpayer.Data fields for Taxpayer objects include the Social Security
//number, the yearly gross income, and the tax owed.Include a property with get and set
//accessors for the first two data fields, but make the tax owed a read-only property.The tax
//should be calculated whenever the income is set.Assume the tax is 15 % of income for
//incomes under $30,000 and 28 % for incomes that are $30,000 or higher. Write a program
//that declares an array of ten Taxpayer objects.Prompt the user for data for each object and
//display the ten objects.
    public class Exercise_2
    {
        public static void DoExercise2()
        {
            Console.WriteLine("\nExercise 2\n");
            TaxPayer[] taxPayers = new TaxPayer[3];

            for(var i = 0; i < 3; i++)
            {
                Console.WriteLine("What is your social security number?");
                var ssc = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your yearly gross income?");
                var ygi = int.Parse(Console.ReadLine());

                taxPayers[i] = new TaxPayer(ssc, ygi);
            }

            Console.WriteLine();
            foreach (var tp in taxPayers)
                Console.WriteLine(tp.ToString());
        }
    }
    public class TaxPayer
    {
        private int _socialSecurityNumber;
        private float _yearlyGrossIncome;
        private readonly float _taxOwed;

        public TaxPayer(int socialSecurityNumber, float yearlyGrossIncome)
        {
            _socialSecurityNumber = socialSecurityNumber;
            _yearlyGrossIncome = yearlyGrossIncome;
            _taxOwed = CalculateTax(_yearlyGrossIncome);
        }
        public float CalculateTax(float yearlyGrossIncome)
        {
            if(yearlyGrossIncome < 0)
            {
                return yearlyGrossIncome = 0;
            }
            else if(yearlyGrossIncome < 30000)
            {
                //15% taxes
                return yearlyGrossIncome * 15 / 100;
            }
            else
            {
                //28% taxes
                return yearlyGrossIncome * 28 / 100;
            }
        }

        public override string ToString()
        {
            return $"The tax owed by the person with the social security number: {_socialSecurityNumber}," +
                $" who receives {_yearlyGrossIncome} euro per year is {_taxOwed} euro.";
        }
        public int SocialSecurityNumber
        {
            get
            {
                return _socialSecurityNumber;
            }
            set
            {
                _socialSecurityNumber = value;
            }
        }
        public float YearlyGrossIncome
        {
            get
            {
                return _yearlyGrossIncome;
            }
            set
            {
                _yearlyGrossIncome = value;
            }
        }
    }
}
