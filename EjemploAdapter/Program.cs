
//Programa principal
Persona persona = new Persona("Victor Hugo", "Carreon Pulido", 20, 1.68);
IPersona adaptador = new AdaptadorPersona(persona);
Console.WriteLine(adaptador.ObtenerCaracteristicas());
persona = new Persona("Edgar Eduardo", "Arguijo Vazquez", 21, 1.70);
adaptador = new AdaptadorPersona(persona);
Console.WriteLine(adaptador.ObtenerCaracteristicas());
persona = new Persona("Andrea Evelyn", "Mejia Rubio", 22, 1.65);
adaptador = new AdaptadorPersona(persona);
Console.WriteLine(adaptador.ObtenerCaracteristicas());
Console.ReadLine();

//La clase de IPerson defina la interfaz usada por el dominio del codigo cliente.
public interface IPersona
{
    string ObtenerCaracteristicas();
}

//La clase persona contiene el funcionamiento principal, pero la interfaz es
//incompatible con el codigo existente. La clase Persona necesita un
//adaptador entes de que el codigo cliente pueda utilizarlo.
class Persona
{
    public string Nombre;
    public string Apellido;
    public int Edad;
    public double Altura;

    public Persona(Persona persona) {
        this.Nombre = persona.Nombre;
        this.Altura = persona.Altura;
        this.Edad = persona.Edad;
        this.Apellido = persona.Apellido;
    }
    public Persona() { }
    public Persona(string nombre, string apellido, int edad, double altura) { 
        this.Edad= edad;
        this.Altura= altura;
        this.Nombre= nombre;
        this.Apellido= apellido;
    }
}

//La clase AdaptadorPersona hace que sea comapatible con la interfaz IPersona 
class AdaptadorPersona : IPersona
{
    private readonly Persona persona;

    public AdaptadorPersona(Persona persona) { this.persona = persona; }

    string IPersona.ObtenerCaracteristicas()
    {
        return $"El nombre de la persona es: {persona.Nombre} {persona.Apellido}, su edad es: {persona.Edad} y su estatura es de {persona.Altura} mts";
    }
}
