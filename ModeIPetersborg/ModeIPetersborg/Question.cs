using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeIPetersborg
{
    class Question
    {
        public List<string> Text = new List<string>();
        List<Choice> Choice; 

        public Question(List<string> text, List<Choice> choice)
        {
            foreach (string t in text)
            {
                Text.Add(t);
            }
            Choice = choice;
        }

        public void AddChoice(bool Correct, string Text)
        {
            Choice.Add(new Choice(Text, Correct));
        }
    }
}
