using Student_class;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. Create student.");
        Console.WriteLine("2. Get all student.");
        Console.WriteLine("3. Excit.");
        Student student1 = new Student(4, "gunay", "Babayeva", "gny_b");

        StudentAbout(4, "gunay", "Babayeva");

    }


    static void StudentAbout(int id, string name, string surname)
    {
        Student student1 = new Student(4, "gunay", "Babayeva","gunaybabayeva");
        Student[]studentss=new Student[0];

        
        int secim = 0;
        while(secim!=3)
        {

            Console.Write("\nSecim : ");
            secim = int.Parse(Console.ReadLine());
            

            if (secim == 1)
            {
                Array.Resize( ref studentss, studentss.Length+1);
                studentss[studentss.Length-1]=student1;

                Console.Write("Id: ");
                student1.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                student1.Name = Console.ReadLine().Trim();
                Console.Write("Surname: ");
                student1.Surname = Console.ReadLine().Trim();
                Console.Write("Usename: ");
                student1.Surname = Console.ReadLine().Trim();
                student1.Username = student1.Name+student1.Surname;
                student1.Username.Replace('у' ,'r');
                student1.Username.Replace('р', 'g');
                student1.Username.Replace('м', 'z');


                Console.WriteLine("Creat Student");

            }



          
            if (secim == 2)
            {
                Console.WriteLine("get all student");
                Console.WriteLine(student1.Name + " " + student1.Surname+" "+ student1.Username);

            }
           
            if (secim == 3)
            {
                Console.WriteLine("Excit program.");
            }

        }


    }


    
}
