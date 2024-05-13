public class StateManager
{
    private State state;

    public StateManager(State initialState)
    {
        state = initialState;
    }

    public void Save()
    {
        try
        {
            // Assuming 'state' is a serializable object
            // and we're saving it to a file
            using (var stream = new FileStream("state.dat", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, state);
            }
            Console.WriteLine("State saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred: " + ex.Message);
        }
        catch (SerializationException ex)
        {
            Console.WriteLine("State could not be serialized: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}

// Usage
var initialState = new State();
var stateManager = new StateManager(initialState);
stateManager.Save();
