
namespace AbstractFactoryPattern.Problem.Material
{
    internal class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material : Textbox");
        }
    }
}
