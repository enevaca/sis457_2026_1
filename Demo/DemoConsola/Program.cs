using DemoBiblioteca;
using DemoConsola;

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
int numero = 3; // Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= numero; i++) {
    Console.WriteLine($"El factorial de {i} es {factorial(i)}");
}

// POO - Programación Orientada a Objetos
Persona persona = new Persona();
persona.cedulaIdentidad = "123456";
persona.nombres = "Juan";
persona.primerApellido = "Pérez";
persona.segundoApellido = "López";
persona.fechaNacimiento = new DateOnly(2003, 12, 25);
persona.celular = 71717171;
persona.saludar();

Estudiante estudiante = new Estudiante();
estudiante.cedulaIdentidad = "654321";
estudiante.nombres = "María";
estudiante.primerApellido = "Gómez";
estudiante.segundoApellido = "Suárez";
estudiante.fechaNacimiento = new DateOnly(2005, 8, 6);
estudiante.celular = 72727272;
estudiante.carnetUniversitario = "26-1234";
estudiante.saludar();

Docente docente = new Docente();
docente.cedulaIdentidad = "987654";
docente.nombres = "Carlos";
docente.primerApellido = "Villagreal";
docente.segundoApellido = "Martínez";
docente.fechaNacimiento = new DateOnly(1900, 8, 6);
docente.celular = 73737373;
docente.item = 777;
docente.saludar();

// Clases Abstractas
//FiguraGeometrica figura = new FiguraGeometrica(); // No se puede instanciar una clase abstracta
FiguraGeometrica cuadrado = new Cuadrado(5);
Console.WriteLine($"El área del cuadrado es {cuadrado.area()}");
Console.WriteLine($"El perímetro del cuadrado es {cuadrado.perimetro()}");

FiguraGeometrica reactangulo = new Rectangulo(8, 5);
Console.WriteLine($"El área del rectángulo es {reactangulo.area()}");
Console.WriteLine($"El perímetro del rectángulo es {reactangulo.perimetro()}");

// Interfaces
// IVehiculo vehiculo = new IVehiculo(); // No se puede instanciar un interface
Automovil automovil = new();
automovil.acelerar(100);
automovil.frenar();
automovil.girar(30);

// Manejo de Excepciones
int dividendo, divisor, resultado;
try
{
    dividendo = 5;
    divisor = 0; // 0 -> va a ir por el catch porque dará error de división por cero
    resultado = dividendo / divisor;
    Console.WriteLine($"El resultado de la división es {resultado}");
}
catch (Exception) {
    Console.WriteLine("No es posible la división por Cero (0)");
}
finally {
    resultado = 0;
}

// Programación Asíncrona
metodoAsincrono();
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadLine();

static async void metodoAsincrono() { 
    await metodoDeLargaDuracion();
}

static async Task<int> metodoDeLargaDuracion() {
    Console.WriteLine("Iniciando método de larga duración");
    await Task.Delay(5000);
    Console.WriteLine("Fin de la tarea de larga duración");
    return 0;
}

// Biblioteca de Clases
int suma = Calculadora.sumar(26, 10);
int resta = Calculadora.restar(15, 5);
int multiplicacion = Calculadora.multiplicar(20, 5);
int division = Calculadora.dividir(20, 5);
int modulo = Calculadora.modulo(23, 5);
Console.WriteLine($"Suma: {suma}, Resta: {resta}, Mult: {multiplicacion}, Div: {division}");
