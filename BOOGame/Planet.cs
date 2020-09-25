using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public class Planet : IDbEntity
    {
        private long? id;
        public long? Id { get => this.id; set => this.id = value; }
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
        public int? CaseNb { get; set; }

        public virtual List<Resource> Resources
        {
            get { return Resources; }
            set
            {
                this.Resources = new List<Resource>();
                if (value is List<Resource> && value.Count == 4)
                {
                    Resources = value;
                }
            } 
        } 

        [NotMapped]
        public virtual List<Building> Buildings { get; set; }
    }
}
