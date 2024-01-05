using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }


    public override string ToString()
    {
        return $"Person: {Name}";
    }
}

class Student : Person
{

    public Student(string name) : base(name) { }
    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

class Teacher : Person
{
    public Teacher(string name) : base(name) { }

    public void Explain()
    {
        Console.WriteLine($"{Name} is explaining.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter name for person {i + 1}: ");
            string name = Console.ReadLine();

            if (i < 2)
            {
                people[i] = new Student(name);
            }
            else
            {
                people[i] = new Teacher(name);
            }
        }

        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());

            if (person is Student)
            {
                ((Student)person).Study();
            }
            else if (person is Teacher)
            {
                ((Teacher)person).Explain();
            }

            Console.WriteLine();
        }
    }
}
