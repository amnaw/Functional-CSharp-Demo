namespace Models.Types
{
    public record struct Year(int Number)
    {
        // use Year to instantiate Months obj
        public Month GetMonth(int oridinal) =>
            oridinal >= 1 && oridinal <= 12 ? new(this, oridinal)
            : throw new ArgumentException(nameof(oridinal));

        public IEnumerable<Month> TryGetMonth(int oridinal) =>
            this.Months.Where(month => month.Ordinal== oridinal);


        public IEnumerable<Month> TryGetMonth2(int oridinal)
        {
            if (oridinal >= 1 && oridinal <= 12) yield return new(this, oridinal);
        }

        // select Closure cannot capture a value type (struct Year) from this
        public IEnumerable<Month> Months =>
            this.GetMonths(this);

        private IEnumerable<Month> GetMonths(Year year) =>
           Enumerable.Range(1, 12).Select(month => new Month(year, month));





        public Year DecdeBeginning => new(this.Number / 10 * 10 + 1);

        public IEnumerable<Year> Decade =>
            Enumerable.Range(this.DecdeBeginning.Number, 10)
            .Select(year => new Year(year));
    }
}
