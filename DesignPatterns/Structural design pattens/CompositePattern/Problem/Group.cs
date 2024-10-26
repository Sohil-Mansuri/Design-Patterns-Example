

namespace CompositePattern.Problem
{
    internal class Group
    {
        /// <summary>
        /// This one working fine but here we have to type cast which is costly
        /// and our hierarchy
        /// </summary>
        public List<Object> Objects { get; set; } = [];


        public void Run()
        {
            foreach (var obj in Objects)
            {
                if(obj is Shape shape)
                    shape.Render();
                else if(obj is Group group)
                    group.Run();
            }

            Console.WriteLine("Group is Rendered");
        }
    }
}
