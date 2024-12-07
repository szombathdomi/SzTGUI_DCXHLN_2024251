using System.Collections.Generic;
using System.Windows;

namespace SzTGUI_DCXHLN_2024251
{
    public partial class AddMovieWindow : Window
    {
        private List<Movie> movies; // tárolás
        private Movie movieToEdit; // Az esetlegesen szerkesztett film referencia

        
        public AddMovieWindow(List<Movie> movies, Movie movieToEdit = null) // a konstruktor: filmek listáját és szerkesztésre szánt filmet kap paraméterül
        {
            InitializeComponent();
            this.movies = movies;
            this.movieToEdit = movieToEdit;

            // Ha van szerkesztésre szánt film, akkor a mezők kitöltése a film adataival
            if (this.movieToEdit != null)
            {
                NameBox.Text = this.movieToEdit.Name; // Film neve
                GenreBox.Text = this.movieToEdit.Genre; // Film műfaja
                LengthBox.Text = this.movieToEdit.Length.ToString(); // Film hossza
                ReleaseYearBox.Text = this.movieToEdit.ReleaseYear.ToString(); // Film kiadási éve
                RatingBox.Text = this.movieToEdit.Rating.ToString(); // Film értékelése
            }
        }

        // A "Mentés" gomb eseménykezelője
        private void OnSaveClicked(object sender, RoutedEventArgs e)
        {
            // Ellenőrzések a bevitt adatok érvényességére
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(GenreBox.Text) ||
                !int.TryParse(LengthBox.Text, out int length) ||
                !int.TryParse(ReleaseYearBox.Text, out int releaseYear))
            {
                MessageBox.Show("Kérjük, töltse ki az összes mezőt helyesen.", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return; // Hiba esetén a metódus befejezése
            }

            // Új film létrehozása, ha nem szerkesztett filmet kezelünk
            if (movieToEdit == null)
            {
                Movie newMovie = new Movie
                {
                    Name = NameBox.Text, // Film neve
                    Genre = GenreBox.Text, // Film műfaja
                    Length = int.Parse(LengthBox.Text), // Film hossza
                    ReleaseYear = int.Parse(ReleaseYearBox.Text), // Film kiadási éve
                    Rating = double.Parse(RatingBox.Text) // Film értékelése
                };
                movies.Add(newMovie); // Az új film hozzáadása a listához
            }
            else // Szerkesztett film esetén frissítjük az adatokat
            {
                movieToEdit.Name = NameBox.Text; // Film neve
                movieToEdit.Genre = GenreBox.Text; // Film műfaja
                movieToEdit.Length = int.Parse(LengthBox.Text); // Film hossza
                movieToEdit.ReleaseYear = int.Parse(ReleaseYearBox.Text); // Film kiadási éve
                movieToEdit.Rating = double.Parse(RatingBox.Text); // Film értékelése
            }

            this.Close(); // Az ablak bezárása
        }
    }
}
