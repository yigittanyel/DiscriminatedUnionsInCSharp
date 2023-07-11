namespace DiscriminatedUnionsInCSharp.Models;

public record Receipt(int ReceiptId, int Payment);
public record Product(int ProductId, string Name, int Cost);
public record Order(int ProductId, int Payment);