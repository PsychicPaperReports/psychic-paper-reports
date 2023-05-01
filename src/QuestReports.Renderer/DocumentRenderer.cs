using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace QuestReports.Renderer;

public static class DocumentRenderer
{
    public static void Render()
    {
        var document = Document.Create(
            doc =>
            {
                doc.Page(page => page.Size(PageSizes.A1));
                doc.Page(page => page.Size(PageSizes.A4));
            });

        var bytes = document.GeneratePdf();
        File.WriteAllBytes("file.pdf", bytes);
    }
}
