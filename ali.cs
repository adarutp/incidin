public abstract class PostBase
{
    public abstract Task<TPostBuilder> GetPostAsync();
}

public class ConcretePost : PostBase
{
    private readonly TPostBuilder _postBuilder = new TPostBuilder();

    public override async Task<TPostBuilder> GetPostAsync()
    {
        // Simulate an asynchronous operation
        await Task.Delay(100);
        return _postBuilder;
    }
}

class Program
{
    static async Task Main()
    {
        ConcretePost concretePost = new ConcretePost();
        TPostBuilder postBuilder = await concretePost.GetPostAsync();
        Console.WriteLine(postBuilder.BuildContent());
    }
}
