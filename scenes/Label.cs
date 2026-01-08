using Godot;
using System;

public partial class InfoTabla : Node2D
{
	
	[Export] public string uzenet = "Juss ki a labirintusból! \n Egy kulcsot kell keresned a virágok alatt \n A virágot felszedheted E betűvel \n Az enterrel a kulcsot felveszed és az ajtót nyitod";

	public override void _Ready()
	{
		
		Label felirat = GetNode<Label>("Label");
		
		
		felirat.Text = uzenet;

		
		felirat.HorizontalAlignment = HorizontalAlignment.Center;
	}
}
