using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBeta
{
    [Serializable]
    class Question
    {
        string questionString;
        string answerA;
        string answerB;
        string answerC;
        string answerD;
        string feedback;
        string correctAnswer;

        public Question(string questionString, string answerA, string answerB, string answerC, string answerD, string feedback, string correctAnswer)
        {
            this.questionString = questionString;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
            this.feedback = feedback;
            this.correctAnswer = correctAnswer;
        }

        public Question()
        {
            this.questionString = string.Empty;
            this.answerA = string.Empty;
            this.answerB = string.Empty;
            this.answerC = string.Empty;
            this.answerD = string.Empty;
            this.feedback = string.Empty;
            this.correctAnswer = string.Empty;
        }

        public string QuestionString { get => questionString; set => questionString = value; }
        public string AnswerA { get => answerA; set => answerA = value; }
        public string AnswerB { get => answerB; set => answerB = value; }
        public string AnswerC { get => answerC; set => answerC = value; }
        public string AnswerD { get => answerD; set => answerD = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }

        public override string ToString()
        {
            return questionString;
        }
    }

}
