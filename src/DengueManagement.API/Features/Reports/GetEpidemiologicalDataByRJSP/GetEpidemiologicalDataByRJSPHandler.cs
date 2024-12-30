using DengueManagement.API.APIClients.InfoDengue.GetEpidemiologicalDataByRJSP;
using Mapster;
using MediatR;

namespace DengueManagement.API.Features.Reports.GetEpidemiologicalDataByRJSP
{
    public class GetEpidemiologicalDataByRJSPHandler(IGetEpidemiologicalDataByRJSPFacade getEpidemiologicalDataByRJSPFacade) : IRequestHandler<GetEpidemiologicalDataByRJSPCommand, List<GetEpidemiologicalDataByRJSPResult>>
    {
        public async Task<List<GetEpidemiologicalDataByRJSPResult>> Handle(GetEpidemiologicalDataByRJSPCommand command, CancellationToken cancellationToken)
        {
            var filter = command.Adapt<GetEpidemiologicalDataByRJSPFilter>();
            
            var result = await getEpidemiologicalDataByRJSPFacade.ListAsync(filter);
            
            return  result.Adapt<List<GetEpidemiologicalDataByRJSPResult>>();
        }
    }
}
