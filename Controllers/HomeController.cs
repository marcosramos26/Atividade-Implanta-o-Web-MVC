using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        // Instancia do tipo cliente
        Cliente cliente1 = new Cliente(01, " Arthur A. Ferreira", "000.000.000-01", "arthurgomes@gmail.com", "Junin");
        Cliente cliente2 = new Cliente(02, " João Gomes", "000.000.000-02", "joaogomes@hotmail.com", "Jones");

        // lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);

        ViewBag.listaClientes = listaClientes;

        // Instancia do tipo fornecedor

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "10.000.000/0001-00", "cpets@gmail.com" );
        Fornecedor fornecedor2 = new Fornecedor(02, "Comic pets", "20.000.000/0002-00", "comicpets@gmail.com" );

         // lista de Fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
         listaFornecedores.Add(fornecedor1);
         listaFornecedores.Add(fornecedor2);

         ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
