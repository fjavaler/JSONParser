using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser
{
  public class JSONPersonComplex : JSONPersonSimple
  {
    public Address address { get; set; }
  }
}
