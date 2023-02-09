using Godot;
using System;

public class Projectile : Node2D
{


    public override void _Ready()
    {

    }


    public override void _Process(float delta)
    {

    }

    public void _on_Area2D_body_entered(KinematicBody2D body)
    {
        this.QueueFree();
    }
}
