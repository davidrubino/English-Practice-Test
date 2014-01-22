using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class Answer
    {
        private string Title;
        private Boolean Truthfulness;

        public Answer(string title, Boolean truthfulness)
        {
            this.Title = title;
            this.Truthfulness = truthfulness;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public void SetTitle(string title)
        {
            this.Title = title;
        }

        public Boolean GetTruthfulness()
        {
            return this.Truthfulness;
        }

        public void SetTruthfulness(Boolean truthfulness)
        {
            this.Truthfulness = truthfulness;
        }
    }
}
