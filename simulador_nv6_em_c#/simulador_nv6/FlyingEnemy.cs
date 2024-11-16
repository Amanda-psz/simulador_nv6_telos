using System;

namespace simulador_nv6
{
    internal class FlyingEnemy : Enemy
    {
        private float Altitude;
        public FlyingEnemy(int health, float velocity, float altitude) : base(health, velocity)
        {
            Altitude = altitude;
        }

        public void FlyEnemy()
        {
            Console.WriteLine($"Inimigo está voando a {Altitude} metros de altitude!");
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
        }

        public override void Move()
        {
            Animation = State == States.FLY ? "walk" : "fly";
            Console.WriteLine($"Inimigo se movimentando com a velocidade X: {VelocityX}");
            Console.WriteLine($"Animação atual do inimigo: {Animation}");
        }
    }
}
