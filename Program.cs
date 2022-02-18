using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword sword1 = new Sword();
            sword1.Name = "'Legolas Bow'";
            sword1.Damage = 2000;
            sword1.Durability = 3000;
            sword1.Material = "The Elven Tree";

            Sword sword2 = new Sword();
            sword2.Name = "'Swords of Legolas'";
            sword2.Damage = 1400;
            sword2.Durability = 2300;
            sword2.Material = "Elven Steel";

            Sword sword3 = new Sword();
            sword3.Name = "'Gimli 's Axe'";
            sword3.Damage = 1300;
            sword3.Durability = 1500;
            sword3.Material = "Dwarf Steel";

            Sword sword4 = new Sword();
            sword4.Name = "'Gimli 's Hatchet'";
            sword4.Damage = 1100;
            sword4.Durability = 1000;
            sword4.Material = "'Dwarf Steel'";

            Sword sword5 = new Sword();
            sword5.Name = "'The Wanderer's Sword'";
            sword5.Damage = 920;
            sword5.Durability = 850;
            sword5.Material = "'Steel'";

            Sword sword6 = new Sword();
            sword6.Name = "'Aragorn 's Bow'";
            sword6.Damage = 900;
            sword6.Durability = 700;
            sword6.Material = "Oak";

            Sword sword7 = new Sword();
            sword7.Name = "'Two-handed axe'";
            sword7.Damage = 1200;
            sword7.Durability = 2000;
            sword7.Material = "Dwarf Steel";

            Sword sword8 = new Sword();
            sword8.Name = "'Anduril'";
            sword8.Damage = 6000;
            sword8.Durability = 1200;
            sword8.Material = "Holy Elven Steel";

            Sword sword9 = new Sword();
            sword9.Name = "'Galadriel 's Bow'";
            sword9.Damage = 8000;
            sword9.Durability = 1800;
            sword9.Material = "Galadriel Tree";

            //

            Armour armour1 = new Armour();
            armour1.Name = "'Legolas Armor'";
            armour1.Durability = 1100;
            armour1.Material = "The Great Elven Tree";

            Armour armour2 = new Armour();
            armour2.Name = "'Gimli Armor'";
            armour2.Durability = 1200;
            armour2.Material = "Sparkling Mithril";

            Armour armour3 = new Armour();
            armour3.Name = "'Aragorn 's Armor'";
            armour3.Durability = 1000;
            armour3.Material = "The strongest leather";

            //

            Human human1 = new Human();
            human1.Name = "Legolas";
            human1.Health = 3000;
            List<Weapon> human1w = new List<Weapon>();
            List<Armor> human1a = new List<Armor>();
            human1.Weapon1 = sword1;
            human1.Weapon2 = sword2;
            human1.Armor = armour1;

            Human human2 = new Human();
            human2.Name = "Gimli";
            human2.Health = 5000;
            List<Weapon> human2w = new List<Weapon>();
            List<Armor> human2a = new List<Armor>();
            human2.Weapon1 = sword3;
            human2.Weapon2 = sword4;
            human2.Armor = armour2;

            Human human3 = new Human();
            human3.Name = "Aragorn";
            human3.Health = 4000;
            List<Weapon> human3w = new List<Weapon>();
            List<Armor> human3a = new List<Armor>();
            human3.Weapon1 = sword5;
            human3.Weapon2 = sword6;
            human3.Armor = armour3;

            //

            Enemy enemy1 = new Enemy();
            enemy1.Name = "Saruman";
            enemy1.Health = 1000;
            enemy1.Loot = new ILoot[4];
            enemy1.Weapon1 = sword3;
            enemy1.Weapon2 = sword3;
            enemy1.Armor = armour1;

            Enemy enemy3 = new Enemy();
            enemy3.Name = "Gotmog";
            enemy3.Health = 3000;
            enemy3.Loot = new ILoot[4];
            enemy3.Weapon1 = sword7;
            enemy3.Weapon2 = sword6;
            enemy3.Armor = armour2;

            Enemy enemy2 = new Enemy();
            enemy2.Name = "Sauron";
            enemy2.Health = 99999999;
            enemy2.Loot = new ILoot[4];
            enemy2.Weapon1 = sword7;
            enemy2.Weapon2 = sword7;
            enemy2.Armor = armour3;

            //

            Object object1 = new Object();
            object1.Name = "Box";
            object1.Health = 1500;
            object1.Loot = new ILoot[1];

            Object object2 = new Object();
            object2.Name = "Box";
            object2.Health = 1500;
            object2.Loot = new ILoot[1];

            Object object3 = new Object();
            object3.Name = "Box";
            object3.Health = 1500;
            object3.Loot = new ILoot[1];

            //

            Console.WriteLine("Choose a hero (1, 2, 3): ");
            Console.WriteLine(" ");
            Console.WriteLine($"First hero(1): name - {human1.Name},  health - {human1.Health},  weapon - in left hand '{sword1.Name}', in right hand '{sword2.Name}', armor - '{armour1.Name}'");
            Console.WriteLine($"First weapon: name - '{sword1.Name}', damage - {sword1.Damage}, durability - {sword1.Durability}, material - {sword1.Material}.");
            Console.WriteLine($"Second weapon: name - '{sword2.Name}', damage - {sword2.Damage}, durability - {sword2.Durability}, material - {sword2.Material}.");
            Console.WriteLine($"Armor: name - '{armour1.Name}', durability - {armour1.Durability}, material - {armour1.Material}.");
            Console.WriteLine(" ");
            Console.WriteLine($"Second hero(2): name - {human2.Name},  health - {human2.Health},  weapon - in left hand '{sword3.Name}', in right hand '{sword4.Name}', armor - '{armour2.Name}'");
            Console.WriteLine($"First weapon: name - '{sword3.Name}', damage - {sword3.Damage}, durability - {sword3.Durability}, material - {sword3.Material}.");
            Console.WriteLine($"Second weapon: name - '{sword4.Name}', damage - {sword4.Damage}, durability - {sword4.Durability}, material - {sword4.Material}.");
            Console.WriteLine($"Armor: name - '{armour2.Name}', durability - {armour2.Durability}, material - {armour2.Material}.");
            Console.WriteLine(" ");
            Console.WriteLine($"Third hero(3): name - {human3.Name},  health - {human3.Health},  weapon - in left hand '{sword5.Name}', in right hand '{sword6.Name}', armor - '{armour3.Name}'");
            Console.WriteLine($"First weapon: name - '{sword5.Name}', damage - {sword5.Damage}, durability - {sword5.Durability}, material - {sword5.Material}.");
            Console.WriteLine($"Second weapon: name - '{sword6.Name}', damage - {sword6.Damage}, durability - {sword6.Durability}, material - {sword6.Material}.");
            Console.WriteLine($"Armor: name - '{armour3.Name}', durability - {armour3.Durability}, material - {armour3.Material}.");
            Console.WriteLine(" ");
            Console.WriteLine("To select enter the number under which the character is signed ");
            Console.WriteLine(" ");
            string ch = Console.ReadLine();
            Console.WriteLine(" ");

            if (ch == "1")
            {
                human1.Name = human3.Name;
                human1.Health = human3.Health;
                human1.Weapon1 = human3.Weapon1;
                human1.Weapon2 = human3.Weapon2;
                human1.Armor = human3.Armor;
            }

            if (ch == "2")
            {
                human1.Name = human2.Name;
                human1.Health = human2.Health;
                human1.Weapon1 = human2.Weapon1;
                human1.Weapon2 = human2.Weapon2;
                human1.Armor = human2.Armor;
            }
            if (ch == "3")
            {
                human1.Name = human3.Name;
                human1.Health = human3.Health;
                human1.Weapon1 = human3.Weapon1;
                human1.Weapon2 = human3.Weapon2;
                human1.Armor = human3.Armor;
            }



            enemy1.Health = enemy1.Health + enemy1.Armor.Durability;
            enemy2.Health = enemy2.Health + enemy2.Armor.Durability;
            enemy3.Health = enemy3.Health + enemy3.Armor.Durability;
            int treatment = 200;
            int treatmentArmor = 200;
            var d = human1.Weapon1.Damage + human1.Weapon2.Damage;


            if (human1.Armor == armour3)
            {
                treatmentArmor = 5500;
            }



            Console.WriteLine($"You Find the {object1.Name}");
            Console.WriteLine(" ");
            for (int i = 0; object1.Health > 0; i++)
            {

                int Damage = human1.Weapon1.Damage + human1.Weapon2.Damage;
                Console.WriteLine($"Your Health {human1.Health}");
                Console.WriteLine($"Health of the object { object1.Health}");
                Console.WriteLine($"Damage -{d}");
                human1.Weapon1.Debuff(human1.Weapon1.Damage);
                human1.Weapon2.Debuff(human1.Weapon2.Damage);
                object1.Debuff(Damage);
                Console.WriteLine(" ");
                if (human1.Weapon1.Durability <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"--Your Weapon on left hand, {human1.Weapon1.Name} was crashed--");
                    Console.WriteLine(" ");
                    human1.Weapon1 = sword6;
                }
                if (human1.Weapon2.Durability <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"--Your Weapon on right hand, {human1.Weapon2.Name} was crashed--");
                    Console.WriteLine(" ");
                    human1.Weapon2 = sword6;
                }
                if (object1.Health < 0)
                {
                    object1.Destroy();
                    Console.WriteLine($"You crash the {object1.Name}");
                    Console.WriteLine($"You find {sword9.Name}, damage - {sword9.Damage}, durability - {sword9.Durability}, materials - {sword9.Material}.");
                    human1w.Add(sword9);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("You can change your weapon or your armor, if you want do this enter '1', if go to next enter '2', if you want to healing enter '3'.");
            Console.WriteLine(" ");

            string ch2 = Console.ReadLine();
            Console.WriteLine(" ");

            if (ch2 == "3")
            {

                human1.Buff(treatment);
                Console.WriteLine("Your drink health potion.");
                Console.WriteLine($"Your Health = {human1.Health}");
                Console.WriteLine(" ");
            }


            if (ch2 == "1")
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Your weapon inventory: ");
                Console.WriteLine(human1w[0].Name);
                Console.WriteLine($"Your armor inventory: ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine($"Do you want change your weapon or armor?(1 - weapon, 2 - armor, 3 - no): ");
                Console.WriteLine(" ");
                string ch3 = Console.ReadLine();
                Console.WriteLine(" ");
                if (ch3 == "1")
                {
                    Console.WriteLine($"Select the hand in which you want to change weapons(1 - left, 2 - right): ");
                    Console.WriteLine(" ");
                    string ch4 = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (ch4 == "1")
                    {
                        Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                        Console.WriteLine(" ");
                        string ch5 = Console.ReadLine();
                        if (ch5 == "1")
                        {
                            human1w.Add(human1.Weapon1);
                            Console.WriteLine($"In the inventory your inventory: {human1.Weapon1.Name} ");
                            human1.Weapon1 = human1w[0];
                            human1w.Remove(human1w[0]);
                            Console.WriteLine($"In your hand now: {human1.Weapon1.Name} ");

                        }
                    }
                    if (ch4 == "2")
                    {

                        Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                        Console.WriteLine(" ");
                        string ch61 = Console.ReadLine();
                        if (ch61 == "1")
                        {


                            human1w.Add(human1.Weapon2);
                            Console.WriteLine($"In the inventory your inventory: {human1.Weapon2.Name} ");
                            human1.Weapon2 = human1w[0];
                            human1w.Remove(human1w[0]);
                            Console.WriteLine($"In your hand now: {human1.Weapon2.Name} ");
                        }


                        else { }
                    }
                    else
                    {

                        Console.WriteLine(" ");
                    }
                }
                if (ch3 == "2")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You dont have any armor on inventory. ");
                    Console.WriteLine(" ");
                }
                else { }
            }
            else
            {



            }

            //

            Console.WriteLine("We go to the next opponent! ");
            Console.WriteLine(" ");

            Console.WriteLine($"You Find the {enemy1.Name}");
            Console.WriteLine(" ");
            for (int i = 0; enemy1.Health > 0; i++)
            {
                for (int j = 0; human1.Health > 0; j++)
                {

                    int Damage = human1.Weapon1.Damage + human1.Weapon2.Damage;
                    int d1 = enemy1.Weapon1.Damage + enemy1.Weapon2.Damage;

                    Console.WriteLine($"Your Health {human1.Health}");
                    Console.WriteLine($"Your Armor Durability {human1.Armor.Durability}");
                    Console.WriteLine($"Health of the enemy { enemy1.Health}");
                    Console.WriteLine($"Your Damage -{Damage}");
                    human1.Weapon1.Debuff(human1.Weapon1.Damage);
                    human1.Weapon2.Debuff(human1.Weapon2.Damage);
                    enemy1.Debuff(Damage);
                    Console.WriteLine($"Enemy Damage -{d1}");
                    human1.Armor.Debuff(d1);
                    Console.WriteLine(" ");
                    if (human1.Weapon1.Durability <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"--Your Weapon on left hand, {human1.Weapon1.Name} was crashed--");
                        Console.WriteLine(" ");
                        human1.Weapon1 = sword6;
                    }
                    if (human1.Weapon2.Durability <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"--Your Weapon on right hand, {human1.Weapon2.Name} was crashed--");
                        Console.WriteLine(" ");
                        human1.Weapon2 = sword6;
                    }
                    if (human1.Armor.Durability < 0)
                    {
                        human1.Debuff(d1);
                    }
                    if (enemy1.Health < 0)
                    {
                        enemy1.Destroy();
                        Console.WriteLine($"You kill the {enemy1.Name}");
                        human1.Armor.Durability = 200;
                        break;
                    }
                    if (human1.Health < 0)
                    {
                        human1.Destroy();
                        Console.WriteLine($"GAME OVER");
                        return;



                    }
                }

                Console.WriteLine("You can change your weapon or your armor, if you want do this enter '1', if go to next enter '2', if you want to healing enter '3'.");
                Console.WriteLine(" ");
                string ch3 = Console.ReadLine();
                Console.WriteLine(" ");
                if (ch3 == "1")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your weapon inventory: ");
                    Console.WriteLine(human1w[0].Name);
                    Console.WriteLine($"Your armor inventory: ");
                    Console.WriteLine();
                    Console.WriteLine(" ");
                    Console.WriteLine($"Do you want change your weapon or armor?(1 - weapon, 2 - armor, 3 - no): ");
                    Console.WriteLine(" ");
                    string ch41 = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (ch41 == "1")
                    {
                        Console.WriteLine($"Select the hand in which you want to change weapons(1 - left, 2 - right): ");
                        Console.WriteLine(" ");
                        string ch5 = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (ch5 == "1")
                        {
                            Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                            Console.WriteLine(" ");
                            string ch6 = Console.ReadLine();
                            if (ch6 == "1")
                            {
                                human1w.Add(human1.Weapon1);
                                Console.WriteLine($"In the inventory your inventory: {human1.Weapon1.Name} ");
                                human1.Weapon1 = human1w[0];
                                human1w.Remove(human1w[0]);
                                Console.WriteLine($"In your hand now: {human1.Weapon1.Name} ");

                            }
                            else { }
                        }
                        if (ch5 == "2")
                        {
                            Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                            Console.WriteLine(" ");
                            string ch61 = Console.ReadLine();
                            if (ch61 == "1")
                            {
                                human1w.Add(human1.Weapon2);
                                Console.WriteLine($"In  your inventory: {human1.Weapon2.Name} ");
                                human1.Weapon2 = human1w[0];
                                human1w.Remove(human1w[0]);
                                Console.WriteLine($"On you hand now: {human1.Weapon2.Name} ");
                            }


                            else { }
                        }
                    }
                    if (ch41 == "2")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You dont have any armor on inventory. ");
                        Console.WriteLine(" ");
                    }
                    else { }
                }


                else { }

                if (ch3 == "3")
                {
                    human1.Buff(treatment);
                    Console.WriteLine("Your drink health potion.");
                    Console.WriteLine(" ");
                }

                Console.WriteLine($"You Find the {object2.Name}");
                Console.WriteLine(" ");
                for (int a = 0; object2.Health > 0; a++)
                {
                    int Damage = human1.Weapon1.Damage + human1.Weapon2.Damage;
                    Console.WriteLine($"Your Health {human1.Health}");
                    Console.WriteLine($"Health of the object { object2.Health}");
                    Console.WriteLine($"Damage -{Damage}");
                    human1.Weapon1.Debuff(human1.Weapon1.Damage);
                    human1.Weapon2.Debuff(human1.Weapon2.Damage);
                    object2.Debuff(Damage);
                    Console.WriteLine(" ");
                    if (human1.Weapon1.Durability <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"--Your Weapon on left hand, {human1.Weapon1.Name} was crashed--");
                        Console.WriteLine(" ");
                        human1.Weapon1 = sword6;
                    }
                    if (human1.Weapon2.Durability <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"--Your Weapon on right hand, {human1.Weapon2.Name} was crashed--");
                        Console.WriteLine(" ");
                        human1.Weapon2 = sword6;
                    }
                    if (object2.Health < 0)
                    {
                        object2.Destroy();
                        Console.WriteLine($"You crash the {object2.Name}");
                        Console.WriteLine($"You find {armour3.Name}. Durability - {armour3.Durability}, materials - {armour3.Material}.");
                        human1a.Add(armour3);
                    }
                }
                Console.WriteLine("You can change your weapon or your armor, if you want do this enter '1', if go to next enter '2', if you want to healing enter '3'.");
                Console.WriteLine(" ");
                string ch4 = Console.ReadLine();
                Console.WriteLine(" ");
                if (ch4 == "1")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your weapon inventory: ");
                    Console.WriteLine(human1w[0].Name);
                    Console.WriteLine($"Your armor inventory: ");
                    Console.WriteLine(human1a[0].Name);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Do you want change your weapon or armor?(1 - weapon, 2 - armor, 3 - no): ");
                    Console.WriteLine(" ");
                    string ch5 = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (ch5 == "1")
                    {
                        Console.WriteLine($"Select the hand in which you want to change weapons(1 - left, 2 - right): ");
                        Console.WriteLine(" ");
                        string ch6 = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (ch6 == "1")
                        {
                            Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                            Console.WriteLine(" ");
                            string ch7 = Console.ReadLine();
                            if (ch7 == "0")
                            {
                                human1w.Add(human1.Weapon1);
                                Console.WriteLine($"In your inventory: {human1.Weapon1.Name} ");
                                human1.Weapon1 = human1w[0];
                                human1w.Remove(human1w[0]);
                                Console.WriteLine($"In your hand now: {human1.Weapon1.Name} ");

                            }
                        }
                        if (ch6 == "2")
                        {
                            Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                            Console.WriteLine(" ");
                            string ch71 = Console.ReadLine();
                            if (ch71 == "0")
                            {
                                human1w.Add(human1.Weapon2);
                                Console.WriteLine($"In your inventory: {human1.Weapon2.Name} ");
                                human1.Weapon2 = human1w[0];
                                human1w.Remove(human1w[0]);
                                Console.WriteLine($"In your hand now: {human1.Weapon2.Name} ");
                                Console.WriteLine(" ");
                            }
                        }

                    }
                    if (ch5 == "2")
                    {
                        Console.WriteLine($"Select armor from your inventory(enter the place of the armor in the inventory): ");
                        Console.WriteLine(" ");
                        string ch7 = Console.ReadLine();
                        if (ch7 == "1")
                        {
                            human1a.Add(human1.Armor);
                            Console.WriteLine($"In the inventory your inventory: {human1.Armor.Name} ");
                            human1.Armor = human1a[0];
                            human1a.Remove(human1a[0]);
                            Console.WriteLine($"On you now: {human1.Armor.Name} ");

                        }
                    }
                    else { }
                }
                if (ch3 == "3")
                {
                    human1.Buff(treatment);
                    Console.WriteLine("Your drink health potion.");
                    Console.WriteLine(" ");
                }
                else { }



                Console.WriteLine($" ");
                Console.WriteLine($"You find {enemy3.Name}.");
                Console.WriteLine($" ");
                for (int o = 0; enemy3.Health > 0; o++)
                {
                    for (int j = 0; human1.Health > 0; j++)
                    {

                        int Damage = human1.Weapon1.Damage + human1.Weapon2.Damage;
                        int d1 = enemy3.Weapon1.Damage + enemy3.Weapon2.Damage;

                        Console.WriteLine($"Your Health {human1.Health}");
                        Console.WriteLine($"Your Armor Durability {human1.Armor.Durability}");
                        Console.WriteLine($"Health of the enemy { enemy3.Health}");
                        Console.WriteLine($"Your Damage -{Damage}");
                        human1.Weapon1.Debuff(human1.Weapon1.Damage);
                        human1.Weapon2.Debuff(human1.Weapon2.Damage);
                        enemy3.Debuff(Damage);
                        Console.WriteLine($"Enemy Damage -{d1}");
                        human1.Armor.Debuff(d1);
                        Console.WriteLine(" ");
                        if (human1.Weapon1.Durability <= 0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"--Your Weapon on left hand, {human1.Weapon1.Name} was crashed--");
                            Console.WriteLine(" ");
                            human1.Weapon1 = sword6;
                        }
                        if (human1.Weapon2.Durability <= 0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"--Your Weapon on right hand, {human1.Weapon2.Name} was crashed--");
                            Console.WriteLine(" ");
                            human1.Weapon2 = sword6;
                        }
                        if (human1.Armor.Durability < 0)
                        {
                            human1.Debuff(d1);
                        }
                        if (enemy3.Health < 0)
                        {
                            enemy3.Destroy();
                            Console.WriteLine($"You kill the {enemy3.Name}");
                            human1.Armor.Buff(treatmentArmor);
                            break;
                        }
                        if (human1.Health <= 0)
                        {
                            human1.Destroy();
                            Console.WriteLine($"GAME OVER");
                            return;



                        }
                    }

                    Console.WriteLine("You can change your weapon or your armor, if you want do this enter '1', if go to next enter '2', if you want to healing enter '3'.");
                    Console.WriteLine(" ");
                    string ch42 = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (ch42 == "1")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"Your weapon inventory: ");
                        Console.WriteLine(human1w[0].Name);
                        Console.WriteLine($"Your armor inventory: ");
                        Console.WriteLine(human1a[0].Name);
                        Console.WriteLine(" ");
                        Console.WriteLine($"Do you want change your weapon or armor?(1 - weapon, 2 - armor, 3 - no): ");
                        Console.WriteLine(" ");
                        string ch51 = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (ch51 == "1")
                        {
                            Console.WriteLine($"Select the hand in which you want to change weapons(1 - left, 2 - right): ");
                            Console.WriteLine(" ");
                            string ch5 = Console.ReadLine();
                            Console.WriteLine(" ");
                            if (ch5 == "1")
                            {
                                Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                                Console.WriteLine(" ");
                                string ch6 = Console.ReadLine();
                                if (ch6 == "0")
                                {
                                    human1w.Add(human1.Weapon1);
                                    Console.WriteLine($"In the inventory your inventory: {human1.Weapon1.Name} ");
                                    human1.Weapon1 = human1w[0];
                                    human1w.Remove(human1w[0]);
                                    Console.WriteLine($"In your hand now: {human1.Weapon1.Name} ");

                                }
                            }
                            if (ch5 == "2")
                            {
                                Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                                Console.WriteLine(" ");
                                string ch61 = Console.ReadLine();
                                if (ch61 == "1")
                                {
                                    human1w.Add(human1.Weapon1);
                                    Console.WriteLine($"In the inventory your inventory: {human1.Weapon1.Name} ");
                                    human1.Weapon1 = human1w[1];
                                    human1w.Remove(human1w[1]);
                                    Console.WriteLine($"In your hand now: {human1.Weapon1.Name} ");
                                }
                            }

                            if (ch5 == "2")
                            {
                                Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                                Console.WriteLine(" ");
                                string ch6 = Console.ReadLine();

                                if (ch6 == "1")
                                {
                                    human1w.Add(human1.Weapon2);
                                    Console.WriteLine($"In the inventory your inventory: {human1.Weapon2.Name} ");
                                    human1.Weapon2 = human1w[0];
                                    human1w.Remove(human1w[0]);
                                    Console.WriteLine($"In your hand now: {human1.Weapon2.Name} ");

                                }
                            }

                        }
                        if (ch51 == "2")
                        {
                            Console.WriteLine($"Select armor from your inventory(enter the place of the armor in the inventory): ");
                            Console.WriteLine(" ");
                            string ch7 = Console.ReadLine();
                            if (ch7 == "0")
                            {
                                human1a.Add(human1.Armor);
                                Console.WriteLine($"In the inventory your inventory: {human1.Armor.Name} ");
                                human1.Armor = human1a[0];
                                human1a.Remove(human1a[0]);
                                Console.WriteLine($"On you now: {human1.Armor.Name} ");

                            }
                        }
                        else { }
                    }


                    else { }

                    if (ch42 == "3")
                    {
                        human1.Buff(treatment);
                        Console.WriteLine("Your drink health potion.");
                        Console.WriteLine(" ");
                    }

                    Console.WriteLine($"You Find the {object3.Name}");
                    Console.WriteLine(" ");
                    for (int a = 0; object3.Health > 0; a++)
                    {
                        int Damage = human1.Weapon1.Damage + human1.Weapon2.Damage;
                        Console.WriteLine($"Your Health {human1.Health}");
                        Console.WriteLine($"Health of the object { object3.Health}");
                        Console.WriteLine($"Damage -{Damage}");
                        human1.Weapon1.Debuff(human1.Weapon1.Damage);
                        human1.Weapon2.Debuff(human1.Weapon2.Damage);
                        object3.Debuff(Damage);
                        Console.WriteLine(" ");
                        if (human1.Weapon1.Durability <= 0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"--Your Weapon on left hand, {human1.Weapon1.Name} was crashed--");
                            Console.WriteLine(" ");
                            human1.Weapon1 = sword6;
                        }
                        if (human1.Weapon2.Durability <= 0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"--Your Weapon on right hand, {human1.Weapon2.Name} was crashed--");
                            Console.WriteLine(" ");
                            human1.Weapon2 = sword6;
                        }
                        if (object3.Health < 0)
                        {
                            object3.Destroy();
                            Console.WriteLine($"You crash the {object3.Name}");
                            Console.WriteLine($"You find {sword2.Name}: Damage - {sword2.Damage} Durability - {sword2.Durability}, materials - {sword2.Material}.");
                            human1w.Add(sword2);
                        }
                    }
                    Console.WriteLine("You can change your weapon or your armor, if you want do this enter '1', if go to next enter '2', if you want to healing enter '3'.");
                    Console.WriteLine(" ");
                    string ch43 = Console.ReadLine();
                    Console.WriteLine(" ");
                    if (ch43 == "1")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"Your weapon inventory: ");
                        Console.WriteLine(human1w[0].Name, human1w[1].Name);
                        Console.WriteLine($"Your armor inventory: ");
                        Console.WriteLine(human1a[0].Name);
                        Console.WriteLine(" ");
                        Console.WriteLine($"Do you want change your weapon or armor?(1 - weapon, 2 - armor, 3 - no): ");
                        Console.WriteLine(" ");
                        string ch5 = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (ch5 == "1")
                        {
                            Console.WriteLine($"Select the hand in which you want to change weapons(1 - left, 2 - right): ");
                            Console.WriteLine(" ");
                            string ch6 = Console.ReadLine();
                            Console.WriteLine(" ");
                            if (ch6 == "1")
                            {
                                Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                                Console.WriteLine(" ");
                                string ch7 = Console.ReadLine();
                                if (ch7 == "1")
                                {
                                    human1w.Add(human1.Weapon1);
                                    Console.WriteLine($"In your inventory: {human1.Weapon1.Name} ");
                                    human1.Weapon1 = human1w[0];
                                    human1w.Remove(human1w[0]);
                                    Console.WriteLine($"In your hand now: {human1.Weapon1.Name} ");

                                }
                                if (ch7 == "2")
                                {
                                    human1w.Add(human1.Weapon1);
                                    Console.WriteLine($"In your inventory: {human1.Weapon1.Name} ");
                                    human1.Weapon1 = human1w[1];
                                    human1w.Remove(human1w[1]);
                                    Console.WriteLine($"In your hand now: {human1.Weapon1.Name} ");

                                }
                            }
                            if (ch6 == "2")
                            {
                                Console.WriteLine($"Select weapon from your inventory(enter the place of the weapon in the inventory): ");
                                Console.WriteLine(" ");
                                string ch71 = Console.ReadLine();
                                if (ch71 == "1")
                                {
                                    human1w.Add(human1.Weapon2);
                                    Console.WriteLine($"In your inventory: {human1.Weapon2.Name} ");
                                    human1.Weapon2 = human1w[0];
                                    human1w.Remove(human1w[0]);
                                    Console.WriteLine($"In your hand now: {human1.Weapon2.Name} ");
                                    Console.WriteLine(" ");
                                }
                                if (ch71 == "2")
                                {
                                    human1w.Add(human1.Weapon2);
                                    Console.WriteLine($"In your inventory: {human1.Weapon2.Name} ");
                                    human1.Weapon2 = human1w[1];
                                    human1w.Remove(human1w[1]);
                                    Console.WriteLine($"In your hand now: {human1.Weapon2.Name} ");

                                }
                            }

                        }
                        if (ch5 == "2")
                        {
                            Console.WriteLine($"Select armor from your inventory(enter the place of the armor in the inventory): ");
                            Console.WriteLine(" ");
                            string ch7 = Console.ReadLine();
                            if (ch7 == "1")
                            {
                                human1a.Add(human1.Armor);
                                Console.WriteLine($"In the inventory your inventory: {human1.Armor.Name} ");
                                human1.Armor = human1a[0];
                                human1a.Remove(human1a[0]);
                                Console.WriteLine($"On you now: {human1.Armor.Name} ");

                            }
                        }
                        else { }
                    }
                    if (ch43 == "3")
                    {
                        human1.Buff(treatment);
                        Console.WriteLine("Your drink health potion.");
                        Console.WriteLine(" ");
                    }
                    else { }
                    Console.WriteLine($" ");
                    Console.WriteLine($"You find {enemy2.Name}.");
                    Console.WriteLine($" ");
                    for (int h = 0; enemy2.Health > 0; h++)
                    {
                        for (int j = 0; human1.Health > 0; j++)
                        {

                            int Damage = human1.Weapon1.Damage + human1.Weapon2.Damage;
                            int d1 = enemy2.Weapon1.Damage + enemy2.Weapon2.Damage;

                            Console.WriteLine($"Your Health {human1.Health}");
                            Console.WriteLine($"Your Armor Durability {human1.Armor.Durability}");
                            Console.WriteLine($"Health of the enemy { enemy2.Health}");
                            Console.WriteLine($"Your Damage -{Damage}");
                            human1.Weapon1.Debuff(human1.Weapon1.Damage);
                            human1.Weapon2.Debuff(human1.Weapon2.Damage);
                            enemy2.Debuff(Damage);
                            Console.WriteLine($"Enemy Damage -{d1}");
                            human1.Armor.Debuff(d1);
                            Console.WriteLine(" ");
                            if (human1.Weapon1.Durability <= 0)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"--Your Weapon on left hand, {human1.Weapon1.Name} was crashed--");
                                Console.WriteLine(" ");
                                human1.Weapon1 = sword6;
                            }
                            if (human1.Weapon2.Durability <= 0)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"--Your Weapon on right hand, {human1.Weapon2.Name} was crashed--");
                                Console.WriteLine(" ");
                                human1.Weapon2 = sword6;
                            }
                            if (human1.Armor.Durability < 0)
                            {
                                human1.Debuff(d1);
                            }
                            if (enemy2.Health < 0)
                            {
                                enemy2.Destroy();
                                Console.WriteLine($"You kill the {enemy2.Name}");
                                Console.WriteLine($" ");
                                Console.WriteLine($"----------------------");
                                Console.WriteLine($"----CONGRITULATION----");
                                Console.WriteLine($"----------------------");

                                break;
                            }
                            if (human1.Health <= 0)
                            {
                                human1.Destroy();
                                Console.WriteLine($"GAME OVER");
                                return;



                            }
                        }

                    }
                }
            }


        }


        //

        private static void PrintCollection1(List<Weapon> human1w)
        {
            foreach (Weapon item in human1w)
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintCollection2(List<Armor> human1a)
        {
            foreach (Armor item in human1a)
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintCollection3(List<Weapon> human2w)
        {
            foreach (Weapon item in human2w)
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintCollection4(List<Armor> human2a)
        {
            foreach (Armor item in human2a)
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintCollection5(List<Weapon> human3w)
        {
            foreach (Weapon item in human3w)
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintCollection6(List<Armor> human3a)
        {
            foreach (Armor item in human3a)
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintCollection7(List<Weapon> human4w)
        {
            foreach (Weapon item in human4w)
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintCollection8(List<Armor> human4a)
        {
            foreach (Armor item in human4a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
