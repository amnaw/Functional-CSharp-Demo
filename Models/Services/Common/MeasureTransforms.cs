using Models.Types;

namespace Models.Services.Common;

// Discriminated Unions
public static class MeasureTransforms
{
    // Patteren matching type test
    public static (Measure a, Measure b) SplitInHalves(this Measure m) =>
        //(default!, default!);
        m switch
        {
            DiscreteMeasure d =>
                (d with { Value = (d.Value + 1) / 2 }, d with { Value = d.Value / 2 }),

            ContinuousMeasure c when c with { Value = c.Value / 2 } is Measure half => // always true
                (half, half),

            _ =>
            throw new InvalidOperationException(
                $"Not defined for object of type {m?.GetType().Name ?? "<null>"}")
        };


    // General Advice: Seperate techincal code from domain-specific code


    private static (Measure a, Measure b) SplitInHalves(this DiscreteMeasure d) =>
        (d with { Value = (d.Value + 1) / 2 }, d with { Value = d.Value / 2 });

    private static (Measure a, Measure b) SplitInHalves(this ContinuousMeasure c)
    {
        Measure half = c with { Value = c.Value / 2 };
        return (half, half);
    }

    public static (Measure a, Measure b) SplitInHalves2(this Measure m) =>
       m switch
       {
           DiscreteMeasure d => d.SplitInHalves(),
           ContinuousMeasure c => c.SplitInHalves(),
           _ =>
           throw new InvalidOperationException(
               $"Not defined for object of type {m?.GetType().Name ?? "<null>"}")
       };

    public static (Measure a, Measure b) SplitInHalves3(this Measure m) =>
    m.AsDiscriminatedUnion() switch
    {
        DiscreteMeasure d => d.SplitInHalves(),
        ContinuousMeasure c => c.SplitInHalves(),
        _ => default!
    };


    public static (Measure a, Measure b) SplitInHalves4(this Measure m) =>
        m.MapAny(
            d => ((d with { Value = (d.Value + 1) / 2 }, d with { Value = d.Value / 2 })),

            c => 
            {
                Measure half = c with { Value = c.Value / 2 };
                return (half, half);
            }
            
         );
}
