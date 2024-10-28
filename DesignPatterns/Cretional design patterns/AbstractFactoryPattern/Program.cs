namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from problem section");

            var contactform = new Problem.ContactForm();
            contactform.LoadForm(Problem.Theme.Ant);

            Console.WriteLine("Output from Solution section");

            var newContactForm = new Solution.ContactForm();
            newContactForm.Load(new Solution.Ant.AntThemeFactory());

        }
    }
}
