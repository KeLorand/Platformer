using Godot;
using System;

public class Enemy : Node2D
{   Node2D Jatekos;
	
	private int speed = 2;
	private float time = 0;
	private bool goRight = false;
	private Node2D ScriptNode;
	private Vilag vilag;
	


	public override void _Ready()
	{
		Jatekos = GetNode<Node2D>("Jatekos");
		ScriptNode = GetNode("/root/Vilag") as Node2D;
		vilag = ScriptNode as Vilag;
		
	}

	public override void _Process(float delta)
	{
		time += delta;
		if (time >= 3)
		{
			goRight = !goRight;
			time = 0;
		}
		if (goRight)
		{
			Position += new Vector2(speed, 0);
		}
		else
		{
			Position -= new Vector2(speed, 0);
		}
	}
	
	public void _on_Area2D_body_entered(KinematicBody2D Jatekos)
	{
		
			GD.Print("hello");
			
			Jatekos.Position = vilag.SpawnPoint;
			
		
	}
}
