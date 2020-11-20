using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples\LOGITpe2020-Week12-WorkingWithFiles-task\";
            string vegetablesPath = @"C:\Users\opilane\samples\LOGITpe2020-Week12-WorkingWithFiles-task\vegetables\";
            string fruitPath = @"C:\Users\opilane\samples\LOGITpe2020-Week12-WorkingWithFiles-task\fruit\";

            Fruit(rootPath, fruitPath);
            Vegetables(rootPath, vegetablesPath);
            Deleter(fruitPath, vegetablesPath);
        }
        public static void Fruit(string rootPath, string fruitPath)
        {

            File.Move(rootPath + "apples.txt", fruitPath + "apples.txt");
            File.Move(rootPath + "bananas.txt", fruitPath + "bananas.txt");
            File.Move(rootPath + "pineapples.txt", fruitPath + "pineapples.txt");
        }
        public static void Vegetables(string rootPath, string vegetablesPath)
        {
            File.Move(rootPath + "cucumbers.txt", vegetablesPath + "cucumbers.txt");
            File.Move(rootPath + "onions.txt", vegetablesPath + "onions.txt");
            File.Move(rootPath + "potatos.txt", vegetablesPath + "potatos.txt");
        }
        public static void Deleter(string fruitPath, string vegetablesPath)
        {
            File.Delete(vegetablesPath + "cheese.txt");
            File.Delete(fruitPath + "toiletPaper.txt");
        }
    }
}
