using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RPClassicalBaptistPress.Pages
{
    public class MediaModel : PageModel
    {
        public class Files
        {
            public string Title { get; set; }
            public string Paragraph { get; set; }
            public string Author { get; set; }
            public string Source { get; set; }
            public bool IsYouTubeLink { get; set; }

        }
        public void OnGet()
        {
        }
    }
}
