extends Control

@onready var score_label = $ScoreLabel as Label
@onready var health_label = $HealthLabel as Label
# Called when the node enters the scene tree for the first time.
var health: int = 100

func _ready() -> void:
	update_score()


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	update_score()

func update_score() -> void:
		score_label.text = "Pontuação: " + str(GlobalScore.score)
		health_label.text = "Vida: " + str(health)
