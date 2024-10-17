using MediatorPattern.Example1;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articalDilogBox = new ArticalDialogBox();
            articalDilogBox.SelectArtical("Artical 2");
            articalDilogBox.SelectArtical("");
           
            Console.WriteLine("Using Observer pattern");
            articalDilogBox.SelectArtical("Artical 3");
            articalDilogBox.SelectArtical("");

            Console.ReadKey();
        }
    }
}
