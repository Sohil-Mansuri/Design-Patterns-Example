
namespace MediatorPattern.Using_observer
{
    internal class TitleTextBox : UIControl
    {
         private string? _title;

        public string? Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                NotifyEventHandler();
            }
        }
    }
}
