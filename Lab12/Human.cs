using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Human:Player
    {

        public override string GetRoshambo()
        {
            string HumanplayerInput = Validate.GetValidString();
            return HumanplayerInput;
        }

    }
}
