/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarCreations.Models
{
    public class JarsTypeViewModel
    {
    }
}*/

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace JarCreations.Models
{
    public class JarsTypeViewModel
    {
        public List<Jar> Jars { get; set; }
        public SelectList Types { get; set; }
        public string JarType { get; set; }
        public string SearchString { get; set; }
    }
}