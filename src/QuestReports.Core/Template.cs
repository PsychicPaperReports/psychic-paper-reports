namespace QuestReports.Core;

/// <summary>
/// Preprocessed report template.
/// </summary>
public class Template : DocumentBase
{
    public IEnumerable<DocumentContent> HeadersContents { get; init; } = Array.Empty<DocumentContent>();

    public IEnumerable<DocumentContent> FootersContents { get; init; } = Array.Empty<DocumentContent>();

    public DocumentContent DocumentContent { get; init; } = null!;
}
