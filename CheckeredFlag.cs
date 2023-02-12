using Godot;
using System;

public class CheckeredFlag : Node2D
{

    public override void _Ready()
    {
        
    }

    public void _on_Area2D_body_entered(KinematicBody2D Player)
    {
        if (Player.Name == "JatekosBody")
        {
            GetTree().ChangeScene("res://VictoryScreen.tscn");
        }
    }

}
