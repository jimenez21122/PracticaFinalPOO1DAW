using System;
using System.Collections.Generic;

namespace POO_Practica_Ej6
{
    public class tListadeCursos
    {
        List<tCurso> cursos;

        public tListadeCursos()
        {
            cursos = new List<tCurso>();
        }
        public void AgregateCourse(tCurso curso)
        {
            cursos.Add(curso);
        }
        public void SearchCourse(string buscar)
        {
            for (int i = 0; cursos.Count > i; i++)
            {
                if (cursos[i].GetCodigo() == buscar)
                    cursos.RemoveAt(i);
                else
                    Console.WriteLine("El curso no existe");
            }
        }
        public void ListCourse()
        {
            int n = 1;
            for (int i = 0; cursos.Count > i; i++)
            {


                Console.WriteLine("Curso Nº {0}", n);
                Console.WriteLine(cursos[i].GetNombre());
                Console.WriteLine(cursos[i].GetCodigo());
                Console.WriteLine();

                n++;
            }
        }
        public void ListStudentCourse(List<tAlumno> alumnos)
        {

            for (int i = 0; cursos.Count > i; i++)
            {
                Console.WriteLine(cursos[i].GetNombre());
                Console.WriteLine(cursos[i].GetCodigo());

                if (cursos[i].GetCodigo() == alumnos[i].GetCodigoCurso())
                {
                    Console.WriteLine(alumnos[i].GetNombre());
                    Console.WriteLine(alumnos[i].GetDni());
                    Console.WriteLine(alumnos[i].GetTelefono());
                }
                Console.WriteLine();
            }
        }
    }
}
