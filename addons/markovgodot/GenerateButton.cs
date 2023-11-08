using Godot;
using System;
using markov;

public partial class GenerateButton : BaseButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_pressed()
	{
		GD.Print("Generating Map...");
		Generate.GenerateModel("test");
	}


}



