using System;
using System.Numerics;

namespace Console_RPG_game
{
    class Program
    {
        static public int PlayerHP = 4;
        static public int PotionAmount = 2;
        static public int EnemyHP_1 = 5;
        static public int EnemyHP_2 = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("You have been wondering in the forest armed with a sword and 2 potions happily until you encounter two Rivals with Sharp Sword,What Will you do? ");
            Console.WriteLine("To attack Enemy 1 Type A\nTo attack Enemy 2 Type B\nTo Drink a Potion Type P\nCOMMANDS COULD ONLY BE TAKEN IN CAPITAL LETTERS");
            GetInput();

        }

        static public void GetInput()
        {
            Console.WriteLine("Your Health : " + PlayerHP + "\nEnemy 1 Health : " + EnemyHP_1 + "\nEnemy 2 Health : " + EnemyHP_2 + "\nYour Potion amount : " + PotionAmount + "\nWhat will you do?TYPE HELP TO SEE COMMANDS AND STATS");
            String Input = Console.ReadLine();
            PlayerTurn(Input);
        }



        static public void PlayerTurn(String InputOption)
        {
            if (PlayerHP > 0)
            {
                switch (InputOption)
                {
                    // Remove 1 from Enemy 1 HP
                    case "A":
                        EnemyHP_1--;
                        Enemies_Turn();
                        Console.WriteLine("Your Health : " + PlayerHP + "\nEnemy 1 Health : " + EnemyHP_1 + "\nEnemy 2 Health : " + EnemyHP_2 + "\nYour Potion amount : " + PotionAmount + "\nWhat will you do?TYPE HELP TO SEE COMMANDS AND STATS");
                        break;
                    // Remove 1 from Enemy 2 HP
                    case "B":
                        EnemyHP_2--;
                        Enemies_Turn();
                        Console.WriteLine("Your Health : " + PlayerHP + "\nEnemy 1 Health : " + EnemyHP_1 + "\nEnemy 2 Health : " + EnemyHP_2 + "\nYour Potion amount : " + PotionAmount + "\nWhat will you do?TYPE HELP TO SEE COMMANDS AND STATS");
                        break;
                    // Remove Potion Amount then add 1 HP
                    case "P":
                        if (PotionAmount > 0)
                        {
                            PotionAmount--;
                            PlayerHP++;
                            PlayerHP++;
                            PlayerHP++;
                            Enemies_Turn();
                            Console.WriteLine("Your Health : " + PlayerHP + "\nEnemy 1 Health : " + EnemyHP_1 + "\nEnemy 2 Health : " + EnemyHP_2 + "\nYour Potion amount : " + PotionAmount + "\nWhat will you do?TYPE HELP TO SEE COMMANDS AND STATS");
                        }
                        else
                        {
                            Console.WriteLine("No Potions Left Try Again!");
                            GetInput();
                        }
                        break;
                    //HELP Command
                    case "HELP":
                        Console.WriteLine("To attack Enemy 1 Type A\nTo attack Enemy 2 Type B\nTo Drink a Potion Type P");
                        GetInput();
                        break;
                    // GIVE OUT WARNING FOR INVALID COMMAND
                    default:
                        Console.WriteLine("INVALID COMMAND!");
                        GetInput();
                        break;
                }

            }
            if (PlayerHP == 0) {
                Console.Clear();
                Console.WriteLine("                                     GAME OVER YOU DIED");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

        }

        static public void Enemies_Turn()
        {
            if (EnemyHP_1 > 0)
            {
                PlayerHP--;
                Console.WriteLine("");
                GetInput();
            }
            if (EnemyHP_2 > 0)
            {
                PlayerHP--;
                Console.WriteLine("");
                GetInput();
            }
            if (EnemyHP_1 == 0){
                if (EnemyHP_2 == 0) {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Congartulation!!! You have Won the game press X ");
                    Console.ReadLine();
                }
            }
        }
        




    }
}
