/* Program.cs
* Administración y organización de datos
* IINF 4° E
* Organización de archivos secuenciales
* Nombre del alumno: Felipe Trujillo De Paz Antonio De Jesus De Los Santso Aguilar
* No de control: 21887040 y 21887020
*/

using System;
using System.IO;

public static class Program
{
    struct alumno_t
    {
        public string nombre;
        public int matricula;
        public string carrera;
        public int semestre;
        public char grupo;
        public decimal promedio;
    }

    static void Main(string[] args)
    {
        alumno_t[] alumno = new alumno_t[2];
        Console.Clear();

        try
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\User\\Videos\\Nueva carpeta\\Libro1.csv"))
            {
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null && i < alumno.Length)
                {
                    string[] values = line.Split(',');
                    alumno[i].nombre = values[0];
                    alumno[i].matricula = int.Parse(values[1]);
                    alumno[i].carrera = values[2];
                    alumno[i].semestre = int.Parse(values[3]);
                    alumno[i].grupo = values[4][0];
                    alumno[i].promedio = decimal.Parse(values[5]);
                    i++;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }

        Console.WriteLine("Datos del Alumno");
        Console.WriteLine("----------------");
        for (int i = 0; i < alumno.Length; i++)
        {
            Console.WriteLine($"Nombre: {alumno[i].nombre}\n"
            + $"Número de Control: {alumno[i].matricula}\n"
            + $"Carrera: {alumno[i].carrera}\n"
            + $"Semestre: {alumno[i].semestre}\n"
            + $"Grupo: {alumno[i].grupo}\n"
            + $"Promedio: {alumno[i].promedio}");
            Console.WriteLine("----------------");
        }

        Console.Write("Presione una tecla para terminar ");
        Console.ReadKey();
    }
}