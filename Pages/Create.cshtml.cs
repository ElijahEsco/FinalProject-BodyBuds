using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FinalProject_BodyBuds.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace FinalProject_BodyBuds.Pages
{
    public class CreateModel : PageModel
    {
        private readonly BodyTypeDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public BodyType BodyType {get; set;}

        public CreateModel(BodyTypeDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.BodyTypes.Add(BodyType);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
