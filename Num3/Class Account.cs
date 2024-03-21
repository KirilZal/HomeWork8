namespace Num3
{
    using System;
    enum position
    {
       Manager = 160,
       HR = 168,
       FullStak = 200,
       FrontEnd = 300
    }
    class Account
    {  
        public bool AskForBonus(position worker, int hours)
        {
            double premiacof = 0.25;
            if (hours > (int)worker) 
            {
                double bonus = premiacof * hours;
                Console.WriteLine($"премія працівника ${bonus}");
                return true;
            }
            else
            {
                Console.WriteLine("ви не отримаете премію");
                return false;
            }
          
        }
       
    } 
}