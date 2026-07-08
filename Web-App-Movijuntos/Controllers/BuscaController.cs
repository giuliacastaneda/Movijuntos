using Microsoft.AspNetCore.Mvc;
using Web_App_Movijuntos.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Web_App_Movijuntos.Data;

namespace Web_App_Movijuntos.Controllers
{
    public class BuscaController : Controller
    {
        private readonly AppDbContext _context;

        public BuscaController(AppDbContext context)
        {
            _context = context;
        }
        
    }
}
