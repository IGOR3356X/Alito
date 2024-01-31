using System.Windows;
using Telegram.Bot;
using Telegram.Bot.Polling;

namespace Alito
{


    public partial class MainWindow : Window
    {
        private static ITelegramBotClient _botClient;
        private static ReceiverOptions _receiverOptions;
        public MainWindow()
        {
            InitializeComponent();
            _botClient = new TelegramBotClient("6719677792:AAHNkG5A943qr_if48dwEd0sLP8NmLut0zI");

        }
        

    }
}
