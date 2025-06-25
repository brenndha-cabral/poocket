using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poocket.Models
{
  public class Nokia : Smartphone
  {
    public Nokia(string imei, string model, int storage) : base(imei, model, 7)
    {
    }
  }
}