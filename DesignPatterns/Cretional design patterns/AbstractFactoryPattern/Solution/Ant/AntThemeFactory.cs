
namespace AbstractFactoryPattern.Solution.Ant
{
    internal class AntThemeFactory : ITheremFactory
    {
        public IButton CreateButton()
        {
            return new AntButton();
        }

        public ITextBox CreateTextBox()
        {
            return new AntTextbox();
        }
    }
}
