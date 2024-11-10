class_name EnemyWithAttack
extends Enemy

# Variável com o valor do dano supostamente causado no jogador
var attack: int = 15
@onready var player := get_node("SkeletalPlayer") # Variável que armazena o nó em que jogador se encontra
@onready var attack_ray := $RayCast2D  # RayCast2D para detectar o ataque, não implementado

# Chamado quando o nó entra na árvore de cena pela primeira vez.
func _ready() -> void:
	pass

# Chamado a cada frame. 'delta' é o tempo decorrido desde o último frame.
func _process(delta: float) -> void:
	# Lógica para o inimigo atacar o jogador se estiver no alcance.
	if is_within_attack_range():
		attack_player(attack)  # Ataca o jogador se dentro do alcance.
	
	# Chama a função de movimentação e animação da classe base
	move()

# Verifica se o jogador está dentro do alcance do ataque
func is_within_attack_range() -> bool:
	# Verifique se o RayCast2D está colidindo com o jogador
	if attack_ray.is_colliding():
		var collider = attack_ray.get_collider()
		return collider == player
	return false

# Método de ataque que aplica dano ao jogador
func attack_player(damage: int) -> void:
	if player and player.has_method("receive_damage"):  # Verifica se o jogador tem o método de receber dano
		print(damage, " de dano!")
		player.receive_damage(damage)  # Aplica o dano ao jogador
