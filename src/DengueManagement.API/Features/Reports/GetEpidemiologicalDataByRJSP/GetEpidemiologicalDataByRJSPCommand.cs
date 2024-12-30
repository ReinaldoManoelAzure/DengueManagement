using DengueManagement.API.APIClients.InfoDengue.GetEpidemiologicalDataByRJSP;
using MediatR;

namespace DengueManagement.API.Features.Reports.GetEpidemiologicalDataByRJSP
{
    public record GetEpidemiologicalDataByRJSPCommand(
        string Cpf,
        string Name,
        int Geocode,
        string Disease,
        int EwStart,
        int EwEnd,
        int EyStart,
        int EyEnd) : IRequest<List<GetEpidemiologicalDataByRJSPResult>>;
}
