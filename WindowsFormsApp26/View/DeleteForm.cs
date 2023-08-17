using ConsoleApp31.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26.View
{
    public partial class DeleteForm : Form
    {
        static public DataBase Db_;
        public DeleteForm(DataBase db)
        {
            InitializeComponent();
            Db_ = db;
            foreach (var vegetable in Db_.Show())
            {
                listBox1.Items.Add(vegetable.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Db_.Delete(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            foreach (var vegetable in Db_.Show())
            {
                listBox1.Items.Add(vegetable.ToString());
            }
        }
    }
}
