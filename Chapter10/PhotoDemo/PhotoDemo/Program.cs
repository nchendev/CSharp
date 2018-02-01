using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PhotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--REGULAR PHOTO--");
            Photo photo1 = new Photo();
            WriteLine(photo1);
            WriteLine("--MATTED PHOTO--");
            MattedPhoto photo2 = new MattedPhoto();
            WriteLine(photo2);
            WriteLine("--FRAMED PHOTO--");
            FramedPhoto photo3 = new FramedPhoto();
            WriteLine(photo3);
            ReadLine();
        }
    }
    class Photo
    {
        protected double width;
        protected double height;
        protected double price;
        public Photo()
        {
            WriteLine("What is the width?");
            width = double.Parse(ReadLine());
            WriteLine("What is the height?");
            height = double.Parse(ReadLine());
            if (width == 8 && height == 10)
                price = 3.99;
            else if (width == 10 && height == 8)
                price = 3.99;
            else if (width == 10 && height == 12)
                price = 5.99;
            else if (width == 12 && height == 10)
                price = 5.99;
            else
                this.price = 9.99;
        }
        public override string ToString()
        {
            return (GetType() + ": w=" + width + " h=" + height + "color=none framed=no price=" + price);
        }
    }
    class MattedPhoto:Photo
    {
        protected string color;
        string Color
        {
            get
            {
                return color;
            }
            set
            {
                WriteLine("What color do you want your matted photo?");
                color = ReadLine();
            }
        }
        public MattedPhoto()
        {

            WriteLine("What color do you want your matted photo?");
            color = ReadLine();
            ToString();
        }
        public override string ToString()
        {
            return (GetType() + ": w=" + width + " h=" + height + " color=" + color + " framed=no price=" + price+10);
        }
    }
    class FramedPhoto:Photo
    {
        public override string ToString()
        {
            return (GetType() + ": w=" + width + " h=" + height + " color=none framed=yes price=" + price+25);
        }
    }
}
