using System;
namespace InputToJson
{
    public class PeopleClass
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string Job { get; set; }

        public double Salary { get; set; }

        public string Quote { get; set; }

        public PeopleClass(string name, int age, string job, double salary, string quote)
        {
            this.Name = name;
            this.Age = age;
            this.Job = job;
            this.Salary = salary;
            this.Quote = quote;
        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }
}
