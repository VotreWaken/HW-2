using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31.Models
{
    public class VegetableFruitsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string color { get; set; }
        public int calories { get; set; }
        public override string ToString()
        {
            return string.Format($"{Id} {Name} {Type} {color} {calories}");
        }
        public VegetableFruitsModel()
        {

        }
        public VegetableFruitsModel(string name, string type, string color, string calories)
        {
            Name = name;
            Type = type;
            this.color = color;
            this.calories = Convert.ToInt32(calories);
        }

        public VegetableFruitsModel(string id, string name, string type, string color, string calories)
        {
            Id = Convert.ToInt32(id);
            Name = name;
            Type = type;
            this.color = color;
            this.calories = Convert.ToInt32(calories);
        }
    }
}
