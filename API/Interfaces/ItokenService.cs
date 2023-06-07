using API.Entities;

namespace API.Interfaces
{
    public interface ItokenService
    {
        string CreateToken(Appuser user);
    }
}