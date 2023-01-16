using Godot;
using System;

public class KinematicBody2D1 : KinematicBody2D
{
	float gravitacio = 10;
	float sebesseg = 200;
	bool wasonwall = false;
	Vector2 mozgas = Vector2.Zero;
	KinematicCollision2D m_utkozes;
	public override void _PhysicsProcess(float delta)
	{
		//base._PhysicsProcess(delta);
		//MoveAndCollide(new Vector2(0, 200 * delta));
		//MoveAndCollide(new Vector2(200 * delta, 200 * delta)); //Ütközés után megáll.
		//MoveAndSlide(new Vector2(200, 200)); //Ütközés után csúszik. (A deltával számol.)
		/*
		//Gravitáció alkalmazása
		mozgas.y += gravitacio * delta;
		MoveAndCollide(mozgas);
		GD.Print(mozgas.y);
		// Nem jó mert a padlón nő a gravitációs vektor. (Egyre lejjebb szeretné tenni.)
		*/
		/*
		mozgas.y += gravitacio * delta;
		KinematicCollision2D utkozes = MoveAndCollide(mozgas); 
		GD.Print(mozgas.y);
		if (utkozes != null) mozgas.y = 0;
		//Ez már jobb de nincs sebessége
		*/
		/*
		mozgas.y += gravitacio * delta;
		mozgas.x = sebesseg * delta;
		KinematicCollision2D utkozes = MoveAndCollide(mozgas); 
		GD.Print(mozgas.y);
		if (utkozes != null) mozgas.y = 0;
		//Nem jó mert mindig változik a mozgásvektor és emiatt elmozdul.
		*/
		/*
		if (m_utkozes == null)
		{
			mozgas.y += gravitacio * delta;
			mozgas.x = sebesseg * delta;
		}
		m_utkozes = MoveAndCollide(mozgas);
		GD.Print(mozgas.y);
		Ez már jó egy nem mozgatható testre
		*/
		/*
		mozgas.y += gravitacio * delta;
		if (Input.IsActionPressed("ui_left"))
		{
			mozgas.x = -sebesseg * delta;
		}
		if (Input.IsActionPressed("ui_right"))
		{
			mozgas.x = sebesseg * delta;
		}
		KinematicCollision2D utkozes = MoveAndCollide(mozgas); 
		GD.Print(mozgas.y);
		if (utkozes != null) mozgas.y = 0;
		//Nehezen akadozva mozog ezért mozgatható testnél nem használjuk a mc-t
		*/
		/*
		mozgas.y += gravitacio;
		if (Input.IsActionPressed("ui_left"))
		{
			mozgas.x = -sebesseg;
		}
		if (Input.IsActionPressed("ui_right"))
		{
			mozgas.x = sebesseg;
		}
		MoveAndSlide(mozgas);
		GD.Print(mozgas.y);
		//Itt sem jó a gravitáció kezelés
		*/
		/*
		if (! IsOnFloor()) mozgas.y += gravitacio;
		else mozgas.y = gravitacio;
		if (Input.IsActionPressed("ui_left"))
		{
			mozgas.x = -sebesseg;
		}
		if (Input.IsActionPressed("ui_right"))
		{
			mozgas.x = sebesseg;
		}
		MoveAndSlide(mozgas, Vector2.Up);
		GD.Print(mozgas.y);
		//Ez már jó csak nem tudom megállítani és nem ugrik.
		*/
		/*
		if (! IsOnFloor()) mozgas.y += gravitacio;
		else mozgas.y = gravitacio;
		if (Input.IsActionPressed("ui_left"))
		{
			mozgas.x = -sebesseg;
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
		{
			mozgas.y = -300;
		}
		MoveAndSlide(mozgas, Vector2.Up);
		//Nem jó mert a levegőben is ugorhat.
		*/
		/*
		if (IsOnFloor()) GD.Print($"Padlón");
		if (IsOnCeiling()) GD.Print($"Plafonon");
		if (IsOnWall()) GD.Print($"Falon");
		if (! IsOnFloor() && ! IsOnCeiling() && ! IsOnWall()) GD.Print($"Levegőben");
		if (! IsOnFloor()) mozgas.y += gravitacio;
		else mozgas.y = gravitacio;
		if (Input.IsActionPressed("ui_left"))
		{
			mozgas.x = -sebesseg;
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
		{
			if (IsOnFloor() || IsOnWall()) mozgas.y = -300; //Ha a falról is ugorhat
		}
		MoveAndSlide(mozgas, Vector2.Up);
		//Nem jó mert a lejtőn a levegőben lesz és onnan nem ugorhat.
		*/
		//if (IsOnFloor()) GD.Print($"Padlón");
		//if (IsOnCeiling()) GD.Print($"Plafonon");
		//if (IsOnWall()) GD.Print($"Falon");
		//if (! IsOnFloor() && ! IsOnCeiling() && ! IsOnWall()) GD.Print($"Levegőben");
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
				 mozgas.y = -300; //Ha a falról is ugorhat
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
	}
}
