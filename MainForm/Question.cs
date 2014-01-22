using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class Question
    {
        private string Title;
        private Answer FirstAnswer, SecondAnswer, ThirdAnswer;

        public Question(string title, Answer first, Answer second, Answer third)
        {
            this.Title = title;
            this.FirstAnswer = first;
            this.SecondAnswer = second;
            this.ThirdAnswer = third;
        }

        public Answer GetRightAnswer(Question q)
        {
            if (q.GetFirstAnswer().GetTruthfulness() == true)
                return q.GetFirstAnswer();
            else if (q.GetSecondAnswer().GetTruthfulness() == true)
                return q.GetSecondAnswer();
            else
                return q.GetThirdAnswer();
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public Answer GetFirstAnswer()
        {
            return this.FirstAnswer;
        }

        public Answer GetSecondAnswer()
        {
            return this.SecondAnswer;
        }

        public Answer GetThirdAnswer()
        {
            return this.ThirdAnswer;
        }

    }
}
