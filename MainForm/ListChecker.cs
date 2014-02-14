using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class ListChecker
    {
        private List<string> correctAnswersList;
        private List<string> userAnswersList;
        private UserInputAnswersForm userInputAnswerForm;

        public ListChecker(UserInputAnswersForm userInputAnswerForm)
        {
            this.correctAnswersList = new List<string>();
            this.userAnswersList = new List<string>();
            this.userInputAnswerForm = userInputAnswerForm;
            FillCorrectAnswersList();
        }

        public void FillCorrectAnswersList()
        {
            this.correctAnswersList.Add("have");
            this.correctAnswersList.Add("in");
            this.correctAnswersList.Add("to");
            this.correctAnswersList.Add("into");
            this.correctAnswersList.Add("showcasing");
            this.correctAnswersList.Add("walkways");
            this.correctAnswersList.Add("latest");
            this.correctAnswersList.Add("has");
            this.correctAnswersList.Add("about");
            this.correctAnswersList.Add("seen");
            this.correctAnswersList.Add("accessible");
            this.correctAnswersList.Add("at");
            this.correctAnswersList.Add("are");
            this.correctAnswersList.Add("has");
            this.correctAnswersList.Add("at");
            this.correctAnswersList.Add("to");
            this.correctAnswersList.Add("to");
            this.correctAnswersList.Add("operating systems");
            this.correctAnswersList.Add("its");
            this.correctAnswersList.Add("did not");
            this.correctAnswersList.Add("in");
            this.correctAnswersList.Add("launched");
            this.correctAnswersList.Add("more");
            this.correctAnswersList.Add("scale");
            this.correctAnswersList.Add("have not");
            this.correctAnswersList.Add("company");
            this.correctAnswersList.Add("any");
            this.correctAnswersList.Add("from");
            this.correctAnswersList.Add("in");
            this.correctAnswersList.Add("to");
            this.correctAnswersList.Add("through");
            this.correctAnswersList.Add("data");
            this.correctAnswersList.Add("called");
            this.correctAnswersList.Add("every");
            this.correctAnswersList.Add("aside");
            this.correctAnswersList.Add("limited");
            this.correctAnswersList.Add("as");
            this.correctAnswersList.Add("available");
            this.correctAnswersList.Add("were");
            this.correctAnswersList.Add("have");
            this.correctAnswersList.Add("privacy");
            this.correctAnswersList.Add("into");
            this.correctAnswersList.Add("stores");
            this.correctAnswersList.Add("looked");
            this.correctAnswersList.Add("as");
            this.correctAnswersList.Add("time");
            this.correctAnswersList.Add("able to");
            this.correctAnswersList.Add("hike");
            this.correctAnswersList.Add("down");
            this.correctAnswersList.Add("excellent");
            this.correctAnswersList.Add("into");
            this.correctAnswersList.Add("will not");
            this.correctAnswersList.Add("much");
            this.correctAnswersList.Add("prepare");
            this.correctAnswersList.Add("what");
            this.correctAnswersList.Add("much");
            this.correctAnswersList.Add("valuable");
        }

        public int CheckAnswers()
        {
            int score = 0;
            for (int i = 0; i < this.correctAnswersList.Count; i++)
            {
                for (int j = 0; j < this.userAnswersList.Count; j++)
                {
                    if (this.userAnswersList.ElementAt(j) == this.correctAnswersList.ElementAt(i))
                    {
                        score++;
                    }
                }
            }
            return score;
        }

        public string ShowScore()
        {
            return "Congratulations! You have " + CheckAnswers() + " correct answers.";
        }

        public void FillUserAnswersList()
        {
            for (int i = 0; i < 57; i++)
            {
                string o = this.userInputAnswerForm.GetDataTable().Rows[i]["Your answer"].ToString();
                this.userAnswersList.Add(o);
            }
        }

        public string UserAnswersListToString()
        {
            string str = "";
            if (this.userAnswersList.Any())
            {
                for (int i = 0; i < this.userAnswersList.Count; i++)
                {
                    str += this.userAnswersList.ElementAt(i)+"\n";
                }
            }
            else
            {
                str = "No data in the list.";
            }
            return str;
        }

        public List<string> GetUserAnswersList()
        {
            return this.userAnswersList;
        }
    }
}
