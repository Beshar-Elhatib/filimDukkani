using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_2_filimDukkani
{
    public partial class frmMagzaninArayuz : Form
    {
        private FilimDukkanı filmDukkanı;

        public frmMagzaninArayuz()
        {
            InitializeComponent();
            filmDukkanı = new FilimDukkanı();
        }

        public frmKisiEkleme KisiEkleForm
        {
            get => default;
            set
            { }
        }
        public frmFilimEkle FilmEkleForm
        {
            get => default;
            set
            {
            }
        }
        public frmfilimKiralama FilmKiralamaForm
        {
            get => default;
            set
            {
            }
        }


        private void btnFilimEkle_Click(object sender, EventArgs e)
        {
            frmFilimEkle filmEkleForm = new frmFilimEkle(filmDukkanı);
            filmEkleForm.ShowDialog();
        }

        private void btnFilimKirala_Click(object sender, EventArgs e)
        {
            Form frm2=new frmfilimKiralama(filmDukkanı);
            frm2.ShowDialog();
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            Form frm3=new frmKisiEkleme(filmDukkanı);
            frm3.ShowDialog();
        }


        private void btnDosyaYaz_Click(object sender, EventArgs e)
        {
            Kaydet(); 
        }
        private void btnDosyaOku_Click(object sender, EventArgs e)
        {
            Yükle();
        }

        private void Kaydet()
        {
            using (StreamWriter writer = new StreamWriter(@"E:\C#\ödevler\odev_2_filimDukkani\film_dukkanı_bilgileri.txt"))
            {
                foreach (var movie in filmDukkanı.Films)
                {
                    writer.WriteLine($"{movie.Id},{movie.Title},{movie.DailyRentalRate}");
                }
                foreach (var person in filmDukkanı.Persons)
                {
                    writer.WriteLine($"{person.Id},{person.Name},{person.Surname}");
                }
                foreach (var rental in filmDukkanı.Rentals)
                {
                    writer.WriteLine($"{rental.RentalId},{rental.Movie.Id},{rental.Person.Id},{rental.RentDate}");
                }
            }
            MessageBox.Show("Bilgiler dosyaya kaydedildi.");
        }

        private void Yükle()
        {
            filmDukkanı = new FilimDukkanı();
            // File ff = new File(@"D:\ntpprojects\film_dukkanı_bilgileri.txt");
            if (File.Exists(@"E:\C#\ödevler\odev_2_filimDukkani\film_dukkanı_bilgileri.txt"))
            {
                using (StreamReader reader = new StreamReader(@"E:\C#\ödevler\odev_2_filimDukkani\film_dukkanı_bilgileri.txt", true))
                {
                    Console.WriteLine("i=girdinjdjs jsdjs");
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (!double.TryParse(parts[1], out _) && double.TryParse(parts[2], out _))
                        {
                            int id = int.Parse(parts[0]);
                            string title = parts[1];
                            Console.WriteLine(parts[2]);
                            double dailyRentalRate = double.Parse(parts[2]);
                            filmDukkanı.AddMovie(new Movie { Id = id, Title = title, DailyRentalRate = dailyRentalRate });
                        }
                        else if (!double.TryParse(parts[1], out _) && !double.TryParse(parts[2], out _))
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string surname = parts[2];
                            filmDukkanı.AddPerson(new Person { Id = id, Name = name, Surname = surname });
                        }
                        else
                        {
                            int rentalId = int.Parse(parts[0]);
                            int movieId = int.Parse(parts[1]);
                            int personId = int.Parse(parts[2]);
                            DateTime rentDate = DateTime.Parse(parts[3]);
                            var movie = filmDukkanı.Films.Find(m => m.Id == movieId);
                            var person = filmDukkanı.Persons.Find(p => p.Id == personId);
                            filmDukkanı.RentMovie(movie, person, rentDate);
                        }
                    }
                }
                MessageBox.Show("Bilgiler dosyadan yüklendi.");
            }
            else
            {
                MessageBox.Show("Bilgi dosyası bulunamadı.");
            }
        }

        private void btnVerilerGoster_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("filmad/kisiad/kirafilm", typeof(string)); // İsim olarak kullanılan sütun adını birleştirdik
            dataTable.Columns.Add("ucret/soyad/alankisi", typeof(string)); // Oran/Soyad olarak kullanılan sütun adını birleştirdik
            dataTable.Columns.Add("filmin kiralandigi tarih", typeof(DateTime)); // Kiralama Tarihi
            string[] lines = File.ReadAllLines(@"E:\C#\ödevler\odev_2_filimDukkani\film_dukkanı_bilgileri.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    dataTable.Rows.Add(int.Parse(parts[0]), parts[1], parts[2], DBNull.Value);
                }
                else if (parts.Length == 4)
                {
                    int movieId = int.Parse(parts[1]);
                    int personId = int.Parse(parts[2]);
                    DateTime rentDate = DateTime.Parse(parts[3]);
                    dataTable.Rows.Add(int.Parse(parts[0]), parts[1], parts[2], rentDate);
                }
            }
           
            dataGridView1.DataSource = dataTable;
        }

        private void btnVerileriSil_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"E:\C#\ödevler\odev_2_filimDukkani\film_dukkanı_bilgileri.txt"))
            {
                using (StreamWriter reader = new StreamWriter(@"E:\C#\ödevler\odev_2_filimDukkani\film_dukkanı_bilgileri.txt"))
                {
                }
            }
        }

        private void frmMagzaninArayuz_Load(object sender, EventArgs e)
        {

        }
    }
}
