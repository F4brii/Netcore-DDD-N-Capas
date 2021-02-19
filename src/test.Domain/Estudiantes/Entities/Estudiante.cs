using System;

namespace test.Domain.Estudiantes.Entities {
    
    public class Estudiante{

        public Estudiante (
            int estudianteID,
            string nombres,
            string apellidos
        ) {
            this.ID = estudianteID;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
        }

        public Estudiante () {}

        public int ID { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }
    }
}
