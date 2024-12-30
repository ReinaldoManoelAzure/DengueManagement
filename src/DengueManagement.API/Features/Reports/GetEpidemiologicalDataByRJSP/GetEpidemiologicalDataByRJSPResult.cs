namespace DengueManagement.API.Features.Reports.GetEpidemiologicalDataByRJSP
{
    
    public record GetEpidemiologicalDataByRJSPResult(
        long StartDateMillis, // Data inicial em milissegundos desde a época
        int EpidemiologicalWeek, // Semana Epidemiológica
        double EstimatedCases, // Número estimado de casos
        int EstimatedCasesMin, // Estimativa mínima de casos
        int EstimatedCasesMax, // Estimativa máxima de casos
        int NotifiedCases, // Casos notificados
        double ProbabilityRtGreaterThanOne, // Probabilidade de Rt > 1
        double IncidenceRatePer100k, // Taxa de incidência por 100.000
        int LocalityId, // ID da localidade
        int AlertLevel, // Nível de alerta
        long Id, // Índice numérico
        string? ModelVersion, // Versão do modelo
        string? Tweet, // Tweet (opcional)
        double Rt, // Estimativa do número reprodutivo
        double EstimatedPopulation, // População estimada
        double MinTemperature, // Temperatura mínima média
        double MaxTemperature, // Temperatura máxima média
        double AvgTemperature, // Temperatura média
        double MinHumidity, // Umidade mínima média
        double MaxHumidity, // Umidade máxima média
        double AvgHumidity, // Umidade média
        int ClimaticReceptivity, // Receptividade climática
        int TransmissionEvidence, // Evidência de transmissão
        int IncidenceLevel, // Nível de incidência
        int? ProbableCases, // Casos prováveis (opcional)
        double? ProbableCasesEstimation, // Estimativa de casos prováveis (opcional)
        double? ProbableCasesEstimationMin, // Estimativa mínima de casos prováveis (opcional)
        double? ProbableCasesEstimationMax, // Estimativa máxima de casos prováveis (opcional)
        int? ConfirmedCases, // Casos confirmados (opcional)
        int AccumulatedNotificationsYear // Número acumulado de notificações no ano
    );
}