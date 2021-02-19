using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using test.Domain.Estudiantes.Entities;

namespace test.Domain.Estudiantes.IRepositories {

    public interface IEstudianteRepository {

        Estudiante Get (int id);

        Estudiante Add (Estudiante estudiante);

        // Task Update (Estudiante estudiante);

        // Task<IList<Estudiante>> GetAll ();

        // Task Delete (EstudianteID id);
    }
}