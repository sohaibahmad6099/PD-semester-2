using System;
using System.Collections.Generic;
using System.Linq;
using Week_4_PD_Tasks.BL;

namespace Week_4_PD_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(num<4)
            {
                num = taskMenu();
                Console.Clear();
                if(num==1)
                {
                    Task1();
                }
                else if(num==2)
                {
                    Task2 ();
                }
                else if(num==3)
                {
                    Task3();
                }
            }
        }
        static int taskMenu()
        {
            int num;
            Console.WriteLine("1.Task 1");
            Console.WriteLine("2.Task 2");
            Console.WriteLine("3.Task 3");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void Task3()
        {
            List<Player> Players = new List<Player>();
            List<Stats> Stats = new List<Stats>();
            Player Input = new Player();
            Stats Output = new Stats();
            int idx = 0;
            int idx2 = 0;
            int state = 0;
            while (state < 6)
            {
                Console.Clear();
                state = task3Menu();
                if (state == 1)
                {
                    // Add Players
                    Input = Addplayer();
                    Players.Add(Input);
                }
                else if (state == 2)
                {
                    // Learn Skill
                    idx = FindIDX(Players);
                    Output = SkillStatistics(Players, idx, Stats);
                    Stats.Add(Output);
                }
                else if (state == 3)
                {
                    //Add Skill
                    Output = AddSkill();
                    Stats.Add(Output);
                }
                else if (state == 4)
                {
                    // Attack
                    idx = FindIDX(Players);
                    Console.WriteLine("Now name of the player to be Attacked");
                    idx2 = FindIDX(Players);
                }
                else if (state == 5)
                {
                    // Player Info
                    if (idx != 0 && idx2 != 0)
                    {
                        PrintPlayerInfo(Players[idx], Players[idx2]);
                    }
                }
            }
        }
        static int task3Menu()
        {
            int num;
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Learn Skill");
            Console.WriteLine("3. Add Skill");
            Console.WriteLine("4. Attack");
            Console.WriteLine("5. Players Info");
            Console.WriteLine("6. Exit");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static Player Addplayer()
        {
            Player Alice = new Player();
            Stats Skill = new Stats();
            Alice = PlayerInput();
            return Alice;
        }
        static Stats SkillStatistics(List<Player> players,int idx,List<Stats> stats)
        {
            Player player = players[idx];
            Stats Skill = new Stats();
            Skill = Input2();
            player.SkillStatictics.Add(Skill);
            players[idx].LearnSkill(Skill);
            return Skill;
        }
        static Stats AddSkill()
        {
            Stats Skill = new Stats();
            Skill = Input2();
            return Skill;
        }
        static int FindIDX(List<Player> players) 
        {
            int num;
            for(int i =0; i < players.Count; i++)
            {
                Console.WriteLine($"{i}\t{players[i].name}");
            }
            Console.WriteLine("Enter the index of the Person you want to add a skill");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void PrintPlayerInfo(Player player1,Player player2)
        {
            Console.WriteLine($"The Name and Health of Both the Players is Given below: ");
            Console.WriteLine($"{player1.name}\t{player1.hp}\t{player1.armor}\t{player1.energy}");
            Console.WriteLine($"{player2.name}\t{player2.hp}\t{player2.armor}\t{player2.energy}");
        }
        static int AttackingIDX(List<Player> players) 
        {
            int num;
            for(int i = 0;i<players.Count;i++)
            {
                Console.WriteLine($"{i}\t{players[i].name}");
            }
            Console.WriteLine("Enter the index of with the player name");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void Task2()
        {
            string result;
            Player Alice = new Player();
            Player Bob = new Player();
            Stats Skill = new Stats();
            Alice = PlayerInput();
            Bob = PlayerInput();
            while (Alice.hp >= 0 && Bob.hp >= 0)
            {
                Console.Clear();
                Console.WriteLine("Alice will Attack");
                Skill = Input2();
                Alice.LearnSkill(Skill);
                result = Alice.Attack(Bob);
                Console.WriteLine(result);
                Console.WriteLine("Bob will Attack");
                Skill = Input2();
                Bob.LearnSkill(Skill);
                result = Bob.Attack(Alice);
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
        static Player PlayerInput()
        {
            Player player;
            Console.WriteLine("Enter the name of the player: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the armor: ");
            float armor = float.Parse(Console.ReadLine());
            while (armor > 100 && armor < 0)
            {
                armor = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the health: ");
            float health = float.Parse(Console.ReadLine());
            while (health > 100 && health < 0)
            {
                health = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the energy: ");
            float energy = float.Parse(Console.ReadLine());
            while (energy < 0)
            {
                energy = float.Parse(Console.ReadLine());
            }
            player = new Player(name, health, energy, armor);
            return player;
        }
        static Stats Input2()
        {
            float damage ;
            Console.WriteLine("Enter the Skill Name: ");
            string SkillName = Console.ReadLine();
            Console.WriteLine("Enter the Damage: ");
            damage = float.Parse(Console.ReadLine());
            while (damage > 100 && damage < 0)
            {
                damage = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the heal: ");
            float heal = float.Parse(Console.ReadLine());
            while (heal > 100 && heal < 0)
            {
                heal = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the Cost: ");
            float cost = float.Parse(Console.ReadLine());
            while (cost > 100 && cost < 0)
            {
                cost = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the penetrartion: ");
            float penetration = float.Parse(Console.ReadLine());
            while (penetration > 100 && penetration < 0)
            {
                penetration = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the description: ");
            string description = Console.ReadLine();
            Stats stats = new Stats(SkillName, damage, penetration, heal, cost, description);
            return stats;
        }
        static void Task1()
        {
            int num = 0;
            Ship_Position ship = new Ship_Position();
            List<Ship_Position> ships = new List<Ship_Position>();
            while (num < 5)
            {
                Console.Clear();
                num = menu();
                Console.Clear();
                if (num == 1)
                {
                    ship = Input();
                    ships.Add(ship);
                }
                else if (num == 2)
                {
                    Ships(ships);
                    num = InputCheck();
                    ShipPosition(num, ships);
                }
                else if (num == 3)
                {
                    Ships(ships);
                    num = InputCheck();
                    Console.WriteLine($"The serial number of the ship is {ships[num].serialNo}");
                }
                else if (num == 4)
                {
                    Ships(ships);
                    num = InputCheck();
                    ChangePosition(num, ships);
                }
                Console.ReadKey();
            }
        }
        static int menu()
        {
            int num;
            Console.WriteLine("1. Add Ship\r\n2. View Ship Position\r\n3. View Ship Serial Number\r\n4. Change Ship Position\r\n5. Exit");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static Ship_Position Input()
        {
            Ship_Position input = new Ship_Position();
            Console.WriteLine("Enter The Number of Ship: ");
            input.serialNo = Console.ReadLine();
            Console.WriteLine("Enter Ship's Latitude:");
            Console.WriteLine("Enter the Latitude Angle: ");
            input.LATDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Latitude Minutes: ");
            input.LATMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Latitude Direction: ");
            input.LATAxis = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship's Longitude:");
            Console.WriteLine("Enter the Longitude Angle: ");
            input.LONDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Longitude Minutes: ");
            input.LONMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Longitude Direction: ");
            input.LONAxis = char.Parse(Console.ReadLine());
            return input;
        }
        static void Ships(List<Ship_Position> ship)
        {
            Console.WriteLine("The Ships are given below: ");
            for (int i = 0; i < ship.Count(); i++)
            {
                Console.WriteLine($"{i}\t{ship[i].serialNo}");
            }
            Console.WriteLine("Enter the index of the ship you want to view");
        }
        static int InputCheck()
        {
            int num;
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void ChangePosition(int state, List<Ship_Position> ship)
        {
            Console.WriteLine($"The serial number of the ship is: {ship[state].serialNo}");
            Console.WriteLine("Enter Ship's Latitude:");
            Console.WriteLine("Enter the Latitude Angle: ");
            ship[state].LATDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Latitude Minutes: ");
            ship[state].LATMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Latitude Direction: ");
            ship[state].LATAxis = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship's Longitude:");
            Console.WriteLine("Enter the Longitude Angle: ");
            ship[state].LONDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Longitude Minutes: ");
            ship[state].LONMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Longitude Direction: ");
            ship[state].LONAxis = char.Parse(Console.ReadLine());
        }
        static void ShipPosition(int num, List<Ship_Position> ship)
        {
            Console.WriteLine("The Position of the ship are given:");
            Console.WriteLine($"The serial number of ship is {ship[num].serialNo}");
            Console.WriteLine($"Ship is at {ship[num].LATDegree}\u00b0 {ship[num].LATMinutes}' {ship[num].LATAxis} Latitude");
            Console.WriteLine($"Ship is at {ship[num].LONDegree}\u00b0 {ship[num].LONMinutes}' {ship[num].LONAxis} Longitude");
        }
    }
}
