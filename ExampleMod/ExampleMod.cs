using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IkenFeline;
using IkenFeline.Attributes;
using IkenFeline.Mod;

namespace ExampleMod
{
    [IkenFelineMod]
    public class ExampleMod : IkenFelineMod
    {
        public ExampleMod(ModManifest manifest) : base(manifest)
        {
        }

        public override void Load()
        {
            Logger.Log("Example Mod loaded!");
        }
    }
}
