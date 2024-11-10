class_name Gun extends Marker2D

const BULLET_VELOCITY = 10000
const BULLET_SCENE = preload("res://assets/bullet.tscn")

func shoot(direction) -> void:
	
	var bullet := BULLET_SCENE.instantiate() as Bullet
	bullet.global_position = global_position
	bullet.linear_velocity = Vector2(direction * BULLET_VELOCITY, 0)
	
	bullet.set_as_top_level(true)
	
	add_child(bullet)
