using System;
using test.Application.Models;
using test.Infrastructure.Repositories;
using test.Domain.Estudiantes.Services;
using test.Domain.Estudiantes.Entities;
using test.Domain.Estudiantes.IRepositories;

namespace test.Application.UseCases {
    public class EstudianteUseCase {

        private IEstudianteRepository _estudianteRepository;

        public EstudianteUseCase () {
            _estudianteRepository = new EstudianteRepository ();
        }

        public Estudiante Get (int  Id) {
            var estudianteService = new EstudianteService (_estudianteRepository);
            Estudiante estudiante = estudianteService.Get (Id);
            return estudiante;
        }

    }
}