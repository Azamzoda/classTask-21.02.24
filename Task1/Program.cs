var per=new Person();
System.Console.WriteLine("Enter your FirstName: ");
per.FirstName = Console.ReadLine();
System.Console.WriteLine($"Enter your Lastname: ");
per.LastName =Console.ReadLine();
System.Console.WriteLine($"Enter your Age: ");
per.Age = Convert.ToInt32(Console.ReadLine());
 per.GetInfo();
 per.GetBirthYear();

public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;
    public string Address;

    public void GetInfo()
    {
        System.Console.WriteLine($"FirsName: {FirstName}");
        System.Console.WriteLine($"LastName: {LastName}");
    }
    public void GetBirthYear()
    {
        System.Console.WriteLine($"Age: {Age}");
    } 

}