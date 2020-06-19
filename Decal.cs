using UnityEngine;

namespace SDG.Unturned
{
    public enum EDecalType
    {
        DIFFUSE
    }
    
    // Allows you to apply decals to modded objects without the need of two seperate objects or the need of the editor. 
    // This is useful when your object is not part of the landscape and is something like a placeable object or a vehicle.
    // The fallback system is as follows:
    // If the Render Type in the graphics settings is set to forward a MeshRenderer is rendered as the decal. 
    // The MeshRenderer can either be a component on the parent Game Object or a component of another child or the parent named "Mesh".
    // If the Render Type is Deferred then the material is used and will be projected over any meshes within the BoxCollider on the parent Game Object.
    public class Decal : MonoBehaviour
    {
        // There is only one of these...
        [Tooltip("Decal Type")]
        public EDecalType type;

        // Material with the texture and shader etc that the decal is composed of.
        public Material material;

        // The scale of the distance away from the camera before the decal is not rendered. Scales with the Render Distance graphics setting.
        [Tooltip("LOD Bias")]
        public float lodBias = 1f;

        // Some unknown editor thing. Might show selection box around it.
        public bool isSelected;

        // Ignore this, it is automatically set to the Parent's Box Collider which must be specified. It is the space occupied by the decal.
        protected BoxCollider box;
    }
}
