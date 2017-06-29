using System.Security.Cryptography.X509Certificates;

namespace SolidExercices
{
    public interface IOperateur
    {
        decimal Calcule(string operation);
        char Character { get; }
    }
}