#if TOOLS
using Godot;
using System;


[Tool]
public partial class markovgodot : EditorPlugin
{

	private Control _dock;

	public override void _EnterTree()
	{
		_dock = GD.Load<PackedScene>("res://addons/markovgodot/markov_dock.tscn").Instantiate<Control>();
		AddControlToDock(DockSlot.LeftUl, _dock);
	}

	public override void _ExitTree()
	{
		// Clean-up of the plugin goes here.
		// Remove the dock.
		RemoveControlFromDocks(_dock);
		// Erase the control from the memory.
		_dock.Free();
	}

}
#endif
