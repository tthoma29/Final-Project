﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBeta
{
    public partial class MainWindow : Form
    {
        BindingList<Question> questionList;
        AddQuestion addQuestion;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            questionList = new BindingList<Question>();
            questionListBox.DataSource = questionList;
            addQuestion = new AddQuestion();
        }

        private void newQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addQuestion.Show();
        }

        private void saveQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
