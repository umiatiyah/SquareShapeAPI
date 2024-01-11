using System.Threading.Tasks;

namespace SquareShapeAPI.Contracts
{
    public interface IColorRepository
    {
        Task SendColorChanges(string colorName);
    }
}
