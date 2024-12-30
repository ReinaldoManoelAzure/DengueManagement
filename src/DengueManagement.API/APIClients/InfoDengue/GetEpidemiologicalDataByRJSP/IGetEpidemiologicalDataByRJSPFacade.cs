using Refit;

namespace DengueManagement.API.APIClients.InfoDengue.GetEpidemiologicalDataByRJSP
{
    public interface IGetEpidemiologicalDataByRJSPFacade
    {
        [Get("/api/alertcity/")]
        Task<List<GetEpidemiologicalDataByRJSPResponse>> ListAsync([Query] GetEpidemiologicalDataByRJSPFilter filter);
    }
}
