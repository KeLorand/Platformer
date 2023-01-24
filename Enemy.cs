using Godot;
using System;

public class Enemy : Node2D
{
    private int speed = 2;
    private float time = 0;
    private bool goRight = false;
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

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
}