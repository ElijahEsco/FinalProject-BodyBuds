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
    public class IndexModel : PageModel
    {
        private readonly BodyTypeDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        public List<BodyType> BodyTypes {get; set;}

        public SelectList BodyTypesDropDown {get; set;}

        public IndexModel(BodyTypeDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            BodyTypes = _context.BodyTypes.ToList();

            BodyTypesDropDown = new SelectList(BodyTypes, "BodyTypeId", "TypeName");
        }
    }
}
