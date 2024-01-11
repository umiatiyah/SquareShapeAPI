using Microsoft.AspNetCore.SignalR;
using SquareShapeAPI.Contracts;
using System.Drawing;
using System.Threading.Tasks;

namespace SquareShapeAPI.Repositories
{
    public class ColorRepository : IColorRepository
    {
        private readonly IHubContext<ColorHub> _colorHub;
        public ColorRepository(IHubContext<ColorHub> colorHub)
        {
            _colorHub = colorHub;
        }

        public async Task SendColorChanges(string colorName)
        {
            await _colorHub.Clients.All.SendAsync("ChangeColor", colorName);
        }
    }
}
