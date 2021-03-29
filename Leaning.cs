using Godot;
using System;

public class Leaning : Spatial
{
    private const float DegreesToRadians = Mathf.Pi / 180f;
    public override void _Process(float delta)
    {
        if (Input.IsActionJustPressed("ui_select"))
        {
            GetChild<Tween>(2).InterpolateProperty(GetChild<Spatial>(1), "translation:y", 2.583, 2.7f, .1f);
            GetChild<Tween>(2).InterpolateProperty(GetChild<Spatial>(1), "translation:z", 0, 2f, .1f);
            GetChild<Tween>(2).InterpolateProperty(GetChild<Spatial>(1), "rotation_degrees:x", 0, 30f, .1f);
            GetChild<Tween>(2).Start();
        }

    }

    public override void _PhysicsProcess(float delta)
    {
        if (Input.IsActionPressed("ui_left"))
        {
            RotateY(DegreesToRadians * 100f * delta);
        }
    }
}
