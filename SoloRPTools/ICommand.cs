namespace SoloRPTools
{
    public interface ICommand
    {
        string GetName();
        void Execute(string[] args);
    }
}
