using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ConsoleApp31.Models;
namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {

        static public DataBase Db_ = new DataBase();
        public Form1()
        {
            InitializeComponent();
            RequestCB.Items.Add("1. Display All Information");
            RequestCB.Items.Add("2. Display All Names");
            RequestCB.Items.Add("3. Display All Colors");
            RequestCB.Items.Add("4. Display Max Calories");
            RequestCB.Items.Add("5. Display Min Calories");
            RequestCB.Items.Add("6. Display Average Calories");
            RequestCB.Items.Add("7. Display Vegetable Count");
            RequestCB.Items.Add("8. Display Fruits Count");
            RequestCB.Items.Add("9. Display Vegetable and Fruits By Choosen Color");
            RequestCB.Items.Add("10. Display Vegetable and Fruits By Every Color");
            RequestCB.Items.Add("11. Display Vegetable and Fruits Under Concreate Calories");
            RequestCB.Items.Add("12. Display Vegetable and Fruits Upper Concreate Calories");
            RequestCB.Items.Add("13. Display Vegetable and Fruits By Concreate Diapason Calories");
            RequestCB.Items.Add("14. Display Vegetable and Fruits By Color Red And Yellow");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAndUpdateAllTextBoxes();
            switch (RequestCB.SelectedIndex)
            {
                case 0:
                    foreach (var vegetable in Db_.Show())
                    {
                        ResultLB.Items.Add(vegetable.ToString());
                    }
                    break;
                case 1:
                    foreach (var vegetable in Db_.ShowName())
                    {
                        ResultLB.Items.Add(vegetable.ToString());
                    }
                    break;
                case 2:
                    foreach (var vegetable in Db_.ShowColors())
                    {
                        ResultLB.Items.Add(vegetable.ToString());
                    }
                    break;
                case 3:
                    ResultLB.Items.Add(Db_.MaxCalories());
                    break;
                case 4:
                    ResultLB.Items.Add(Db_.MinCalories());
                    break;
                case 5:
                    ResultLB.Items.Add(Db_.AvgCalories());
                    break;
                case 6:
                    ResultLB.Items.Add(Db_.ShowCountVegetables());
                    break;
                case 7:
                    ResultLB.Items.Add(Db_.ShowCountFruits());
                    break;
                // 11
                case 8:
                    ColorTB.ReadOnly = false;
                    break;
                case 9:
                    foreach (var vegetable in Db_.ShowCountEveryColor())
                    {
                        ResultLB.Items.Add(vegetable.ToString());
                    }
                    break;
                case 10:
                    MinCaloriesTB.ReadOnly = false;
                    FindBtn.Enabled = true;
                    break;
                case 11:
                    MaxCaloriesTB.ReadOnly = false;
                    FindBtn.Enabled = true;
                    break;
                case 12:
                    MinCaloriesTB.ReadOnly = false;
                    MaxCaloriesTB.ReadOnly = false;
                    FindBtn.Enabled = true;
                    break;
                case 13:
                    foreach (var vegetable in Db_.ShowFruitsVegetablesWithRedYellowColor())
                    {
                        ResultLB.Items.Add(vegetable.ToString());
                    }
                    break;
                default:
                    break;
            }
        }

        private void ClearAndUpdateAllTextBoxes()
        {
            ColorTB.ReadOnly = true;
            MinCaloriesTB.ReadOnly = true;
            MaxCaloriesTB.ReadOnly = true;
            ColorTB.Text = string.Empty;
            MinCaloriesTB.Text = string.Empty;
            MaxCaloriesTB.Text = string.Empty;
            ResultLB.Items.Clear();
            FindBtn.Enabled = false;
        }

        private void ColorTB_TextChanged(object sender, EventArgs e)
        {
            if (Db_.ShowCountFruitsAndVegetablesByChooseColor(ColorTB.Text).Count != 0)
            {
                foreach (var vegetable in Db_.ShowCountFruitsAndVegetablesByChooseColor(ColorTB.Text))
                {
                    ResultLB.Items.Add(vegetable.ToString());
                }
            }
            else
            {
                ResultLB.Items.Clear();
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            ResultLB.Items.Clear();
            if (RequestCB.SelectedIndex == 10)
            {
                foreach (var vegetable in Db_.ShowFruitsVegetablesUnderCalories(Convert.ToInt32(MinCaloriesTB.Text)))
                {
                    ResultLB.Items.Add(vegetable.ToString());
                }
            }
            if (RequestCB.SelectedIndex == 11)
            {
                foreach (var vegetable in Db_.ShowFruitsVegetablesUpperCalories(Convert.ToInt32(MaxCaloriesTB.Text)))
                {
                    ResultLB.Items.Add(vegetable.ToString());
                }
            }
            if (RequestCB.SelectedIndex == 12)
            {
                foreach (var vegetable in Db_.ShowFruitsVegetablesByDiapasonCalories(Convert.ToInt32(MinCaloriesTB.Text), Convert.ToInt32(MaxCaloriesTB.Text)))
                {
                    ResultLB.Items.Add(vegetable.ToString());
                }
            }
        }
    }
}
