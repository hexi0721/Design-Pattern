using UnityEngine;

namespace FactoryMethodPatternPractice
{
    
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public abstract class Product { }
    
    public class ConcreteProductA : Product
    {
        public ConcreteProductA()
        {
            Debug.Log("生成物件A");
        }
    }

    public class ConcreteProductB : Product
    {
        public ConcreteProductB()
        {
            Debug.Log("生成物件A");
        }
    }

}
