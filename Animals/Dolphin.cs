using System;

namespace Zoological
{
    public class Dolphin : ISwiming
    {
        public int MaximumDepth { get; } = 1000;

        public void Swim()
        {
            Console.WriteLine("Swim, Swim");
        }
    }
}