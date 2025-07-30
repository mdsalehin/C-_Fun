
class Student
{
    //property 
    public string name;
    public int age;

    //Constructor = --- Student ----This is Called Constructor
    //A constructor is a special method that sets the values of an object's properties when the object is created
    public Student(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
        //this is the parameter Name, Age
    }

    //Funcionality Or Mathode
    public void ShowInfo()
    {
        Console.WriteLine("Name: {0}, Age: {1}", name, age);
    }


}

class Program
{
    public static void Main()
    {
        
        Student student = new Student("salahin",25);
        student.ShowInfo();
    }
}