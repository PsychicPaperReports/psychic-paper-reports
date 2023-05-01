namespace QuestReports.Core;

public class Meta
{
    public Guid FileIdentifier { get; init; }

    public FileType FileType { get; init; }

    public Version Version { get; init; } = null!;

    public string VersionHash { get; init; } = null!;

    public DateTime CreateDateTime { get; init; }

    public DateTime UpdateDateTime { get; init; }

    public string Creator { get; init; } = null!;

    public string CreatorHash { get; init; } = null!;

    public string Updater { get; init; } = null!;

    public string UpdaterHash { get; init; } = null!;
}
