namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from problem section");

            var compressCloudString = new Problem.EncryptedCoudStream();
            compressCloudString.Write("sohilmansuri");

            // now if we got the requirement of do compression and encryption before storing into cloud
            //so have to again create new class Called CompressAndEnryptionCloudStream class and inheri from ClouStream class
            // if order change then also we have to update again 
            // such issue can be solved using Decorater pattern 


            Console.WriteLine("Output from solution section");

            var encoding = new Solution.EncryptComponenet(new Solution.CloudStreamComponent());
            encoding.Operation("sohilMansuri3434");

            Console.WriteLine("Example 2");
            var compressEncoding = new Solution.CompressComponenet(new Solution.EncryptComponenet(new Solution.CloudStreamComponent()));
            compressEncoding.Operation("stereteere5fdfjdfdj");


            Console.WriteLine("Output from Coffee section");

            var coffeeWithExtraCreemAndMilk = new CoffeeExample.CreemDecorator(new CoffeeExample.MilkDecorator(new CoffeeExample.CoffeeDecorater()));

            //Here we can chage the order also

            Console.WriteLine("Total : {0} ", coffeeWithExtraCreemAndMilk.Calculate());
            Console.WriteLine("Item : {0} ", coffeeWithExtraCreemAndMilk.GetDescription());

            Console.ReadKey();
        }
    }
}
