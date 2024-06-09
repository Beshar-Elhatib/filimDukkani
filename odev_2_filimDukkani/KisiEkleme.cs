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
    public partial class frmKisiEkleme : Form
    {
        private FilimDukkanı filmDukkanı;
        public frmKisiEkleme(FilimDukkanı filmDukkanı)
        {
            InitializeComponent();
            this.filmDukkanı = filmDukkanı;
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            filmDukkanı.AddPerson(new Person { Id = filmDukkanı.Persons.Count + 1, Name = name, Surname = surname });
            MessageBox.Show("Kişi başarıyla eklendi.");
            this.Close();
        }
    }
}
