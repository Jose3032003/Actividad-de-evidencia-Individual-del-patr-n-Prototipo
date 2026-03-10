using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipoExamenes
{
    public class Calculo1Examen : ExamenPrototype
    {
        public Calculo1Examen()
        {
            _claveMateria = "MAT-101";
            _nombreAsignatura = "Calculo Diferencial";
            _docente = "Dr. Herrera";
        }
        public override ExamenPrototype Clone() => (Calculo1Examen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}