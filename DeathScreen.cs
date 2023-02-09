using Godot;
using System;

public class DeathScreen : Node2D
{


    private float resetTimer;


    public override void _Ready()
    {
        
    }


    public override void _Process(float delta)
    {
        resetTimer += delta;
        if (resetTimer >= 5)
        {
            resetTimer = 0;
            GetTree().ChangeScene("res://Vilag.tscn");
        }
    }
}
