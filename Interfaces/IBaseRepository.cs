namespace Comparador.Interfaces
{
    public interface IBaseRepository

    {

        public interface IBaseRepository<T>

        {
            List<T> Consultar();
        }
    }
}