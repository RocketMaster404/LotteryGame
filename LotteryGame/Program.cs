using System;

namespace LottoApp
{
   class Program
   {

      static string[] users = { "Anna", "Simon", "Robin", "Erik" };


      static int[] LotteryTickets = new int[5];

      static int BuyTickets()
      {
         int tickets = 0;
         int ticketNumbers;
         bool logIn = true;

         while (logIn)
         {
            Console.WriteLine("Ange din användare: ");
            string userName = Console.ReadLine();

            for (int i = 0; i < users.Length; i++)
            {
               if (userName == users[i])
               {
                  Console.WriteLine($"Välkommen {userName}");
                  logIn = false;
               }
            }

            if (logIn)
            {
               Console.WriteLine("Felaktigt användarnamn");
            }

           
         }
         Console.Write("Hur många lotter vill du köpa (max 5st): ");
         while (!int.TryParse(Console.ReadLine(), out tickets) || tickets > 5)
         {
            Console.WriteLine("Du kan endast köpa 5 lotter");
         }




         for (int i = 0; i < tickets; i++)
         {
            Console.WriteLine("Ange ditt nummer du vill satsa på: ");
            while (!int.TryParse(Console.ReadLine(), out ticketNumbers) || ticketNumbers > 50)
            {
               Console.WriteLine("Du måste ange tal mellan 1 - 50");
            }
            LotteryTickets[i] = ticketNumbers;
         }

         return tickets;

      }



      static void GetWinningTickets(int amount)
      {


         bool win = false;

         int[] ComputersNumbers = new int[3];
         for (int i = 0; i < ComputersNumbers.Length; i++)
         {
            Random rnd = new Random();
            ComputersNumbers[i] = rnd.Next(1, 7);
            Console.Write($"{ComputersNumbers[i]} ");

         }


         for (int i = 0; i < amount; i++)
         {

            for (int j = 0; j < ComputersNumbers.Length; j++)
            {
               if (ComputersNumbers[j] == LotteryTickets[j])
               {

                  win = true;
               }

            }

         }

         if (win)
         {
            Console.WriteLine($"\nGrattis du vann");
         }
         else
         {
            Console.WriteLine($"\nDu förlorade");
         }
      }




      static void Main(string[] args)
      {

         Console.WriteLine("Welcome to the Lotto App!");
         int amount = BuyTickets();
         //TicketGenerator(amount);
         GetWinningTickets(amount);


      }
   }
}