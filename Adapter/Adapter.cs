namespace Adapter
{
    // the target defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }

    // the adaptee contains some useful behavior, but its interface is incompatible with the existing client code. 
    // the adaptee needs some adaptation before the client code can use it.
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    // the adapter makes the adaptee's interface compatible with the target's interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}