using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public interface IDbEntity
    {
       [Range(1,long.MaxValue)] 
       long? Id { get; set; }
    }
}
