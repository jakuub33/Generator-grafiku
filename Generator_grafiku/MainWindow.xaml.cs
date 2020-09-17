using System.Windows;
using System.Windows.Media;

namespace Generator_grafiku
{
    /// <summary>
    /// Aplikacja, która generuje grafik dla 5 zespołów.
    /// </summary>
    public partial class MainWindow : Window
    {
        int countChecked;
        bool v1, v2, v3, v4, v5;
        bool a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, e1, e2, e3;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Guzik generujący grafik.
        /// </summary>
        private void BtnCreate_Click(object sender, RoutedEventArgs x)
        {         
            if (!v5) //Jeśli v5 jest true to oznacza, że grafik już istnieje, więc trza najpierw go wyczyścic.
            {
                if (v1 && v2 && v3)  //Jeśli 3 zespoły zostały zaznaczone, stwórz grafik.
                {                    
                    BtnClear.Visibility = Visibility.Visible;
                    NewTab.Visibility = Visibility.Hidden;
                    ColorTab.Visibility = Visibility.Visible;
                    HoursInfo.Visibility = Visibility.Visible;

                    //Sprawdzam, która wersja jest przydzielona do którego zespołu
                    CheckVersionA();
                    CheckVersionB();
                    CheckVersionC();
                    CheckVersionD();
                    CheckVersionE();
                }
                else
                {
                    MessageBox.Show("Najpierw zaznacz 3 zespoły!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Najpierw wyczyść stary grafik!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
            }            
        }

        /// <summary>
        /// Sprawdza wersje zespołu E.
        /// </summary>
        private void CheckVersionE()
        {
            if (cbE.IsChecked == true)
            {
                if (e1)
                {
                    teamE.Foreground = Brushes.Red;
                }
                else if (e2)
                {
                    teamE.Foreground = Brushes.LimeGreen;
                }
                else if (e3)
                {
                    teamE.Foreground = Brushes.Gold;
                }
            }
            else
            {
                if (!v4)
                {
                    v4 = true;
                    teamE.Foreground = Brushes.Orchid;
                }
                else
                {
                    v5 = true;
                    teamE.Foreground = Brushes.DeepSkyBlue;
                }
            }
        }

        /// <summary>
        /// Sprawdza wersje zespołu D.
        /// </summary>
        private void CheckVersionD()
        {
            if (cbD.IsChecked == true)
            {
                if (d1)
                {
                    teamD.Foreground = Brushes.Red;
                }
                else if (d2)
                {
                    teamD.Foreground = Brushes.LimeGreen;
                }
                else if (d3)
                {
                    teamD.Foreground = Brushes.Gold;
                }
            }
            else
            {
                if (!v4)
                {
                    v4 = true;
                    teamD.Foreground = Brushes.Orchid;
                }
                else
                {
                    v5 = true;
                    teamD.Foreground = Brushes.DeepSkyBlue;
                }
            }
        }

        /// <summary>
        /// Sprawdza wersje zespołu C.
        /// </summary>
        private void CheckVersionC()
        {
            if (cbC.IsChecked == true)
            {
                if (c1)
                {
                    teamC.Foreground = Brushes.Red;
                }
                else if (c2)
                {
                    teamC.Foreground = Brushes.LimeGreen;
                }
                else if (c3)
                {
                    teamC.Foreground = Brushes.Gold;
                }
            }
            else
            {
                if (!v4)
                {
                    v4 = true;
                    teamC.Foreground = Brushes.Orchid;
                }
                else
                {
                    v5 = true;
                    teamC.Foreground = Brushes.DeepSkyBlue;
                }
            }
        }

        /// <summary>
        /// Sprawdza wersje zespołu B.
        /// </summary>
        private void CheckVersionB()
        {
            if (cbB.IsChecked == true)
            {
                if (b1)
                {
                    teamB.Foreground = Brushes.Red;
                }
                else if (b2)
                {
                    teamB.Foreground = Brushes.LimeGreen;
                }
                else if (b3)
                {
                    teamB.Foreground = Brushes.Gold;
                }
            }
            else
            {
                if (!v4)
                {
                    v4 = true;
                    teamB.Foreground = Brushes.Orchid;
                }
                else
                {
                    v5 = true;
                    teamB.Foreground = Brushes.DeepSkyBlue;
                }
            }
        }

        /// <summary>
        /// Sprawdza wersje zespołu A.
        /// </summary>
        private void CheckVersionA()
        {
            if (cbA.IsChecked == true)
            {
                if (a1)
                {
                    teamA.Foreground = Brushes.Red;
                }
                else if (a2)
                {
                    teamA.Foreground = Brushes.LimeGreen;
                }
                else if (a3)
                {
                    teamA.Foreground = Brushes.Gold;
                }
            }
            else
            {
                if (!v4)
                {
                    v4 = true;
                    teamA.Foreground = Brushes.Orchid;
                }
                else
                {
                    v5 = true;
                    teamA.Foreground = Brushes.DeepSkyBlue;
                }
            }
        }

        /// <summary>
        /// Guzik, który czyści uzupełniony grafik.
        /// </summary>
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            BtnClear.Visibility = Visibility.Hidden;
            NewTab.Visibility = Visibility.Visible;
            ColorTab.Visibility = Visibility.Hidden;
            HoursInfo.Visibility = Visibility.Hidden;            
            cbA.IsChecked = cbB.IsChecked = cbC.IsChecked = cbD.IsChecked = cbE.IsChecked = false;
            v4 = v5 = false;
            teamA.Foreground = teamB.Foreground = teamC.Foreground = teamD.Foreground = teamE.Foreground = Brushes.Black;
            countChecked = 0; //Zeruje ilość zaznaczeń, aby było można dodać nowy grafik.
        }

        /// <summary>
        /// Wykonuje się, gdy zaznaczymy CheckBox A.
        /// </summary>
        private void A_Checked(object sender, RoutedEventArgs e)
        {
            if (countChecked < 3) //Sprawdzam czy zostały już wybrane 3 zespoły.
            {
                if (!v1)
                {
                    countChecked++;
                    v1 = true;
                    a1 = true;
                }
                else if (!v2)
                {
                    countChecked++;
                    v2 = true;
                    a2 = true;
                }
                else if (!v3)
                {
                    countChecked++;
                    v3 = true;
                    a3 = true;
                }
            }
            else
            {
                MessageBox.Show("Trzy zespoły już są zaznaczone!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                cbA.IsChecked = false;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy zaznaczymy CheckBox B.
        /// </summary>
        private void B_Checked(object sender, RoutedEventArgs e)
        {
            //Checking(b1, b2, b3, cbB);
            if (countChecked < 3) //Sprawdzam czy zostały już wybrane 3 zespoły.
            {
                if (!v1)
                {
                    countChecked++;
                    v1 = true;
                    b1 = true;
                }
                else if (!v2)
                {
                    countChecked++;
                    v2 = true;
                    b2 = true;
                }
                else if (!v3)
                {
                    countChecked++;
                    v3 = true;
                    b3 = true;
                }
            }
            else
            {
                MessageBox.Show("Trzy zespoły już są zaznaczone!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                cbB.IsChecked = false;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy zaznaczymy CheckBox C.
        /// </summary>
        private void C_Checked(object sender, RoutedEventArgs e)
        {
            //Checking(c1, c2, c3, cbC);
            if (countChecked < 3) //Sprawdzam czy zostały już wybrane 3 zespoły.
            {
                if (!v1)
                {
                    countChecked++;
                    v1 = true;
                    c1 = true;
                }
                else if (!v2)
                {
                    countChecked++;
                    v2 = true;
                    c2 = true;
                }
                else if (!v3)
                {
                    countChecked++;
                    v3 = true;
                    c3 = true;
                }
            }
            else
            {
                MessageBox.Show("Trzy zespoły już są zaznaczone!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                cbC.IsChecked = false;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy zaznaczymy CheckBox D.
        /// </summary>
        private void D_Checked(object sender, RoutedEventArgs e)
        {
            //Checking(d1, d2, d3, cbD);
            if (countChecked < 3) //Sprawdzam czy zostały już wybrane 3 zespoły.
            {
                if (!v1)
                {
                    countChecked++;
                    v1 = true;
                    d1 = true;
                }
                else if (!v2)
                {
                    countChecked++;
                    v2 = true;
                    d2 = true;
                }
                else if (!v3)
                {
                    countChecked++;
                    v3 = true;
                    d3 = true;
                }
            }
            else
            {
                MessageBox.Show("Trzy zespoły już są zaznaczone!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                cbD.IsChecked = false;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy zaznaczymy CheckBox E.
        /// </summary>
        private void E_Checked(object sender, RoutedEventArgs e)
        {
            //Checking(e1, e2, e3, cbE);
            if (countChecked < 3) //Sprawdzam czy zostały już wybrane 3 zespoły.
            {
                if (!v1)
                {
                    countChecked++;
                    v1 = true;
                    e1 = true;
                }
                else if (!v2)
                {
                    countChecked++;
                    v2 = true;
                    e2 = true;
                }
                else if (!v3)
                {
                    countChecked++;
                    v3 = true;
                    e3 = true;
                }
            }
            else
            {
                MessageBox.Show("Trzy zespoły już są zaznaczone!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                cbE.IsChecked = false;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy CheckBox A jest odznaczony.
        /// </summary>
        private void A_UnChecked(object sender, RoutedEventArgs e)
        {
            //UnChecking(a1, a2, a3);
            if (a1) //Jeśli dla zespołu została przypisana wersja 1.
            {
                v1 = false;
                a1 = false;
                countChecked--;
            }
            else if (a2)
            {
                v2 = false;
                a2 = false;
                countChecked--;
            }
            else if (a3)
            {
                v3 = false;
                a3 = false;
                countChecked--;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy CheckBox B jest odznaczony.
        /// </summary>
        private void B_UnChecked(object sender, RoutedEventArgs e)
        {
            //UnChecking(b1, b2, b3);
            if (b1) //Jeśli dla zespołu została przypisana wersja 1.
            {
                v1 = false;
                b1 = false;
                countChecked--;
            }
            else if (b2)
            {
                v2 = false;
                b2 = false;
                countChecked--;
            }
            else if (b3)
            {
                v3 = false;
                b3 = false;
                countChecked--;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy CheckBox C jest odznaczony.
        /// </summary>
        private void C_UnChecked(object sender, RoutedEventArgs e)
        {
            //UnChecking(c1, c2, c3);
            if (c1) //Jeśli dla zespołu została przypisana wersja 1.
            {
                v1 = false;
                c1 = false;
                countChecked--;
            }
            else if (c2)
            {
                v2 = false;
                c2 = false;
                countChecked--;
            }
            else if (c3)
            {
                v3 = false;
                c3 = false;
                countChecked--;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy CheckBox D jest odznaczony.
        /// </summary>
        private void D_UnChecked(object sender, RoutedEventArgs e)
        {
            //UnChecking(d1, d2, d3);
            if (d1) //Jeśli dla zespołu została przypisana wersja 1.
            {
                v1 = false;
                d1 = false;
                countChecked--;
            }
            else if (d2)
            {
                v2 = false;
                d2 = false;
                countChecked--;
            }
            else if (d3)
            {
                v3 = false;
                d3 = false;
                countChecked--;
            }
        }

        /// <summary>
        /// Wykonuje się, gdy CheckBox E jest odznaczony.
        /// </summary>
        private void E_UnChecked(object sender, RoutedEventArgs e)
        {
            //UnChecking(e1, e2, e3);
            if (e1) //Jeśli dla zespołu została przypisana wersja 1.
            {
                v1 = false;
                e1 = false;
                countChecked--;
            }
            else if (e2)
            {
                v2 = false;
                e2 = false;
                countChecked--;
            }
            else if (e3)
            {
                v3 = false;
                e3 = false;
                countChecked--;
            }
        }

        /// <summary>
        /// Guzik, który zamyka aplikację.
        /// </summary>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
