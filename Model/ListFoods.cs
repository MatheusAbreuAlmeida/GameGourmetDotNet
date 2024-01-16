using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNet.Model
{
    public class ListFoods
    {
        private List<Food> foods = new List<Food>();

        public List<Food> GetFoods()
        {
            return foods;
        }

        public void SetFoods(List<Food> foods)
        {
            this.foods = foods;
        }
    }
}
