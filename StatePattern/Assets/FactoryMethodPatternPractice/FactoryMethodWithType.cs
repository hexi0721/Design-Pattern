using UnityEngine;

namespace FactoryMethodPatternPractice
{
    
    public abstract class CreatorWithType
    {
        public abstract Product FactoryMethod(int type);
    }

    public class ConcreteCreatorWithType : CreatorWithType
    {
        public override Product FactoryMethod(int type)
        {

            switch (type)
            {
                case 1:
                    return new ConcreteProductA();
                case 2:
                    return new ConcreteProductB();
                default:
                    Debug.Log("無物件");
                    break;
            }

            return null;
        }
    }

}