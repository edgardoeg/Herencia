
using Herencia;

Vertebrado vertebrado = new Vertebrado(); // Asignar valores a las propiedades de la clase Vertebrado

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
invertebrado.Imprimir(); // Llamar al método Imprimir de la clase Invertebrado