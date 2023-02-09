using Godot;

public class ProjectileShooter : Node
{
    float timer;
    bool fire;

    [Export]public PackedScene Projectile;
    private void ShootProjectile()
    {

        var ProjectileRB = new RigidBody2D();
        Node2D projectile = (Node2D)Projectile.Instance();
        projectile.AddChild(ProjectileRB);
        this.AddChild(projectile);
        ProjectileRB.SetLinearVelocity(new Vector2(-1000, 0));
    }

    public override void _Process(float delta)
    {
        timer += delta;
        if (timer > 2 && fire == true)
        {
            ShootProjectile();
            timer = 0;
        }


    }
    public void _on_Area2D_body_entered(KinematicBody2D Jatekos)
    {

        fire = true;


    }
    public void _on_Area2D_body_exited(KinematicBody2D Jatekos)
    {
        fire = false;
    }
}
