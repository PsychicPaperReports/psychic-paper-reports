namespace QuestReports.Core;

public class ScalableSize
{
    public ScalableSize(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public ScalableSize(float width, float height, float scale)
    {
        Width = width;
        Height = height;
        Scale = scale;
    }

    public float Width
    {
        get => OriginalWidth * Scale;
        init => OriginalWidth = value;
    }

    public float OriginalWidth { get; init; }

    public float Height
    {
        get => OriginalHeight * Scale;
        init => OriginalHeight = value;
    }

    public float OriginalHeight { get; init; }

    public float Scale { get; init; } = 1f;
}
