class_name FlyingEnemy
extends Enemy

var altitude: int = 80

# Função/metodo para o inimigo voar
func flying() -> void:
	velocity.y = -altitude # Define a velocidade no eixo Y para simular o voo
	self.velocity = velocity  # Atualiza a velocidade da classe base
	move_and_slide()

# Chama a função para o movimento de voo.
func _process(delta: float) -> void:
	flying()
