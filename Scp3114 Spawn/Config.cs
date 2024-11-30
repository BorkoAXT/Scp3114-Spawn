using Exiled.API.Interfaces;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace SCP3114Spawner
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public float SpawnChance { get; set; } = 10f; 
    }
}
