using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nautilus.Json;
using Nautilus.Options.Attributes;

namespace DanDoes.HelloWorld
{
    [Menu("Hello World")]
    public class ModOptions : ConfigFile
    {
        [Slider("Knife Damage Multiplier", 1.0f, 100.0f, DefaultValue = 5.0f, Format = "{0:F0}")]
        public float KnifeDamageMultiplier = 1.0f;
    }
}
