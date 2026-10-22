
namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Pediatria", Descricao = "Cuidados com crianças" },
        new Especialidade { Id = 2, Nome = "Cardiologia", Descricao = "Cuidados com o coração" },
        new Especialidade { Id = 3, Nome = "Neurologia", Descricao = "Cuidados com o sistema nervoso" },
        new Especialidade { Id = 4, Nome = "Ortopedia", Descricao = "Cuidados com ossos e articulações" }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Fabiana costa", Crm = "12345-SP", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Arthur Lima", Crm = "23456-SP", EspecialidadeId = 2 },
        new Medico { Id = 3, Nome = "Washington Sousa", Crm = "34567-SP", EspecialidadeId = 3 },
        new Medico { Id = 4, Nome = "Daniel Andrade", Crm = "45678-SP", EspecialidadeId = 4 },
        new Medico { Id = 5, Nome = "Ruti Santos", Crm = "56789-SP", EspecialidadeId = 1 },
        new Medico { Id = 6, Nome = "Mariana Rocha", Crm = "67890-SP", EspecialidadeId = 2 }
    };
}
