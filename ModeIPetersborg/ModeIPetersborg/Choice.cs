using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeIPetersborg
{
    class Choice
    {
        public bool Correct { get; set; }
        public string Text { get; set; }

        public Choice(string Text, bool Correct)
        {
            this.Text = Text;
            this.Correct = Correct;
        }
    }
}
