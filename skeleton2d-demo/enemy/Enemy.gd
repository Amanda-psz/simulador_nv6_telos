class_name Enemy
extends CharacterBody2D

# Estados possíveis do inimigo
const States = {
	IDLE = "idle",
	WALK = "walk",
	RUN = "run",
	FLY = "fly",
	FALL = "fall",
}

var health: int = 100
var WALK_SPEED: int = 50 # Velocidade para movimento no estado WALK

# Estado inicial do inimigo
var _state := States.WALK

# Referências para nós e propriedades
@onready var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")
@onready var plataform_detector := $PlataformDetector as RayCast2D
@onready var floor_detector_left := $FloorDetectorLeft as RayCast2D
@onready var floor_detector_right := $FloorDetectorRight as RayCast2D
@onready var animated_sprite := $AnimatedSprite2D as AnimatedSprite2D

# Chamado quando o nó entra na árvore de cena pela primeira vez
func _ready() -> void:
	pass

# Chamado a cada frame, delta é o tempo decorrido desde o último frame
func _process(delta: float) -> void:
	move()
	displayStatus()
	
func move() -> void:
	# Atualiza a velocidade com base no estado e nas colisões
	if _state == States.WALK and velocity.is_zero_approx():
		velocity.x = WALK_SPEED
	
	# Verificar se o RayCast está colidindo antes de acessar
	if floor_detector_left and not floor_detector_left.is_colliding():
		velocity.x = WALK_SPEED
	elif floor_detector_right and not floor_detector_right.is_colliding():
		velocity.x = -WALK_SPEED
	if is_on_wall():
		velocity.x = -velocity.x
	
	# Move o inimigo com base na velocidade
	move_and_slide()
	
	# Atualiza a orientação do sprite com base na direção do movimento
	if velocity.x > 0.0:
		animated_sprite.scale.x = 1.0
	elif velocity.x < 0.0:
		animated_sprite.scale.x = -1.0
	
	# Determina a animação baseada no estado atual
	var animation: StringName
	if _state == States.WALK:
		animation = "walk"	
	else:
		animation = "idle"
		
	if animation != animated_sprite.animation:
		animated_sprite.play(animation)

# Função para aplicar dano ao inimigo
func receiveDamage(damage: int) -> void:
	health -= damage
	if health < 0:
		health = 0

# Função para exibir o status atual do inimigo
func displayStatus() -> void:
	print("Vida: " + str(health) + " Velocidade: " + str(velocity.x))

# Function to check if the enemy is dead
func isDead() -> bool:
	return health <= 0
