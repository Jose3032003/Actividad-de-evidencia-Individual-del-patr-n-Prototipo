namespace PatronPrototipoExamenes
{
    /// Materia: Patrones de Diseño.
    /// HERENCIA: toma todos los atributos de ExamenPrototype.
    /// CLONACION: MemberwiseClone hace una copia exacta de este examen.
    public class PatronesDisenioExamen : ExamenPrototype
    {
        public PatronesDisenioExamen()
        {
            _claveMateria = "TIC-401";
            _nombreAsignatura = "Patrones de Diseño";
            _docente = "Dr. Ramirez";
        }
        public override ExamenPrototype Clone() => (PatronesDisenioExamen)this.MemberwiseClone();
        public override string VerExamen() => $"{_nombreAsignatura} [{_claveMateria}] Docente: {_docente} Grupo: {_grupo} Salon: {_salon} Tipo: {_tipoExamen}";
    }
}
