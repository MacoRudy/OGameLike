using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOGame
{
    public abstract class FonctionBuilding : Building
    {
        public abstract List<Action> Action(); 
    }
}
