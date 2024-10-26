
namespace MediatorPattern.Example1
{
    internal class SaveButton(DialogBox dialogBox) : UIControl(dialogBox)
    {
        private bool _isSaveButtonEnabled;

        public bool IsActive
        {
            get
            {
                return _isSaveButtonEnabled;
            }
            set
            {
                _isSaveButtonEnabled = value;
            }
        }
    }
}
