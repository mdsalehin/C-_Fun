
/*Polymorphism মানে হলো —
"বহুরূপিতা" বা "একটি জিনিসের একাধিক রূপ বা আচরণ"।*/

/*messy code this is*/
using System.Reflection.Metadata;

public class JipsCourse
{
    public void QuizWithTime(int startTime,int endTime,int duration)
    {
        Console.WriteLine("Quiz With __Jips___Time");
    }

    public void QuizForPractice()
    {
        Console.WriteLine("Quiz For __Jips___Practice");
    }

    public void QuizForPreparation(int duration)
    {
        Console.WriteLine("Quiz For __Jips___Preparation");
    }

}

/********** To Avoid this kind of code we need Polymorphism. ******************/

//Below is an example of polymorphism.
public class CpCourse
{
    public void Quiz()
    {
        Console.WriteLine("Quiz For Cp_Practice) == Mathode OverLoading ");
    }
    public void Quiz(int duration)
    {
        Console.WriteLine("Quiz For Cp_Preparation_One (One Parameter_Pass AutoMatically detect) == Mathode OverLoading");
    }
    public void Quiz(int startTime, int endTime, int duration)
    {
        Console.WriteLine("Quiz With Cp_Time (Three Parameter_Pass AutoMatically detect) == Mathode OverLoading ");
    }
    public void Quiz(string name)
    {
        Console.WriteLine("this is One Paramitter Pass.But Work this is String type.And it will work.)");
    }

}


public class Program
{
    public static void Main()
    {
        Console.WriteLine("This is Called Mathode OverLoading ->(OR Compile-Time Polymorphism)..Mathod Name Same Always But Parameter Different");
        CpCourse cp = new CpCourse();
        cp.Quiz();
        cp.Quiz(5);
        cp.Quiz(10,20,10);
        Console.WriteLine('\n');
        Console.WriteLine('\n');



        Console.WriteLine("So avoid this.this is the major diffrents");
        JipsCourse jips = new JipsCourse();
        jips.QuizForPractice();
        jips.QuizWithTime(5,10,25);
        jips.QuizForPreparation(5);
        Console.WriteLine('\n');
    }
}