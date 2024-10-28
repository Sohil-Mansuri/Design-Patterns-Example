
namespace AbstractFactoryPattern.Solution.Ant
{
    internal class AntTextbox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant : Textbox");
        }
    }
}
