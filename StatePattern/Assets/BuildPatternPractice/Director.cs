public class Director
{
    private Product product;
    
    public void Construct(Builder builder)
    {
        product = new Product();
        builder.BuildPart1(product);
        builder.BuildPart2(product);
    }
    
    public Product GetResult()
    {
        return product;
    }
}