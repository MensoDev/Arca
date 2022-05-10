using System.Text;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace Arca.Services;

public class PdfService : IPdfService
{
    public async Task<string> ReadBrokerageNoteByStreamAsync(Stream stream)
    {
        var memoryStream = new MemoryStream();
        await stream.CopyToAsync(memoryStream);
        
        memoryStream.Position = 0;
        
        using var pdfDocument = new PdfDocument(new PdfReader(memoryStream));
        var numberOfPages = pdfDocument.GetNumberOfPages();
        
        var stringBuilder = new StringBuilder();
        for (var i = 1; i <= numberOfPages; ++i)
        {
            var page = pdfDocument.GetPage(i);
            var strategy = new SimpleTextExtractionStrategy();
            stringBuilder.Append(PdfTextExtractor.GetTextFromPage(page, strategy));
        }
        pdfDocument.Close();
        return stringBuilder.ToString();
    }
}