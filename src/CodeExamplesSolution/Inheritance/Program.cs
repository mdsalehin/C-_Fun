
//This is Code is Run but this is not the best practice.....Beacuse Same mathod and Property use again and again.
// To avoid this problem there comes the Inheritance........... 

/*
public class Student
{
    public string name;
    public int age;


   
    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

}

public class JIPCStudent
{
    public string name;
    public int age;
    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public void GiveQuiz()
    {
        Console.WriteLine("Give Quiz");
    }

}
public class CpStudent
{
    public string name;
    public int age;

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public void GiveContest()
    {
        Console.WriteLine("Give Contest");
    }

}

class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.name = "salahin";
        student.age = 25;
        student.ShowInfo();
       
    }


}
*/

//So what is the disAdvanteg of the class 
/*To avoid repeating common code across multiple classes, we use inheritance.
By creating a base class called Student, we can place all the shared properties and methods in that class.
Then, other classes like JIPCStudent and CpStudent can inherit from Student, so they automatically get those features.*/


/********************************************************************************************************************************/

//Approch1

/*
public class Student
{
    public string name;
    public int age;

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

public class JIPCStudent: Student
{
    public void GiveQuiz()
    {
        Console.WriteLine("Give Quiz For JIPCStudent");
    }
}

public class CpStudent: Student
{
    public void GiveContest()
    {
        Console.WriteLine("Give Contest For CpStudent");
    }
}

class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.name = "salahin";
        student.age = 25;
        student.ShowInfo();
        Console.WriteLine('\n');

        JIPCStudent jipc = new JIPCStudent();
        jipc.name = "alamin";
        jipc.age = 22;
        jipc.ShowInfo();
        jipc.GiveQuiz();
        Console.WriteLine('\n');

        CpStudent cp = new CpStudent();
        cp.name = "Pro_Salahin";
        cp.age = 21;
        cp.ShowInfo();
        cp.GiveContest();
    }
}
*/

//Approch2 using Constructor
public class Student
{
    private string name;
    private int age;


    //using Constructor
    public Student(string Name,int Age)
    {
        this.name= Name;
        this.age = Age;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

public class JIPCStudent : Student
{

    public JIPCStudent(string Name, int Age) : base(Name, Age)
    {

    }

    public void GiveQuiz()
    {
        Console.WriteLine("Give Quiz For JIPCStudent");
    }
}
public class CpStudent : Student
{
    public CpStudent(string Name, int Age) : base(Name, Age)
    {
     
    }
    public void GiveContest()
    {
        Console.WriteLine("Give Contest For CpStudent");
    }
}
class Program
{
    public static void Main()
    {
        Student student = new Student("salahin",25);
        student.ShowInfo();
        Console.WriteLine('\n');

        JIPCStudent jipc = new JIPCStudent("alamin", 14);
        jipc.GiveQuiz();
        jipc.ShowInfo();
        Console.WriteLine('\n');

        CpStudent cp = new CpStudent("Pro_Salahin", 25);
        cp.GiveContest();
        cp.ShowInfo();

    }

}


