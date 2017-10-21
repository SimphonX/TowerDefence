using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towers_classes
{
    public interface BuildingInterface
    {
        void Damage(int value);
        void Repair(int value);
    }
}
