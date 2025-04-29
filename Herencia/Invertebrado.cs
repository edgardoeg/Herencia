
namespace Herencia
{
    public class Invertebrado : Animal
    {
        public string? TipoCuerpo { get; set; }
        public string? MetodoReproduccion { get; set; }
        public string? TipoAlimentacion { get; set; }
        public string? CicloVida { get; set; }
        public string? Tamaño { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}"); 
            Console.WriteLine($"Edad: {Edad}  Años");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Habitat: {Habitat}"); //estos atributos (Nombre, Edad, Especie, Habitat) son heredados de la clase animal
            Console.WriteLine($"Tipo de Cuerpo: {TipoCuerpo}");
            Console.WriteLine($"Metodo de Reproduccion: {MetodoReproduccion}");
            Console.WriteLine($"Tipo de Alimentacion: {TipoAlimentacion}");
            Console.WriteLine($"Ciclo de Vida: {CicloVida}");
            Console.WriteLine($"Tamaño: {Tamaño}");
        }


    }
}
