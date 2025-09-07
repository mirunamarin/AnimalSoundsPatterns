using AnimalSoundsPatterns.Animals;

namespace AnimalSoundsPatterns.Factory
{
    public abstract class AnimalCreator
    {
        public abstract string Type { get; }
        public abstract IAnimal Create();
    }

    public sealed class DogCreator : AnimalCreator
    {
        public override string Type => "Dog";
        public override IAnimal Create() => new Dog();
    }

    public sealed class CatCreator : AnimalCreator
    {
        public override string Type => "Cat";
        public override IAnimal Create() => new Cat();
    }

    public sealed class CowCreator : AnimalCreator
    {
        public override string Type => "Cow";
        public override IAnimal Create() => new Cow();
    }

    public sealed class DuckCreator : AnimalCreator
    {
        public override string Type => "Duck";
        public override IAnimal Create() => new Duck();
    }
}
