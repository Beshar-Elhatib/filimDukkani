using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_2_filimDukkani
{
    public partial class frmfilimKiralama : Form
    {
        private FilimDukkanı filmDukkanı;
        public frmfilimKiralama(FilimDukkanı filmDukkanı)
        {
            InitializeComponent();
            this.filmDukkanı = filmDukkanı;
            comboBox1.DataSource = filmDukkanı.Films;
            comboBox1.DisplayMember = "Title";
            comboBox2.DataSource = filmDukkanı.Persons;
            comboBox2.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmfilimKiralama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = (Movie)comboBox1.SelectedItem;
            Person selectedPerson = (Person)comboBox2.SelectedItem;
            DateTime rentDate = dateTimePicker1.Value;
            filmDukkanı.RentMovie(selectedMovie, selectedPerson, rentDate);
            MessageBox.Show("Film başarıyla kiralandı.");
            this.Close();
        }
    }
}
