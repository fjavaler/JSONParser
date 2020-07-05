using System.Collections.Generic;

namespace JSONParser
{
  internal class JSONPersonArray : JSONPersonComplex
  {
    public List<PhoneNumber> phoneNumbers { get; set; }
  }
}