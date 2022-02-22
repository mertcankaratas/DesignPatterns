using System;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyFactory enemyFactory = new EnemyFactory();

            enemyFactory.CreateEnemy("Megatron");
            enemyFactory.CreateEnemy("Blackout");
            enemyFactory.CreateEnemy("Brawl");
            enemyFactory.CreateEnemy("aa");

        }
    }
}
