
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;

namespace SCP3114Spawner
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "SCP3114Spawner";
        public override string Author => "YourName";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(6, 0, 0);

        public EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Server.RoundStarted += EventHandlers.OnRoundStarted;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandlers.OnRoundStarted;
            EventHandlers = null;
            base.OnDisabled();
        }
    }
}
