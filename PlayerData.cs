using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class PlayerData
    {
        public DateTime DateTime { get; set; }
        public string PlayerName { get; set; }
        public int CorrectAnswers { get; set; }
        public int IncorrectAnswers { get; set; }
    }
}
