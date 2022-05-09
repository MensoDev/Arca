namespace Arca.Domain.Entities;

public abstract record StronglyTypedIdBase
{
    protected StronglyTypedIdBase(Guid? id)
        => Id = id ?? Guid.NewGuid();

    protected StronglyTypedIdBase(string? idGuidString)
        => Id = idGuidString is null ? Guid.NewGuid() : new Guid(idGuidString);
    
    protected Guid Id { get; set; }
    
    public override string ToString() => Id.ToString();
}