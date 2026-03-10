using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipoExamenes
{
    // Materia: Programacion Orientada a Objetos.
    // HERENCIA: toma todos los atributos de ExamenPrototype.
    // CLONACION: MemberwiseClone hace una copia exacta de este examen.
    public class POOExamen : ExamenPrototype
    {
        public POOExamen()
        {
            _claveMateria = "TIC-302";
            _nombreAsignatura = "Programacion Orientada a Objetos";
            _docente = "Ing. Torres";
        }
        public override ExamenPrototype Clone() => (POOExamen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}