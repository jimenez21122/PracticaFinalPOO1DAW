using System.Collections.Generic;

namespace POO_Practica_Ej6
{
    public class tAlumno
    {
        string nombre;
        string dni;
        string telefono;
        string codigoCurso;

        List<double> ListaNotas;

        public tAlumno()
        {
            ListaNotas = new List<double>();
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetDni()
        {
            return dni;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        public string GetTelefono()
        {
            return telefono;
        }
        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public string GetCodigoCurso()
        {
            return codigoCurso;
        }
        public void SetCodigoCurso(string codigoCurso)
        {
            this.codigoCurso = codigoCurso;
        }
        public void SetListaNotas(double Nota)
        {
            ListaNotas.Add(Nota);
        }
        public double GetStudentMedia()
        {
            double aux = 0;
            for (int i = 0; i < ListaNotas.Count; i++)
            {
                aux += ListaNotas[i];
            }
            return aux / ListaNotas.Count;
        }
        public void RemoveGrade()
        {
            for (int i = 0; i < ListaNotas.Count; i++)
            {
                ListaNotas.RemoveAt(i);
            }
        }
    }
}
