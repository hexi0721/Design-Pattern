using System.Collections.Generic;
using UnityEngine;

namespace FlyWeightPattternPractice
{

    public abstract class FlyWeight
    {
        protected string content;

        public FlyWeight(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }

        public abstract void Operator();
    }

    public class ConcreteFlyWeight : FlyWeight
    {
        public ConcreteFlyWeight(string content) : base(content) { }

        public override void Operator()
        {
            Debug.Log($"ConcreteFlyWeight.Content[{content}]");
        }
    }

    public class UnSharedConcreteFlyWeight
    {
        private FlyWeight flyWeight;

        private string unShareContent;
        public UnSharedConcreteFlyWeight(string unShareContent)
        {
            this.unShareContent = unShareContent;
        }
        public void SetFlyWeight(FlyWeight flyWeight)
        {
            this.flyWeight = flyWeight;
        }
        public void Operator()
        {
            if (flyWeight != null)
            {
                Debug.Log($"UnSharedConcreteFlyWeight.Content[{unShareContent}] 包含: {flyWeight.GetContent()}");
            }
            else
            {
                Debug.Log($"UnSharedConcreteFlyWeight.Content[{unShareContent}]");
            }
        }
    }

    public class FlyWeightFactory
    {
        private Dictionary<string, FlyWeight> flyWeights = new();

        public FlyWeight GetFlyWeight(string key, string content)
        {
            if (flyWeights.ContainsKey(key))
            {
                return flyWeights[key];
            }

            ConcreteFlyWeight concreteFlyWeight = new(content);
            flyWeights.Add(key, concreteFlyWeight);
            Debug.Log($"New ConcreFlyWeight Key[{key}] Content[{content}]");
            return concreteFlyWeight;
        }

        private UnSharedConcreteFlyWeight GetUnSharedFlyWeight(string content)
        {
            return new(content);
        }

        public UnSharedConcreteFlyWeight GetUnSharedFlyWeight(string key, string sharedContent, string unSharedContent)
        {
            FlyWeight sharedFlyWeight = GetFlyWeight(key, sharedContent);
            UnSharedConcreteFlyWeight unSharedConcreteFlyWeight = GetUnSharedFlyWeight(unSharedContent);
            unSharedConcreteFlyWeight.SetFlyWeight(sharedFlyWeight);
            return unSharedConcreteFlyWeight;
        }
    }
}
