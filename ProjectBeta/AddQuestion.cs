using System;
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
    public delegate void QuestionAdded(Question q);
    public partial class AddQuestion : Form
    {
        public AddQuestion NewQuestionAdded;

        public AddQuestion()
        {
            InitializeComponent();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            //tracks valid input
            bool inputValid = true;

            //loops controls to see if each contains any value
            foreach(Control c in this.Controls)
            {
                if(c == null)
                {
                    inputValid = false;
                }
            }

            //runs if all fields have values
            if (inputValid)
            {
                Question tmpQuestion = new Question();
            }

            else
            {
                //some sort of error update (status bar?)
            }
        }

    }
}
