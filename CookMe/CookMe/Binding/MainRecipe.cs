using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookMe.Binding
{
    public class MainRecipe
    {
        public MainRecipe(string name, string pic)
            {
                FoodImage = pic;
                FoodName = name;
                
            }
            public string FoodImage { set; get; }
            public string FoodName { set; get; }

            public override string ToString()
            {
                return FoodImage + FoodName;
            }
    }
}
