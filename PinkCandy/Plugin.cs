using Exiled.API.Enums;
using Exiled.API.Features;
using UnityEngine;
using Scp330 = InventorySystem.Items.Usables.Scp330.CandyKindID;

namespace PinkCandy
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin plugin;
        public override string Prefix => "PinkCandy";
        public override string Name => "PinkCandy";
        public override string Author => "[OPENSOURCE PLUGIN] [https://github.com/scp-sl-opensource-plugins]";
        public override PluginPriority Priority => PluginPriority.Last;
        public override void OnEnabled()
        {
            plugin = this;
            Exiled.Events.Handlers.Scp330.InteractingScp330 += InteractingScp330;
            base.OnEnabled();

        }
        private void InteractingScp330(Exiled.Events.EventArgs.Scp330.InteractingScp330EventArgs ev) { if (ev.IsAllowed && Random.Range(1, 100) <= Config.Chance) ev.Candy = Scp330.Pink; }
        public override void OnDisabled()
        {
            plugin = null;
            Exiled.Events.Handlers.Scp330.InteractingScp330 -= InteractingScp330;
            base.OnDisabled();
        }
    }
}