using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Account ACC =new Account();
            Console.WriteLine("виберіть свою посаду  1-Fullstak 2-Manager 3-HR 4-FrontEnd");
            
            int Post =int.Parse(Console.ReadLine());
            Console.WriteLine("введіть кількість своіх годин ");
            int hours = int.Parse(Console.ReadLine());
            switch (Post)
            {
                case 1:
             ACC.AskForBonus(position.FullStak, hours);
                    break;
                    case 2:
                    ACC.AskForBonus(position.Manager, hours);
                    break;
                    case 3:
                    ACC.AskForBonus(position.HR, hours);
                    break;
                case 4:
                    ACC.AskForBonus(position.FrontEnd, hours);
                    break;
                default:
                    {
                        Console.WriteLine("немае такоі посади");
                        break;

                    }


            }

         
          //  int hours=int.Parse(Console.ReadLine());
          //  ACC.AskForBonus(position.FullStak,hours);

        }
    }
}
