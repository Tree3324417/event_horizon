﻿using Combat.Component.Body;
using Combat.Component.Platform;
using Combat.Factory;
using UnityEngine;

namespace Combat.Component.Systems.Weapons
{
    public enum WeaponType
    {
        Common,
        Manageable,
        Continuous,
        RequiredCharging,
    }

    public enum BulletType
    {
        Direct,
        Homing,
        Projectile,
        AreaOfEffect,
    }

    public enum BulletEffectType
    {
        Common,
        DamageOverTime,
        Repair,
        Special,
        ForDronesOnly,
    }

    public class WeaponInfo
    {
        public WeaponInfo(WeaponType weaponType, float spread, IBulletFactory bulletFactory, IWeaponPlatform platform)
        {
            _bulletFactory = bulletFactory;
            _weaponType = weaponType;
            _spread = spread;

            if (platform.Body.Parent != null && weaponType == WeaponType.Common)
                Recoil = _bulletFactory.Stats.Recoil / platform.Body.TotalWeight();
        }

        public WeaponType WeaponType { get { return _weaponType; } }
        public BulletType BulletType { get { return _bulletFactory.Stats.Type; } }
        public BulletEffectType BulletEffectType { get { return _bulletFactory.Stats.EffectType; } }
        public float Range { get { return _bulletFactory.Stats.BulletHitRange; } }
        public float Spread { get { return _spread; } }
        public bool IsRelativeVelocity { get { return !_bulletFactory.Stats.IgnoresShipSpeed; } }
        public float BulletSpeed { get { return _bulletFactory.Stats.BulletSpeed; } }
        public float EnergyCost { get { return _bulletFactory.Stats.EnergyCost; } }
        public float Recoil { get; private set; }

        private readonly float _spread;
        private readonly WeaponType _weaponType;
        private readonly IBulletFactory _bulletFactory;
    }
}
