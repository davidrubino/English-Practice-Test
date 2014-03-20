using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class QuizzModel
    {
        private int index;
        private List<string> userAnswers, rightAnswers;

        public QuizzModel()
        {
            this.index = 0;
            this.userAnswers = new List<string>();
            this.rightAnswers = new List<string>();
        }

        public void SetIndex(int i)
        {
            this.index = i;
        }

        public int GetIndex()
        {
            return this.index;
        }

        public List<string> GetRightAnswers(List<Question> questionsList)
        {
            List<string> answers = new List<string>();
            for (int i = 0; i < questionsList.Count; i++)
            {
                answers.Add(questionsList.ElementAt(i).GetRightAnswer(questionsList.ElementAt(i)).GetTitle());
            }
            return answers;
        }

        public string ShowRightAnswers()
        {
            string content = "";
            for (int i = 0; i < this.rightAnswers.Count; i++)
            {
                content += "\n" + this.rightAnswers.ElementAt(i);
            }
            return content;
        }

        public string ShowUserAnswers()
        {
            string content = "";
            if (this.userAnswers.Any())
            {
                for (int i = 0; i < this.userAnswers.Count; i++)
                {
                    content += "\n" + this.userAnswers.ElementAt(i);
                }
            }
            else
            {
                content = "There are no answers yet.";
            }
            return content;
        }

        public string CheckResults()
        {
            int score = 0;
            int totalAnswers = this.rightAnswers.Count;
            for (int i = 0; i < this.userAnswers.Count; i++)
            {
                if (this.rightAnswers.Contains(this.userAnswers.ElementAt(i)))
                    score++;
            }
            return "Correct answers: " + score + " out of " + totalAnswers;
        }
    }
}
