using UnityEngine;
using SDG.Unturned;

namespace SDG.Framework.Devkit
{
    // Instantly kills anything inside of the child Box Trigger Collider
    public class KillVolume : MonoBehaviour
    {       
        public bool killPlayers;

        public bool killZombies;

        public bool killAnimals;

        public bool killVehicles;

        public EDeathCause deathCause;
    }
}

namespace SDG.Unturned
{
    // Token: 0x0200063F RID: 1599
    public enum EDeathCause
    {
        // Token: 0x04001B4E RID: 6990
        BLEEDING,
        // Token: 0x04001B4F RID: 6991
        BONES,
        // Token: 0x04001B50 RID: 6992
        FREEZING,
        // Token: 0x04001B51 RID: 6993
        BURNING,
        // Token: 0x04001B52 RID: 6994
        FOOD,
        // Token: 0x04001B53 RID: 6995
        WATER,
        // Token: 0x04001B54 RID: 6996
        GUN,
        // Token: 0x04001B55 RID: 6997
        MELEE,
        // Token: 0x04001B56 RID: 6998
        ZOMBIE,
        // Token: 0x04001B57 RID: 6999
        ANIMAL,
        // Token: 0x04001B58 RID: 7000
        SUICIDE,
        // Token: 0x04001B59 RID: 7001
        KILL,
        // Token: 0x04001B5A RID: 7002
        INFECTION,
        // Token: 0x04001B5B RID: 7003
        PUNCH,
        // Token: 0x04001B5C RID: 7004
        BREATH,
        // Token: 0x04001B5D RID: 7005
        ROADKILL,
        // Token: 0x04001B5E RID: 7006
        VEHICLE,
        // Token: 0x04001B5F RID: 7007
        GRENADE,
        // Token: 0x04001B60 RID: 7008
        SHRED,
        // Token: 0x04001B61 RID: 7009
        LANDMINE,
        // Token: 0x04001B62 RID: 7010
        ARENA,
        // Token: 0x04001B63 RID: 7011
        MISSILE,
        // Token: 0x04001B64 RID: 7012
        CHARGE,
        // Token: 0x04001B65 RID: 7013
        SPLASH,
        // Token: 0x04001B66 RID: 7014
        SENTRY,
        // Token: 0x04001B67 RID: 7015
        ACID,
        // Token: 0x04001B68 RID: 7016
        BOULDER,
        // Token: 0x04001B69 RID: 7017
        BURNER,
        // Token: 0x04001B6A RID: 7018
        SPIT,
        // Token: 0x04001B6B RID: 7019
        SPARK
    }
}

