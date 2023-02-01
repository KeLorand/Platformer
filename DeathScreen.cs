using Godot;
using System;

public class DeathScreen : Node2D
{

    private Label deathsCountLabel;
    private int deathsCount;
    private float resetTimer;


    public override void _Ready()
    {
        deathsCountLabel = GetNode("DeathCounter") as Label;
        deathsCount++;
        GD.Print(deathsCount);
        deathsCountLabel.Text = $"Halálok száma: {deathsCount}";
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
