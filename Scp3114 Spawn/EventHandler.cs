using Exiled.API.Features;
using Exiled.Events.EventArgs;
using PlayerRoles;

namespace SCP3114Spawner
{
    public class EventHandlers
    {
        private static readonly RoleTypeId SCP3114Role = RoleTypeId.Scp3114; 

        public void OnRoundStarted()
        {
            
            if (ShouldSpawnSCP3114())
            {
                var availablePlayers = Player.List.Where(p => p.Role.Type == RoleTypeId.None).ToList();

                if (availablePlayers.Count > 0)
                {
                    
                    var selectedPlayer = availablePlayers[UnityEngine.Random.Range(0, availablePlayers.Count)];
                    selectedPlayer.Role.Set(SCP3114Role, spawn: true);
                    Log.Info($"SCP-3114 has spawned as {selectedPlayer.Nickname}.");
                }
            }
        }

        private bool ShouldSpawnSCP3114()
        {
            
            return UnityEngine.Random.Range(0f, 100f) < Plugin.Instance.Config.SpawnChance;
        }
    }
}
