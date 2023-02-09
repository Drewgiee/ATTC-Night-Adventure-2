using System;
using System.Collections.Generic;
namespace ATTCNightAdventure
{
    public class program {
          
        public static void Main(string[] args) {
             // assets/collectibles
            string[] collectibles = {"Can of Beans", "Benchmade Demascus steel Knife", "Jordans", "Apple iPhone 14 Pro Max", "Gold Rolex"};
            List<string> collectiblesRange = new List<string>   (collectibles);
            // shoes
            string[] shoes = {"Jordans","New Balances","Reebok", "Nike"}; 
            List<string> shoesRange = new List<string>   (shoes); 
            // currency/item values
            int Money = 50;
            int Glock_17_Gen_5_Value = 1600;
            int Rolex_Value = 1690;
            int Money_Left=Money;
            // item damage values
            int Glock_17_Gen_5_damage = 40;
            int Benchmade_Demascus_steel_Knife_damage = 20;
            // player hp pool & damage
            int player_health = 100; 
            Console.WriteLine(player_health);
            // player fist damage seperate from glock dmg
            int player_damage =10; 

            
            
            // damage values taken by player
            int robber_damage =15;
            // robber health
            int robber_health =80; 
            int robber_health_left = robber_health - player_damage;
            
            // remaining player health
            int player_health_left = player_health - robber_damage;
            player_health = player_health_left;
            Console.WriteLine(player_health_left);
            
            // Health CheckPoints
            int EMT_help = player_health_left +10;
            Console.WriteLine(player_health);

            // check inventory/add inventory functions
            List<string> inventory = new List<string>();
            Console.WriteLine(String.Join(" ", inventory));
            
            
            
        
            
            Console.WriteLine(@"
 __          __  _                            _______    
 \ \        / / | |                          |__   __|   
  \ \  /\  / ___| | ___ ___  _ __ ___   ___     | | ___  
   \ \/  \/ / _ | |/ __/ _ \| '_ ` _ \ / _ \    | |/ _ \ 
    \  /\  |  __| | (_| (_) | | | | | |  __/    | | (_) |
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|    |_|\___/ 
                                                         
                                                                     

            ");

                Thread.Sleep(1000);

            Console.WriteLine(@"
             _______   _         _______ _                           _        _____ _     _                       
     /\     |__   __| (_)       |__   __| |                         | |      / ____| |   (_)                      
    /  \       | |_ __ _ _ __      | |  | |__  _ __ ___  _   _  __ _| |__   | |    | |__  _  ___ __ _  __ _  ___  
   / /\ \      | | '__| | '_ \     | |  | '_ \| '__/ _ \| | | |/ _` | '_ \  | |    | '_ \| |/ __/ _` |/ _` |/ _ \ 
  / ____ \     | | |  | | |_) |    | |  | | | | | | (_) | |_| | (_| | | | | | |____| | | | | (_| (_| | (_| | (_) |
 /_/    \_\    |_|_|  |_| .__/     |_|  |_| |_|_|  \___/ \__,_|\__, |_| |_|  \_____|_| |_|_|\___\__,_|\__, |\___/ 
                        | |                                     __/ |                                  __/ |      
                        |_|                                    |___/                                  |___/                                                                                                                                                                                                                 
            ");
            Thread.Sleep(1000);
            Console.WriteLine(@"
  _   _ _       _     _     _______ _                              _                 _                  
 | \ | (_)     | |   | |   |__   __(_)                    /\      | |               | |                 
 |  \| |_  __ _| |__ | |_     | |   _ _ __ ___   ___     /  \   __| __   _____ _ __ | |_ _   _ _ __ ___ 
 | . ` | |/ _` | '_ \| __|    | |  | | '_ ` _ \ / _ \   / /\ \ / _` \ \ / / _ | '_ \| __| | | | '__/ _ \
 | |\  | | (_| | | | | |_     | |  | | | | | | |  __/  / ____ | (_| |\ V |  __| | | | |_| |_| | | |  __/
 |_| \_|_|\__, |_| |_|\__|    |_|  |_|_| |_| |_|\___| /_/    \_\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|
           __/ |                                                                                        
          |___/                                                                                         
            "); 
            Thread.Sleep(1000);

           
            
// Introduction
    Console.WriteLine("Just as your about to head to bed you go to the fridge to get a glass of milk, as you open the fridge you realize there is no milk");
    Thread.Sleep(1000);
    Console.WriteLine("You realize you must take on the chicago night life to go buy some milk");

// Climb out window or front door (sneakOut)
    Console.WriteLine("Seeing as it is late you must either climb out the window or sneak out through the front door");
    Thread.Sleep(1000);
    Console.WriteLine("Do you sneak out the window? y/n");
    var sneakOut = Console.ReadLine();
    if(sneakOut == "y") {
        Console.WriteLine("You sneak out the window and make your way down fire escape and are now by the road");
        inventory.Add("Can o' beans");
        
        Thread.Sleep(1000);
                
    }
    else if(sneakOut == "n"){
        Console.WriteLine("You sneak out the front door and take the elevator down to the lobby and walk outside");
        Thread.Sleep(1000);
    }
            
// You made it outside and do you want to check your inventory (checkInventory)
    Console.WriteLine("Before you brave the Chicago night life would you like to check your inventory? y/n");
    var checkInventory = Console.ReadLine();
    if (checkInventory == "y"){

                 Console.WriteLine("You have: ");
                foreach (string item in inventory)
                        {
                           
                            Console.Write(item + ", ");
                            Thread.Sleep(1000);
                            
                        } 
                        
            
                
            
        } else if (checkInventory == "n") {
            Console.WriteLine("You continue on your journey.");
            Thread.Sleep(1000);
    }

    Console.WriteLine("    ");
    // Encounter Man with weapon (manWeapon)
        
            
        
            Console.WriteLine("You encounter a man and he tells you to give him all your money, he also brandishes a weapon. Do you take him on? y/n");
            Console.WriteLine("You have no weapons to fight with");
            var manWeapon = Console.ReadLine();
            
            
            
            if (manWeapon == "y"){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine( @"
  ______ _       _     _   
 |  ____(_)     | |   | |  
 | |__   _  __ _| |__ | |_ 
 |  __| | |/ _` | '_ \| __|
 | |    | | (_| | | | | |_ 
 |_|    |_|\__, |_| |_|\__|
            __/ |          
           |___/                           
                
                ");
                Console.WriteLine("You and the man fight. After a long hard battle you end up victorious");
                Console.ForegroundColor = ConsoleColor.White;
                // minor injuries sustained
                Console.WriteLine("You now have " + player_health_left + " health left, you sustained minor injuries, if you find a medical center you can regain your health.");
                Thread.Sleep(1000);
                Console.WriteLine("Do you check the mans inventory? y/n");
                var deadManInventory = Console.ReadLine();
                if(deadManInventory == "y") {
                    Console.WriteLine("The man had a Benchmade Damascus Steel Knife");
                    Console.WriteLine("Do you take it? y/n");
                    var takeWeapon = Console.ReadLine();
                    if(takeWeapon == "y"){
                         inventory.Add("Benchmade Demascus Knife");
                        Console.WriteLine("You have: ");
                foreach (string item in inventory)
                        {
                           
                            Console.Write(item + ", ");
                            Thread.Sleep(1000);
                            
                        } 
                    }
                    else if (takeWeapon == "n"){
                        Console.WriteLine("You leave the knife and continue your path.");
                    }
                }
                
            }
            else if (manWeapon == "n"){
                Console.WriteLine("You say no and the man runs down the alley.");
                
            } 
                        
            Console.WriteLine("Seeing as it is not safe to walk around outside would you like to call a Taxi? y/n");
            var callTaxi = Console.ReadLine(); 

            if (callTaxi == "y") {
                Console.WriteLine("You stand and wait before a Taxi finally pulls over and lets you in. You sit down and get settled in and see somthing shining from the rip in the seat. What will it be?");
                Console.WriteLine("Its a gold Rolex!");
                Console.WriteLine("You tell the Taxi driver to take you to the pawn shop so you can make some quick cash");
                Thread.Sleep(1000);
            Console.WriteLine("After a 15 min ride you make it to the pawn shop");
            Thread.Sleep(1000);
            Console.WriteLine("You walk up to the counter to start the negotiation for the Rolex and a Glock 17 Gen 5 catches your eye");
            Thread.Sleep(1000);
            Console.WriteLine("Would you like the gun? y/n"); 
            var buyGun = Console.ReadLine();
            if (buyGun == "y") {
                Console.WriteLine("The Glock 17 Gen 5 is now yours!");
                inventory.Add("Glock 17 Gen 5");
                Console.WriteLine("You have: ");
                foreach (string item in inventory)
                        {
                           
                            Console.Write(item + ", ");
                            Thread.Sleep(1000);
                            
                        } 
            }

                



                
            }  Console.WriteLine("You continue to the store");
            
             else if(callTaxi == "n") {
                Console.WriteLine("You decide not to call a Taxi and keep walking in the dark at 1 am after almost getting robbed in Chicago. Good Choice.");
                           //no to taxi
            Console.WriteLine("You continue your way down the road.");
            
            Console.WriteLine("You find a rich persons house. Do you dumpster dive or no?: (y/n)");
            var dumsterDive = Console.ReadLine();
            
            switch (dumsterDive) {
// Yes to Dumpster Dive
                case "y":
                    Console.WriteLine("You head to the dumpster and find a Gold Rolex. Do you head to the pawn shop to trade it?: (y/n)");
                    inventory.Add("Gold Rolex");
                    var pawnShopDumpster = Console.ReadLine();
// Yes to Pawn Shop
                    switch (pawnShopDumpster){
                        case "y":
                        Console.WriteLine("You get to the pawn shop. You find a Glock 17 Gen 5. Do you trade for the Glock?: (y");
                            var pawnGlockDumpster = Console.ReadLine();
                            // Yes to Glock
                            switch (pawnGlockDumpster){
                                case "y":
                                    inventory.Add("Glock 17 Gen 5");
                                    Console.WriteLine("You trade for the Glock 17 Gen 5 and continue on your path to the store.");
                                    Console.WriteLine("Your inventory now is: ");
                foreach (string item in inventory)
                        {
                           
                            Console.Write(item + ", ");
                            Thread.Sleep(1000);
                            
                        } 
                                break;

                                case "n":
                                    Console.WriteLine("You end up keeping the Rolex and continue to the store.");
                                break;
                            }
                            
                        break;

                        case "n":
                            Console.WriteLine("You continue on your path towards the store.");
                        break;
                    }

                    break;
// No to Dumpster Dive
                case "n":
                    Console.WriteLine("You continue your way to the store.");
                break;

            }
            }
           
    }
}}