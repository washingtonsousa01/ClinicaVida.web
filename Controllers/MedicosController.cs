
using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ClinicaVida.Web.Controllers;

public class MedicosController : Controller
{
    public IActionResult Index(int? especialidadeId)
    {
        var medicos = ClinicaEmMemoria.Medicos
            .Where(m => especialidadeId == null ||
                        m.EspecialidadeId == especialidadeId)
            .OrderBy(m => m.Nome)
            .ToList();

        foreach (var medico in medicos)
        {
            medico.Especialidade = ClinicaEmMemoria.Especialidades
                .FirstOrDefault(e => e.Id == medico.EspecialidadeId);
        }

        ViewBag.Especialidades = ClinicaEmMemoria.Especialidades;
        ViewBag.EspecialidadeSelecionada = especialidadeId;

        return View(medicos);
    }

    public IActionResult Details(int id)
    {
        var medico = ClinicaEmMemoria.Medicos
            .FirstOrDefault(m => m.Id == id);

        if (medico == null)
        {
            return NotFound();
        }

        medico.Especialidade = ClinicaEmMemoria.Especialidades
            .FirstOrDefault(e => e.Id == medico.EspecialidadeId);

        return View(medico);
    }
}
