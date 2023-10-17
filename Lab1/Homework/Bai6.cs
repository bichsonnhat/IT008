namespace Bai6
{
    class Mamal
    {
        public string? characteristics;
    }    

    class Whale : Mamal
    {
        Whale() { }
    }

    interface IThinking
    {
        public void thinking_behavior();
    }

    interface IIntelligent
    {
        public void intelligent_behavior();
    }

    interface IAbility : IThinking, IIntelligent {}

    class Human : Mamal, IAbility
    {
        Human() { }
        public void intelligent_behavior() { };
        public void thinking_behavior() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}