using Godot;
using System;

public class Vilag : Node2D
{
    Camera2D Kamera;
    Node2D Jatekos;
    Node2D Ellenseg;
    public Vector2 SpawnPoint = new Vector2(0, 0);


    public override void _Process(float delta)
    {
        Kamera.Position = new Vector2(Jatekos.Position.x, Jatekos.Position.y + 300);
        GD.Print(Jatekos.Position);
    }
    public override void _Ready()
    {
        Kamera = (Camera2D)GetNode("Camera2D1");
        Jatekos = (Node2D)GetNode("Jatekos/KinematicBody2D1");
        Ellenseg = (Node2D)GetNode("Enemy");
    }
    private void _on_Area2D_body_entered(object area)
    {
        GD.Print("hello");
        //GetTree().ChangeScene("res://DeathScreen.tscn");
        Jatekos.Position = SpawnPoint;
    }
}
