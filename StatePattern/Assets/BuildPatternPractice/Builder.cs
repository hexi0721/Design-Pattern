public abstract class Builder
{
    public abstract void BuildPart1(Product product);
    public abstract void BuildPart2(Product product);
}

public class ConcreteBuilderA : Builder
{
    public override void BuildPart1(Product product)
    {
        product.AddPart("ConcreteBuilderA_Part1");
    }

    public override void BuildPart2(Product product)
    {
        product.AddPart("ConcreteBuilderA_Part2");
    }
}

public class ConcreteBuilderB : Builder
{
    public override void BuildPart1(Product product)
    {
        product.AddPart("ConcreteBuilderB_Part1");
    }

    public override void BuildPart2(Product product)
    {
        product.AddPart("ConcreteBuilderB_Part2");
    }
}