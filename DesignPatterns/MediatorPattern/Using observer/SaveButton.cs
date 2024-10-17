
namespace MediatorPattern.Using_observer
{
    internal class SaveButton : UIControl
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
