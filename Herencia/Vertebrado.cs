

namespace Herencia
{
    //:este simbolo permite heredar una clase, para este caso vamos a heredar la clase animal
    public class Vertebrado : Animal  
    {
        public string? TipoEsqueleto { get; set; }
        public int NumeroExtremidades { get; set; }
        public string? TipoSangre { get; set; }
        public string? Dieta { get; set; }
        public int ExpectativaVida { get; set; }
        public string? Reproduccion { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}"); //estos atributos (Nombre, Edad, Especie, Habitat) son heredados de la clase animal
            Console.WriteLine($"Edad: {Edad} Años");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Tipo de Esqueleto: {TipoEsqueleto}");
            Console.WriteLine($"Numero de Extremidades: {NumeroExtremidades}");
            Console.WriteLine($"TipoSangre: {TipoSangre}");
            Console.WriteLine($"Dieta: {Dieta}");
            Console.WriteLine($"Expectativa de Vida: {ExpectativaVida} Años");
            Console.WriteLine($"Tipo de Reproduccion: {Reproduccion}");
        }
    }
}
