namespace FactoryMethodPatternPractice
{
    
    public class FactoryMethodWithGenericClass
    {
        CreatorWithGeneric<ConcreteProductA> creator = new CreatorWithGeneric<ConcreteProductA>();
        public void UnitTest()
        {
            Product product = creator.FactoryMethod();
        }
    }
    public class CreatorWithGeneric<T> where T : Product, new()
    {
        public T FactoryMethod()
        {
            return new T();
        }

    }

}