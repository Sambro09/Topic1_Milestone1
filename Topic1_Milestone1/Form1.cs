namespace Topic1_Milestone1
{
    public partial class Form1 : Form
    {
        // integer to decide page number
        int pageNumber = 0;

        // string variables
        string greeting, adjective, noun,
            greetingPage = "Greeting",
            adjectivePage = "Adjective",
            nounPage = "Noun",
            resultPage = "Result!",
            empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // increase page number everytime button is pressed to move to next page
            pageNumber++;

            if (pageNumber == 1)
            {
                // take the input and assign it to a string variable, then clear the text box
                greeting = inputBox.Text;
                inputBox.Text = empty;

                // change the form and label name
                inputLabel.Text = adjectivePage;
                Text = adjectivePage;
            }
            else if (pageNumber == 2)
            {
                // take the input and assign it to a string variable, then clear the text box
                adjective = inputBox.Text;
                inputBox.Text = empty;

                // change the form and label name
                inputLabel.Text = nounPage;
                Text = nounPage;
            }
            else if (pageNumber == 3)
            {
                // take the input and assign it to a string variable, then clear and hide the text box
                noun = inputBox.Text;
                inputBox.Text = empty;
                inputBox.Visible = false;

                // take the 3 assigned strings and show them on the label
                inputLabel.Text = greeting + " " + adjective + " " + noun;

                // switch buttons
                nextButton.Visible = false;
                restartButton.Visible = true;

                // change the form name
                Text = resultPage;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            pageNumber = 0;

            inputBox.Text = empty;

            restartButton.Visible = false;
            inputBox.Visible = true;
            nextButton.Visible = true;

            inputLabel.Text = greetingPage;
            Text = greetingPage;

        }
    }
}