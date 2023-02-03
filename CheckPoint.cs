using Godot;
using System;

public class CheckPoint : Node2D
{

    private Node2D ScriptNode;
    private Vilag vilag;

    public override void _Ready()
    {
        ScriptNode = GetNode("/root/Vilag") as Node2D;
        vilag = ScriptNode as Vilag;
    }


    public override void _Process(float delta)
    {

    }

    public void _on_Area2D_body_entered(PhysicsBody2D player)
    {
        vilag.SpawnPoint = new Vector2(this.Position.x, this.Position.y - 300);
        GD.Print(vilag.SpawnPoint);
        this.QueueFree();
    }
}
