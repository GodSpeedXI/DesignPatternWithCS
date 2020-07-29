namespace DesignPatternPractice.IteratorPattern
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
