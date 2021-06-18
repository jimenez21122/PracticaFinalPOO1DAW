using System;
using System.Collections.Generic;

namespace POO_Practica_Ej6
{
    public class tListadeProfesores
    {
        List<tProfesor> profesores;
        public tListadeProfesores()
        {
            profesores = new List<tProfesor>();
        }
        //Profesores
        public void AgregateTeacher(tProfesor profesor)
        {
            profesores.Add(profesor);
        }
        public void SearchCourse(string buscar)
        {
            for (int i = 0; profesores.Count > i; i++)
            {
                if (profesores[i].GetCodigoCurso() == buscar)
                    profesores.RemoveAt(i);
                else
                    Console.WriteLine("El profesor no existe");
            }
        }
        public void ListTeacher()
        {
            int n = 1;
            for (int i = 0; profesores.Count > i; i++)
            {


                Console.WriteLine("Curso Nº {0}", n);
                Console.WriteLine(profesores[i].GetNombre());
                Console.WriteLine();

                n++;
            }
        }
        public void ListTeacherData()
        {
            int n = 1;
            for (int i = 0; profesores.Count > i; i++)
            {


                Console.WriteLine("Curso Nº {0}", n);
                Console.WriteLine(profesores[i].GetNombre());
                Console.WriteLine(profesores[i].GetDni());
                Console.WriteLine(profesores[i].GetTelefono());
                Console.WriteLine(profesores[i].GetCodigoCurso());
                Console.WriteLine();

                n++;
            }
        }
        public void SortAlphabeticallyTeacher()
        {
            tProfesor profesor;
            string nombre1;
            string nombre2;

            for (int i = 0; i < profesores.Count - 1; i++)
            {
                for (int j = 1; j < profesores.Count; j++)
                {
                    nombre1 = profesores[i].GetNombre();
                    nombre2 = profesores[j].GetNombre();

                    if (nombre1.CompareTo(nombre2) == 1)
                    {
                        profesor = profesores[i];
                        profesores[i] = profesores[j];
                        profesores[j] = profesor;
                    }
                }
            }
            ListTeacher();
        }

        //Asignaturas
        public void AgreagateSubject(string asign, string buscar)
        {
            for (int i = 0; profesores.Count > i; i++)
            {
                if (buscar == profesores[i].GetDni())
                    profesores[i].SetListaAsignatura(asign);
                else
                    Console.WriteLine("El profesor no existe");
            }
        }
        public void SearchSubject(string buscar)
        {
            for (int i = 0; profesores.Count > i; i++)
            {

                if (profesores[i].GetDni() == buscar)
                    profesores[i].RemoveAsignatura();
                else
                    Console.WriteLine("El profesor no existe");
            }
        }
        public void MostrarProfesoresConAsiganturas()
        {
            for (int i = 0; profesores.Count > i; i++)
            {
                if (profesores[i].CheckAsignatura() >= 1)
                {
                    Console.WriteLine("Nombre: ");
                    Console.WriteLine(profesores[i].GetNombre());
                    Console.WriteLine("DNI: ");
                    Console.WriteLine(profesores[i].GetDni());
                }
            }
        }
    }
}
