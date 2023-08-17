using ConsoleApp31.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26.View
{
    public partial class AddForm : Form
    {
        static public DataBase Db_;
        public AddForm(DataBase db)
        {
            InitializeComponent();
            Db_ = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VegetableFruitsModel model = new VegetableFruitsModel(NameTB.Text, TypeTB.Text, ColorTB.Text, CaloriesTB.Text);
            Db_.Add(model);
        }
    }
}
