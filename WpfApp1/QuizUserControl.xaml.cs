using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for QuizUserControl.xaml
    /// </summary>
    public partial class QuizUserControl : UserControl
    {
        // create a new list of integers called question numbers
        // this interger will hold how many questions we have for this quiz and we will shuffle this inside the start game function
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // create 3 more integers called qNum that will control which question shows on the screen, i and score
        int qNum = 0;
        int i;
        int score;

        public QuizUserControl()
        {
            InitializeComponent();

            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            // this is the check answer event, this event is linked to each button on the canvas
            // when either of the buttons will be pressed we will run this event
            Button senderButton = sender as Button; // first check which button sent this event and link it to a local button inside of this event
            //ans1.Background = new SolidColorBrush(Colors.Red);
            // in the if statement below we will check if the button clicked on has a 1 tag inside of it, if it does then we will add 1 to the score
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            // if the qnum is less than 0 then we will reset the qnum integer to 0
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                // if the qnum is greater than 0 then we will add 1 to the qnum integer
                qNum++;
            }
            // update the score text label each time the buttons are pressed
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;
            // run the next question function
            NextQuestion();
        }
        private void RestartGame()
        {
            // restart game function will load all of the default values for this game
            score = 0; // set score to 0
            qNum = -1; // set qnum to -1
            i = 0; // set i to 0
            StartGame(); // run the start game function
        }
        private void NextQuestion()
        {
            // this function will check which question to show next and it will have all of the question and answer definitions
            // in the if statement below it will checking if the qnum integer is less than the total number of questions if it then we will set the value of i to the value of qnum
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                // if we have done below the number of questions we have available then we will restart the game
                //RestartGame();
                ans1.Visibility = Visibility.Hidden; 
                ans2.Visibility=Visibility.Hidden;
                ans3.Visibility=Visibility.Hidden; 
                ans4.Visibility=Visibility.Hidden;
                txtQuestion.Visibility=Visibility.Hidden;
                qImage.Visibility=Visibility.Hidden;
                Canvas.SetLeft(scoreText, 319);
                Canvas.SetTop(scoreText, 103);
                TryAgainQuiz.Visibility = Visibility.Visible;
            }
            // below we are running a foreach loop where will check for each button inside of the canvas and when we find them we will set their tag to 0 and background to dakr salmon colour
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }
            // below you have all of the question and answers template
            // you can add your own questions to the txtQuestion section
            // and add your own answers inside of the ans1, ans2, ans3 content and so. 
            // this switch statement will check what value is inside of i integer and show the questions based on that value
            switch (i)
            {
                case 1:
                    txtQuestion.Text = "What is the population of Lebanon?"; // this the question for the quiz
                    ans1.Content = "2 millions"; // each of the buttons can have their own answers in this game
                    ans2.Content = "4 millions";
                    ans3.Content = "5 millions";
                    ans4.Content = "8 millions";
                    ans2.Tag = "1"; // here we tell the program which one of the answers above is the right answer by adding the 1 inside of the tag for the button. 
                    // in this example we adding 1 inside of ans2 or button 2
                    // so when the button is clicked the game will know which is the correct answer and it add 1 to the score for the game
                    //qImage.Source = new BitmapImage(new Uri("cedar 2.png")); // here we will load the 1st image inside of the qimage 
                    //string abc = "/Images/Quiz/Question1.png";
                    //BitmapImage bitmap = new BitmapImage(new Uri("cedar 2.png"));
                    //Uri imageUri = new Uri("Images/Quiz/Question1.png");
                    qImage.Source = new BitmapImage(new Uri("/Question1.png", UriKind.Relative));
                    break; // when this condition is met the program will break the switch statement here and wait for the next one
                           // rest of the condition will follow the same principle as this one
                case 2:
                    txtQuestion.Text = "What is the area of Lebanon?";
                    ans1.Content = "11000 km2";
                    ans2.Content = "7060 km2";
                    ans3.Content = "10452 km2";
                    ans4.Content = "17230 km2";
                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question2.png", UriKind.Relative));
                    break;
                case 3:
                    txtQuestion.Text = "Lebanon has access to the: ";
                    ans1.Content = "Mediterranean Sea";
                    ans2.Content = "Black sea";
                    ans3.Content = "Red sea";
                    ans4.Content = "Baltic sea";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question3.png", UriKind.Relative));
                    break;
                case 4:
                    txtQuestion.Text = "How many religions The country recognizes:";
                    ans1.Content = "18 religious communities";
                    ans2.Content = "2 religious communities";
                    ans3.Content = "10 religious communities";
                    ans4.Content = "6 religious communities";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question4.png", UriKind.Relative));
                    break;
                case 5:
                    txtQuestion.Text = "What is the capital city of Lebanon?";
                    ans1.Content = "Beirut";
                    ans2.Content = "Tripoli";
                    ans3.Content = "Harrissa";
                    ans4.Content = "Byblos";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question5.png", UriKind.Relative));
                    break;
                case 6:
                    txtQuestion.Text = "how much is the highest mountain in Lebanon?";
                    ans1.Content = "3,088 meters";
                    ans2.Content = "1502 meters";
                    ans3.Content = "6900 meters";
                    ans4.Content = "4532 meters";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question6.png", UriKind.Relative));
                    break;
                case 7:
                    txtQuestion.Text = "What is the type of authority in Lebanon";
                    ans1.Content = "Parliamentary democratic republic";
                    ans2.Content = "Royal";
                    ans3.Content = "Dictatorship";
                    ans4.Content = "Federalism";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question7.png", UriKind.Relative));
                    break;
                case 8:
                    txtQuestion.Text = "In what year Lebanon got its independence ";
                    ans1.Content = "1943";
                    ans2.Content = "1990";
                    ans3.Content = "2000";
                    ans4.Content = "1955";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question8.jpg", UriKind.Relative));
                    break;
                case 9:
                    txtQuestion.Text = "What is main language in lebanon";
                    ans1.Content = "Arabic";
                    ans2.Content = "Aramic";
                    ans3.Content = "Persian";
                    ans4.Content = "Hebrew";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question9.jpg", UriKind.Relative));
                    break;
                case 10:
                    txtQuestion.Text = "When was the city of Byblos founded?";
                    ans1.Content = "1500 years ago";
                    ans2.Content = "2300 years ago";
                    ans3.Content = "3800 years ago";
                    ans4.Content = "5000 years ago";
                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("/Question10.jpg", UriKind.Relative));
                    break;
            }
        }
        private void StartGame()
        {
            // this is the start game function
            // inside of this function we will randomise the questions list and save it back into the list 
            // create a new randomlist variable and use the line below to randomise the order of the content
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            // save the random list to the question numbers list again
            questionNumbers = randomList;
            // empty the question order label on the canvas
            questionOrder.Content = null;
            // run a for loop to add the value which will display the randomised list to the display so we can see how the list has been ramdomised
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }

        private void RestartGame(object sender, RoutedEventArgs e)
        {

            ans1.Visibility = Visibility.Visible;
            ans2.Visibility = Visibility.Visible;
            ans3.Visibility = Visibility.Visible;
            ans4.Visibility = Visibility.Visible;
            txtQuestion.Visibility = Visibility.Visible;
            qImage.Visibility = Visibility.Visible;
            Canvas.SetLeft(scoreText, 0);
            Canvas.SetTop(scoreText, 0);
            TryAgainQuiz.Visibility = Visibility.Hidden;

            // restart game function will load all of the default values for this game
            score = 0; // set score to 0
            qNum = -1; // set qnum to -1
            i = 0; // set i to 0
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;
            StartGame(); // run the start game function
        }
    }
}
