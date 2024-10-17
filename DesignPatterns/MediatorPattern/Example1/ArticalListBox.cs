

namespace MediatorPattern.Example1
{
    internal class ArticalListBox(DialogBox dialogBox) : UIControl(dialogBox)
    {
        //default items 
        private List<string> _listItems =
        [
            "Artical 1", "Artical 2", "Artical 3","Artical 4"
        ];

        private string _selectedItem = string.Empty;

        public string SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                dialogBox.Change(this);
            }
        }

        
    }
}
