using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            random = new Random();

            ActivePage(0);
        }

        private Random random;

        stGame Game;

        stQuestion NewQuestion;

        private int QuestionTime;

        struct stQuestion
        {
            public int FirstNumber;
            public int SecondNumber;
            public int CorrectAnswer;
            public int UserAnswer;
            public bool QuestionResult;
            public char Operation;
            public int AnswerTime;
        }

        struct stGame
        {
            public enLevel Level;
            public enPage Page;
            public enOperation Operation;
            public stQuestion[] Questions;
            public int RoundsNumber;
            public int QuestionNumber;
            public int CorrectAnswer;
            public int WrongAnswer;
            public int Timer;
            public int RoundNumber;
        }

        enum enPage
        {
            starGame = 0,
            PlayGame = 1,
            FinalResult = 2,
        }

        enum enLevel
        {
            Easy = 1,
            Mid = 2,
            Hard = 3,
            Mix = 4,
        }

        enum enOperation
        {
            Add = 1,
            Sub = 2,
            Mult = 3,
            Divid = 4,
            Mix = 5
        }

        // game prpo; 
        private void SetGameLevel()
        {
            switch (comboBoxLevel.Text)
            {
                case "Easy":
                    Game.Level = enLevel.Easy;

                    break;

                case "Mid":
                    Game.Level = enLevel.Mid;


                    break;

                case "Hard":
                    Game.Level = enLevel.Hard;

                    break;

                case "Mix":
                    Game.Level = enLevel.Mix;

                    break;
            }
            lblChoseLevel.Text = $"( {comboBoxLevel.Text} )";
        }


        private void SetGameOperation()
        {
            switch (comboBoxOperation.Text)
            {
                case "+":
                    Game.Operation = enOperation.Add;
                    break;

                case "-":
                    Game.Operation = enOperation.Sub;

                    break;

                case "*":
                    Game.Operation = enOperation.Mult;

                    break;

                case "/":
                    Game.Operation = enOperation.Divid;

                    break;

                case "Mix":
                    Game.Operation = enOperation.Mix;

                    break;
            }
            lblChoseOperation.Text = $"( {comboBoxOperation.Text} )";


        }

        private void setGameRoundsNumber()
        {

            Game.RoundsNumber = int.Parse(numericUpDownRoundNumber.Value.ToString());


        }

        private void SetGamePage(int CorrentPage)
        {
            if (CorrentPage == 0)
            {
                Game.Page = enPage.starGame;
                return;
            }

            if (CorrentPage == 1)
            {
                Game.Page = enPage.PlayGame;
                return;
            }

            if (CorrentPage == 2)
            {
                Game.Page = enPage.FinalResult;
                return;
            }
        }

        private void SetGameQuestionTime()
        {
            Game.Timer = int.Parse(numericUpDownQTime.Value.ToString());

            QuestionTime = Game.Timer;
        }

        private void SetTimeQuestion()
        {

            Game.Questions[Game.QuestionNumber].AnswerTime = int.Parse(lblTimer.Text);

        }

        private string SetGameFinalResult()
        {
            if (Game.WrongAnswer > Game.CorrectAnswer)
            {
                return "( Loss )";
            }
            else if (Game.WrongAnswer == Game.CorrectAnswer)
            {
                return "( Draw )";
            }
            else
            {
                return "( Winner )";
            }

        }

        private void showFinalResult()
        {
            for (int i = 0; i < Game.RoundsNumber; i++)
            {
                TextBox Question = CreatetQurstionResult(i);

                flowLayoutPanelResults.Controls.Add(Question);
            }

            lblCorrectAnswer.Text = Game.CorrectAnswer.ToString();
            lblWrongAnswer.Text = Game.WrongAnswer.ToString();
            lblFinalResult.Text = SetGameFinalResult();

        }

        private void ResetGame()
        {
            Game.CorrectAnswer = 0;
            Game.WrongAnswer = 0;
            progressBar.Value = 0;
            Game.RoundsNumber = 0;

            numericUpDownRoundNumber.Value = 1;
            flowLayoutPanelResults.Controls.Clear();

            btnNextQuestion.Visible = true;
            btnFinalResult.Visible = false;


            lblFinalResult.Text = "0";
            lblWrongAnswer.Text = "0";
            lblCorrectAnswer.Text = "0";

            EnableOptionsBtns(true);

        }


        // question prop
        private char SetRandomOperation()
        {
            char[] arrOperation = { '+', '-', '*', '/' };
            char Operation = arrOperation[GetRandomNumberBetween(0, 3)];

            switch (Operation)
            {
                case '+':
                    return '+';

                case '-':
                    return '-';

                case '*':
                    return '*';

                default:

                    return '/';


            }
        }

        private int SetCourrectAnswer(int FirstNumber, int SecondNumber, char Operation)
        {
            switch (Operation)
            {
                case '+':
                    return FirstNumber + SecondNumber;

                case '-':
                    return FirstNumber - SecondNumber;


                case '*':
                    return FirstNumber * SecondNumber;

                default:
                    return FirstNumber / SecondNumber;

            }

        }

        private char SetQuestionOperation(enOperation Operation)
        {
            switch (Operation)
            {
                case enOperation.Add:
                    return '+';

                case enOperation.Mult:
                    return '*';


                case enOperation.Sub:
                    return '-';

                default:
                    return '/';

            }
        }

        private void MarkQuestionAsWrong()
        {
            Game.Questions[Game.QuestionNumber].QuestionResult = false;
            textBoxEnterYouAnswer.BackColor = Color.FromArgb(255, 87, 88);
            Game.WrongAnswer++;
        }

        private void MarkQuestionAsCorrect()
        {
            Game.Questions[Game.QuestionNumber].QuestionResult = true;
            textBoxEnterYouAnswer.BackColor = Color.FromArgb(43, 127, 44);
            Game.CorrectAnswer++;


        }

        private void ShowQuestions(int QustionIndex)
        {

            Game.RoundNumber = Game.QuestionNumber + 1;

            lblRoundNumber.Text = $"( {Game.RoundNumber.ToString()} / {Game.RoundsNumber} )";
            lblNumberOne.Text = Game.Questions[QustionIndex].FirstNumber.ToString();
            lblNumberTwo.Text = Game.Questions[QustionIndex].SecondNumber.ToString();
            lblOperation.Text = Game.Questions[QustionIndex].Operation.ToString();
            textBoxEnterYouAnswer.BackColor = Color.FromArgb(43, 43, 43);

            SetOptionsNumber();

            //start timer
            timer.Start();
        }



        //create questions
        private stQuestion GenerateQuestion()
        {

            if (Game.Operation == enOperation.Mix)
            {
                NewQuestion.Operation = SetRandomOperation();
            }
            else
            {

                NewQuestion.Operation = SetQuestionOperation(Game.Operation);

            }


            if (Game.Level == enLevel.Mix)
            {
                NewQuestion.FirstNumber = GetRandomNumberBetween(1, 100);
                NewQuestion.SecondNumber = GetRandomNumberBetween(1, 100);
                NewQuestion.CorrectAnswer = SetCourrectAnswer(NewQuestion.FirstNumber, NewQuestion.SecondNumber, NewQuestion.Operation);
            }

            if (Game.Level == enLevel.Easy)
            {
                NewQuestion.FirstNumber = GetRandomNumberBetween(1, 10);
                NewQuestion.SecondNumber = GetRandomNumberBetween(1, 10);
                NewQuestion.CorrectAnswer = SetCourrectAnswer(NewQuestion.FirstNumber, NewQuestion.SecondNumber, NewQuestion.Operation);

            }

            if (Game.Level == enLevel.Mid)
            {
                NewQuestion.FirstNumber = GetRandomNumberBetween(10, 50);
                NewQuestion.SecondNumber = GetRandomNumberBetween(10, 50);
                NewQuestion.CorrectAnswer = SetCourrectAnswer(NewQuestion.FirstNumber, NewQuestion.SecondNumber, NewQuestion.Operation);

            }

            if (Game.Level == enLevel.Hard)
            {
                NewQuestion.FirstNumber = GetRandomNumberBetween(50, 100);
                NewQuestion.SecondNumber = GetRandomNumberBetween(50, 100);
                NewQuestion.CorrectAnswer = SetCourrectAnswer(NewQuestion.FirstNumber, NewQuestion.SecondNumber, NewQuestion.Operation);

            }

            return NewQuestion;
        }

        private TextBox CreateTextBox()
        {
            TextBox TextBox = new TextBox();
            TextBox.ReadOnly = true;
            TextBox.Size = new Size(302, 250);
            TextBox.Font = new Font(FontFamily.GenericSansSerif, 15);

            return TextBox;
        }

        private TextBox CreateTxtBoxQuestionFinalResult(stQuestion Question)
        {

            TextBox TxtBoxQuestionFinalResult = CreateTextBox();
            TxtBoxQuestionFinalResult.Text = $"{Question.FirstNumber}";
            TxtBoxQuestionFinalResult.Text += $" {Question.Operation}";
            TxtBoxQuestionFinalResult.Text += $" {Question.SecondNumber}";
            TxtBoxQuestionFinalResult.Text += $" = {Question.UserAnswer}";

            TxtBoxQuestionFinalResult.Text += $"    You Answerd in:({Game.Timer - Question.AnswerTime}s)";


            if (Question.QuestionResult)
            {
                TxtBoxQuestionFinalResult.BackColor = Color.Green;
            }

            else
            {
                TxtBoxQuestionFinalResult.BackColor = Color.Red;

            }

            return TxtBoxQuestionFinalResult;
        }

        private TextBox CreatetQurstionResult(int QuestionNumber)
        {

            stQuestion Question = new stQuestion();
            Question.FirstNumber = Game.Questions[QuestionNumber].FirstNumber;
            Question.SecondNumber = Game.Questions[QuestionNumber].SecondNumber;
            Question.Operation = Game.Questions[QuestionNumber].Operation;
            Question.QuestionResult = Game.Questions[QuestionNumber].QuestionResult;
            Question.UserAnswer = Game.Questions[QuestionNumber].UserAnswer;
            Question.AnswerTime = Game.Questions[QuestionNumber].AnswerTime;

            TextBox TxtBoxQuestionResult = CreateTxtBoxQuestionFinalResult(Question);

            return TxtBoxQuestionResult;

        }

        private void GetneratQuestions()
        {
            Game.Questions = new stQuestion[100];

            for (int i = 0; i < Game.RoundsNumber; i++)
            {
                Game.Questions[i] = GenerateQuestion();
            }
        }



        //check user answer 
        private bool CheckUserAnswer()
        {
            if (string.IsNullOrWhiteSpace(textBoxEnterYouAnswer.Text))
            {
                errorProvider.SetError(textBoxEnterYouAnswer, "Enter Number First");

                return false;
            }

            else if (textBoxEnterYouAnswer.Text == "Enter Your Answer ")
            {
                errorProvider.SetError(textBoxEnterYouAnswer, "Enter Number First");

                return false;
            }
            else
            {
                errorProvider.Clear();
                btnNextQuestion.Enabled = true;
                return true;
            }

        }

        private int GetCorrectAnswer()
        {
            return Game.Questions[Game.QuestionNumber].CorrectAnswer;

        }

        private int GetUserAnswer()
        {
            Game.Questions[Game.QuestionNumber].UserAnswer = int.Parse(textBoxEnterYouAnswer.Text);

            return Game.Questions[Game.QuestionNumber].UserAnswer;

        }




        //options 
        private void CheckOption(Button btnOption)
        {
            textBoxEnterYouAnswer.Text = btnOption.Text;

            //stop timer 
            timer.Stop();

            if (CheckUserAnswer())
            {
                SetTimeQuestion();



                if (GetCorrectAnswer() == GetUserAnswer())
                {
                    MarkQuestionAsCorrect();
                }
                else
                {
                    MarkQuestionAsWrong();
                }

                //Check if game over or not
                GameOver();
            }
        }

        private int SetOption()
        {
            switch (Game.Level)
            {
                case enLevel.Easy:
                    return GetRandomNumberBetween(1, 10);

                case enLevel.Mid:
                    return GetRandomNumberBetween(10, 50);

                case enLevel.Hard:
                    return GetRandomNumberBetween(50, 100);

                default:
                    return GetRandomNumberBetween(1, 100);
            }
        }

        private void SetCorrectOption()
        {
            groupBoxOptions.Controls[GetRandomNumberBetween(0, 3)].Text = Game.Questions[Game.QuestionNumber].CorrectAnswer.ToString();
        }

        private void SetOptionsNumber()
        {
            btnOption1.Text = SetOption().ToString();
            btnOption2.Text = SetOption().ToString();
            btnOption3.Text = SetOption().ToString();
            btnOption4.Text = SetOption().ToString();

            SetCorrectOption();

        }

        private void EnableOptionsBtns(bool Disable)
        {
            btnOption1.Enabled = Disable;
            btnOption2.Enabled = Disable;
            btnOption3.Enabled = Disable;
            btnOption4.Enabled = Disable;

        }


        //Pages
        private void ActivePage(int PageIndex)
        {
            tabControlMain.SelectedTab = tabControlMain.TabPages[PageIndex];

            switch (Game.Page)
            {
                case enPage.starGame:

                    tabPagePlayGame.Enabled = false;
                    tabPageFinalResult.Enabled = false;
                    tabPageStartGame.Enabled = true;


                    break;

                case enPage.PlayGame:

                    tabPagePlayGame.Enabled = true;
                    tabPageFinalResult.Enabled = false;
                    tabPageStartGame.Enabled = false;

                    break;

                case enPage.FinalResult:

                    tabPagePlayGame.Enabled = false;
                    tabPageFinalResult.Enabled = true;
                    tabPageStartGame.Enabled = false;

                    break;
            }
        }


        private void MoveToPage(enPage Page)
        {
            Game.Page = Page;

            switch (Page)
            {
                case enPage.starGame:

                    ActivePage(0);
                    break;

                case enPage.PlayGame:

                    ActivePage(1);
                    break;

                case enPage.FinalResult:

                    ActivePage(2);
                    break;
            }
        }


        //random
        private int GetRandomNumberBetween(int min, int max)
        {
            int RandomNumber = random.Next(min, max + 1);

            return RandomNumber;

        }



        //timer 
        private void ResetTimer()
        {

            lblTimer.Text = Game.Timer.ToString();

            QuestionTime = Game.Timer;

            timer.Start();

        }




        //progressPar
        private void IcrementProgress()
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 100 / Game.RoundsNumber;
            }

        }





        //start and end
        private void StartGame()
        {

            SetGameLevel();

            SetGameOperation();

            setGameRoundsNumber();

            SetGameQuestionTime();

            GetneratQuestions();

            MoveToPage(enPage.PlayGame);

            ShowQuestions(Game.QuestionNumber = 0);
        }




        private void GameOver()
        {
            if (Game.QuestionNumber == Game.RoundsNumber - 1)
            {
                IcrementProgress();

                btnNextQuestion.Visible = false;

                btnFinalResult.Visible = true;

                EnableOptionsBtns(false);
            }
        }




        //events
        private void btnOption_Click(object sender, EventArgs e)
        {

            CheckOption((Button)sender);

            EnableOptionsBtns(false);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {

            StartGame();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            EnableOptionsBtns(true);

            IcrementProgress();

            ResetTimer();

            textBoxEnterYouAnswer.Text = null;

            Game.QuestionNumber++;

            ShowQuestions(Game.QuestionNumber);

        }

        private void btnFinalResult_Click(object sender, EventArgs e)
        {
            MoveToPage(enPage.FinalResult);

            showFinalResult();

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            QuestionTime--;

            lblTimer.Text = $"{QuestionTime.ToString()}";

            if (QuestionTime == 0)
            {
                timer.Stop();

                MarkQuestionAsWrong();

                btnNextQuestion.Enabled = true;

                GameOver();

                btnNextQuestion.PerformClick();

            }

        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {

            ResetGame();

            MoveToPage(enPage.starGame);
        }


    }
}
