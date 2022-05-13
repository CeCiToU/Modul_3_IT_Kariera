namespace ConsoleApp294
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        private int bonusSalary;

        public Person(int bonusSalary)
        {
            this.BonusSalary = bonusSalary;
        }

        public Person(string firstName, string lastName, int age, double salary, int bonusSalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            if (Age < 30)
            {
                bonusSalary /= 2;
                double num = salary * bonusSalary / 100;
                salary = salary + num;
                this.Salary = salary;
            }
            else
            {
                double num = salary * bonusSalary / 100;
                salary = salary + num;
                this.Salary = salary;
            }
            this.Salary = salary;
        }

        public string FirstName 
        {
            get => firstName;
            set { 
            if(value.Length < 3)
                {
                    throw new System.ArgumentException("First name cannot be less than 3 symbols");
                }
                firstName = value;
            }
        }
        public string LastName 
        {
            get => lastName;
            set
            {
                if (value.Length < 3)
                {
                    throw new System.ArgumentException("Last name cannot be less than 3 symbols");
                }
                lastName  = value;
            }
        }
        public int Age { get => age;
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Age cannot be zero or negative integer");
                }
                age = value;
            }
        }
        public double Salary { get => salary;
            set
            {
                if(value < 460)
                {
                    throw new System.ArgumentException("Salary cannot be less than 460 leva");
                }
                salary = value;
            }
                }
        public int BonusSalary
        {
            get { return bonusSalary; }
            set
            {
                if (Age < 30)
                {
                    bonusSalary /= 2;
                    double num = Salary * bonusSalary / 100;
                    salary = value + num;
                }
                else
                {
                    double num = Salary * bonusSalary / 100;
                    salary = value + num;
                }
            }
        }



        public override string ToString()
        {
            return $"{FirstName} {LastName} get {Salary:F2} leva";
        }
    }
}