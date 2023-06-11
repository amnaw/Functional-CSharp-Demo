using Models.Types;
using Models.Types.Media;

namespace Models.Services.Media
{
    public static class BarcodeGenetation
    {
        // generate barcode given part sku
        public static FileContent ToCode39(this StockKeepUnit sku, int barHeight)
        {
            return new FileContent(null, null);
        }
    }
}
