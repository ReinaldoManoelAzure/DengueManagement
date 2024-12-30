using System.Text.Json.Serialization;

namespace DengueManagement.API.APIClients.InfoDengue.GetEpidemiologicalDataByRJSP
{
 
    public record GetEpidemiologicalDataByRJSPResponse(
        [property: JsonPropertyName("data_iniSE")] long StartDateMillis,            // Data inicial em milissegundos desde a época
        [property: JsonPropertyName("SE")] int EpidemiologicalWeek,                 // Semana Epidemiológica
        [property: JsonPropertyName("casos_est")] double EstimatedCases,           // Número estimado de casos
        [property: JsonPropertyName("casos_est_min")] int EstimatedCasesMin,       // Estimativa mínima de casos
        [property: JsonPropertyName("casos_est_max")] int EstimatedCasesMax,       // Estimativa máxima de casos
        [property: JsonPropertyName("casos")] int NotifiedCases,                   // Casos notificados
        [property: JsonPropertyName("p_rt1")] double ProbabilityRtGreaterThanOne,  // Probabilidade de Rt > 1
        [property: JsonPropertyName("p_inc100k")] double IncidenceRatePer100k,     // Taxa de incidência por 100.000
        [property: JsonPropertyName("Localidade_id")] int LocalityId,              // ID da localidade
        [property: JsonPropertyName("nivel")] int AlertLevel,                       // Nível de alerta
        [property: JsonPropertyName("id")] long Id,                                 // Índice numérico
        [property: JsonPropertyName("versao_modelo")] string? ModelVersion,         // Versão do modelo
        [property: JsonPropertyName("tweet")] string? Tweet,                        // Tweet (opcional)
        [property: JsonPropertyName("Rt")] double Rt,                               // Estimativa do número reprodutivo
        [property: JsonPropertyName("pop")] double EstimatedPopulation,             // População estimada
        [property: JsonPropertyName("tempmin")] double MinTemperature,             // Temperatura mínima média
        [property: JsonPropertyName("tempmax")] double MaxTemperature,             // Temperatura máxima média
        [property: JsonPropertyName("tempmed")] double AvgTemperature,             // Temperatura média
        [property: JsonPropertyName("umidmin")] double MinHumidity,                // Umidade mínima média
        [property: JsonPropertyName("umidmax")] double MaxHumidity,                // Umidade máxima média
        [property: JsonPropertyName("umidmed")] double AvgHumidity,                // Umidade média
        [property: JsonPropertyName("receptivo")] int ClimaticReceptivity,         // Receptividade climática
        [property: JsonPropertyName("transmissao")] int TransmissionEvidence,       // Evidência de transmissão
        [property: JsonPropertyName("nivel_inc")] int IncidenceLevel,               // Nível de incidência
        [property: JsonPropertyName("casprov")] int? ProbableCases,                 // Casos prováveis (opcional)
        [property: JsonPropertyName("casprov_est")] double? ProbableCasesEstimation,// Estimativa de casos prováveis (opcional)
        [property: JsonPropertyName("casprov_est_min")] double? ProbableCasesEstimationMin, // Estimativa mínima de casos prováveis (opcional)
        [property: JsonPropertyName("casprov_est_max")] double? ProbableCasesEstimationMax, // Estimativa máxima de casos prováveis (opcional)
        [property: JsonPropertyName("casconf")] int? ConfirmedCases,               // Casos confirmados (opcional)
        [property: JsonPropertyName("notif_accum_year")] int AccumulatedNotificationsYear // Número acumulado de notificações no ano
    );


}
