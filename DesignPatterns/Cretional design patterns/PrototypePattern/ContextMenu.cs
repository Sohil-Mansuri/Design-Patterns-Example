
namespace PrototypePattern
{
    /// <summary>
    /// This is conext menu for all the kind of componenet
    /// </summary>
    /// <param name="componenet"></param>
    internal class ContextMenu(IComponenet componenet)
    {
        public IComponenet Duplicate()
        {
            return componenet.Clone();
        }
    }
}
