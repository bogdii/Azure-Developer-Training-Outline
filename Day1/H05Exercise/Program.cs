using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B01WebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the image that you want to download");
            string image = Console.ReadLine();
            WebClient client = new WebClient();
   
            string url = $"https://www.google.com/search?q={image}";
            string localPath = @"C:\Images"; 
            string fileName = "image.png"; 

            // If the local folder does not exist
            if (!Directory.Exists(localPath))
            {
                Directory.CreateDirectory(localPath);
            }

            
            string filePath = Path.Combine(localPath, fileName);

            
            client.DownloadFile(url, filePath);


            Console.WriteLine($"Image downloaded and saved to {filePath}");

            Console.ReadLine();
        }
    }
}