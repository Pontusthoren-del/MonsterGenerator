using System.Xml.Serialization;

namespace SUT25_Onlinelektion_09_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster myMonster = Monster.CreateRandomMonster(); //Anropar vårat skapade monster

            Console.WriteLine($"Skapat monster {myMonster.Name}, Styrka:{myMonster.Str}, Hälsa:{myMonster.Hp}."); //Skriver ut vårat monster som har skapats

            myMonster.Attack(); //Vårat skapade monster attackaerar och gör skada. Anropar våran Attack metod.

        }

        class Monster
        {
            public string Name { get; set; } //Get körs när man hämtar värdet till metoden,Set körs när den får ett nytt värde(Namn).
            public int Str { get; set; } 
            public int Hp { get; set; } 

            private static Random random = new Random();
            public Monster(string name, int str, int hp) //Här får monstret sitt namn, styrka och hp. Random av våran CreateRandomMonster.
            {
                Name = name;
                Str = str;
                Hp = hp;
            }

            public static Monster CreateRandomMonster() //Här skapas vårat monster. Något av namnen, Str och HP. Allt genereras random.
            {
                string[] names = { "Nisse", "Byfånen", "MrFantastic" };
                string name = names[random.Next(names.Length)];
                int str = random.Next(1, 11);
                int hp = random.Next(1,101);

                return new Monster(name, str, hp);
            }
            public void Attack() //Här har vi våran Attack. Så vårat Monster som är (Name) attackerar och gör skada från uträkningen (Damage).
            {
                int damage = random.Next(1, Str + 1);
                Console.WriteLine($"Monster {Name} attackerar och gör {damage} skada!");
            }

        }

    }

}
