using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipoExamenes
{

    // Clase base del patron Prototype. 
    // HERENCIA: todas las materias se basan en esta clase,
    // lo que significa que comparten los mismos atributos y metodos.
    // 
    // DATOS PROTEGIDOS: los atributos usan "protected", esto significa
    // que solo esta clase y las que se basen en ella pueden usarlos,
    // nadie mas puede modificarlos directamente desde afuera.
    // CLONACION: obliga a cada materia a definir su propio Clone().

    public abstract class ExamenPrototype
    {
        // Estos son los datos protegidos, no son publicos, cada materia los define en su constructor
        protected string _claveMateria;
        protected string _nombreAsignatura;
        protected string _docente;
        protected string _salon;
        protected string _grupo;
        protected string _tipoExamen;

        // Solo estos datos se pueden cambiar desde fuera, son los que varian por grupo
        public string Docente { set => _docente = value; }
        public string Salon { set => _salon = value; }
        public string Grupo { set => _grupo = value; }
        public string TipoExamen { set => _tipoExamen = value; }

        // Cada materia define como se clona y como se muestra en pantalla
        public abstract ExamenPrototype Clone();
        public abstract string VerExamen();
    }
}
