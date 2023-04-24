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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for facts.xaml
    /// </summary>
    public partial class facts : Window
    {
        public facts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //StackPanel myStackPanel = new StackPanel();

            //// Create a FlowDocument to contain content for the RichTextBox.
            //FlowDocument myFlowDoc = new FlowDocument();

            //// Create a Run of plain text and some bold text.
            //Run myRun = new Run("This is flow content and you can ");
            //Bold myBold = new Bold(new Run("edit me!"));

            //// Create a paragraph and add the Run and Bold to it.
            //Paragraph myParagraph = new Paragraph();
            //myParagraph.Inlines.Add(myRun);
            //myParagraph.Inlines.Add(myBold);

            //// Add the paragraph to the FlowDocument.
            //myFlowDoc.Blocks.Add(myParagraph);

            //RichTextBox myRichTextBox = new RichTextBox();

            //// Add initial content to the RichTextBox.
            //myRichTextBox.Document = myFlowDoc;

            //myStackPanel.Children.Add(myRichTextBox);
            //this.Content = myStackPanel;

        }
    }
}
