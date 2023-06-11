namespace Application.Presistence
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll();
    }

}
