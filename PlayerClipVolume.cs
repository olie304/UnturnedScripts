using System;
using SDG.Framework.Debug;
using SDG.Framework.Devkit.Visibility;
using SDG.Framework.IO.FormattedFiles;
using SDG.Unturned;
using UnityEngine;

namespace SDG.Framework.Devkit
{
    // Requires a BoxCollider on the base Game Object
    // Presumably prevents players from passing through the BoxCollider but not other entities?
    // Game Object Layer is set to 21 at runtime and cannot be overriden
    public class PlayerClipVolume : MonoBehaviour
    {
        // Whether or not to block the player from crossing through
        [SerializeField]
        protected bool _blockPlayer;
    }
}
