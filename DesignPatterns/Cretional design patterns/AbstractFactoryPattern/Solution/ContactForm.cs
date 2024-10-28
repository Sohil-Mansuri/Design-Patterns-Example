
namespace AbstractFactoryPattern.Solution
{
    internal class ContactForm
    {
        public void Load(ITheremFactory theremFactory)
        {
            theremFactory.CreateTextBox().Render();
            theremFactory.CreateButton().Render();
        }
    }
}
