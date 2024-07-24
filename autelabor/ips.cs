public class AnimationContext
{
    // Basic properties relevant to animation
    public string Name { get; set; }
    public bool IsAnimating { get; set; }

    // Methods relevant to animation context
    public void Start()
    {
        IsAnimating = true;
        // Additional start logic
    }

    public void Stop()
    {
        IsAnimating = false;
        // Additional stop logic
    }
}
