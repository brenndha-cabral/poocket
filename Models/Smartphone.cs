using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poocket.Repository;

namespace poocket.Models
{
  public class Smartphone
  {
    private int v;

    public string Imei { get; set; }
    public string Model { get; set; }
    public int Storage { get; set; }

    public Smartphone(
        string imei,
        string model,
        int storage
        )
    {
        Imei = imei;
        Model = model;
        Storage = storage;
    }
  }
}