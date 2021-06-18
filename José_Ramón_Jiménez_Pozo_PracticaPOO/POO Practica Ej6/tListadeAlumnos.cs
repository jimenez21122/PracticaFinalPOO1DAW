using System;
using System.Collections.Generic;

namespace POO_Practica_Ej6
{
    public class tListadeAlumnos
    {
        List<tAlumno> alumnos;
        public tListadeAlumnos()
        {
            alumnos = new List<tAlumno>();
        }
        //Alumnos
        public void AgregateStudent(tAlumno alumno)
        {
            alumnos.Add(alumno);
        }
        public void SearchStudent(string buscar)
        {
            for (int i = 0; alumnos.Count > i; i++)
            {
                if (alumnos[i].GetDni() == buscar)
                    alumnos.RemoveAt(i);
                else
                    Console.WriteLine("El Alumno no existe");
            }
        }
        public void ListStudentName()
        {
            int n = 1;

            for (int i = 0; alumnos.Count > i; i++)
            {
                Console.WriteLine("Curso Nº {0}", n);
                Console.WriteLine(alumnos[i].GetNombre());
                Console.WriteLine();

                n++;
            }
        }
        public void ListStudentData()
        {
            int n = 1;

            for (int i = 0; alumnos.Count > i; i++)
            {
                Console.WriteLine("Curso Nº {0}", n);
                Console.WriteLine(alumnos[i].GetNombre());
                Console.WriteLine(alumnos[i].GetDni());
                Console.WriteLine(alumnos[i].GetTelefono());
                Console.WriteLine(alumnos[i].GetCodigoCurso());
                Console.WriteLine();

                n++;
            }
        }
        public void SortAlphabeticallyStudent()
        {
            tAlumno alumno;
            string nombre1;
            string nombre2;

            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                for (int j = 1; j < alumnos.Count; j++)
                {
                    nombre1 = alumnos[i].GetNombre();
                    nombre2 = alumnos[j].GetNombre();

                    if (nombre1.CompareTo(nombre2) == 1)
                    {
                        alumno = alumnos[i];
                        alumnos[i] = alumnos[j];
                        alumnos[j] = alumno;
                    }
                }
            }
        }
        public void ListStudentCourse(string buscar)
        {
            for (int i = 0; alumnos.Count > i; i++)
            {
                if (buscar == alumnos[i].GetCodigoCurso())
                {
                    Console.WriteLine(alumnos[i].GetNombre());
                    Console.WriteLine(alumnos[i].GetCodigoCurso());
                }
                Console.WriteLine();
            }
        }
        //Notas
        public void AgreagateGrade(double nota, string buscar)
        {
            for (int i = 0; alumnos.Count > i; i++)
            {
                if (buscar == alumnos[i].GetDni())
                    alumnos[i].SetListaNotas(nota);
                else
                    Console.WriteLine("El alumno no existe");
            }
        }
        public void MostrarListaNotas(List<double> ListaNotas)
        {
            for (int i = 0; i > ListaNotas.Count; i++)
            {
                Console.WriteLine(ListaNotas[i]);
            }
        }
        public void ListApprobed()
        {
            for (int i = 0; i > alumnos.Count; i++)
            {
                if (alumnos[i].GetStudentMedia() >= 5)
                {
                    Console.WriteLine(alumnos[i].GetNombre());
                    Console.WriteLine(alumnos[i].GetDni());
                    Console.WriteLine(alumnos[i].GetTelefono());
                    Console.WriteLine(alumnos[i].GetCodigoCurso());
                }
            }
        }
        public void ListSuspensed()
        {
            for (int i = 0; i > alumnos.Count; i++)
            {
                if (alumnos[i].GetStudentMedia() < 5)
                {
                    Console.WriteLine(alumnos[i].GetNombre());
                    Console.WriteLine(alumnos[i].GetDni());
                    Console.WriteLine(alumnos[i].GetTelefono());
                    Console.WriteLine(alumnos[i].GetCodigoCurso());
                }
            }
        }
        public void SearchGrade(string entrar)
        {

            for (int i = 0; alumnos.Count > i; i++)
            {

                if (alumnos[i].GetDni() == entrar)
                    alumnos[i].RemoveGrade();
                else
                    Console.WriteLine("El alumno no existe");
            }
        }
    }
}
