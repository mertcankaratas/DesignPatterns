using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class EnemyFactory
    {

       
        public Enemy CreateEnemy(string enemyType)
        {
            Enemy enemy;

            switch (enemyType)
            {
                case "Megatron":
                    enemy = new Megatron();

                    Console.WriteLine(enemy);
                    return enemy;

                case "Blackout":
                    enemy = new Blackout();

                    Console.WriteLine(enemy);
                    return enemy;


                case "Brawl":
                    enemy = new Brawl();

                    Console.WriteLine(enemy);
                    return enemy;

                default:

                    Console.WriteLine($" {enemyType} not found");
                    break;
            }


            return null;
        }
    }
}
