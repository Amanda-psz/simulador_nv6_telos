using System;

namespace simulador_nv6
{
    internal class EnemyWithAttack : Enemy
    {
        private int Attacking;

        public EnemyWithAttack(int health, float velocity, int attacking) : base(health, velocity)
        {
            Attacking = attacking;
        }

        public void EnemyAttack()
        {
            Console.WriteLine($"Inimigo recebe {Attacking} de dano do jogador!");
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