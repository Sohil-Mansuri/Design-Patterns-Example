
namespace StrategyPattern.Problem
{
    public class ImageStorage(ImageType imageType, string filter)
    {
        /// <summary>
        /// This is not correct way, its not following SRP, its saving, compressing and Filtering
        /// Also its no follwing OCP, tomorrow if we get new Image type then again you have to update this class 
        /// Solution is Use strategy pattern if you have multiple alogrithems
        /// Check solution section for more details 
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(string fileName)
        {
            //Compress image 
            if (imageType == ImageType.Jpg)
            {
                CompressJpg();
            }
            else if (imageType == ImageType.Png)
            {
                CompressPng();
            }

            //ApplyFilter 
            if (filter == Constancs.BlackAndWhite)
                ApplyBlackAndWhiteFilter();
            else if (filter == Constancs.HighContrast)
                ApplyHighContrast();

            //Save image into any storage
            Console.WriteLine("{0} is Saved", fileName);
        }

        private void CompressJpg()
        {
            Console.WriteLine("Compressing jpg file");
        }

        private void CompressPng()
        {
            Console.WriteLine("Compressing png file");
        }

        private void ApplyBlackAndWhiteFilter()
        {
            Console.WriteLine("Applying Back And white");
        }

        private void ApplyHighContrast()
        {
            Console.WriteLine("Applying  High-Contrast filter");
        }
    }


    public enum ImageType
    {
        None,
        Jpg,
        Png
    }
}
