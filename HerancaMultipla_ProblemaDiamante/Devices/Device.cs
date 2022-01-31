namespace HerancaMultipla_ProblemaDiamante.Devices;
internal abstract class Device
{
    public int SerialNumber { get; set; }

    public abstract void ProcessDoc(string document);
}
