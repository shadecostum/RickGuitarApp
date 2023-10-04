using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarApp.Models
{
    public class GuitarSpecClass
    {
        //enum class called
        private BuilderType Builder;
        private WoodType BackWood;
        private GuitarType GuitarType;
        private WoodType TopWood;
        private string Model;


       // (BuilderType.Collings, "CJ", GuitarType.Acoustic, WoodType.IndianRosewood, WoodType.Maple));
        public GuitarSpecClass(BuilderType Builder, string model, GuitarType guitarType, WoodType backwood, WoodType topwood)
        {
            this.Builder = Builder;
            this.Model = model;
            this.BackWood = backwood;
            this.TopWood = topwood;
            this.GuitarType = guitarType;
        }

        public BuilderType getBuilder()
        {
            return Builder;
        }
        public WoodType getBackWood()
        {
            return BackWood;
        }
        public WoodType getTopWood()
        {
            return TopWood;
        }
        public string getModel()
        {
            return Model;
        }
        public GuitarType getGuitarType()
        {
            return GuitarType;
        }

        internal bool CheckMatches(GuitarSpecClass personNeedSpec)
        {
            if (Builder != personNeedSpec.Builder)
                return false;
            if (!string.IsNullOrEmpty(Model) && !Model.Equals(personNeedSpec.Model, StringComparison.OrdinalIgnoreCase))
                return false;
            if (GuitarType != personNeedSpec.GuitarType)
                return false;
            if (BackWood != personNeedSpec.BackWood)
                return false;
            if (TopWood != personNeedSpec.TopWood)
                return false;
            return true;





        }
    }
}
