namespace De_Tod_chill.Database.Contexts.Factory;

// To save a list of Context to use in the project
public class MainContextFactory
{
    private readonly IDictionary<string, MainContext> _context;

    public MainContextFactory(IDictionary<string, MainContext> context)
    {
        _context = context;
    }
    
    public MainContext GetContext(string contextName)
    {
        return _context[contextName];
    }
}