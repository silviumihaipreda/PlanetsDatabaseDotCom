using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetsDatabaseDotCom.Models;

namespace PlanetsDatabaseDotCom.Services
{
    public class PlanetsService : IPlanetsService
    {
        private readonly Planet[] planets;

        public IEnumerable<Planet> GetAll()
        {
            return planets.AsEnumerable();
        }

        public PlanetsService()
        {
            planets = new Planet[] {

            new Planet {name="Mercury", distance = 58*Constants.million},
            new Planet {name="Venus", distance = 108*Constants.million },
            new Planet {name="Terra", distance = 149*Constants.million },
            new Planet {name="Mars", distance = 228*Constants.million },
            new Planet {name="Jupiter", distance = 778*Constants.million },
            new Planet {name="Saturn", distance = 1427*Constants.million },
            new Planet {name="Uranus", distance = 2871*Constants.million },
            new Planet {name="Neptune", distance = 4497*Constants.million }
            };
        }
    }
}
