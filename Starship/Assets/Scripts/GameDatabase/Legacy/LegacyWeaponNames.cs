using System.Collections.Generic;

using System.Linq;
using GameDatabase.DataModel;
using GameDatabase.Model;

namespace Database.Legacy
{
    public static class LegacyWeaponNames
    {
        public static ItemId<Weapon> GetId(string value) { int id; return new ItemId<Weapon>(_items.TryGetValue(value, out id) ? id : -1); }

        public static string GetName(ItemId<Weapon> id) { return _items.FirstOrDefault(item => item.Value == id.Value).Key; } // TODO: delete

        private static readonly Dictionary<string, int> _items = new Dictionary<string, int>()
        {
            { "AcidCannon_M_1", 1 },
            { "AcidMissileLauncher_L_1", 2 },
            { "AntiMatterBomb_L_1", 3 },
            { "AntiMatterBomb_L_2", 4 },
            { "AsteroidFragments", 5 },
            { "BlackHole_M_1", 6 },
            { "ChargedLaser_L_1", 7 },
            { "ChargedLaser_L_2", 8 },
            { "ChargedLaser_L_3", 9 },
            { "ChargedLaser_M_1", 10 },
            { "ChargedTorpedo_L_1", 11 },
            { "DroneControl_M", 12 },
            { "EmpTorpedo_L_1", 13 },
            { "EmpTorpedo_M_1", 14 },
            { "EnergyBeam_M", 15 },
            { "EnergySiphon_M", 16 },
            { "EnergySiphon_S", 17 },
            { "Fireworks", 18 },
            { "FragBomb_M_1", 19 },
            { "IonCannon_L_1", 20 },
            { "IonCannon_L_2", 21 },
            { "IonCannon_M_1", 22 },
            { "IonCannon_M_2", 23 },
            { "LaserBeam_L_1", 24 },
            { "LaserBeam_L_2", 25 },
            { "LaserBeam_M_1", 26 },
            { "LaserBeam_S_1", 27 },
            { "LaserBeam_S_2", 28 },
            { "LaserCannon_M_1", 29 },
            { "LightningCannon_L_1", 30 },
            { "LightningCannon_M_1", 31 },
            { "LightningCannon_S_1", 32 },
            { "LightningCannon_S_2", 33 },
            { "LightningCannon_S_3", 34 },
            { "MassDriver_M_1", 35 },
            { "MassDriver_M_2", 36 },
            { "MissileLauncher_L_1", 37 },
            { "MissileLauncher_L_2", 38 },
            { "MissileLauncher_L_3", 39 },
            { "MissileLauncher_L_4", 40 },
            { "MissileLauncher_M_1", 41 },
            { "MissileLauncher_M_2", 42 },
            { "MissileLauncher_M_3", 43 },
            { "MissileLauncher_S_1", 44 },
            { "NeutronBlaster_L_1", 45 },
            { "NeutronBlaster_M_1", 46 },
            { "NeutronBlaster_M_2", 47 },
            { "PlasmaCannon_S_1", 48 },
            { "PlasmaMultiCannon_M_1", 49 },
            { "PlasmaThrower_M_1", 50 },
            { "PlasmaThrower_M_2", 51 },
            { "PlasmaTorpedo_L_1", 52 },
            { "PlasmaWeb_M_1", 53 },
            { "PlasmaWeb_S_1", 54 },
            { "ProtoonTorpedo_L_1", 55 },
            { "ProtoonTorpedo_M_1", 56 },
            { "ProtoonTorpedo_M_2", 57 },
            { "ProtoonTorpedo_S_1", 58 },
            { "Pulsar_M1", 59 },
            { "Pulsar_M2", 60 },
            { "PulseCannon_L_1", 61 },
            { "PulseCannon_L_2", 62 },
            { "PulseCannon_M_1", 63 },
            { "PulseCannon_M_2", 64 },
            { "PulseCannon_S_1", 65 },
            { "PulseCannon_S_2", 66 },
            { "PulseMashineGun_M_1", 67 },
            { "PulseMultiCannon_M_1", 68 },
            { "QuantumTorpedo_L_1", 69 },
            { "RailGun_L_1", 70 },
            { "RepairBeam_M_1", 71 },
            { "RepairBeam_S_1", 72 },
            { "RocketLauncher_M_1", 73 },
            { "RocketLauncher_M_2", 74 },
            { "RoverMissileLauncher", 75 },
            { "RoverPulseCannon", 76 },
            { "SingularityCannon_M_1", 77 },
            { "StasisField_L_1", 78 },
            { "StasisField_L_2", 79 },
            { "StasisField_M_1", 80 },
            { "StasisField_S_1", 81 },
            { "TestLaserBeam", 82 },
            { "TractorBeam_M", 83 },
            { "TutorialGun", 84 },
            { "TutorialMissile", 85 },
            { "VampiricRay_L", 86 },
            { "VampiricRay_L_1", 87 },
            { "VampiricRay_M", 88 },
            { "VampiricRay_M_1", 89 },
            { "VolcanoBomb", 90 },
            { "XmasBomb_M_1", 91 },
        };
    }
}
