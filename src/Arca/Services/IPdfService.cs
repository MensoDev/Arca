namespace Arca.Services;

public interface IPdfService
{
    Task<string> ReadBrokerageNoteByStreamAsync(Stream stream);
}