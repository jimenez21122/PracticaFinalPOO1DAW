namespace POO_Practica_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {

            tListadeCursos listadeCursos = new tListadeCursos();
            tListadeAlumnos listadeAlumnos = new tListadeAlumnos();
            tListadeProfesores listadeProfesores = new tListadeProfesores();

            ManageInterface.ManageMainMenu(listadeCursos, listadeAlumnos, listadeProfesores);

        }
    }
}
