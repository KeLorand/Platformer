using Godot;
using System;


public class Platform_Disappear : Node2D
{
    [Export]public PackedScene Platform;
    float timer;
    bool vane;
    private Sprite sprite;
    public override void _Ready()
    {
        sprite = GetNode<Sprite>("Sprite");
        sprite.Modulate = new Color(165, 23, 0, 255);
    }

    public override void _Process(float delta)
    {   
        timer += delta;
        if (timer >= 10)
        {
            sprite.Modulate = new Color(0, 0, 0, 255);
            vane = false;
        }
    }

    public void _on_Area2D_body_entered(KinematicBody2D player)
    {
        sprite.Modulate =new Color(0,0,0,0);
         vane = true;
         timer = 0;
    }
}
