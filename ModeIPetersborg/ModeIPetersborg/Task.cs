using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeIPetersborg
{
    class Task
    {
        public string Title { get; set; }
        public string Explanation { get; set; }
        public List<Question> Questions = new List<Question>();

        public void AddQuestion(List<string> text, List<string> ChoiceText, List<bool> Correct)
        {
            List<Choice> test = new List<Choice>();
            for (int i = 0; i < ChoiceText.Count ; i++)
            {
                test.Add(new Choice(ChoiceText[i], Correct[i]));
            }
            Questions.Add(new Question(text, test));
        }

        public string question(int index)
        {
            return Questions[index].Text[index];
        }
    }
}
