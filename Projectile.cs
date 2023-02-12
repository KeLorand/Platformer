using Godot;
using System;

public class Projectile : Node2D
{

    private RigidBody2D ProjectileRB;
    private KinematicBody2D Jatekos;
    private Node2D ScriptNode;
    private Vilag vilag;

    public override void _Ready()
    {
        ProjectileRB = GetNode("RigidBody2D") as RigidBody2D;
        ProjectileRB.LinearVelocity = new Vector2(-500, 0);
        Jatekos = (KinematicBody2D)GetNode("/root/Vilag/Jatekos/JatekosBody");
        ScriptNode = GetNode("/root/Vilag") as Node2D;
        vilag = ScriptNode as Vilag;
    }


    public override void _Process(float delta)
    {

    }

    public void _on_Area2D_body_entered(KinematicBody2D body)
    {
        if (body.Name == "JatekosBody")
        {
            this.QueueFree();
            vilag.hp -=1;
        }

        
    }
}
