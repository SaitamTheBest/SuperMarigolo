using Godot;
using System;

public partial class Tchomp : Area2D
{
	public static AudioStreamPlayer2D Scream;
	public override void _Ready()
	{
		Scream = GetNode<AudioStreamPlayer2D>("AudioStreamPlayer2D");
	}

	public void _on_body_entered(CharacterBody2D body)
	{
		GetTree().ChangeSceneToFile("res://Interfaces/GameOverMenu/Gameover.tscn");
	}
}
