using Domain.Enum_s;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Domain
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Brand { get; set; }
        public BodyColor BodyColor { get; set; }
        public BodyType BodyType { get; set; }
        public double Power { get; set; }
    }
}
