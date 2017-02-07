namespace inheritanceDMU2.Model
{
    public interface IBil
    {
        double BilPrisExAfgift { get; }
        int KøbsÅr { get; }
        string Mærke { get; set; }
        string RegistringNr { get; set; }

        double HalvÅrligEjeafgift();
        double RegistreringAfgift();
        double RækkeVidde();
        double TotalPris();
    }
}