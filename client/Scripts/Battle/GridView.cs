using Godot;

namespace ProjectPx.Battle;

[Tool]
public partial class GridView : Node2D
{
    [Export] public ushort Width { get; set; } = 10;
    [Export] public ushort Height { get; set; } = 10;
    [Export] public ushort TileWidth { get; set; } = 64;
    [Export] public ushort TileHeight { get; set; } = 32;
    [Export] public Vector2 Origin { get; set; } = Vector2.Zero;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public override void _Draw()
    {
        for (var i = 0; i < Width; i++)
        for (var j = 0; j < Height; j++)
        {
            var diamond = new[]
            {
                new Vector2(i, TileHeight / 2f), // Top
                new Vector2(-TileWidth / 2f, j), // Left
                new Vector2(i, -TileHeight / 2f), // Bottom
                new Vector2(TileWidth / 2f, j) // Right
            };

            DrawLine(diamond[0], diamond[1], Colors.White);
            DrawLine(diamond[1], diamond[2], Colors.White);
            DrawLine(diamond[2], diamond[3], Colors.White);
            DrawLine(diamond[3], diamond[0], Colors.White);
        }
    }
}