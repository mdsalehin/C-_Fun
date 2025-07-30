/*
Access Modifiers
Public
Private
Protected 

public class Student
{
    private string name;
    private int age;

    public Student(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: {0}, Age: {1}", name, age);
    }
}

class Program
{
    public static void Main()
    {
        Student student = new Student("salahin", 25);
        // student.name = "alamin";
        // student.age = 20;
        
        // So this is the bug. I changed it like this.
        // If I make property private, this is the 1st process.

        student.ShowInfo();
    }
}
*/

/*********************************************************************************************************************/


public class Student
{
    private string name;
    private int age;

    public void SetName(string Name)
    {
        this.name = Name;
    }
    public string GetName()
    {
        return this.name;
    }
    public void SetAge(int Age)
    {
        this.age = Age;
    }
    public int getAge()
    {
        return this.age;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: {0}, Age: {1}", name, age);        
    }
}


class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.SetName("salahin");
        student.SetAge(25);
        // student.ShowInfo();



        Student student1 = new Student();
        student1.SetName("alamin");
        student1.SetAge(22);

        Console.WriteLine("Name: {0}, Age: {1}", student.GetName(), student.getAge());
        Console.WriteLine("Name: {0}, Age: {1}", student1.GetName(), student1.getAge());
    }
}

/*
 MVC
Model_View_Controller 
  
     Model  = Student 
     View   = Console - Normally Html file,js,css
 Controller = Program -- Frontend Data pass to backend & Backend Data pass to Frontend
 */