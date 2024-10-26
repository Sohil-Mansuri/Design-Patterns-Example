
namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from problem section");

            //Group 
            //    Group 1
            //      Shape
            //      Shape
            //    Group 2
            //      Shape
            //      Shape

            var group1 = new Problem.Group();
            group1.Objects.Add(new Problem.Shape());
            group1.Objects.Add(new Problem.Shape());

            var group2 = new Problem.Group();
            group2.Objects.Add(new Problem.Shape());
            group2.Objects.Add(new Problem.Shape());

            var mainGroup = new Problem.Group();
            mainGroup.Objects.Add(group1);
            mainGroup.Objects.Add(group2);

            mainGroup.Run();
            // as you can see its very complex 

            Console.WriteLine("Output from solution section");

            var newgroup1 = new Solution.Group();
            newgroup1.AddComponents(new Solution.Shape("1"));
            newgroup1.AddComponents(new Solution.Shape("2"));

            var newEndgroup = new Solution.Group();
            newEndgroup.AddComponents(new Solution.Shape("5"));
            newEndgroup.AddComponents(new Solution.Shape("6"));

            newgroup1.AddComponents(newEndgroup);

            var  newgroup2 = new Solution.Group();
            newgroup2.AddComponents(new Solution.Shape("3"));
            newgroup2.AddComponents(new Solution.Shape("4"));

            var newMainGroup = new Solution.Group();
            newMainGroup.AddComponents(newgroup1);
            newMainGroup.AddComponents(newgroup2);

            newMainGroup.Render();

            Console.ReadKey();

        }
    }
}
