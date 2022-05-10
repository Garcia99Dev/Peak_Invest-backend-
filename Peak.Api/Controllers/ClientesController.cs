using Microsoft.AspNetCore.Mvc;
using Peak.Api.DTOs;

namespace Peak.Api.Controllers;

[ApiController]
[Route("consulta")]
public class ClientesController : ControllerBase
{
    List<KeyValuePair<int, string>> lista;

    public ClientesController()
    {
        lista = new List<KeyValuePair<int, string>>();

        lista.Add(new KeyValuePair<int, string>(1, "João"));
        lista.Add(new KeyValuePair<int, string>(2, "Maria"));
        lista.Add(new KeyValuePair<int, string>(3, "Ana"));
    }

    [HttpGet]
    public UsuarioDTO Get(int id)
    {
        string nome = lista.Find(x => x.Key == id).Value;
        UsuarioDTO usuario = new UsuarioDTO();
        usuario.Id = id;
        usuario.Name = nome;

        return usuario;
    }

    [HttpPost]
    public EmprestimoDTO CalcularValor(EmprestimoDTO emprestimo)
    {
        emprestimo.CalcularTaxaDeEmprestimo();
        return emprestimo;
    }
}
