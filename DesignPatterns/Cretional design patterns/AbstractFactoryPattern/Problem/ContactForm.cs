
using AbstractFactoryPattern.Problem.Ant;
using AbstractFactoryPattern.Problem.Material;

namespace AbstractFactoryPattern.Problem
{
    /// <summary>
    /// As this solutin is not follwing OCP 
    /// use Abstract factory pattern want to create similar object from family of objects
    /// </summary>
    internal class ContactForm
    {
        public void LoadForm(Theme theme)
        {
            if (theme == Theme.Material)
            {
                new MaterialTextBox().Render();
                new MaterailButton().Render();
            }
            else if (theme == Theme.Ant)
            {
                new AntTextBox().Render();
                new AntButton().Render();
            }
        }
    }

    public enum Theme
    {
        Material,
        Ant
    }
}
