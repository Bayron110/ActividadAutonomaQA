namespace ActividadAutonoma.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Url { get; set; }

        // 🔥 ESTA ES LA SOLUCIÓN
        public string Image
        {
            get
            {
                var partes = Url.TrimEnd('/').Split('/');
                var id = partes[partes.Length - 1];
                return $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{id}.png";
            }
        }
    }
}