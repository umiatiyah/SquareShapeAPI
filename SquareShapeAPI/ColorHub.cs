using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SquareShapeAPI
{
    public class ColorHub : Hub
    {
        public async Task ChangeColor(string color)
        {
            await Clients.All.SendAsync("ChangeColor", color);
        }
    }
}
