using Godot;
using System;

public class Vilag : Node2D
{
	Camera2D Kamera;
	Node2D Jatekos;
	public override void _Process(float delta)
	{
		Kamera.Position = new Vector2(Jatekos.Position.x, Kamera.Position.y);
	}
	public override void _Ready()
	{
		Kamera = (Camera2D)GetNode("Camera2D1");
		Jatekos = (Node2D)GetNode("Jatekos/KinematicBody2D1");
	}
	private void _on_Area2D_area_entered(object area)
{
	
}
}



