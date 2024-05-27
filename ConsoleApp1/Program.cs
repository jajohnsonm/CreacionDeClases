using System;

namespace EstructuraDeClase
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
    }

    public class Empleado : MiembroDeLaComunidad
    {
        public int ID_Empleado { get; set; }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public int Matricula { get; set; }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoDeGraduacion { get; set; }
    }

    public class Docente : Empleado
    {
        public string Materias { get; set; }
    }

    public class Administrativo : Empleado
    {
        public string Departamento { get; set; }
    }

    public class Administrador : Docente
    {
        public string Cargo { get; set; }
    }

    public class Maestro : Docente
    {
        public DateTime FechaDeEntrada {  get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado { Nombre = "Juan", ID_Empleado = 10001 };

            Estudiante estudiante = new Estudiante { Nombre = "María", Matricula = 20200001 };

            ExAlumno exAlumno = new ExAlumno { Nombre = "Pedro", AñoDeGraduacion = 2010 };

            Docente docente = new Docente { Nombre = "Ana", ID_Empleado = 10002, Materias = "Precalculo" };

            Administrativo administrativo = new Administrativo { Nombre = "Carlos", ID_Empleado = 10003, Departamento = "Recursos Humanos" };

            Administrador administrador = new Administrador { Nombre = "Laura", ID_Empleado = 10004, Materias = "Redaccion Castellana", Cargo = "Jefa de Departamento" };

            Maestro maestro = new Maestro { Nombre = "Luis", ID_Empleado = 10005, Materias = "Historia", FechaDeEntrada = new DateTime(2015, 4, 10) };


            //Mostrar Informaciones
            Console.WriteLine($"Empleado: {empleado.Nombre}, ID: {empleado.ID_Empleado}");

            Console.WriteLine($"Estudiante: {estudiante.Nombre}, Matrícula: {estudiante.Matricula}");
            
            Console.WriteLine($"ExAlumno: {exAlumno.Nombre}, Año de Graduación: {exAlumno.AñoDeGraduacion}");
            
            Console.WriteLine($"Docente: {docente.Nombre}, ID: {docente.ID_Empleado}, Asignatura: {docente.Materias}");
            
            Console.WriteLine($"Administrativo: {administrativo.Nombre}, ID: {administrativo.ID_Empleado}, Departamento: {administrativo.Departamento}");
            
            Console.WriteLine($"Administrador: {administrador.Nombre}, ID: {administrador.ID_Empleado}, Asignatura: {administrador.Materias}, Cargo: {administrador.Cargo}");
            
            Console.WriteLine($"Maestro: {maestro.Nombre}, ID: {maestro.ID_Empleado}, Materia: {maestro.Materias}, Años de Experiencia: {maestro.FechaDeEntrada}");

        }
    }


}