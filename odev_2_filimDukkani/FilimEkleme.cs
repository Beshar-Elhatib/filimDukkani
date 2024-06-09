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
    public partial class frmFilimEkle : Form
    {
        private FilimDukkanı filmDukkanı;
        public frmFilimEkle(FilimDukkanı FilimDukkanı)
        {
            InitializeComponent();
            this.filmDukkanı = FilimDukkanı;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            double dailyRentalRate = double.Parse(textBox2.Text);
            filmDukkanı.AddMovie(new Movie { Id = filmDukkanı.Films.Count + 1, Title = title, DailyRentalRate = dailyRentalRate });
            MessageBox.Show("Film başarıyla eklendi.");
            this.Close();
        }
    }
}
