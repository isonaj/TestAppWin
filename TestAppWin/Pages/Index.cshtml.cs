using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestAppWin.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<string> MyFiles { get; set; }
        public void OnGet()
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            MyFiles = Directory.EnumerateFiles("data");
        }
    }
}
