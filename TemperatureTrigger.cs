using UnityEngine;

namespace SDG.Unturned
{
    // Creates a Temperature Bubble which applies the specified effect when the player is inside.
    // The Bubble is positioned at the position of the Game Object the script is attatched to and has a radius of the X scale of the same Game Object's Transform component
    public class TemperatureTrigger : MonoBehaviour
    {
    // Specifed effect to apply to player inside bubble
    public EPlayerTemperature temperature;
    }

    public enum EPlayerTemperature
    {
    FREEZING,
    COLD,
    WARM,
    BURNING,
    NONE,
    COVERED,
    ACID
    }
}
