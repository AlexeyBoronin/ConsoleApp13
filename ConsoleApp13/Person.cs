
using static System.Console;

namespace ConsoleApp13
{
    class Person
    {
        public string name ;
        //public Company company ;
        public int age;

        //public Person(): this("Неизвестно") { }
        //public Person(string name): this(name,18) { }
        public Person(string name="Неизвестно", int age=18) 
        { 
            this.name =name;
            this.age = age; 
            //company = new Company(); 
        }
        public void Deconstruct(out string personName, out int personAge)
        {
            personAge = age;
            personName = name;
        }
        public void Print()
        {
            WriteLine($"Имя: {name} Возраст: {age}");
        }
    }
    //class Company
    //{
    //    public string title="Неизвестно";
    //}
}
