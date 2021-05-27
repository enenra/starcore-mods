using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;

namespace ShipPoints
{
	[MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    class PointAdditions : MySessionComponentBase
    {
        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {
            MyAPIGateway.Utilities.SendModMessage(2546247, MyAPIGateway.Utilities.SerializeToBinary(@"
				LargeBlockBatteryBlock@15;
                BattleshipCannon@60;
                BattleshipCannonMK2@110;
                BattleshipCannonMK22@110;
                BattleshipCannonMK3@275;
                BFG_M@500;
                RailgunxTurretS@150;
                RailgunxTurretM@275;
                RailgunxTurret@400;
				
				StaticBattery1@100;
				StaticBattery1Stack@100;
				Railgunx@150;
				
                M1Torpedo@400;
                M8Launcher@300;
                BFTriCannon@375;
                MXA_SMAC@3000;
				
                C100mmTurret@100;
                C200mmTurret@160;
				C300mmTurret@300;
				
                CIWS@175;
                AMSlaser@125;
                AS2@450;
                AS3@300;
                AS4@500;
                EmitterL@50;
                EmitterLA@50;
                LargeShieldModulator@15;
                LargeEnhancer@15;
                MA_Gladius@450;
                MA_PDT@100;
                MA_Gimbal_Laser@80;
                MA_Gimbal_Laser_Armored@80;
                MA_Gimbal_Laser_Armored_Slope@80;
                MA_Gimbal_Laser_Armored_Slope2@80;
                MA_Gimbal_Laser_Armored_Slope45@80;
                MA_PDX@225;
                MA_Gimbal_Laser_T2@100;
                MA_Gimbal_Laser_T2_Armored@100;
                MA_Gimbal_Laser_T2_Armored_Slope@100;
                MA_Gimbal_Laser_T2_Armored_Slope2@100;
                MA_Gimbal_Laser_T2_Armored_Slope45@100;
                MA_T2PDX@120;
                MA_T2PDX_Slope@120;
                MA_T2PDX_Slope2@120;
                MA_Fixed_000@50;
                MA_Fixed_001@50;
                MA_Fixed_002@50;
                MA_Fixed_007@50;
                MA_Fixed_003@50;
                MA_Fixed_004@50;
                MA_Fixed_005@50;
                MA_Fixed_006@50;
                MA_Blister@50;
                MA_Blister45@50;
                MA_Blister30@50;
                MA_Blister32@50;
                MA_Meatball@150;
                MA_Tiger@150;
                MA_Designator@20;
                LargeBlockSmallGenerator@18;
                LargeBlockLargeGenerator@300;
				
                LargeBlockSmallThrust@15;
                LargeBlockLargeThrust@110;
                LargeBlockLargeIon@110;
                LargeBlockSmallIon@15;
				LargeBlockSmallThrustSciFi@15;
				LargeBlockLargeThrustSciFi@110;
				
                AQD_LG_IonThrusterS_ArmoredSlope@15;
                AQD_LG_IonThrusterS_Armored@15;
                AQD_LG_IonThrusterL_ArmoredSlope@110;
                AQD_LG_IonThrusterL_Armored@110;
                IonHeavyCovered@450;
                LargeWarhead@20;
                LargeDecoy@10;
                LargeStator@50;
                LargeAdvancedStator@50;
                LargeHinge@50;
                LargePistonBase@50;
                MCRNPDCTurretLB@200;
                MCRNPDCTurretSB@200;
                MCRNRightRetractPDC@200;
                MCRNLeftRetractPDC@200;
                MCRNTopRetractPDC@200;
                K_SA_Launcher_FixedMount@500;

                MA_Buster_ArmorBlock@1;
                MA_Buster_Window@1;
                MA_Buster_Camera@1;

                LargeBlockRemoteControl@50;
                LargeProgrammableBlock@50;
            "));
        }
    }
}
