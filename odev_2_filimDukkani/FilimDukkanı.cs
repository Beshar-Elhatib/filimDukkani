using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_filimDukkani
{
    public class FilimDukkanı
    {
        public List<Movie> Films { get; set; }
        public List<Person> Persons { get; set; }
        public List<Rental> Rentals { get; set; }
        internal Properties.Resources Resources
        {
            get => default;
            set
            {
            }
        }
        public Rental Rental
        {
            get => default;
            set
            {
            }
        }
        public Movie Movie
        {
            get => default;
            set
            {
            }
        }
        public Person Person
        {
            get => default;
            set
            {
            }
        }
        public frmMagzaninArayuz Form1
        {
            get => default;
            set
            {
            }
        }
        public FilimDukkanı()
        {
            Films = new List<Movie>();
            Persons = new List<Person>();
            Rentals = new List<Rental>();
        }
        public void AddMovie(Movie movie)
        {
            Films.Add(movie);
        }
        public void AddPerson(Person person)
        {
            Persons.Add(person);
        }
        public Rental RentMovie(Movie movie, Person person, DateTime rentDate)//filim kiralama metodu 
        {
            Rental rental = new Rental
            {
                RentalId = Rentals.Count + 1,
                Movie = movie,
                Person = person,
                RentDate = rentDate
            };
            Rentals.Add(rental);
            return rental;
        }
    }
}
