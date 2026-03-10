using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PatronPrototipoExamenes
{
    public class BaseDatosExamen : ExamenPrototype
    {
        public BaseDatosExamen()
        {
            _claveMateria = "TIC-305";
            _nombreAsignatura = "Base de Datos";
            _docente = "Dr. Ramirez";
        }
        public override ExamenPrototype Clone() => (BaseDatosExamen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}