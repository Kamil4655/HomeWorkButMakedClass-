using ConsoleApp4.Models;

namespace ConsoleApp4;


internal class Program
{
    static void Main(string[] args)
    {
        Person studentOne = new Person("Kamil", "Gahramanov", "AB106", 100);
        studentOne.GetInfo();
        studentOne.CheckGraduation();
        studentOne.GetDiplomDegree();

        Console.WriteLine();

        Person studentTwo = new Person("Anar", "Amanli", "AB106", 80);
        studentTwo.GetInfo();
        studentTwo.CheckGraduation();
        studentTwo.GetDiplomDegree();

        Person studentThree= new Person("Emil", "Aliyev", "AB106", 70);
        studentThree.GetInfo();
        studentThree.CheckGraduation();
        studentThree.GetDiplomDegree();

        Person studentFour = new Person("Qerib", "Garibzade", "AB106", 60);
        studentFour.GetInfo();
        studentFour.CheckGraduation();
        studentFour.GetDiplomDegree();

        Person studentFive = new Person("Sahin", "Shahinzade", "AB106", 50);
        studentFive.GetInfo();
        studentFive.CheckGraduation();
        studentFive.GetDiplomDegree();



    }
}
