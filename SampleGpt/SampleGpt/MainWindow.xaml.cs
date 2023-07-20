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

namespace SampleGpt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await RequestChatGptAsync();
        }

        private async Task RequestChatGptAsync()
        {
            var api = new OpenAI_API.OpenAIAPI("");
            var chat = api.Chat.CreateConversation();

            chat.AppendUserInput(textBox1.Text);

            var response = await chat.GetResponseFromChatbotAsync();
            textBox2.Text = response;
        }
    }
}
