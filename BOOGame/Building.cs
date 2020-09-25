using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public abstract class Building : IDbEntity
    {
        private long? id;
        public long? Id { get => this.id; set => this.id = value; }
        [MinLength(5)]
        [MaxLength(20)]
        
        public string Name { get; set; }
        public int? Level { get; set; }
        public int? NbCell
        {
            get { return this.Level; }
        }

        public List<Resource> TotalCost
        {
            get { return new List<Resource>(); }

        }
        public List<Resource> NextCost
        {
            get { return new List<Resource>(); }

        }
    }
}
