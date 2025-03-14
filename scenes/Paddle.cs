using Godot;
using System;

public partial class Paddle : Area2D
{
	[Export]
	private float speed = 60f;

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		Position += new Vector2(speed * Input.GetAxis("left", "right") * (float)delta, 0);
	}
	
	private void OnGemAreaEntered(Area2D area)
	{
		GD.Print("Area Entered:", area);
	}
}
