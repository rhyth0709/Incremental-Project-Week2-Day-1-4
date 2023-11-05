using System;
using System.Collections.Generic;
using System.Linq;
using dotnetapp.Managers;
using dotnetapp.Models;

namespace dotnetapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of managers
            Player p = new Player();
            PlayerManager playerManager = new PlayerManager();
             
            while(true)
            {
                Console.WriteLine("1.List All Players\n2.Delete a Player\n3.Add a Player\n4.Edit Player\n5.Display Single Player.\nAny other key to exit");
                Console.WriteLine("Enter your choice");
                string choice = Console.ReadLine();

                switch(choice)
                {

                    case "1":
                    Console.WriteLine("Using Connected");
                    playerManager.DisplayAllPlayers();
                    Console.WriteLine("Using Disconnected");
                    playerManager.ListPlayers();
                    break;
                    case "2":
                    Console.WriteLine("Enter the ID to Delete");
                    int i = Convert.ToInt32(Console.ReadLine());
                   
                   playerManager.DeletePlayer(i);
                    break;
                    case "3":
                    int id = Convert.ToInt32(Console.ReadLine());
                    int Age = Convert.ToInt32(Console.ReadLine());
                    string Name = Console.ReadLine();
                    string Category = Console.ReadLine();
                    decimal BiddingPrice = Convert.ToDecimal(Console.ReadLine());
                   // playerManager.AddPlayerToDatabase(new Player{Id=id,Name=Name,Age=Age,Category=Category,BiddingPrice=BiddingPrice});
                  playerManager.AddPlayer(new Player{Id=id,Name=Name,Age=Age,Category=Category,BiddingPrice=BiddingPrice});

                    break;
                    case "4":
                     id = Convert.ToInt32(Console.ReadLine());
                     Age = Convert.ToInt32(Console.ReadLine());
                     Name = Console.ReadLine();
                     Category = Console.ReadLine();
                     BiddingPrice = Convert.ToDecimal(Console.ReadLine());
                    playerManager.EditPlayer(new Player{Id=id,Name=Name,Age=Age,Category=Category,BiddingPrice=BiddingPrice});
                    break;
                    case "5":
                    Console.WriteLine("Enter Player Name to get Details");
                    Name = Console.ReadLine();
                    playerManager.FindPlayer(Name);
                    break;
                    default:
                    Environment.Exit(0);
                    break;
          

                }


            }
                     
        }
    }
}
