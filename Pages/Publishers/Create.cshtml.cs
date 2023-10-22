﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Covaci_Adriana_Lab2.Data;
using Covaci_Adriana_Lab2.Models;

namespace Covaci_Adriana_Lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Covaci_Adriana_Lab2.Data.Covaci_Adriana_Lab2Context _context;

        public CreateModel(Covaci_Adriana_Lab2.Data.Covaci_Adriana_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
