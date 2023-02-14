using Godot;
using System;

public class Vilag : Node2D
{

	Camera2D Kamera;
	Node2D Jatekos;
	Node2D Ellenseg;
	
	Sprite Heart;
	Sprite Heart2;
	Sprite Heart3;
	public int hp = 3;
	public Vector2 SpawnPoint = new Vector2(0, 0);

	[Export] public PackedScene Platform;

	public override void _Process(float delta)
	{
		Kamera.Position = new Vector2(Jatekos.Position.x, Jatekos.Position.y + 300);
		
		if (hp == 3)
		{
			Heart.Visible = true;
			Heart2.Visible = true;
			Heart3.Visible = true;
		}

		if (hp == 2)
		{
			Heart.Visible = false;
			Heart2.Visible = true;
			Heart3.Visible = true;
		}

		if (hp == 1)
		{
			Heart.Visible = false;
			Heart2.Visible = false;
			Heart3.Visible = true;
		}

		if (hp <= 0) GetTree().ChangeScene("res://DeathScreen.tscn");

		if (Input.IsActionPressed("ui_cancel")) GetTree().ChangeScene("res://Control.tscn");
	}
	public override void _Ready()
	{

		Kamera = (Camera2D)GetNode("Camera2D1");
		Jatekos = (Node2D)GetNode("Jatekos/JatekosBody");
		Ellenseg = (Node2D)GetNode("Enemy");
		Heart = (Sprite)GetNode("Jatekos/JatekosBody/Heart");
		Heart2 = (Sprite)GetNode("Jatekos/JatekosBody/Heart2");
		Heart3 = (Sprite)GetNode("Jatekos/JatekosBody/Heart3");
		

	}
	private void _on_Area2D_body_entered(KinematicBody2D Jatekos)
	{
		if ((Jatekos.Name == "JatekosBody"))
		{
			hp = hp - 1;
			Jatekos.Position = SpawnPoint;
			//GetTree().ChangeScene("res://DeathScreen.tscn");
			Jatekos.Position = SpawnPoint;
		}

	}

}