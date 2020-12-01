using System;

namespace Zoological
{
    public class Lion : IWalking
    {
        public void Walk()
        {
            Console.WriteLine("lazing around");
        }

        public void Run()
        {
            Console.WriteLine("You can't catch me!");
        }
    }
}