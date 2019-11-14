using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;


namespace ConsoleApp5
{
    public class Program
    {
        //public string returnResult()
        // {

        // }
        public static int Main(string[] args)

        {
            int a = Program.FileSort();
            //Console.WriteLine(a);
            return a;

            //\\lvlnas10\Public\KTP Last Pics
            //(@"C:\Users\sean.brittian\source\repos\ConsoleApp5\ConsoleApp5\Quality_pic_samples");
        }
        /*
        public static int TestRes()
        {
            int a = Program.FileSort();
            Console.WriteLine(a);
            return a;
        }
        */
        public static int FileSort()
        {

            string[] GetDirectory = Directory.GetDirectories(@"\\lvlnas10\\Public\\KTP Last Pics");
            string[] GetPictures1 = Directory.GetFiles(GetDirectory[0], "*.jpg");
            string[] GetPictures2 = Directory.GetFiles(GetDirectory[1], "*.jpg");
            string[] GetPictures3 = Directory.GetFiles(GetDirectory[2], "*.jpg");
            string[] GetPictures4 = Directory.GetFiles(GetDirectory[3], "*.jpg");

            int i;
            int result = 0;

            for (i = 0; i < GetDirectory.Length; i++)
            {
                if (i == 0)
                {
                    foreach (string file in GetPictures1)
                    {
                        string a = ColorTest(file);
                        if (a == "fail")
                        {
                            result += 1;
                        }
                        else
                        {
                            result += 0;
                        }
                        //Console.WriteLine(file);
                    }
                }
                if (i == 0)
                {
                    foreach (string file in GetPictures2)
                    {
                        string a = ColorTest(file);
                        if (a == "fail")
                        {
                            result += 1;
                        }
                        else
                        {
                            result += 0;
                        }
                        //Console.WriteLine(file);
                    }
                }
                if (i == 0)
                {
                    foreach (string file in GetPictures3)
                    {
                        string a = ColorTest(file);
                        if (a == "fail")
                        {
                            result += 1;
                        }
                        else
                        {
                            result += 0;
                        }
                        //Console.WriteLine(file);
                    }
                }
                if (i == 0)
                {
                    foreach (string file in GetPictures4)
                    {
                        string a = ColorTest(file);
                        if (a == "fail")
                        {
                            result += 1;
                        }
                        else
                        {
                            result += 0;
                        }
                        //Console.WriteLine(file);
                    }
                }
            }
            //string a = ColorTest(@"\\lvlnas10\\Public\\KTP Last Pics\Row 4\3031962_rear_20191008012215.jpg");
            //Console.WriteLine(a);
            if (result < 5)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }
            return result;
        }

        public static string ColorTest(string image)
        {
            Bitmap imageck;
            imageck = new Bitmap(image);

            int x, y;
            int test = 0;
            string b;
            string res = "Color [A=255, R=0, G=0, B=0]";
            for (x = 0; x < 10; x++)
            {
                for (y = 0; y < 10; y++)
                {
                    Color pixelColor = imageck.GetPixel(x, y);
                    string pixcol = Convert.ToString(pixelColor);
                    if (pixcol == res)
                    {
                        test = 1;

                    }
                    //Console.WriteLine(pixelColor);

                }
            }
            if (test == 0)
            {
                b = ("pass");
            }
            else
            {
                b = ("fail");

            }
            return b;
        }



    }

}
