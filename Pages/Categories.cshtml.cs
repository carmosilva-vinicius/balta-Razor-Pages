using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyRazorApp.Pages
{
    public class Categories : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();

        public void OnGet(int skip = 0, int take = 25)
        {
            var temp = new List<Category>();

            for (int i = 0; i < 1787; i++)
            {
                temp.Add(
                    item:new Category(i,
                    Title:$"Categoria {i}",
                    Price:i*18.95M)
                );
            }

            CategoryList = temp.Skip(skip).Take(take).ToList();
        }
    }

    public record Category(int Id, string Title, decimal Price);
}