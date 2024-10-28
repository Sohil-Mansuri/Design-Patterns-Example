
namespace AbstractFactoryPattern.Solution.Material
{
    internal class MaterialTextbox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material : Textbox");
        }
    }
}
