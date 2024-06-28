using RockPaperScissors.Actions;
using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Tests.TestImplementations
{
    public class AlwaysPicksScissors : IChoiceGetter
    {
        public Choice GetChoice()
        {
            return Choice.Scissors;
        }
    }
}
