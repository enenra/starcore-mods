using System.Collections.Generic;
using Sandbox.Definitions;
using Sandbox.Game;
using Sandbox.Game.Entities;
using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.ModAPI;
using VRageMath;


namespace Klime.BoostedThrustAndFlame
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    public class BoostedThrustAndFlame : MySessionComponentBase
    {
        public override void LoadData()
        {
            foreach (var def in MyDefinitionManager.Static.GetAllDefinitions())
            {
                MyThrustDefinition thruster = def as MyThrustDefinition;

                if (thruster != null && !thruster.Id.SubtypeName.ToLower().Contains("hover"))
                {
                    thruster.ForceMagnitude *= 3.5f;
                    thruster.MaxPowerConsumption *= 3.5f;
                    thruster.FlameLengthScale *= 3.5f;
                }
            }
        }

        protected override void UnloadData()
        {
        
        }
    }
}