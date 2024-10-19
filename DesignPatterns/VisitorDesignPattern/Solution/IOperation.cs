
namespace VisitorDesignPattern.Solution
{
    /// <summary>
    /// As our object structure is stable that's why we have used only heading and anchor
    /// </summary>
    internal interface IOperation
    {
        void Apply(HeadingNode node);

        void Apply(AncharNode node);

    }
}
