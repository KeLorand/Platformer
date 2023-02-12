using Godot;

public class ProjectileShooter : Node
{
    float timer;
    bool fire;

    [Export]public PackedScene Projectile;
    private void ShootProjectile()
    {
        GD.Print("loves");
        Node2D projectile = (Node2D)Projectile.Instance();
        this.AddChild(projectile);
    }

    public override void _Process(float delta)
    {
        timer += delta;
        if (timer > 2 && fire == true)
        {
            GD.Print("aaas");
            ShootProjectile();
            timer = 0;
        }


    }
    public void _on_Area2D_body_entered(KinematicBody2D Jatekos)
    {

        if (Jatekos.Name == "JatekosBody")
        {
            fire = true;
        }
        


    }
    public void _on_Area2D_body_exited(KinematicBody2D Jatekos)
    {   
        if (Jatekos.Name == "JatekosBody")
        {
            fire = false;
        }
    }
}
