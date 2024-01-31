using Alito.Classes;
using Alito.Classes.Helpers;
using System.Windows;

namespace Alito
{
    public partial class MainWindow : Window
    {
        internal BotLogic bot;
        public MainWindow()
        {
            InitializeComponent();
            var bot = new BotLogic();
            var json = new JSONHelper();
        }
    }
}
