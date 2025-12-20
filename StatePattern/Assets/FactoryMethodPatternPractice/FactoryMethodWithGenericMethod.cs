
namespace FactoryMethodPatternPractice
{
    
    public class FactoryMethodWithGenericMethod
    {
        ConcretCreatorWithGenericMethod creator = new ConcretCreatorWithGenericMethod();
        public void UnitTest()
        {
            Product product = creator.FactoryMethod<ConcreteProductA>();
        }
    }

    public class ConcretCreatorWithGenericMethod : CreatorWithGenericMethod
    {
        public T FactoryMethod<T>() where T : Product, new ()
        {
           return new T(); 
        }
    }

    public interface CreatorWithGenericMethod
    {
        public T FactoryMethod<T>() where T : Product, new ();
    }

}
