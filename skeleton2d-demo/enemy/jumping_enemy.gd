class_name JumpingEnemy
extends Enemy

# Varisvel que define a altura do salto
var jump_height: int = 60

# Função que faz com que o inimigo salte
func jumping() -> void:
	velocity.y = -jump_height
	self.velocity = velocity # Aplica uma velocidade para simular o salto
	move_and_slide()

# Lógica para executar o salto em frames
func _process(delta: float) -> void:
	if is_on_floor(): # Verifica se o inimigo está no chão antes de pular
		jumping()
