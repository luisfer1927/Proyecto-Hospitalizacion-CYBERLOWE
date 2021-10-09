using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia.AppRepositorios;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{
    public class ListasaludModel : PageModel
    {
        private readonly IRepositorioEstadosalud repositorioEstadosalud;
        
        public IEnumerable<EstadodeSalud> EstadodeSalud{get;set;}

        public ListasaludModel(IRepositorioEstadosalud repositorioEstadosalud)
        {
            this.repositorioEstadosalud=repositorioEstadosalud;
        } 
        
    
        public void OnGet()
        {
            EstadodeSalud=repositorioEstadosalud.GetAll();
        }
    }
}
