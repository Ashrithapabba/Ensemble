using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class ClothingItems
    {
    public Guid Id { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
    public DateTime DateAdded { get; set; }

    }
}