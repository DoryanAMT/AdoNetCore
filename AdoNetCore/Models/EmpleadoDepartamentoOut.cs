using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCore.Models
{
    public class EmpleadoDepartamentoOut
    {
        public List<string> nombre {  get; set; }
        public int suma { get; set; }
        public int media {  get; set; }
        public int personas {  get; set; }
    }
}
