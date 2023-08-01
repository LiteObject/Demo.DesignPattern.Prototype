namespace ConsoleApp
{
    public interface IPrototype<T>
    {
        public T Clone();
    }
}