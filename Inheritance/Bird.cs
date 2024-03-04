using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Movement = "Flap flap";
            Respiration = "Inhale, exhale";
            RespondToStimuli = "I can see far!";
            Eat = "Quick beak chomps";
        }
        public string ChirpNoise {  get; set; }

        public bool CanFly {  get; set; }

        public bool CanSing {  get; set; }

        public int FeatherAmount {  get; set; }
    }
}
