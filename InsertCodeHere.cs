using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode(string title, int date, int rating, int age, int lenght, string genre)
        {
            // The FIRST line of code should be BELOW this line
            Console.WriteLine(title);
            Console.WriteLine(date);
            Console.WriteLine(rating + "/10");
            Console.WriteLine("You need to be {0}+ to watch this movie", age);
            Console.WriteLine("It is "+lenght+" mintues long");
            Console.WriteLine("The movie's genre is "+genre);
            // The LAST line of code should be ABOVE this line
        }
    }
}
