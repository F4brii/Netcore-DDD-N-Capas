using System;
using System.Threading.Tasks;
using test.Domain.Estudiantes.Entities;
using test.Domain.Estudiantes.IRepositories;
using test.Infraestructure.Context;
using System.Data.SqlClient;

namespace test.Infrastructure.Repositories {
    public class EstudianteRepository : IEstudianteRepository {

        public Estudiante Get (int id) {
            string sql = "SELECT * FROM Estudiante WHERE ID = @Id";
            SqlCommand command = Connection.GetCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = Connection.RunCommandReader(command);
            Estudiante estudiante = new Estudiante();
            while(reader.Read())
            {
                estudiante.ID = Convert.ToInt32(reader["ID"]);
                estudiante.Nombres = reader.GetString(1);
                estudiante.Apellidos = reader.GetString(2);
            }
            return estudiante;
        }

        public Estudiante Add (Estudiante estudiante) {
            return estudiante;
        }

        // public Task Update (Estudiante estudiante);

        // public Task<IList<Estudiante>> GetAll ();

        // public Task Delete (EstudianteID id);
    }
}