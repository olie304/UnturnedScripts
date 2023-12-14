using System;
using UnityEngine;
using Steamworks; // Requires CSteamID.cs

namespace SDG.Unturned
{
    // Explodes after a certain amount of time after being instantiated
    public class Grenade : MonoBehaviour
    {
        public CSteamID killer;

        // Damage range of explosion
        public float range;

        public float playerDamage;

        public float zombieDamage;

        public float animalDamage;

        public float barricadeDamage;

        public float structureDamage;

        public float vehicleDamage;

        public float resourceDamage;

        public float objectDamage;

        // Effect GUID to play once exploded
        public Guid explosionEffectGuid;

        // [[Obsolete] Effect ID to play once exploded
        public ushort explosion;

        public float fuseLength = 2.5f;

    	public float explosionLaunchSpeed;

    	public bool shouldDestroySelf = true;
    }
}
