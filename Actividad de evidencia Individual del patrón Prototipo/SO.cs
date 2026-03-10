using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipoExamenes
{
    public class SistemasOperativosExamen : ExamenPrototype
    {
        public SistemasOperativosExamen()
        {
            _claveMateria = "TIC-308";
            _nombreAsignatura = "Sistemas Operativos";
            _docente = "Ing. Vega";
        }
        public override ExamenPrototype Clone() => (SistemasOperativosExamen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}

