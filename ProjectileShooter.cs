using Godot;

public class ProjectileShooter : Node
{   
    float timer;
    bool fire;
    private void ShootProjectile()
    {
        var projectile = new RigidBody2D();
        AddChild(projectile);

        var sprite = new Sprite();
        sprite.Texture = (Texture)ResourceLoader.Load("res://Képernyőkép 2023-02-06 085450.png");
        projectile.AddChild(sprite);

        projectile.SetLinearVelocity(new Vector2(-1000, 0));
    }

    public override void _Process(float delta)
    {   
        timer += delta;
        if(timer >2 && fire == true){
                ShootProjectile();
                timer = 0;
        }
            

    }
    public void _on_Area2D_body_entered(KinematicBody2D Jatekos){
            
            fire = true;
            

    }
    public void _on_Area2D_body_exited(KinematicBody2D Jatekos){
        fire = false;
    }
}
