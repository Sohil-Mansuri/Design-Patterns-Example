
namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Example 1 GUI framework");

            var customerService = new Example1.CustomerService();
            var addCustomerCommand = new Example1.AddCustomerCommand(customerService);

            var button = new Example1.Button(addCustomerCommand);
            button.Click();

            Console.WriteLine("You can see all these objects are communicating with each other to do comples task");

            Console.WriteLine("Output from Example 2 : Marcro Recording");

            var compositeCommand = new Example2.CompositeCommand();
            compositeCommand.AddCommand(new  Example2.BlackAndWhiteFilterCommand());
            compositeCommand.AddCommand(new  Example2.ResizeCommand());
            compositeCommand.Execute();

            Console.WriteLine("Output from Example 3 : Undo operation");

            var htmldocument = new Example3.HtmlDocument();
            var history = new Example3.History();
            var undoCommand = new Example3.UndoCommand(history);
            var boldCommand = new Example3.BoldCommand(htmldocument, history);
            var resizeCommand = new Example3.ReSizeCommand(htmldocument, history);

            htmldocument.Size = 30;
            htmldocument.Content = "sohil";
            boldCommand.Execute();
            resizeCommand.Execute();
            Console.WriteLine("after executing");
            Console.WriteLine(htmldocument.Content);
            Console.WriteLine(htmldocument.Size);


            undoCommand.Execute();
            Console.WriteLine("after first undo");
            Console.WriteLine(htmldocument.Size);
            Console.WriteLine(htmldocument.Content);

            undoCommand.Execute();
            Console.WriteLine("after second undo");
            Console.WriteLine(htmldocument.Size);
            Console.WriteLine(htmldocument.Content);


            Console.ReadKey();
        }
    }
}
