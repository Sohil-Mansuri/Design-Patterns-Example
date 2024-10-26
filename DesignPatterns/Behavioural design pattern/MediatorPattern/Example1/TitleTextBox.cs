
namespace MediatorPattern.Example1
{
    internal class TitleTextBox(DialogBox dialogBox) : UIControl(dialogBox)
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
                dialogBox.Change(this);
            }
        }
    }
}
