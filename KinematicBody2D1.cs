using Godot;
using System;

public class KinematicBody2D1 : KinematicBody2D
{
	float gravitacio = 8;
	int hp = 3;
	float sebesseg = 400;
	bool wasonwall = false;
	Vector2 mozgas = Vector2.Zero;
	KinematicCollision2D m_utkozes;
	public override void _PhysicsProcess(float delta)
	{
	
		if (! IsOnFloor()) mozgas.y += gravitacio;
		else mozgas.y = gravitacio;
		if (Input.IsActionPressed("ui_left"))
		{
			mozgas.x = -sebesseg;
		}
		if (!Input.IsActionPressed("ui_left"))
		{
			mozgas.x = 0;
		}
		
		if (Input.IsActionPressed("ui_right"))
		{
			mozgas.x = sebesseg;
		}
		if (Input.IsActionPressed("ui_down"))
		{
			mozgas.x = 0;
		}
		if (Input.IsActionJustPressed("ui_up"))
		{   if(IsOnFloor() && IsOnWall()) wasonwall = false;
			if (IsOnFloor()){
				 mozgas.y = -300; 
				 wasonwall = false;
			}
			
			MoveAndSlide(mozgas, Vector2.Up);
			if (wasonwall == false){
				if (IsOnWall()){ 
					mozgas.y = -300;
					wasonwall = true;
			}}
			
		}
		else MoveAndSlideWithSnap(mozgas, new Vector2(0, 6), Vector2.Up);

		if (hp == 0)
		{
			sebesseg = 0;
			mozgas.y = -250;
			gravitacio = 0;
			mozgas.x = 0;
		}
	}
}
