using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SzTGUI_DCXHLN_2024251
{
    // Movie osztály a filmek adatainak tárolására
    public class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
    }

    public partial class MainWindow : Window
    {
        private List<Movie> movies = new List<Movie>();  // Lista a filmek tárolására

        public MainWindow()
        {
            InitializeComponent();
            LoadMovies();  // A filmek betöltése
            movieGrid.ItemsSource = movies;  // A filmek megjelenítése a táblázatban
        }

        private void LoadMovies()
        {
            movies = new List<Movie>
            {
                new Movie { Name = "The Godfather", Genre = "Krimi", Length = 175, ReleaseYear = 1972, Rating = 9 },
                new Movie { Name = "The Dark Knight", Genre = "Akció", Length = 152, ReleaseYear = 2008, Rating = 9 },
                new Movie { Name = "Pulp Fiction", Genre = "Krimi", Length = 154, ReleaseYear = 1994, Rating = 9 },
                new Movie { Name = "Forrest Gump", Genre = "Dráma", Length = 142, ReleaseYear = 1994, Rating = 8 },
                new Movie { Name = "Inception", Genre = "Sci-Fi", Length = 148, ReleaseYear = 2010, Rating = 8 },
                new Movie { Name = "Fight Club", Genre = "Dráma", Length = 139, ReleaseYear = 1999, Rating = 8 },
                new Movie { Name = "The Matrix", Genre = "Sci-Fi", Length = 136, ReleaseYear = 1999, Rating = 8 },
                new Movie { Name = "Goodfellas", Genre = "Krimi", Length = 145, ReleaseYear = 1990, Rating = 8 },
                new Movie { Name = "Interstellar", Genre = "Sci-Fi", Length = 169, ReleaseYear = 2014, Rating = 8 },
                new Movie { Name = "Schindler's List", Genre = "Dráma", Length = 195, ReleaseYear = 1993, Rating = 9 },
                new Movie { Name = "The Lion King", Genre = "Animáció", Length = 88, ReleaseYear = 1994, Rating = 8 },
                new Movie { Name = "Braveheart", Genre = "Dráma", Length = 178, ReleaseYear = 1995, Rating = 8 },
                new Movie { Name = "The Prestige", Genre = "Dráma", Length = 130, ReleaseYear = 2006, Rating = 8 },
                new Movie { Name = "Gladiator", Genre = "Akció", Length = 155, ReleaseYear = 2000, Rating = 8 },
                new Movie { Name = "Alien", Genre = "Sci-Fi", Length = 117, ReleaseYear = 1979, Rating = 8 },
                new Movie { Name = "Jaws", Genre = "Thriller", Length = 124, ReleaseYear = 1975, Rating = 8 },
                new Movie { Name = "Crash", Genre = "Dráma", Length = 112, ReleaseYear = 2004, Rating = 7 },
                new Movie { Name = "Frozen", Genre = "Animáció", Length = 102, ReleaseYear = 2013, Rating = 7 },
                new Movie { Name = "Up", Genre = "Animáció", Length = 96, ReleaseYear = 2009, Rating = 8 },
                new Movie { Name = "Heat", Genre = "Krimi", Length = 170, ReleaseYear = 1995, Rating = 8 },
                new Movie { Name = "Dune", Genre = "Sci-Fi", Length = 155, ReleaseYear = 2021, Rating = 8 },
                new Movie { Name = "Moon", Genre = "Sci-Fi", Length = 97, ReleaseYear = 2009, Rating = 7 },
                new Movie { Name = "Rush", Genre = "Dráma", Length = 123, ReleaseYear = 2013, Rating = 8 },
                new Movie { Name = "The Departed", Genre = "Krimi", Length = 151, ReleaseYear = 2006, Rating = 8 },
                new Movie { Name = "Whiplash", Genre = "Dráma", Length = 106, ReleaseYear = 2014, Rating = 8 },
                new Movie { Name = "The Green Mile", Genre = "Dráma", Length = 189, ReleaseYear = 1999, Rating = 8 },
                new Movie { Name = "The Pianist", Genre = "Dráma", Length = 150, ReleaseYear = 2002, Rating = 8 },
                new Movie { Name = "Parasite", Genre = "Dráma", Length = 132, ReleaseYear = 2019, Rating = 8 },
                new Movie { Name = "Joker", Genre = "Dráma", Length = 122, ReleaseYear = 2019, Rating = 8 },
                new Movie { Name = "1917", Genre = "Dráma", Length = 119, ReleaseYear = 2019, Rating = 8 },
                new Movie { Name = "A Beautiful Mind", Genre = "Dráma", Length = 135, ReleaseYear = 2001, Rating = 8 },
                new Movie { Name = "Django Unchained", Genre = "Western", Length = 165, ReleaseYear = 2012, Rating = 8 },
                new Movie { Name = "The Truman Show", Genre = "Vígjáték", Length = 103, ReleaseYear = 1998, Rating = 8 },
                new Movie { Name = "Shutter Island", Genre = "Thriller", Length = 138, ReleaseYear = 2010, Rating = 8 },
                new Movie { Name = "Mad Max: Fury Road", Genre = "Akció", Length = 120, ReleaseYear = 2015, Rating = 8 },
                new Movie { Name = "The Social Network", Genre = "Dráma", Length = 120, ReleaseYear = 2010, Rating = 8 },
                new Movie { Name = "Once Upon a Time in Hollywood", Genre = "Dráma", Length = 161, ReleaseYear = 2019, Rating = 8 },
                new Movie { Name = "Gone Girl", Genre = "Thriller", Length = 149, ReleaseYear = 2014, Rating = 8 },
                new Movie { Name = "La La Land", Genre = "Musical", Length = 128, ReleaseYear = 2016, Rating = 8 },
                new Movie { Name = "The Imitation Game", Genre = "Dráma", Length = 113, ReleaseYear = 2014, Rating = 8 },
                new Movie { Name = "Her", Genre = "Romantikus", Length = 126, ReleaseYear = 2013, Rating = 8 },
                new Movie { Name = "Speed", Genre = "Akció", Length = 116, ReleaseYear = 1994, Rating = 7 },
                new Movie { Name = "Soul", Genre = "Animáció", Length = 100, ReleaseYear = 2020, Rating = 8 },
                new Movie { Name = "Gold", Genre = "Dráma", Length = 121, ReleaseYear = 2016, Rating = 6 },
                new Movie { Name = "Mank", Genre = "Dráma", Length = 131, ReleaseYear = 2020, Rating = 6 },
                new Movie { Name = "Mud", Genre = "Dráma", Length = 130, ReleaseYear = 2012, Rating = 7 },
                new Movie { Name = "Joy", Genre = "Dráma", Length = 124, ReleaseYear = 2015, Rating = 6 },
                new Movie { Name = "Room", Genre = "Dráma", Length = 118, ReleaseYear = 2015, Rating = 8 },
                new Movie { Name = "Life", Genre = "Sci-Fi", Length = 104, ReleaseYear = 2017, Rating = 6 },
                new Movie { Name = "Sing", Genre = "Animáció", Length = 108, ReleaseYear = 2016, Rating = 7 },
                new Movie { Name = "The Intouchables", Genre = "Dráma", Length = 112, ReleaseYear = 2011, Rating = 8 },
                new Movie { Name = "Slumdog Millionaire", Genre = "Dráma", Length = 120, ReleaseYear = 2008, Rating = 8 },
                new Movie { Name = "Her", Genre = "Romantikus", Length = 126, ReleaseYear = 2013, Rating = 8 },
                new Movie { Name = "The Revenant", Genre = "Dráma", Length = 156, ReleaseYear = 2015, Rating = 8 },
                new Movie { Name = "Moonlight", Genre = "Dráma", Length = 111, ReleaseYear = 2016, Rating = 8 },
                new Movie { Name = "Spotlight", Genre = "Dráma", Length = 129, ReleaseYear = 2015, Rating = 8 },
                new Movie { Name = "Birdman", Genre = "Dráma", Length = 119, ReleaseYear = 2014, Rating = 8 },
                new Movie { Name = "Blade Runner 2049", Genre = "Sci-Fi", Length = 164, ReleaseYear = 2017, Rating = 8 },
                new Movie { Name = "The Big Short", Genre = "Dráma", Length = 130, ReleaseYear = 2015, Rating = 8 },
                new Movie { Name = "Argo", Genre = "Dráma", Length = 120, ReleaseYear = 2012, Rating = 8 },
                new Movie { Name = "Gravity", Genre = "Sci-Fi", Length = 91, ReleaseYear = 2013, Rating = 7 },
                new Movie { Name = "Bohemian Rhapsody", Genre = "Dráma", Length = 134, ReleaseYear = 2018, Rating = 7 },
                new Movie { Name = "Ford v Ferrari", Genre = "Dráma", Length = 152, ReleaseYear = 2019, Rating = 8 },
                new Movie { Name = "A Star is Born", Genre = "Dráma", Length = 136, ReleaseYear = 2018, Rating = 7 },
                new Movie { Name = "Black Panther", Genre = "Akció", Length = 134, ReleaseYear = 2018, Rating = 7 },
                new Movie { Name = "Logan", Genre = "Akció", Length = 137, ReleaseYear = 2017, Rating = 8 },
                new Movie { Name = "Avengers: Endgame", Genre = "Akció", Length = 181, ReleaseYear = 2019, Rating = 8 },
                new Movie { Name = "Pi", Genre = "Dráma", Length = 84, ReleaseYear = 1998, Rating = 7 },
                new Movie { Name = "Hook", Genre = "Kaland", Length = 142, ReleaseYear = 1991, Rating = 7 },
                new Movie { Name = "WALL-E", Genre = "Animáció", Length = 98, ReleaseYear = 2008, Rating = 8 },
                new Movie { Name = "Ray", Genre = "Dráma", Length = 152, ReleaseYear = 2004, Rating = 7 },
                new Movie { Name = "Ali", Genre = "Dráma", Length = 157, ReleaseYear = 2001, Rating = 7 },
                new Movie { Name = "Saw", Genre = "Horror", Length = 103, ReleaseYear = 2004, Rating = 7 },
                new Movie { Name = "Cube", Genre = "Sci-Fi", Length = 90, ReleaseYear = 1997, Rating = 7 },
                new Movie { Name = "Rocky", Genre = "Dráma", Length = 120, ReleaseYear = 1976, Rating = 8 },
                new Movie { Name = "Jobs", Genre = "Dráma", Length = 128, ReleaseYear = 2013, Rating = 6 },
                new Movie { Name = "Chef", Genre = "Vígjáték", Length = 114, ReleaseYear = 2014, Rating = 7 },
                new Movie { Name = "Jaws", Genre = "Thriller", Length = 124, ReleaseYear = 1975, Rating = 8 },
                new Movie { Name = "Jurassic Park", Genre = "Sci-Fi", Length = 127, ReleaseYear = 1993, Rating = 8 },
                new Movie { Name = "Back to the Future", Genre = "Sci-Fi", Length = 116, ReleaseYear = 1985, Rating = 8 },
                new Movie { Name = "Titanic", Genre = "Dráma", Length = 195, ReleaseYear = 1997, Rating = 7 },
                new Movie { Name = "The Terminator", Genre = "Sci-Fi", Length = 107, ReleaseYear = 1984, Rating = 8 },
                new Movie { Name = "Rocky", Genre = "Dráma", Length = 120, ReleaseYear = 1976, Rating = 8 },
                new Movie { Name = "Die Hard", Genre = "Akció", Length = 132, ReleaseYear = 1988, Rating = 8 },
                new Movie { Name = "The Goonies", Genre = "Kaland", Length = 114, ReleaseYear = 1985, Rating = 3 }
            };
        }

        private void OnFilterClicked(object sender, RoutedEventArgs e)
        {
            string filterText = searchBox.Text.ToLower();  // A keresési szöveg kisbetűsítése

            // A filmek szűrése a megadott keresési feltételek alapján (Mindenre lehet keresni)
            var filteredMovies = movies.Where(m =>
                m.Name.ToLower().Contains(filterText) ||
                m.Genre.ToLower().Contains(filterText) ||
                m.Length.ToString().Contains(filterText) ||
                m.ReleaseYear.ToString().Contains(filterText) ||
                m.Rating.ToString().Contains(filterText)
            ).ToList();

            // Ha nincs találat, hibaüzenet megjelenítése
            if (filteredMovies.Count == 0)
            {
                MessageBox.Show("Nincs találat a keresett feltételnek megfelelő filmekre.", "Keresési hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            // A táblázat forrásának frissítése
            movieGrid.ItemsSource = filteredMovies;
        }

        private void OnAddNewMovieClicked(object sender, RoutedEventArgs e)
        {
            // Új film hozzáadása
            AddMovieWindow addMovieWindow = new AddMovieWindow(movies);
            addMovieWindow.ShowDialog();  // felugró ablakban
            movieGrid.ItemsSource = null;  // Táblázat forrásának törlése a frissítéshez
            movieGrid.ItemsSource = movies;  // Frissített filmek megjelenítése
        }

        // Szerkeszt gomb logic
        private void OnEditMovieClicked(object sender, RoutedEventArgs e)
        {
            // Film szerkesztése
            var button = sender as FrameworkElement;
            var selectedMovie = button.Tag as Movie;  
            AddMovieWindow editWindow = new AddMovieWindow(movies, selectedMovie);
            editWindow.ShowDialog();  // felugró ablakban
            movieGrid.ItemsSource = null;  // Táblázat frissítése
            movieGrid.ItemsSource = movies;  // Frissített filmek megjelenítése
        }

        // Törlés gomb logic
        private void OnDeleteMovieClicked(object sender, RoutedEventArgs e)
        {
            var button = sender as FrameworkElement;
            var selectedMovie = button.Tag as Movie;  

            // Megerősítő üzenet a törléshez
            if (MessageBox.Show($"Biztosan törlöd a következő filmet: {selectedMovie.Name}?", "Film törlése", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                movies.Remove(selectedMovie);  // A kiválasztott film törlése a listából
                movieGrid.ItemsSource = null;  // Táblázat frissítése
                movieGrid.ItemsSource = movies;  // Frissített filmek megjelenítése
            }
        }
    }
}
