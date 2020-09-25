using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public class SolarSystem : IDbEntity
    {
        private long? id;
        public long? Id { get => this.id; set => this.id = value; }
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual List<Planet> Planets { get; set;}
    }
}
