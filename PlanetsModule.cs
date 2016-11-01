using Nancy;
using PlanetsDatabaseDotCom.Services;

namespace PlanetsDatabaseDotCom
{
    public class PlanetsModule : NancyModule
    {
        private readonly IPlanetsService _service;

        public PlanetsModule(IPlanetsService service) : base("/planets")
        {
            _service = service;

            Get["/"] = _ =>
            {
                return Response.AsJson(_service.GetAll());
            };

            After.AddItemToEndOfPipeline((ctx) => ctx.Response
                .WithHeader("Access-Control-Allow-Origin", "*")
                .WithHeader("Access-Control-Allow-Methods", "POST,GET")
                .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type"));
        }
    }
}