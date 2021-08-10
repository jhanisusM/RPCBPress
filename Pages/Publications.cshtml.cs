using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RPClassicalBaptistPress.Pages
{
    public class PublicationsModel : PageModel
    {
        public class Publications
        {
            public string id { get; set; }
            public string BtnStyle { get; set; }
            public string BtnLabel { get; set; }
            public string Title { get; set; }
            public string SubTitle { get; set; }
            public string Paragraph { get; set; }
            public string Device { get; set; }
            public string role { get; set; }
            public string ImgSorce { get; set; }

        }

        public void OnGet()
        {
        }
    }
}
