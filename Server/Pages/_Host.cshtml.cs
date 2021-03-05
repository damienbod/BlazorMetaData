using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorMeta.Server.Pages
{
    public class _HostModel : PageModel
    {
        public string SiteName { get; set; } = "damienbod";
        public string PageDescription { get; set; } = "damienbod init description";
        public void OnGet()
        {
            (SiteName, PageDescription) = GetMetaData();
        }

        private (string, string) GetMetaData()
        {
            var metadata = Request.Path.Value switch
            {
                "/counter" => ("damienbod/counter", "This is the meta data for the counter"),
                "/fetchdata" => ("damienbod/fetchdata", "This is the meta data for the fetchdata"),
                _ => ("damienbod", "general description")
            };
            return metadata;
        }
    }
}
