namespace AbstractFactoryPattern.Solution.Material
{
    internal class MaterialTheme : ITheremFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MaterialTextbox();
        }
    }
}
