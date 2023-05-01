namespace QuestReports.Core;

public class FileExtensionAttribute : Attribute
{
    public FileExtensionAttribute(string extension)
        => FileExtension = "." + extension.ToLowerInvariant();

    public string FileExtension { get; init; }
}
