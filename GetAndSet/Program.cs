using System;

namespace GetAndSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.Name = "Michael";

            Console.WriteLine(user.Name);
        }
    }
}
