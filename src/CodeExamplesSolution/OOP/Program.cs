


class Student
{
    //property 
    public string name;
    public int age;


    //Funcionality
    public void ShowInfo()
    {
        Console.WriteLine("Name: {0}, Age: {1}",name,age);
    }
}

class Program
{
    public static void Main()
    {
        //Student class ar akta object create korechi.so object create krete hole akta Constructor_Create--->Student(); 
        Student student = new Student();

        //object Property Define
        student.name = "salehin";
        student.age = 25;
        student.ShowInfo();

    }
}