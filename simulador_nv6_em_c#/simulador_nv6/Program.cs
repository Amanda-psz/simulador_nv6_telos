using System;

namespace simulador_nv6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            Console.WriteLine("Status do inimigo:");
            enemy.DisplayStatus();
            enemy.Move();
            enemy.ReceiveDamage(15);
            enemy.DisplayStatus();
            Console.WriteLine($"O inimigo morreu? {(enemy.IsDead() ? "Sim" : "Não")}");

            Console.WriteLine("\n\n");

            EnemyWithAttack attackingEnemy = new EnemyWithAttack(100, 70.0f, 20);
            Console.WriteLine("Status do EnemyWithAttack:");
            attackingEnemy.DisplayStatus();
            attackingEnemy.Move();
            attackingEnemy.EnemyAttack();
            attackingEnemy.ReceiveDamage(40);
            attackingEnemy.DisplayStatus();
            Console.WriteLine($"O inimigo morreu? {(attackingEnemy.IsDead() ? "Sim" : "Não")}");

            Console.WriteLine("\n\n");

            FlyingEnemy flyingEnemy = new FlyingEnemy(100, 40.0f, 3.0f);
            Console.WriteLine("Status do FlyingEnemy:");
            flyingEnemy.DisplayStatus();
            flyingEnemy.Move();
            flyingEnemy.FlyEnemy();
            flyingEnemy.ReceiveDamage(20);
            flyingEnemy.ReceiveDamage(30);
            flyingEnemy.DisplayStatus();
            Console.WriteLine($"O inimigo morreu? {(flyingEnemy.IsDead() ? "Sim" : "Não")}");

            Console.WriteLine("\n\n");

            JumpingEnemy jumpingEnemy = new JumpingEnemy(100, 50.0f, 2.5f);
            Console.WriteLine("Status do Jumping:");
            jumpingEnemy.DisplayStatus();
            jumpingEnemy.Move();
            jumpingEnemy.JumpEnemy();
            jumpingEnemy.ReceiveDamage(40);
            jumpingEnemy.ReceiveDamage(50);
            jumpingEnemy.ReceiveDamage(10);
            jumpingEnemy.DisplayStatus();
            Console.WriteLine($"O inimigo morreu? {(jumpingEnemy.IsDead() ? "Sim" : "Não")}");

            Console.WriteLine("\n\n");

            StealthyEnemy stealthyEnemy = new StealthyEnemy(100, 60.0f, "invisivel");
            Console.WriteLine("Status do Stealthy:");
            stealthyEnemy.DisplayStatus();
            stealthyEnemy.Move();
            stealthyEnemy.invisibleEnemy();
            stealthyEnemy.ReceiveDamage(25);
            stealthyEnemy.DisplayStatus();
            Console.WriteLine($"O inimigo morreu? {(stealthyEnemy.IsDead() ? "Sim" : "Não")}");

        }
    }
}
