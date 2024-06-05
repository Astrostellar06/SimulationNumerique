using TMPro;
using UnityEngine;

public class DisplayName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI deviceName;
    void Start()
    {
        deviceName.text = $"Device Name: {SystemInfo.deviceModel}";
    }
}
