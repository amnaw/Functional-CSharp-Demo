using Models.Types.Media;

namespace Models.Types
{
    // these records should exist in their own files
    // these types come from requirments doc and related to business

    public record Part(string Name, StockKeepUnit Sku);
    public record StockKeepUnit(string Value);
    public record ExternalSku(StockKeepUnit Sku, Vendor Vendor);
    public record Vendor(Guid Id, string Name);
    public record ExternalPart(Part Part, ExternalSku ExternalSku);
    public record ExternalSkuPhoto(FileContent photo, Vendor Vendor);

}
