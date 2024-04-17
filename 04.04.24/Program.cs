using _04._04._24.Classes;

namespace _04._04._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager man = new Manager("Jack", 32, "Manager", true);
            Console.WriteLine(man.ToString());
            man.DeleteInfo(man.Name);
            man.ViewInfo(man.Name);
            man.AddInfo(man.Name);
            Console.WriteLine(man.ToString());
            man.EditInfo(man.Age);
            Console.WriteLine(man.ToString());
            man.AppearanceCheck();
        }
    }
}