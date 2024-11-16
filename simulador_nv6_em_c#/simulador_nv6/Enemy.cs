using System;

namespace simulador_nv6
{
    internal class Enemy
    {
        public enum States // estados que o inimigo pode estar
        {
            IDLE,
            WALK,
            RUN,
            FLY,
            FALL
        }

        public States State = States.WALK; // Estado em que o inimigo nicia o jogo
        protected int Health; // Variavel que recebe o valor da vida do inimigo
        protected float VelocityX; // Variavel que recebe o valor da velocidade do inimigo

        public const int WalkSpeed = 50; // Velocidade para o movimento no estado walk

        // Variáveis de colisão e detecção
        protected bool CollidingWall = false;
        protected bool FloorLeftDetected = true;
        protected bool FloorRightDetected = true;

        public string Animation = "idle"; // Variavel para a movimentação do inimigo

        public Enemy(int health = 100, float velocityX = 50.0f)
        {
            Health = health;
            VelocityX = velocityX;
        }

        public virtual void Move() // Função que controla o movimento do inimigo
        {
            if (State == States.WALK && VelocityX < 0.01f)
            {
                VelocityX = WalkSpeed;
            }

            if (!FloorLeftDetected)
            {
                VelocityX = WalkSpeed;
            }
            else if (!FloorRightDetected)
            {
                VelocityX = -WalkSpeed;
            }

            if (CollidingWall)
            {
                VelocityX = -VelocityX;
            }

            Animation = State == States.IDLE ? "walk" : "idle";
            Console.WriteLine($"Inimigo se movimentando com a velocidade X: {VelocityX}");
            Console.WriteLine($"Animação atual do inimigo: {Animation}");
        }

        public virtual void ReceiveDamage(int damage) // Função para efetuar dano ao inimigo
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }  
        }

        public virtual void DisplayStatus() // Função que mostra o status de vida e velociade do inimigo
        {
            Console.WriteLine($"Vida: {Health} Velocidade: {VelocityX}");
        }

        public bool IsDead() // Função que identifica se o inimigo está morto
        {
            return Health <= 0;
        }
    }
}

