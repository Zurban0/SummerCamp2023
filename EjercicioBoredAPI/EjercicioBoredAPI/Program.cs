using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace EjercicioBoredAPI
{
    class Program
    {
        private static string API_BASE = "http://www.boredapi.com";

        static async Task Main(string[] args)
        {
            string enlaceAPI = SacarTipoDeActividad();
            ResultadoJson resulatadoAPI = await RecogerActividadApiAsync(enlaceAPI);

            Console.WriteLine(resulatadoAPI.ToString());
        }

        private static string SacarTipoDeActividad()
        {
            return "";
        }

        private static async Task<ResultadoJson> RecogerActividadApiAsync(string enlaceApi)
        {
            ResultadoJson resulatadoAPI = new();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(API_BASE + enlaceApi);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                     resulatadoAPI = JsonConvert.DeserializeObject<ResultadoJson>(jsonResponse);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error al realizar la solicitud HTTP: {ex.Message}");
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Error al deserializar la respuesta JSON: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }
                return resulatadoAPI;

            }
        }
    }

    

    

    public class ResultadoJson
    {
        public string Activity { get; set; }
        public string Type { get; set; }
        public int Participants { get; set; }
        public decimal Price { get; set; }
        public string Link { get; set; }
        public string Key { get; set; }
        public decimal Accessibility { get; set; }

        public override string ToString()
        {
            return $"Actividad: {Activity}\nTipo: {Type}\nNúmero de Participantes: {Participants}\nPrecio: {Price}\nLink: {Link}\nContraseña: {Key}\nAccesibilidad: {Accessibility}";
        }
    }

}