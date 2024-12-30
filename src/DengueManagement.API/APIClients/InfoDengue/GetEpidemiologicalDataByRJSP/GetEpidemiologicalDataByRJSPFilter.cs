using Refit;

namespace DengueManagement.API.APIClients.InfoDengue.GetEpidemiologicalDataByRJSP
{
    public record GetEpidemiologicalDataByRJSPFilter(
        [property: AliasAs("geocode")]int Geocode, 
        [property: AliasAs("disease")]string Disease,
        [property: AliasAs("ew_start")]int EwStart, 
        [property: AliasAs("ew_end")]int EwEnd, 
        [property: AliasAs("ey_start")]int EyStart, 
        [property: AliasAs("ey_end")]int EyEnd,
        [property: AliasAs("format")]string Format = "json");
}
