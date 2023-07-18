
namespace Entidades
{
    public class Vehiculo
    {
        public double ValorBase { get; set; }
        public DateTime AnioMatriculacion { get; set; }
        public EtiquetaDGT EtiquetaDGT { get; set; }

    }

    public enum EtiquetaDGT
    {
        SinEtiqueta = 1,
        B = 2,
        C = 3,
        ECO = 4,
        CERO = 5,
    }

}
