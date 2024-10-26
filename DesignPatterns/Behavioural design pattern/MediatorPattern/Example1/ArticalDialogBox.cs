

namespace MediatorPattern.Example1
{
    /// <summary>
    /// Mediator Concreate implementation
    /// </summary>
    internal class ArticalDialogBox : DialogBox
    {
        ArticalListBox _articalListBox;
        SaveButton _saveButton;
        TitleTextBox _titleTextBox;

        public ArticalDialogBox()
        {
            _articalListBox = new ArticalListBox(this);
            _saveButton = new SaveButton(this);
            _titleTextBox = new TitleTextBox(this);
        }

        public override void Change(UIControl control)
        {
            if (control is ArticalListBox)
            {
                _titleTextBox.Title = _articalListBox.SelectedItem;
            }
            else if (control is TitleTextBox)
            {
                _saveButton.IsActive = !string.IsNullOrEmpty(_titleTextBox.Title);
            }
        }

        public void SelectArtical(string artical)
        {
            _articalListBox.SelectedItem = artical;

            //print to check
            Console.WriteLine("Textbox content {0}", _titleTextBox.Title);
            Console.WriteLine("Save button : {0}", _saveButton.IsActive);
        }
    }
}
