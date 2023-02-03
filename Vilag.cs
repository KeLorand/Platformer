using Godot;
using System;

public class Vilag : Node2D
{

    Camera2D Kamera;
    Node2D Jatekos;
    Node2D Ellenseg;
    public Vector3 SpawnPoint;
    Sprite Heart;
    Sprite Heart2;
    Sprite Heart3;
    int hp = 3;
    public override void _Process(float delta)
    {
        Kamera.Position = new Vector2(Jatekos.Position.x, Kamera.Position.y);
        
    }
    public override void _Ready()
    {   
        
        Kamera = (Camera2D)GetNode("Camera2D1");
        Jatekos = (Node2D)GetNode("Jatekos/KinematicBody2D1");
        Ellenseg = (Node2D)GetNode("Enemy");
        Heart = (Sprite)GetNode("Jatekos/KinematicBody2D1/Heart");
        Heart2 = (Sprite)GetNode("Jatekos/KinematicBody2D1/Heart2");
        Heart3 = (Sprite)GetNode("Jatekos/KinematicBody2D1/Heart3");
        
    }
    private void _on_Area2D_body_entered(object area)
    {
        GD.Print("hello");
        hp = hp - 1;
        if(hp <= 0) GetTree().ChangeScene("res://DeathScreen.tscn");
        Jatekos.Position = new Vector2(0,0);
        if(hp < 3) Heart.QueueFree();
        if(hp < 2) Heart2.QueueFree();
        
    }
}
