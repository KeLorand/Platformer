using Godot;
using System;

public class Vilag : Node2D
{

    Camera2D Kamera;
    Node2D Jatekos;
    Node2D Ellenseg;
    Node2D Trap;
    Sprite Heart;
    Sprite Heart2;
    Sprite Heart3;
    public int hp = 3;
    public Vector2 SpawnPoint = new Vector2(0, 0);



    public override void _Process(float delta)
    {
        Kamera.Position = new Vector2(Jatekos.Position.x, Jatekos.Position.y + 300);
    }
    public override void _Ready()
    {   
        
        Kamera = (Camera2D)GetNode("Camera2D1");
        Jatekos = (Node2D)GetNode("Jatekos/JatekosBody");
        Ellenseg = (Node2D)GetNode("Enemy");
        Heart = (Sprite)GetNode("Jatekos/JatekosBody/Heart");
        Heart2 = (Sprite)GetNode("Jatekos/JatekosBody/Heart2");
        Heart3 = (Sprite)GetNode("Jatekos/JatekosBody/Heart3");
        Trap = (Node2D)GetNode("Trap");
    }
    private void _on_Area2D_body_entered(KinematicBody2D Jatekos)
    {
        GD.Print("hello");
        hp = hp - 1;
        if(hp <= 0) GetTree().ChangeScene("res://DeathScreen.tscn");
        Jatekos.Position = new Vector2(0,0);
        if(hp < 3) Heart.QueueFree();
        if(hp < 2) Heart2.QueueFree();
        
        //GetTree().ChangeScene("res://DeathScreen.tscn");
        Jatekos.Position = SpawnPoint;
    }
    
}
