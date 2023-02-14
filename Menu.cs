using Godot;

public class Menu : Control
{
    
    public override void _Ready()
    {
        
    }

    public void _on_StartButton_pressed()
    {
        GetTree().ChangeScene("res://Vilag.tscn");
    }

    public void _on_ExitButton_pressed()
    {
        GetTree().Quit();
    }
}
