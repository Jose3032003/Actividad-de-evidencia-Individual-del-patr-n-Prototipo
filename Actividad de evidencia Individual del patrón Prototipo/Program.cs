namespace PatronPrototipoExamenes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cada materia tiene su propio prototipo con datos fijos
            ExamenPrototype prototipoPatrones = new PatronesDisenioExamen();
            ExamenPrototype prototipoPOO = new POOExamen();
            ExamenPrototype prototipoBD = new BaseDatosExamen();
            ExamenPrototype prototipoRedes = new RedesExamen();
            ExamenPrototype prototipoSO = new SistemasOperativosExamen();
            ExamenPrototype prototipoWeb = new IngenieriaWebExamen();
            ExamenPrototype prototipoCalculo = new Calculo1Examen();
            ExamenPrototype prototipoIA = new IAExamen();

            // Esto es lo que se colna del prototipo y solo se cambia lo que varía por grupo
            ExamenPrototype patronesG1 = prototipoPatrones.Clone();
            patronesG1.Grupo = "GDS-81A";
            patronesG1.Salon = "Aula 301";
            patronesG1.TipoExamen = "Parcial 1";
            Console.WriteLine(patronesG1.VerExamen());

           
            ExamenPrototype patronesG2 = prototipoPatrones.Clone();
            patronesG2.Docente = "Mtra. Lopez";
            patronesG2.Grupo = "GDS-81B";
            patronesG2.Salon = "Aula 302";
            patronesG2.TipoExamen = "Final";
            Console.WriteLine(patronesG2.VerExamen());

            ExamenPrototype pooG1 = prototipoPOO.Clone();
            pooG1.Grupo = "GDS-61A";
            pooG1.Salon = "Lab 1";
            pooG1.TipoExamen = "Parcial 2";
            Console.WriteLine(pooG1.VerExamen());

            ExamenPrototype bdG1 = prototipoBD.Clone();
            bdG1.Grupo = "GDS-61A";
            bdG1.Salon = "Aula 110";
            bdG1.TipoExamen = "Parcial 1";
            Console.WriteLine(bdG1.VerExamen());

            ExamenPrototype redesG1 = prototipoRedes.Clone();
            redesG1.Grupo = "GDS-71A";
            redesG1.Salon = "Lab Redes";
            redesG1.TipoExamen = "Final";
            Console.WriteLine(redesG1.VerExamen());

            ExamenPrototype soG1 = prototipoSO.Clone();
            soG1.Grupo = "GDS-71A";
            soG1.Salon = "Aula 210";
            soG1.TipoExamen = "Parcial 1";
            Console.WriteLine(soG1.VerExamen());

            ExamenPrototype webG1 = prototipoWeb.Clone();
            webG1.Grupo = "GDS-81D";
            webG1.Salon = "Lab Web";
            webG1.TipoExamen = "Parcial 2";
            Console.WriteLine(webG1.VerExamen());

            ExamenPrototype calG1 = prototipoCalculo.Clone();
            calG1.Grupo = "GDS-11A";
            calG1.Salon = "Aula 101";
            calG1.TipoExamen = "Parcial 1";
            Console.WriteLine(calG1.VerExamen());

            ExamenPrototype iaG1 = prototipoIA.Clone();
            iaG1.Docente = "Dr. Herrera";
            iaG1.Grupo = "GDS-91A";
            iaG1.Salon = "Lab IA";
            iaG1.TipoExamen = "Final";
            Console.WriteLine(iaG1.VerExamen());

            Console.ReadKey();
        }
    }
}