using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Respiration = "Absorbs oxygen through skin";
            Movement = "Slither slither";
            RespondToStimuli = "Locates prey by tasting the air";
            Eat = "Swallow";
        }
        public bool ScalySkin {  get; set; }
        public string ColdBlooded {  get; set; }
        public bool HasClaws {  get; set; }
        public bool CanRegenerate { get; set; }
    }
}
