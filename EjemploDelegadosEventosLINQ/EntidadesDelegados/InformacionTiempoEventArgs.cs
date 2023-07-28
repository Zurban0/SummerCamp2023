namespace EntidadesEventos
{
    public class InformacionTiempoEventArgs
    {
        public InformacionTiempoEventArgs(int hora, int minuto, int segundo)
        {
            Hora=hora;
            Minuto=minuto;
            Segundo=segundo;
        }

        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }

        public override string ToString()
        {
            return $"{Hora}:{Minuto}:{Segundo}";
        }
    }
}