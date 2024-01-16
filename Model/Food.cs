using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNet.Model
{
    public class Food
    {
        private String Description;
        private String Quality;

        public Food(String Description, String Quality)
        {
            this.Description = Description;
            this.Quality = Quality;
        }

        public String GetDescription()
        {
            return Description;
        }

        public void SetDescription(String Description)
        {
            this.Description = Description;
        }

        public String GetQuality()
        {
            return Quality;
        }

        public void SetQuality(String Quality)
        {
            this.Quality = Quality;
        }

    }
}
