﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers{ get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

       
        public bool IsCorrentAnswer(int choice)
        {
            return  CorrectAnswerIndex == choice;
        }



    }


}
