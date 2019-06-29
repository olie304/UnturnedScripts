using UnityEngine;

namespace SDG.Framework.Devkit
{
    //Requires a Sphere Collider where spawning can occur. Radius is forcibly set to 0.5 on enable but the scale and position can probably be overrided
    public class Spawnpoint : MonoBehaviour
    {
        [Tooltip("Name of Spawnpoint")]
        public string id;

        [Tooltip("Some editor thing")]
        public bool isSelected;
    }
}
