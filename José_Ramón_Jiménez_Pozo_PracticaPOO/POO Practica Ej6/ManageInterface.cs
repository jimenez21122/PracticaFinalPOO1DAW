using System;

namespace POO_Practica_Ej6
{
    class ManageInterface
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("     Menú Principal");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Gestión de Cursos");
            Console.WriteLine("2. Gestión de Alumnos");
            Console.WriteLine("3. Gestión de Profesores");
            Console.WriteLine("0. Salir");
        }
        public static void ManageMainMenu(tListadeCursos listadeCursos, tListadeAlumnos listadeAlumnos, tListadeProfesores listadeProfesores)
        {
            bool finish = false;
            while (!finish)
            {
                PrintMainMenu();
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        ManageCourseMenu(listadeCursos, listadeAlumnos);
                        break;
                    case 2:
                        ManageStudentMenu(listadeAlumnos);
                        break;
                    case 3:
                        ManageTeacherMenu(listadeProfesores);
                        break;
                }
            }
        }
        public static void PrintCourseMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("             Menú Principal/Gestionar Curso             ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("     Gestionar Curso");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1. Añadir Curso");
            Console.WriteLine("2. Eliminar Curso");
            Console.WriteLine("3. Mostrar todos los cursos");
            Console.WriteLine("4. Mostrar todos los alumnos pertenecientes a un curso");
            Console.WriteLine("0. Atrás");
        }
        public static void ManageCourseMenu(tListadeCursos listadeCursos, tListadeAlumnos listadeAlumnos)
        {
            PrintCourseMenu();

            bool finish = false;
            while (finish == false)
            {
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        AplicationControl.AddCourse(listadeCursos);
                        break;
                    case 2:
                        AplicationControl.RemoveCourse(listadeCursos);
                        break;
                    case 3:
                        AplicationControl.ViewCourse(listadeCursos);
                        break;
                    case 4:
                        AplicationControl.ViewStudentCourse(listadeAlumnos);
                        break;
                }
            }
        }
        public static void PrintStudentMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("     Menú Principal/Gestión de Alumnos     ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("     Gestión de Alumnos");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. Gestionar Alumnos");
            Console.WriteLine("2. Gestionar Notas");
            Console.WriteLine("0. Atrás");
        }
        public static void ManageStudentMenu(tListadeAlumnos listadeAlumnos)
        {
            PrintStudentMenu();
            bool finish = false;
            while (finish == false)
            {
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        ManageStudentSubMenu(listadeAlumnos);
                        break;
                    case 2:
                        ManageMarkSubMenu(listadeAlumnos);
                        break;
                }
            }
        }
        public static void PrintStudentSubMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   Menú Principal/Gestión de Alumnos/Gestionar Alumnos   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("     Alumnos");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1. Introducir Alumno");
            Console.WriteLine("2. Eliminar un Alumno");
            Console.WriteLine("3. Mostrar Lista de Alumnos");
            Console.WriteLine("4. Ordenar Alumnos por orden alfabético");
            Console.WriteLine("5. Mostrar Datos Alumno (Por nombre)");
            Console.WriteLine("6. Mostrar Alumnos pertenecientes a un curso");
            Console.WriteLine("0. Atrás");
        }
        public static void ManageStudentSubMenu(tListadeAlumnos listadeAlumnos)
        {
            PrintStudentSubMenu();
            bool finish = false;
            while (finish == false)
            {
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    default:
                        finish = true;
                        break;
                    case 1:
                        AplicationControl.AddStudent(listadeAlumnos);
                        break;
                    case 2:
                        AplicationControl.RemoveStudent(listadeAlumnos);
                        break;
                    case 3:
                        AplicationControl.ViewStudentName(listadeAlumnos);
                        break;
                    case 4:
                        AplicationControl.SortStudent(listadeAlumnos);
                        break;
                    case 5:
                        AplicationControl.ViewStudentData(listadeAlumnos);
                        break;
                    case 6:
                        AplicationControl.ViewStudentCourse(listadeAlumnos);
                        break;
                }
            }
            PrintStudentMenu();
        }
        public static void PrintMarkSubMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   Menú Principal/Gestión de Alumnos/Gestionar Notas   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("     Notas");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1. Añadir notas a Alumno");
            Console.WriteLine("2. Mostrar alumnos con nota media mayor o igual a 5");
            Console.WriteLine("3. Eliminar las notas de un alumno");
            Console.WriteLine("4. Mostrar alumnos con nota media menor a 5");
            Console.WriteLine("0. Atrás");
        }
        public static void ManageMarkSubMenu(tListadeAlumnos listadeAlumnos)
        {
            PrintMarkSubMenu();
            bool finish = false;
            while (finish == false)
            {
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        AplicationControl.AddGrade(listadeAlumnos);
                        break;
                    case 2:
                        AplicationControl.ViewApproved(listadeAlumnos);
                        break;
                    case 3:
                        AplicationControl.RemoveGrade(listadeAlumnos);
                        break;
                    case 4:
                        AplicationControl.ViewSuspensed(listadeAlumnos);
                        break;
                }
            }
            PrintStudentMenu();
        }
        public static void PrintTeacherMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   Menú Principal/Gestión de Profesores   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("     Gestión de Profesores");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. Gestionar Profesores");
            Console.WriteLine("2. Gestionar Asignaturas");
            Console.WriteLine("0. Atrás");
        }
        public static void ManageTeacherMenu(tListadeProfesores listadeProfesores)
        {
            PrintTeacherMenu();
            bool finish = false;
            while (finish == false)
            {
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        ManageTeacherSubMenu(listadeProfesores);
                        break;
                    case 2:
                        ManageSubjectSubMenu(listadeProfesores);
                        break;
                }
            }
        }
        public static void PrintTeacherSubMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   Menú Principal/Gestión de Profesores/Gestionar Profesores   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("     Profesores");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("1. Introducir Profesor");
            Console.WriteLine("2. Eliminar Profesor");
            Console.WriteLine("3. Mostrar Lista de Profesores");
            Console.WriteLine("4. Ordenar Profesores por Orden Alfabético");
            Console.WriteLine("5. Mostrar Datos Profesores");
            Console.WriteLine("0. Atrás");
        }
        public static void ManageTeacherSubMenu(tListadeProfesores listadeProfesores)
        {
            PrintTeacherSubMenu();
            bool finish = false;
            while (finish == false)
            {
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        AplicationControl.AddTeacher(listadeProfesores);
                        break;
                    case 2:
                        AplicationControl.RemoveTeacher(listadeProfesores);
                        break;
                    case 3:
                        AplicationControl.ViewTeacher(listadeProfesores);
                        break;
                    case 4:
                        AplicationControl.SortTeacher(listadeProfesores);
                        break;
                    case 5:
                        AplicationControl.ViewTeacherData(listadeProfesores);
                        break;
                }
            }
            PrintTeacherMenu();
        }
        public static void PrintSubjectSubMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("    Menú Principal/Gestión de Profesores/Gestionar Profesores    ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("     Asiganturas");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("1. Añadir Asignatura a Profesor");
            Console.WriteLine("2. Eliminar las asignaturas de un Profesor");
            Console.WriteLine("3. Mostrar profesores que imparten una asignatura");
            Console.WriteLine("0. Atrás");
        }
        public static void ManageSubjectSubMenu(tListadeProfesores listadeProfesores)
        {
            PrintSubjectSubMenu();
            bool finish = false;
            while (finish == false)
            {
                int control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 0:
                        finish = true;
                        break;
                    case 1:
                        AplicationControl.AddSubject(listadeProfesores);
                        break;
                    case 2:
                        AplicationControl.Removesubject(listadeProfesores);
                        break;
                    case 3:
                        AplicationControl.ViewTaechaerSubject(listadeProfesores);
                        break;
                }
            }
            PrintTeacherMenu();
        }
    }
}
