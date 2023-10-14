using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Estudiante> estudiantes1 = new List<Estudiante>
            {
                new Estudiante { Nombres = "Maria", Apellidos = "Pérez", Edad = 18, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Jose", Apellidos = "Moral", Edad = 21, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Santiago", Apellidos = "Rodríguez", Edad = 22, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Pablo", Apellidos = "Martínez", Edad = 20, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Joselin", Apellidos = "Hernández", Edad = 19, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Xavier", Apellidos = "Pato", Edad = 23, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Vanessa", Apellidos = "Mamani", Edad = 21, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Yerly", Apellidos = "Morales", Edad = 22, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Pierina", Apellidos = "Saldaña", Edad = 23, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Luis", Apellidos = "Ramírez", Edad = 20, Seccion ="Seccion D" },
                new Estudiante { Nombres = "Ines", Apellidos ="Aysa", Edad=19, Seccion="Seccion D"},
                new Estudiante { Nombres ="Elina", Apellidos="Palomino", Edad=21, Seccion="Seccion D"},
                new Estudiante { Nombres ="Johan", Apellidos="Moreno", Edad=24, Seccion="Seccion D"},
                new Estudiante { Nombres ="Janover", Apellidos="Carmen", Edad=22, Seccion="Seccion D"},
                new Estudiante { Nombres ="Treyci", Apellidos="Choque", Edad=23, Seccion="Seccion D"},
            };

            // Agrupar los estudiantes por sección usando LINQ
            // El método GroupBy crea un nuevo grupo para cada sección única en la lista de estudiantes

            var groupedStudents = estudiantes1.GroupBy(e => e.Seccion);

            // Asignar los grupos de estudiantes al ListView
            // ListView mostrará automáticamente los estudiantes agrupados por sección

            lvEstudiantes1.ItemsSource = groupedStudents;
        }
    }
}
