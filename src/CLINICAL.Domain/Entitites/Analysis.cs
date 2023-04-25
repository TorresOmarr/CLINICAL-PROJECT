namespace CLINICAL.Domain.Entitites
{
    public  class Analysis
    {
        public int AnalysisId { get; set; }
        public string? Name { get; set; }
        public int State { get; set; }
        public DateTime AuditCreateDate { get; set; }

    }
}
