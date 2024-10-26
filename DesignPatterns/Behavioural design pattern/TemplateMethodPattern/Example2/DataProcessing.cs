

namespace TemplateMethodPattern.Example2
{
    internal abstract class DataProcessing
    {
        /// <summary>
        /// Algorithem steps
        /// </summary>
        public void DateProcesssing()
        {
            Initilization();
            LoadData();
            ProcessData();
            FinalizeProcessing();
        }

        protected void Initilization()
        {
            Console.WriteLine("Initilization is completed");
        }

        //these both will be implemented by data soure
        //like CSV, files, Database 
        protected abstract void LoadData();
        protected abstract void ProcessData();


        protected  void FinalizeProcessing()
        {
            Console.WriteLine("Final processing is done");
        }
    }
}
