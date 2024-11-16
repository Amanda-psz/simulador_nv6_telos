using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulador_nv6
{
    internal class StealthyEnemy : Enemy
    {
        private string Stealthy;

        public StealthyEnemy(int health, float velocity, string stealthy) : base(health, velocity)
        {
            Stealthy = stealthy;
        }

        public void invisibleEnemy()
        {
            Console.WriteLine($"O inimigo ficou {Stealthy}!");
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
        }

        public override void Move()
        {
            Animation = State == States.WALK ? "walk" : "idle";
            Console.WriteLine($"Inimigo se movimentando com a velocidade X: {VelocityX}");
            Console.WriteLine($"Animação atual do inimigo: {Animation}");
        }
    }
}
