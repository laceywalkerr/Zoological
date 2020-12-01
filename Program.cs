using System;
using System.Collections.Generic;

namespace Zoological
{
    class Program
    {
        static void Main(string[] args)
        {
            Platypus p1 = new Platypus();
            Platypus p2 = new Platypus();
            Platypus p3 = new Platypus();
            Platypus p4 = new Platypus();

            Dolphin d1 = new Dolphin();
            Dolphin d2 = new Dolphin();
            Dolphin d3 = new Dolphin();

            Lion l1 = new Lion();
            Lion l2 = new Lion();

            Pigeon pi1 = new Pigeon();
            Pigeon pi2 = new Pigeon();
            Pigeon pi3 = new Pigeon();

            Seagull s1 = new Seagull();
            Seagull s2 = new Seagull();

            List<IFlying> flyingAnimals = new List<IFlying>()
            {
                pi1,
                pi2,
                pi3,
                s1,
                s2
            };

            foreach (IFlying flyer in flyingAnimals)
            {
                flyer.Fly();
            }

            List<IWalking> walkingAnimals = new List<IWalking>()
            {
                pi1,
                s1,
                l1,
                p1
            };

            foreach (IWalking walker in walkingAnimals)
            {
                walker.Walk();

            }
        }
    }
}