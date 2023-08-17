/*
Main 
*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp31.Models
{
    public class DataBase
    {
        SqlConnection connection = null;

        public DataBase()
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = ConfigurationManager.ConnectionStrings["VegetablesAndFruits"].ConnectionString;
            this.connection.Open();
        }
        public List<VegetableFruitsModel> Show()
        {
            List<VegetableFruitsModel> res = new List<VegetableFruitsModel>();

            string req = "Select * from VegetablesAndFruits";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(new VegetableFruitsModel()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Type = reader.GetString(2),
                        color = reader.GetString(3),
                        calories = reader.GetInt32(4)
                    });
                }
            }
            reader.Close();

            return res;
        }
        public List<string> ShowName()
        {
            List<string> res = new List<string>();

            string req = "Select Name from VegetablesAndFruits";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            return res;
        }
        public List<string> ShowColors()
        {
            List<string> res = new List<string>();

            string req = "Select Color from VegetablesAndFruits group by Color";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            return res;
        }
        public string MaxCalories()
        {
            string query = "Select MAX(Calories) from VegetablesAndFruits";
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString();
        }

        public string MinCalories()
        {
            string query = "Select MIN(Calories) from VegetablesAndFruits";
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString();
        }

        public string AvgCalories()
        {
            string query = "Select AVG(Calories) from VegetablesAndFruits";
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString();
        }

        public string ShowCountVegetables()
        {
            string query = "Select Count(VegetablesAndFruits.Type) from VegetablesAndFruits Where VegetablesAndFruits.Type = 'Овощи'";
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString();
        }

        public string ShowCountFruits()
        {
            string query = "Select Count(VegetablesAndFruits.Type) from VegetablesAndFruits Where VegetablesAndFruits.Type = 'Фрукт'";
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteScalar().ToString();
        }

        public List<string> ShowCountFruitsAndVegetablesByChooseColor(string color)
        {
            List<string> res = new List<string>();

            string query = $"select count(P.Color) from VegetablesAndFruits as P where P.[Type]='Овощи' and P.Color='{color}' group by P.[Type]";
            SqlCommand cmd = new SqlCommand(query, connection);
            object _countV = cmd.ExecuteScalar();

            cmd.CommandText = $"select count(P.Color) from VegetablesAndFruits as P where P.[Type]='Фрукт' and P.Color='{color}' group by P.[Type]";
            object _countF = cmd.ExecuteScalar();

            if (_countV != null)
            {
                res.Add("Vegetables: " + _countV.ToString());
            }
            if (_countF != null)
            {
                res.Add("Fruits: " + _countF.ToString());
            }
            return res;
        }

        public List<string> ShowCountEveryColor()
        {
            List<string> res = new List<string>();

            string req = "Select VegetablesAndFruits.Color, Count(Name) from VegetablesAndFruits Group by Color ";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            return res;
        }

        public List<string> ShowFruitsVegetablesUnderCalories(int calories)
        {
            List<string> res = new List<string>();

            string req = $"Select Name from VegetablesAndFruits Where Calories < {calories}";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            return res;
        }

        public List<string> ShowFruitsVegetablesUpperCalories(int calories)
        {
            List<string> res = new List<string>();

            string req = $"Select Name from VegetablesAndFruits Where Calories > {calories}";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            return res;
        }

        public List<string> ShowFruitsVegetablesByDiapasonCalories(int min, int max)
        {
            List<string> res = new List<string>();

            string req = $"Select Name from VegetablesAndFruits Where Calories > {min} AND Calories < {max}";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            return res;
        }

        public List<string> ShowFruitsVegetablesWithRedYellowColor()
        {
            List<string> res = new List<string>();

            string req = "Select Name from VegetablesAndFruits Where Color = 'Красный' or Color = 'Желтый'";

            SqlCommand cmd = new SqlCommand(req, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res.Add(reader.GetString(0));
                }
            }
            reader.Close();

            return res;
        }

        // Added
        public async void Add(VegetableFruitsModel product)
        {
            string strCmd = $"insert into VegetablesAndFruits(Name, Type, Color, Calories) values('{product.Name}', '{product.Type}', '{product.color}', {product.calories})";
            SqlCommand cmd = new SqlCommand(strCmd, connection);
            await cmd.ExecuteNonQueryAsync();
        }

        public async void Delete(int id)
        {
            string strCmd = $"delete from VegetablesAndFruits where Id={id}";
            SqlCommand cmd = new SqlCommand(strCmd, connection);
            await cmd.ExecuteNonQueryAsync();
        }

        public async void Update(VegetableFruitsModel product)
        {
            string strCmd = $"update VegetablesAndFruits SET Name = '{product.Name}', Type = '{product.Type}', Calories = '{product.calories}', Color = '{product.color}' from VegetablesAndFruits where ID = {product.Id};";
            SqlCommand cmd = new SqlCommand(strCmd, connection);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}
