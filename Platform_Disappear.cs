using Godot;
using System;

public class Platform_Disappear : Node2D
{
    public override void _Ready()
    {

    }

    public override void _Process(float delta)
    {   

    }

    public void _on_Area2D_body_entered(KinematicBody2D player)
    {
        this.Visible = false;
        Timer timer = new Timer();
        timer.WaitTime = 10;
        timer.OneShot = true;
        timer.Connect("timeout", this, nameof(MakeVisible));
        AddChild(timer);
        timer.Start();
    }

    private void MakeVisible()
    {
        this.Visible = true;
    }
}
