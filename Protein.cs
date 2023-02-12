using Godot;
using System;

public class Protein : Node2D
{

    private Node2D ScriptNode;
	private Vilag vilag;
    public override void _Ready()
    {
        ScriptNode = GetNode("/root/Vilag") as Node2D;
		vilag = ScriptNode as Vilag;
    }

    public void _on_Area2D_body_entered(KinematicBody2D Player)
    {
        if (Player.Name == "JatekosBody" && vilag.hp < 3)
        {
            vilag.hp ++;
            this.QueueFree();
        }
    }

}
