using Godot;

public class ControlPanel : Control
{
    private Button startButton;
    private Button exitButton;

    public override void _Ready()
    {
        startButton = GetNode<Button>("StartButton");
        exitButton = GetNode<Button>("ExitButton");

        startButton.Connect("pressed", this, nameof(OnStartButtonPressed));
        exitButton.Connect("pressed", this, nameof(OnExitButtonPressed));
    }

    private void OnStartButtonPressed()
    {
        GetTree().ChangeScene("res://Vilag.tscn");
    }

    private void OnExitButtonPressed()
    {
        GetTree().Quit();
    }
}
