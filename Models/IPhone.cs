using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poocket.Models
{
  public class IPhone : Smartphone
  {
    public IPhone(string imei, string model, int storage) : base(imei, model, 12)
    {
    }
  }
}