using PlanetsDatabaseDotCom.Models;
using System.Collections.Generic;

namespace PlanetsDatabaseDotCom.Services
{
    public interface IPlanetsService
    {
        IEnumerable<Planet> GetAll();
    }
}
