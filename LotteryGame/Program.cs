using System;

namespace LottoApp
{
   class Program
   {

      static string[] users = { "Anna", "Simon", "Antonio", "Erik" };
     
      

      

      static int BuyTickets()
      {
         int tickets = 0;
         int ticketNumbers;
         


         Console.WriteLine("Ange din användare: ");
         string userName = Console.ReadLine();
         Console.Write("Hur många lotter vill du köpa (max 5st): ");
         while (!int.TryParse(Console.ReadLine(), out tickets))
         {
            Console.WriteLine("Du kan endast köpa 5 lotter");
         }

       
            
            
                for (int i = 0; i < tickets; i++)
                {
                    Console.WriteLine("Ange ditt nummer du vill satsa på: ");
                    while (!int.TryParse(Console.ReadLine(), out ticketNumbers) && ticketNumbers < 50)
                    {
                        Console.WriteLine("Du måste ange tal nellan 1 - 50");
                    }
                    LotteryTickets[i] = ticketNumbers;
                }
        


         return tickets;



      }

   

        static void GetWinningTickets(int amount) 
        {
            int[] ComputersNumbers = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Random rnd = new Random();
                ComputersNumbers[i] = rnd.Next(1, 51);
            }
            for (int i = 0; i < amount; i++)
            {
                if (ComputersNumbers[i] == LotteryTickets[i]) 
                {
                    wins += 1;
                    Console.WriteLine($"Du vann {wins} gånger");
                } else
                {
                    Console.WriteLine($"Fel förlora {ComputersNumbers[i]} {LotteryTickets[i]}");
                }
                
            }
        }

        static int wins = 0;

        static int[] LotteryTickets = new int[5];


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Lotto App!");
            int amount = BuyTickets();
            //TicketGenerator(amount);
            GetWinningTickets(amount);


        }
    }
}