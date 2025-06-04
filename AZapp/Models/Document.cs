using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class Document : IDocument
{
    private readonly WishList _modelpath;

    public Document(WishList model)
    {
        _modelpath = model;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(20);
            page.Size(PageSizes.A4);
            page.Content().Column(column =>
            {
                AddSection(column, "Top Priority", _modelpath.TopPriority);
                AddSection(column, "ISO", _modelpath.Want);
                AddSection(column, "My Collection", _modelpath.Have);
            });
        });
    }

    private void AddSection(ColumnDescriptor column, string title, List<string> imagePaths)
{
    column.Item().PaddingBottom(10).AlignCenter().AlignMiddle().Text(title).FontSize(16).Bold();

    const int imagesPerRow = 6;

    for (int i = 0; i < imagePaths.Count; i += imagesPerRow)
    {
        var chunk = imagePaths.Skip(i).Take(imagesPerRow).ToList();

        column.Item().Row(row =>
        {
            foreach (var image in chunk)
            {
                row.RelativeItem().Padding(5).Height(140).Element(container =>
                {
                    container.Column(col =>
                    {
                        // image zone (fixed height)
                        col.Item().Height(100).AlignCenter().AlignMiddle().Element(inner =>
                        {
                            if (File.Exists(image))
                            {
                                inner.Image(image).FitArea();
                            }
                            else
                            {
                                inner.Text("Not found").FontSize(10).Italic().AlignCenter();
                            }
                        });

                        // caption
                        // col.Item().AlignCenter().Text(Path.GetFileName(image)).FontSize(9);
                    });
                });
            }
        });
    }

    column.Item().PaddingBottom(15); // spacing after section
}


}
