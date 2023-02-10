using Godot;
using System;


public class Platform_Disappear : Node2D
{
    [Export]public PackedScene Platform;
    float timer;
    public override void _Ready()
    {
    }

    public override void _Process(float delta)
    {
        
    }

    public void _on_Area2D_body_entered(KinematicBody2D player)
    {
        QueueFree();
    }
}
