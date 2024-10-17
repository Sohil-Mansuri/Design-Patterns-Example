
namespace MediatorPattern.Using_observer
{
    /// <summary>
    /// Observer
    /// no more if else statement usign Observer pattern
    /// </summary>
    internal class ArticalDialogBox
    {
        ArticalListBox _articalListBox = new();
        SaveButton _saveButton = new();
        TitleTextBox _titleTextBox = new();

        public ArticalDialogBox()
        {
            _articalListBox.AddEventHandler(ArticalSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
        }

        public void SelectArtical(string artical)
        {
            _articalListBox.SelectedItem = artical;

            //print to check
            Console.WriteLine("Textbox content {0}", _titleTextBox.Title);
            Console.WriteLine("Save button : {0}", _saveButton.IsActive);
        }


        private void ArticalSelected()
        {
            _titleTextBox.Title = _articalListBox.SelectedItem;
            _saveButton.IsActive = true;
        }

        private void TitleChanged()
        {
            _saveButton.IsActive = !string.IsNullOrEmpty(_titleTextBox.Title);
        }

        
    }
}
