using UnityEngine;

namespace SDG.Unturned
{
    // * WARNING * Might be obsolete now that there is a Unity Event Hook for this in the base game
    // Toggles a binary state object when a phrase is typed in chat within a certain radius of the object.
    // In order for it to work you must create a LevelObject that is on the same position as the parent of this script
    // and it must be a binary state object and it must have the same ID as specified in the ID slot below. I have not
    // been able to test everything so if you are interested and are running into problems leave an issue or contact me some other way.
    // Final Note: In the code it is specified that the chat type must be local and there is a test I am unsure of where if
    // LightingManager.day < LevelLighting.bias then the chat / toggle is ignored. Maybe it means it only works at night?
    public class InteractableBinaryStateChatTrigger : MonoBehaviour
    {
        [Tooltip("Object ID (Choose a random one)")]
        public ushort id;

        [Tooltip("Phrase that will trigger the event")]
        public string phrase;

        [Tooltip("Range of trigger")]
        public float sqrRadius;
    }
}
