using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;
using NUnit.Framework;

namespace ChuckNorrisJokes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnJoke_Click(object sender, EventArgs e)
        {
            Joke response = await ChuckNorrisClient.GetRandomJoke();
            String joke = response.JokeText;
            txtJoke.Text = joke;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<String> listofCategories = await ChuckNorrisClient.GetCategories();
            foreach (string category in listofCategories)
            {
                cboBoxCategory.Items.Add(category);
            }
        }
    }
}
