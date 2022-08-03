namespace Name;

using System;

class Program
{

    public static void Main()
    {
        int NumberOfPoles = 10;
        var Poles = new PoleGenerator(NumberOfPoles);
        var frogGame = new Frog(NumberOfPoles,Poles);
    }

}
class PoleGenerator
{
    public bool IsEven;
    private List<float> PoleList= new List<float>{};
    public  List<float> Poles
    {
        get
        {
            return PoleList;
        }
    }
    private float PoleHight; 

    public PoleGenerator(int NumberOfPoles)
    {
        if (NumberOfPoles % 2 != 0)
        { 
            IsEven = false;
        }
        for (int i = 0; i < NumberOfPoles; i++)
        {
            PoleHight = Random.Shared.NextSingle() *(20-10) + (10);
            PoleList.Add(PoleHight);
        }
    }
}
class Frog
{

    private int FrogOneIndex;
    private int FrogTwoIndex;
    
    
    public Frog(int NumberOfPoles, PoleGenerator poles)
    {
        if (NumberOfPoles % 2== 0 )
        {
            FrogOneIndex = (poles.Poles.Count() / 2) - 1 ;
            FrogTwoIndex = poles.Poles.Count() / 2;
            var FrogOneCheck = poles.Poles.Where(p => poles.Poles[FrogOneIndex] >= poles.Poles[FrogOneIndex-1]);
            for (int i = 0; i < FrogOneCheck.Count(); i++)
            {
                foreach (var item in FrogOneCheck)
                {
                    Console.WriteLine($"FrogOne Can move forward the pole its on is {FrogOneIndex} and pole height is {poles.Poles[FrogOneIndex]}\n");

                    FrogOneIndex--;

                    Console.WriteLine($"FrogOne Moved and right now its on the pole {FrogOneIndex} and pole height is {poles.Poles[FrogOneIndex]}\n");
                    Console.WriteLine("------------------------------\n");
                }
            }

            Console.WriteLine($"FrogOne Couldn't move because the pole ahead of it has bigger height than it is standing\n");

            var FrogTwoCheck = poles.Poles.Where(p => poles.Poles[FrogTwoIndex] >= poles.Poles[FrogTwoIndex+1]);
            
            for (int i = 0; i < FrogTwoCheck.Count(); i++)
            {
                foreach (var item in FrogTwoCheck)
                {
                    Console.WriteLine($"FrogTwo Can move forward the pole its on is {FrogTwoIndex} and pole height is {poles.Poles[FrogTwoIndex]}\n");

                    FrogTwoIndex++;

                    Console.WriteLine($"FrogTwo Moved and right now its on the pole {FrogTwoIndex} and pole height is {poles.Poles[FrogTwoIndex]}\n");

                    Console.WriteLine("------------------------------\n");

                }
            }

            Console.WriteLine($"FrogTwo Couldn't move because the pole ahead of it has bigger height than it is standing\n");

        }else
        {
            FrogOneIndex = poles.Poles.Count() / 2;
            FrogTwoIndex = poles.Poles.Count() / 2;

            var FrogOneCheck = poles.Poles.Where(p => poles.Poles[FrogOneIndex] >= poles.Poles[FrogOneIndex-1]);
            for (int i = 0; i < FrogOneCheck.Count(); i++)
            {
                foreach (var item in FrogOneCheck)
                {
                    Console.WriteLine($"FrogOne Can move forward the pole its on is {FrogOneIndex} and pole height is {poles.Poles[FrogOneIndex]}\n");

                    FrogOneIndex--;

                    Console.WriteLine($"FrogOne Moved and right now its on the pole {FrogOneIndex} and pole height is {poles.Poles[FrogOneIndex]}\n");

                    Console.WriteLine("------------------------------\n");

                }
            }

            Console.WriteLine($"FrogOne Couldn't move because the pole ahead of it has bigger height than it is standing\n");
            Console.WriteLine("------------------------------\n");

            var FrogTwoCheck = poles.Poles.Where(p => poles.Poles[FrogTwoIndex] >= poles.Poles[FrogTwoIndex+1]);
            
            for (int i = 0; i < FrogTwoCheck.Count(); i++)
            {
                foreach (var item in FrogTwoCheck)
                {
                    Console.WriteLine($"FrogTwo Can move forward the pole its on is {FrogTwoIndex} and pole height is {poles.Poles[FrogTwoIndex]}\n");

                    FrogTwoIndex++;

                    Console.WriteLine($"FrogTwo Moved and right now its on the pole {FrogTwoIndex} and pole height is {poles.Poles[FrogTwoIndex]}\n");

                    Console.WriteLine("------------------------------\n");

                }
            }

            Console.WriteLine($"FrogTwo Couldn't move because the pole ahead of it has bigger height than it is standing\n");
            Console.WriteLine("------------------------------\n");
        }
        
    }

}