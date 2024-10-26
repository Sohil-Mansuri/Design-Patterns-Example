
namespace MediatorPattern.Using_observer
{
    internal abstract class UIControl
    {
        private List<Action> handlers = [];


        public void AddEventHandler(Action handler) => handlers.Add(handler);


        protected void NotifyEventHandler()
        {
            foreach (var handler in handlers)
            {
                handler();
            }
        }
    }
}
