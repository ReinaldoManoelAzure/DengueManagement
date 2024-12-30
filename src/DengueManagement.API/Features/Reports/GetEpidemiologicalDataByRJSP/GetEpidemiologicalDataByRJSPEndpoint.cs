using Carter;
using Carter.OpenApi;
using MediatR;

namespace DengueManagement.API.Features.Reports.GetEpidemiologicalDataByRJSP
{
    public class GetEpidemiologicalDataByRJSPEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/reports/epidemiological-data/rj-sp",
                    async (string cpf, string name,int geocode, string disease, int ewStart, int ewEnd, int eyStart, int eyEnd, ISender sender) =>
                    {
                        var command = new GetEpidemiologicalDataByRJSPCommand(cpf, name, geocode, disease, ewStart, ewEnd, eyStart, eyEnd);
                        var result = await sender.Send(command);
                        return Results.Ok(result);
                    })
                .Produces<GetEpidemiologicalDataByRJSPResult>()
                .Produces(StatusCodes.Status400BadRequest)
                .WithTags("Reports")
                .WithName("GetEpidemiologicalDataByRJSP")
                .WithSummary("Retorna todos os dados epidemiológicos dos municípios do Rio de Janeiro e São Paulo")
                .WithDescription("Endpoint responsável em retorna todos os dados epidemiológicos dos municípios do Rio de Janeiro e São Paulo")
                .IncludeInOpenApi();
        }
    }
}
