using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipoExamenes
{
    public class RedesExamen : ExamenPrototype
    {
        public RedesExamen()
        {
            _claveMateria = "TIC-310";
            _nombreAsignatura = "Redes de Computadoras";
            _docente = "Mtra. Lopez";
        }
        public override ExamenPrototype Clone() => (RedesExamen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}
