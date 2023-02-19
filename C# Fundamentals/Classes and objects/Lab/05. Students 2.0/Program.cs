﻿public class Program
{
    static void Main()
    {
        var students = new List<Student>();

        while (true)
        {
            bool exist = false;
            var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            if (list[0] == "end")
            {
                break;
            }
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FirstName == list[0] && students[i].LastName == list[1])
                {
                    exist = true;
                    students[i].Age = int.Parse(list[2]);
                    students[i].HomeTown = list[3];
                }
            }
            if (!exist)
            {
                students.Add(new Student(list[0], list[1], int.Parse(list[2]), list[3]));
            }
        }
        var city = Console.ReadLine();
        students.Where(x => x.HomeTown == city).ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
    }
}
public class Student
{
    private string firstName;
    private string lastName;
    private int age;
    private string homeTown;

    public string FirstName
    {
        get { return firstName; }
        set { this.firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { this.lastName = value; }
    }
    public int Age
    {
        get { return age; }
        set { this.age = value; }
    }
    public string HomeTown
    {
        get { return homeTown; }
        set { this.homeTown = value; }
    }
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.homeTown = homeTown;
    }
}