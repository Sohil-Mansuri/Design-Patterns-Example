
namespace AbstractFactoryPattern.Solution
{
    internal interface ITheremFactory
    {
        ITextBox CreateTextBox();
        IButton CreateButton();
    }
}
