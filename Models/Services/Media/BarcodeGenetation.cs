using Models.Types;
using Models.Types.Media;
using SkiaSharp;


namespace Models.Services.Media
{
    public static class BarcodeGenetation
    {
        // generate barcode given part sku
        public static FileContent ToCode39(this StockKeepUnit sku, int barHeight) =>
             //new(Array.Empty<byte>(), string.Empty);
             sku.Value.ToCode39Bars().ToCode39Bitmap(barHeight).ToPng();


        // Start Functional Decomposition

        private static SKBitmap ToCode39Bitmap(this IEnumerable<int> bars, int barHeight) =>
            bars.ToGraphicalLines().ToBarcodeBitmap(barHeight);

        // Bride the gap btw bar widths {0, 1, 2} and actual lines
        private static SKPaint[] ToGraphicalLines(this IEnumerable<int> bars) =>
            Array.Empty<SKPaint>();

        private static SKBitmap ToBarcodeBitmap(this SKPaint[] bars, int barHeight) =>
            new(10, 10);
    }

    // move to file
    internal static class ImageEncoding
    {
        public static FileContent ToPng(this SKBitmap bitmap) =>
            new(Array.Empty<byte>(), string.Empty);
    }

    // move to file
    public static class Code39
    {
        public static IEnumerable<int> ToCode39Bars(this string value) =>
            // returns {0, 1, 2} represents bars thikness
            Enumerable.Empty<int>();
    }
}
