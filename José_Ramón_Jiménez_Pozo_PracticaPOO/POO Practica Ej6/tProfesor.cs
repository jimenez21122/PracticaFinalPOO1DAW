using System.Collections.Generic;

namespace POO_Practica_Ej6
{
    public class tProfesor
    {
        string nombre;
        string dni;
        string telefono;
        string codigoCurso;

        List<string> ListaAsignaturas;

        public tProfesor()
        {
            ListaAsignaturas = new List<string>();
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
        public void SetListaAsignatura(string asignatura)
        {
            ListaAsignaturas.Add(asignatura);
        }
        public void RemoveAsignatura()
        {
            for (int i = 0; i < ListaAsignaturas.Count; i++)
            {
                ListaAsignaturas.RemoveAt(i);
            }
        }
        public int CheckAsignatura()
        {
            int aux = 0;
            for (int i = 0; ListaAsignaturas.Count > i; i++)
            {
                aux++;
            }
            return aux;
        }
    }
}
