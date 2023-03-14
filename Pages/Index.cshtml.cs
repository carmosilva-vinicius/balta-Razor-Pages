using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyRazorApp.Pages
{
    public class Index : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        
        
        private readonly ILogger<Index> _logger;

        public Index(ILogger<Index> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            await Task.Delay(5000);
            for (int i = 0; i < 100; i++)
            {
                Categories.Add(
                    item:new Category(i,
                    Title:$"Categoria {i}",
                    Price:i*18.95M)
                );
            }
        }
    }
}

public record Category(int Id, string Title, decimal Price);