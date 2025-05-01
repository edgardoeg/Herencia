
using Herencia;

Vertebrado vertebrado = new Vertebrado(); // Asignar valores a las propiedades de la clase Vertebrado
Invertebrado invertebrado = new Invertebrado(); // Asignar valores a las propiedades de la clase Invertebrado

int opcion;
Console.WriteLine("**********************************");
Console.WriteLine("             MENU                 ");
Console.WriteLine(" 1. Animal Vertebrado             ");
Console.WriteLine(" 2. Animal Invertebrado           ");
Console.WriteLine("**********************************");
Console.Write("Ingrese la opción deseada: ");

opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch(opcion)
{
    case 1:
        Console.WriteLine("**********************************");
        Console.WriteLine("*     ANIMAL VERTEBRADO          *");
        Console.WriteLine("**********************************");
        Console.Write("Nombre: ");
        vertebrado.Nombre = Console.ReadLine();
        Console.Write("Edad: ");
        vertebrado.Edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Especie: ");
        vertebrado.Especie = Console.ReadLine();
        Console.Write("Habitat: ");
        vertebrado.Habitat = Console.ReadLine();
        Console.Write("Tipo de Esqueleto: ");
        vertebrado.TipoEsqueleto = Console.ReadLine();
        Console.Write("Numero de Extremidades: ");
        vertebrado.NumeroExtremidades = Convert.ToInt32(Console.ReadLine());
        Console.Write("Tipo de Sangre: ");
        vertebrado.TipoSangre = Console.ReadLine();
        Console.Write("Dieta: ");
        vertebrado.Dieta = Console.ReadLine();
        Console.Write("Expectativa de Vida: ");
        vertebrado.ExpectativaVida = Convert.ToInt32(Console.ReadLine());
        Console.Write("Tipo de Reproduccion: ");
        vertebrado.Reproduccion = Console.ReadLine();
        vertebrado.Imprimir(); // Llamar al método Imprimir de la clase Vertebrado
        break;
    case 2:
        Console.WriteLine("**********************************");
        Console.WriteLine("*     ANIMAL INVERTEBRADO          *");
        Console.WriteLine("**********************************");
        Console.Write("Nombre: ");
        invertebrado.Nombre = Console.ReadLine();
        Console.Write("Edad: ");
        invertebrado.Edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Especie: ");
        invertebrado.Especie = Console.ReadLine();
        Console.Write("Habitat: ");
        invertebrado.Habitat = Console.ReadLine();
        Console.Write("Tipo de Cuerpo: ");
        invertebrado.TipoCuerpo = Console.ReadLine();
        Console.Write("Metodo de Reproduccion: ");
        invertebrado.MetodoReproduccion = Console.ReadLine();
        Console.Write("Tipo de Alimentacion: ");
        invertebrado.TipoAlimentacion = Console.ReadLine();
        Console.Write("Ciclo de Vida: ");
        invertebrado.CicloVida = Console.ReadLine();
        Console.Write("Tamaño: ");
        invertebrado.Tamaño = Console.ReadLine();
        
        invertebrado.Imprimir(); // Llamar al método Imprimir de la clase Invertebrado
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}







/*Vertebrado vertebrado = new Vertebrado(); // Asignar valores a las propiedades de la clase Vertebrado

vertebrado.Nombre = "Tiburón Blanco";
vertebrado.Edad = 15;
vertebrado.Especie = "Carcharodon carcharias";
vertebrado.Habitat = "Océano";
vertebrado.TipoEsqueleto = "Cartilaginoso";
vertebrado.NumeroExtremidades = 4;
vertebrado.TipoSangre = "Fría";
vertebrado.Dieta = "Carnívoro";
vertebrado.ExpectativaVida = 70;
vertebrado.Reproduccion = "Ovíparo";

vertebrado.Imprimir(); // Llamar al método Imprimir de la clase Vertebrado
Console.WriteLine(); // Línea en blanco para separar la salida

Invertebrado invertebrado = new Invertebrado(); // Asignar valores a las propiedades de la clase Invertebrado
invertebrado.Nombre = "Medusa";
invertebrado.Edad = 3;
invertebrado.Especie = "Aurelia aurita";
invertebrado.Habitat = "Océano";
invertebrado.TipoCuerpo = "Gelatinoso";
invertebrado.MetodoReproduccion = "Asexual";
invertebrado.TipoAlimentacion = "Filtrador";
invertebrado.CicloVida = "Metamorfosis";
invertebrado.Tamaño = "Mediano";
invertebrado.Imprimir(); // Llamar al método Imprimir de la clase Invertebrado*/