using System;
using System.Threading.Tasks;
using test.Domain.Estudiantes.Entities;
using test.Domain.Estudiantes.IRepositories;

namespace test.Domain.Estudiantes.Services {

    public class EstudianteService {

        private readonly IEstudianteRepository _estudianteRepository;

        public EstudianteService (IEstudianteRepository estudianteRepository) {
            this._estudianteRepository = estudianteRepository;
        }

        public Estudiante Get (int Id) {
            try {
                return _estudianteRepository.Get (Id);
            } catch (Exception) {
                throw;
            }

        }
    }

}