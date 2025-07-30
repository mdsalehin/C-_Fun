

// In a project, the Authentication class should always be singleton.
//singleton means:Only one instance of the class will exist in the entire application.

public class Authentication
{
    public bool IsAuthenticated()
    {
        return true;
        //return false;
    }
}


public class Student
{
    private string name;
    private int age;

    Authentication auth = new Authentication();

    public void SetName(string Name)
    {
        if (auth.IsAuthenticated())
        {
            this.name = Name;
        }
        else
        {
            Console.WriteLine("You are not Authenticated");
        }

    }
    public string GetName()
    {
        return this.name;
    }

    public void SetAge(int Age)
    {
        if (auth.IsAuthenticated())
        {
            this.age = Age;
        }
        else
        {
            Console.WriteLine("You are not Authenticated");
        }
    }
    public int GetAge()
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

        Student student1 = new Student();
        student1.SetName("alamin");
        student1.SetAge(22);


        Console.WriteLine("Name: {0}, Age: {1}", student.GetName(), student.GetAge());
        Console.WriteLine("Name: {0}, Age: {1}", student1.GetName(), student1.GetAge());


    }
}














/*
 
// In a project, the Authentication class should always be singleton.
//singleton means:Only one instance of the class will exist in the entire application.

//another Approach using constractor


public class Authentication
{
    public bool IsAuthenticated()
    {
        return true;
      //  return false;
    }
}


public class Student
{
    private string name;
    private int age;
    private Authentication auth;
    public Student(Authentication auth)
    {
        this.auth = auth;
    }

    public void SetName(string Name)
    {
        if(auth.IsAuthenticated())
        {
            this.name = Name;
        }
        else
        {
            Console.WriteLine("You are not Authenticated");
        }
      
    }
    public string GetName()
    {
        return this.name;
    }

    public void SetAge(int Age)
    {
        if (auth.IsAuthenticated())
        {
            this.age = Age;
        }
        else
        {
            Console.WriteLine("You are not Authenticated");
        }
    }
    public int GetAge()
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
        Authentication auth = new Authentication();

        Student student = new Student(auth);
        student.SetName("salahin");
        student.SetAge(25);

        Student student1 = new Student(auth);
        student1.SetName("alamin");
        student1.SetAge(22);


        Console.WriteLine("Name: {0}, Age: {1}", student.GetName(),  student.GetAge());
        Console.WriteLine("Name: {0}, Age: {1}", student1.GetName(), student1.GetAge());


    }
}
 */