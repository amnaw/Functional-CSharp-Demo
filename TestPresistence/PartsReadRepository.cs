using Models.Types;
using Application.Presistence;

namespace TestPresistence
{
    public class PartsReadRepository : IReadOnlyRepository<Part>
    {
        public IEnumerable<Part> GetAll() => new[]
        {
            new Part("LED Red 3V", new StockKeepUnit("ELL22SS")),
            new Part("LED Black 3V", new StockKeepUnit("ELL22SS")),
            new Part("LED Orange 3V", new StockKeepUnit("ELL22SS")),
            new Part("LED Black 3V", new StockKeepUnit("ELL22SS")),
            new Part("LED Yellow 3V", new StockKeepUnit("ELL22SS")),
            new Part("LED Pink 3V", new StockKeepUnit("ELL22SS")),
            new Part("LED Green 3V", new StockKeepUnit("ELL22SS"))
        };
    }
}
