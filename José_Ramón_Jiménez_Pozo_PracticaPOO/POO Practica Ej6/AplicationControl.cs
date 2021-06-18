using System;


namespace POO_Practica_Ej6
{
    class AplicationControl
    {
        //Aplicaciones de los cursos
        public static void AddCourse(tListadeCursos listadeCursos)
        {
            Console.Clear();
            tCurso curso = new tCurso();
            Console.WriteLine(" Añadir Curso");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Introduzca el nombre del curso:");
            curso.SetNombre(Console.ReadLine());
            Console.WriteLine("Introduzca el código del curso:");
            curso.SetCodigo(Console.ReadLine());
            listadeCursos.AgregateCourse(curso);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Curso guardado con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void RemoveCourse(tListadeCursos listadeCursos)
        {
            Console.Clear();
            Console.WriteLine(" Eliminar Curso");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Introduzca el código del curso que desee eliminar:");
            string buscar = Console.ReadLine();
            listadeCursos.SearchCourse(buscar);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Curso eliminado con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewCourse(tListadeCursos tListadeCursos)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar todos los cursos");
            Console.WriteLine("-------------------------");
            tListadeCursos.ListCourse();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewStudentCourse(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar todos los alumnos pertenecientes a un curso");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Introduzca el código del curso que desee buscar:");
            Console.WriteLine();
            string buscar = Console.ReadLine();
            listadeAlumnos.ListStudentCourse(buscar);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Pulse 0 para salir");
        }

        //Aplicaciones de los estudiantes
        //Alumnos
        public static void AddStudent(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            tAlumno alumno = new tAlumno();
            Console.WriteLine(" Añadir Alumno");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Introduzca el nombre del alumno: ");
            alumno.SetNombre(Console.ReadLine());
            Console.WriteLine("Introduzca el DNI del alumno: ");
            alumno.SetDni(Console.ReadLine());
            Console.WriteLine("Introduzca el teléfono del alumno: ");
            alumno.SetTelefono(Console.ReadLine());
            Console.WriteLine("Introduzca el código de curso del alumno:");
            alumno.SetCodigoCurso(Console.ReadLine());
            listadeAlumnos.AgregateStudent(alumno);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Alumno guardado con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void RemoveStudent(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Eliminar Alumno");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Introduzca el DNI del Alumno que desee eliminar:");
            string buscar = Console.ReadLine();
            listadeAlumnos.SearchStudent(buscar);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Alumno eliminado con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewStudentName(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar todos los Alumnos");
            Console.WriteLine("--------------------------");
            listadeAlumnos.ListStudentName();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void SortStudent(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Ordenar alfabéticamente los alumnos");
            Console.WriteLine("------------------------------------");
            listadeAlumnos.SortAlphabeticallyStudent();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Alumnos ordenados con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewStudentData(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar los datos de los alumnos por nombre");
            Console.WriteLine("--------------------------------------------");
            listadeAlumnos.ListStudentName();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Pulse 0 para salir");

        }
        //notas
        public static void AddGrade(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Agregar Nota");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Introduzca el DNI del alumno:");
            string buscar = Console.ReadLine();
            Console.WriteLine("Introduzca la nota:");
            double nota = Convert.ToDouble(Console.ReadLine());
            listadeAlumnos.AgreagateGrade(nota, buscar);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Nota agregada con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewApproved(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar alumnos con nota media igual o superior a 5");
            Console.WriteLine("----------------------------------------------------");
            listadeAlumnos.ListApprobed();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void RemoveGrade(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Eliminar las notas de un alumno:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Introduzca el DNI del alumno con las notas que desee eliminar:");
            string entrar = Console.ReadLine();
            listadeAlumnos.SearchGrade(entrar);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Nota eliminada con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewSuspensed(tListadeAlumnos listadeAlumnos)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar alumnos con nota media menor a 5");
            Console.WriteLine("-----------------------------------------");
            listadeAlumnos.ListSuspensed();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Pulse 0 para salir");
        }

        //Aplicaciones de los profesores
        public static void AddTeacher(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            tProfesor profesor = new tProfesor();
            Console.WriteLine(" Añadir Profesor");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Introduzca el nombre del profesor:");
            profesor.SetNombre(Console.ReadLine());
            Console.WriteLine("Introduzca el DNI del profesor:");
            profesor.SetDni(Console.ReadLine());
            Console.WriteLine("Introduzca el teléfono del profesor:");
            profesor.SetTelefono(Console.ReadLine());
            Console.WriteLine("Introduzca el código de curso del profesor:");
            profesor.SetCodigoCurso(Console.ReadLine());
            listadeProfesores.AgregateTeacher(profesor);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Profesor guardado con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void RemoveTeacher(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            Console.WriteLine(" Eliminar Profesor");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Introduzca el DNI del Profesor que desee eliminar:");
            string buscar = Console.ReadLine();
            listadeProfesores.SearchCourse(buscar);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Profesor eliminado con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewTeacher(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar todos los Profesores");
            Console.WriteLine("-----------------------------");
            listadeProfesores.ListTeacher();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void SortTeacher(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            Console.WriteLine(" Ordenar Alfabéticamente los Profesores");
            Console.WriteLine("---------------------------------------");
            listadeProfesores.SortAlphabeticallyTeacher();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Profesores ordenados con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewTeacherData(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar datos de profesores");
            Console.WriteLine("----------------------------");
            listadeProfesores.ListTeacherData();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Pulse 0 para salir");
        }
        //Asignaturas
        public static void AddSubject(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            Console.WriteLine(" Agregar Asignatura");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Introduzca el DNI del profesor:");
            string buscar = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre de la asignatura:");
            string asign = Console.ReadLine();
            listadeProfesores.AgreagateSubject(asign, buscar);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Asignatura agregada con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void Removesubject(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            Console.WriteLine(" Eliminar las Asignaturas de un Profesor");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Introduzca el DNI del Profesor con las asignaturas que desee eliminar:");
            string buscar = Console.ReadLine();
            listadeProfesores.SearchSubject(buscar);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Asignatura eliminada con éxito");
            Console.WriteLine("Pulse 0 para salir");
        }
        public static void ViewTaechaerSubject(tListadeProfesores listadeProfesores)
        {
            Console.Clear();
            Console.WriteLine(" Mostrar profesores que imparten una asignatura");
            Console.WriteLine("-----------------------------------------------");
            listadeProfesores.MostrarProfesoresConAsiganturas();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Pulse 0 para salir");

        }
    }
}
