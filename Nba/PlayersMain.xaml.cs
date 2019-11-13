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
using System.Data.Entity;

namespace Nba {
    /// <summary>
    /// Логика взаимодействия для PlayersMain.xaml
    /// </summary>
    public partial class PlayersMain : Page {
        int teamId;
        int seasonId;
        nbaEntities context = new nbaEntities();
        CollectionViewSource teamViewSource;
        CollectionViewSource seasonViewSource;

        public PlayersMain() {
            InitializeComponent();
            InitializeComponent();
            teamViewSource = ((CollectionViewSource)(FindResource("teamViewSource")));
            seasonViewSource = ((CollectionViewSource)(FindResource("seasonViewSource")));
            DataContext = this;
        }

        //Обработчик события загрузки страницы (событие Loaded в файле разметки
        //в разделе Page)
        private void OnPageLoad(object sender, RoutedEventArgs e) {
            //Обновить заголовок окна
            Window.GetWindow(this).Title = "Players Main";

            //Подготовить источники данных
            context.Seasons.Load();
            context.Teams.Load();
            seasonViewSource.Source = context.Seasons.Local;
            teamViewSource.Source = context.Teams.Local;
        }

        private void BackClick(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new Uri("VisitorMenu.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
