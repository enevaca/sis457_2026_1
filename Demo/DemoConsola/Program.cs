
// Esto es un comentario de una sola línea
/* Esto es un comentario
   de varias líneas */

// Variables
var variable = "Cualquier valor";
bool esActivo = false;
short enteroCorto = 12;
int entero = 123;
long enteroLargo = 1234567890;
double real = 3.1416;
decimal real2 = 3.1416m;
float real3 = 3.1416f;
char caracter = 'A';
string cadena = "Esto es una cadena";
Int16 enteroCorto2 = 12; // short
Int32 entero2 = 123; // int
Int64 enteroLargo2 = 1234567890; // long
DateTime fecha = DateTime.Now;
DateTime fecha2 = new DateTime(2026, 3, 2);

// Constantes
const double PI = 3.1416;
const string SIGLA_MATERIA = "SIS457";

// Operadores y expresiones
entero = 33;
entero2 += 10;
entero2 %= 2;
bool esPar = entero2 % 2 == 0;
int a = 5 + 7 * 2;
int b = (5 + 7) * 2;
b++;

// Conversiones y cadenas
string conversionCadena = real.ToString();
string conversionCadena2 = Convert.ToString(real2);
int conversionEntero = Convert.ToInt32(real);
int conversionEntero2 = int.Parse("123");
bool conversionBooleano = Convert.ToBoolean("true");
bool conversionBooleano2 = bool.Parse("false");

string materia = "Fundamentos de la Programación";
string concatenar = SIGLA_MATERIA + " - " + materia;
string concatenar2 = $"{SIGLA_MATERIA} - {materia}";
string interpolacion = string.Format("{0} - {1}", SIGLA_MATERIA, materia);
string mayusculas = materia.ToUpper();
string minusculas = materia.ToLower();
string reemplazo = materia.Replace("a", "@").Replace(" ", "_");
string subcadena = materia.Substring(4, 20);
string quitarEspaciosExtremos = ("    " + materia + "    ").Trim();
string invertir = new string(materia.Reverse().ToArray());
int logitud = materia.Length;
string[] separar = materia.Split(' ');

// Estructuras de Control
bool cadenaNoVacia;
if (cadena.Length > 0) cadenaNoVacia = true;
else cadenaNoVacia = false;
cadenaNoVacia = cadena.Length > 0 ? true : false;
cadenaNoVacia = cadena.Length > 0;

switch (materia)
{
    case "Informática": materia += "Info"; break;
    default: materia = materia.ToUpper(); break;
}

int contador = 0;
while (contador < 3) { 
    Console.WriteLine($"Contador while {contador}");
    contador++;
}

do
{
    Console.WriteLine($"Contador do-while {contador}");
    contador--;
} while (contador > 0);

for (int i = 0; i < separar.Length; i++) {
    Console.WriteLine($"Ciclo for -> Posición {i}: {separar[i]}");
}

// Métodos o Funciones
void saludar(string nombre) {
    Console.WriteLine($"Hola qué tal {nombre}?");
}
saludar("María");

string revertirCadena(string cadena) {
    return new string(cadena.Reverse().ToArray());
}
string cadenaInvertida = revertirCadena(materia);

long factorial(int numero) {
    long factorial = 1;
    for (int i = 2; i <= Math.Abs(numero); i++) factorial *= i;
    if (numero < 0) factorial *= -1;
    return factorial;
}

Console.Write("Ingrese un número para obtener los primeros N factoriales: ");
int numero = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= numero; i++) {
    Console.WriteLine($"El factorial de {i} es {factorial(i)}");
}

Console.WriteLine(cadenaInvertida);
