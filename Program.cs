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
            public int Strength {get;set;} = 3;
            public int Intelligence {get;set;} = 3;
            public int Dexterity {get;set;} = 3;
            private int Health {get;set;} = 100;
            public int Health {
                get { return Health; }
            }

            public Human(string name, int strength, int intelligence, int dexterity, int health){
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                this.Health = health;
            }

            public int Attack(Human target){
                var Enemy = (Human) enemy;
                Enemy.Health -= 5 * Human.Strength;
                return Enemy.Health;
            }
        }
    }
}
