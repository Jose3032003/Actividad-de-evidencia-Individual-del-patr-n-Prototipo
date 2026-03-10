using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PatronPrototipoExamenes
{
    public class IAExamen : ExamenPrototype
    {
        public IAExamen()
        {
            _claveMateria = "TIC-420";
            _nombreAsignatura = "Inteligencia Artificial";
            _docente = "Dr. Ramirez";
        }
        public override ExamenPrototype Clone() => (IAExamen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}
