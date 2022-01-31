namespace ExercicioProposto_Interfaces.Entities;
internal class Contract
{
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public Double TotalValue { get; set; }
    public List<Installment> Installment { get; set; }

    public Contract(int number, DateTime date, double totalValue)
    {
        Number = number;
        Date = date;
        TotalValue = totalValue;
        Installment = new List<Installment>();
    }

    public void AddInstallment(Installment installment) => Installment.Add(installment);

    public void RemoveInstallment(Installment installment) => Installment.Remove(installment);

}
