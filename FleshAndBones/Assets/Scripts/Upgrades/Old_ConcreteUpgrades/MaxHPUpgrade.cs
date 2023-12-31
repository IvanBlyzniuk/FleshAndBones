﻿using App.World.Entity.Player.PlayerComponents;
using UnityEngine;

namespace App.Upgrades.Old_ConcreteUpgrades
{
    [CreateAssetMenu(fileName = "MaxHPUpgrade", menuName = "Scriptable Objects/Old_Upgrades/MaxHPUpgrade")]
    public class MaxHPUpgrade : Old_BaseUpgrade
    {
        #region Serialized Fields
        [Min(0f)]
        [SerializeField] private float maxHPAddent;
        #endregion

        #region Overriden Methods
        protected override void Upgrade(Player upgradable)
        {
            upgradable.Health.MaxHealth += maxHPAddent;
        }

        protected override void Degrade(Player upgradable)
        {
            upgradable.Health.MaxHealth -= maxHPAddent;
        }

        protected override void UpdateIfEnabled(Player upgradable) { }

        #endregion
    }
}
