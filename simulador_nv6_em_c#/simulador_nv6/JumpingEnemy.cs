using System;

namespace simulador_nv6
{

    internal class JumpingEnemy: Enemy
    {
        private float Jumping;

        public JumpingEnemy(int health, float velocity, float jumping) : base(health, velocity)
        {
            Jumping = jumping;
        }
        
        public void JumpEnemy()
        {
            Console.WriteLine($"O inimigo deu um pulo de {Jumping} metros!");
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
        }

        public override void Move()
        {
            Animation = State == States.RUN ? "walk" : "run";
            Console.WriteLine($"Inimigo se movimentando com a velocidade X: {VelocityX}");
            Console.WriteLine($"Animação atual do inimigo: {Animation}");
        }
    }


}
