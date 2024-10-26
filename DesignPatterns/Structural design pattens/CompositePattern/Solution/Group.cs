

namespace CompositePattern.Solution
{
    internal class Group : IComponant
    {
        private List<IComponant> _componants = [];

        public void AddComponents(IComponant componant) => _componants.Add(componant);

        public void Render()
        {
            foreach (var componant in _componants)
            {
                componant.Render();
            }

            Console.WriteLine("Group is rendered");
        }
    }
}
