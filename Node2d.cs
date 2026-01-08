

using Godot;
using System;

public partial class Virag : Area2D
{
	private bool playerNearby = false;
	// playerRef-re itt most nincs is szükség, ha csak törölni akarod a virágot
	
	public override void _Ready()
	{
		// Fontos: Node2D-t várunk a jeleknél!
		BodyEntered += OnBodyEntered;
		BodyExited += OnBodyExited;
	}

	// Node helyett Node2D-t írtam
	private void OnBodyEntered(Node2D body)
	{
		if (body is Player)
		{
			playerNearby = true;
			GD.Print("Játékos a közelben!"); // Teszt üzenet a konzolra
		}   
	}

	private void OnBodyExited(Node2D body)
	{
		if (body is Player)
		{
			playerNearby = false;
			GD.Print("Játékos elment.");
		}   
	}

	public override void _Process(double delta)
	{
		// IsActionJustPressed-et használunk a pontos érzékeléshez
		if (playerNearby && Input.IsActionJustPressed("interact"))
		{
			QueueFree();
		}
	}
}
