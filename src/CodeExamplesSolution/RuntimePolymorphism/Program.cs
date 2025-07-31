
/*
 * What Is Runtime Polymorphism?
   Runtime polymorphism = method overriding + base class reference + virtual keyword
   Constructor কখনো override করা যায় না
*/
public class Course
{
   
    public string title;
    public string description;
    public void ShowInfo()
    {
        Console.WriteLine("Title: {0}", title);
    }
    public void Quiz(int score)
    {
        Console.WriteLine("Score Quiz");
    }
    public virtual void Quiz()
    {
        Console.WriteLine("Normal Akta Quiz And It Will be Updated");
    }
    
}
public class JipsCourse: Course
{
    
    //Quiz Class ar Mathod ta name chage nah kore OverRide korte Chasii..
    public override void Quiz()
    {
        int start = 10;
        int end   = 30;
        Console.WriteLine("Score JipsQuiz {0} - {1}", start,end);
        Console.WriteLine("This is Runtime_Polymorphism\n");
    }
}
public class Program
{
    public static void Main()
    {
        Course quiz  =  new Course();
        quiz.Quiz(10);
        Console.WriteLine("\n");


        JipsCourse jipc = new JipsCourse();
        jipc.title = "Update_Jips";
        jipc.ShowInfo();
        jipc.Quiz();

    }
}

