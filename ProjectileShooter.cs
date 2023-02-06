using Godot;

public class ProjectileShooter : Node
{   
    int kokanytimer;
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
        kokanytimer++;
        if (kokanytimer == 60) {
            ShootProjectile();
            kokanytimer = 0;
        }

    }
}