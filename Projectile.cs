using Godot;
using System;

public class Projectile : Node2D
{

    private RigidBody2D ProjectileRB;
    private KinematicBody2D Jatekos;

    public override void _Ready()
    {
        ProjectileRB = GetNode("RigidBody2D") as RigidBody2D;
        ProjectileRB.LinearVelocity = new Vector2(-500, 0);
        Jatekos = (KinematicBody2D)GetNode("/root/Vilag/Jatekos/JatekosBody");
    }


    public override void _Process(float delta)
    {

    }

    public void _on_Area2D_body_entered(KinematicBody2D body)
    {
        if (body.Name == "JatekosBody")
        {
            this.QueueFree();
        }

        
    }
}
