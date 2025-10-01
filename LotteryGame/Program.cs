using System;

namespace LottoApp
{
   class Program
   {

      static string[] users = { "Anna", "Simon", "Antonio", "Erik" };

      static int GetUserNumber()
      {
         int input = 0;
         Console.WriteLine("Ange ditt val: ");
         while (!int.TryParse(Console.ReadLine(), out input))
         {
            Console.WriteLine("Du måste ange heltal");
         }
         return input;

      }

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

         while(tickets > 0)
         {
            Console.WriteLine("Ange ditt nummer du vill satsa på: ");
            while (!int.TryParse(Console.ReadLine(), out ticketNumbers) && ticketNumbers >0 || ticketNumbers < 50)
            {
               Console.WriteLine("Du måste ange tal nellan 1 - 50");
            }
            
         }


         return tickets;



      }

      static void Menu()
      {
         Console.WriteLine("1) Köp lotter\n2) Spela\n3) Avsluta");
         int choice = GetUserNumber();

         switch (choice)
         {
            case 1:
               // Köp lotter
               break;
            case 2:
               // Spela
               break;
            case 3:
               //Avsluta
               break;
            default:
               Console.WriteLine("Ange en siffra mellan 1-3");
               break;
         }



      }
      static void Main(string[] args)
      {
         Console.WriteLine("Welcome to the Lotto App!");
      }
   }
}