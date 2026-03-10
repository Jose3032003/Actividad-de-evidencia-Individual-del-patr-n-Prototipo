using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipoExamenes
{
    public class IngenieriaWebExamen : ExamenPrototype
    {
        public IngenieriaWebExamen()
        {
            _claveMateria = "TIC-315";
            _nombreAsignatura = "Ingenieria Web";
            _docente = "Mtra. Lopez";
        }
        public override ExamenPrototype Clone() => (IngenieriaWebExamen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}
