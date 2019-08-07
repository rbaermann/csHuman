using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class Human {

            public string Name {get;set;}
            public int Strength {get;set;}
            public int Intelligence {get;set;}
            public int Dexterity {get;set;}
            private int health {get;set;}
            private int fullHealth {get;set;}
            public int Health {
                get { return health; }
            }

            public Human(string name) {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
                int fullHealth = health;
            }

            public Human(string name, int strength, int intelligence, int dexterity, int health, int fullhp) {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                health = health;
                fullHealth = fullhp;
            }

            public virtual int Attack(Human target) {
                int dmg = 5 * Strength;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }

        class Wizard : Human {

            public Wizard(string name) : base(name) {
                Intelligence = 25;
                health = 50;
            }

            public override int Attack(Human target) {
                int dmg = 5 * Intelligence;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                if(Health == 50) {
                    return target.health;
                }
                if((health + dmg) > 50) {
                    int healed = 50 - health;
                    health = 50;
                    System.Console.WriteLine($"{Name} has healed for {healed}!");
                    return target.health;
                }
                health += dmg;
                System.Console.WriteLine($"{Name} has healed for {dmg}!");
                return target.health;
            }

            public int Heal(Human target) {
                int healedTarget = 10 * Intelligence;
                if(target.health == target.fullHealth) {
                    return target.health;
                }
                if((target.health + healedTarget) > target.fullHealth) {
                    int h = fullHealth - target.health;
                    target.health = target.fullHealth;
                    System.Console.WriteLine($"You have healed {target.Name} by {h}!");
                    return target.health;
                }
                target.health += healedTarget;
                System.Console.WriteLine($"You have healed {target.Name} by {healedTarget}!");
            }
        }

        class Ninja : Human {

            public Ninja(string name) : base(name) {
                Dexterity = 175;
            }

            public override int Attack(Human target) {
                int dmg = 5 * Dexterity;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                Random rand = new Random();
                int j = rand.Next(5);
                if(j == 1) {
                    target.health -= 10;
                    System.Console.WriteLine($"{Name} crit {target.Name} for 10 damage!");
                }
                return target.health;
            }

            public int Steal(Human target) {
                int stl = 5;
                target.health -= 5;
                if(health == fullHealth) {
                    System.Console.WriteLine($"{Name} has dealt 5 damage!");
                    return target.health;
                }
                if((health + stl) > fullHealth) {
                    int s = fullHealth - Health;
                    health = fullHealth;
                    System.Console.WriteLine(($"{Name} has stolen {s} health!"));
                    return target.health;
                }
                health += stl;
                return target.health;
            }
        }

        class Samurai : Human { 
            
            public Samurai(string name) : base(name) {
                health = 200;
            }

            public override int Attack(Human target) {
                int dmg = 5 * Strength;
                if(target.health < 50) {
                    target.health = 0;
                    return target.health;
                }
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }

            public int Meditate() {
                health = 200;
            }
        }
    }
}
