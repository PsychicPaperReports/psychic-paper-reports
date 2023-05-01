namespace QuestReports.Core;

public abstract class DocumentBase
{
    public Meta Meta { get; init; } = new();

    public PageProperties DefaultPageProperties { get; init; } = null!;
}
