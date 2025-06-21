using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private GameObject _leftGenTrigger;
    [SerializeField] private GameObject _rightGenTrigger;

    public void DisableLeftGenTrigger()
    {
        _leftGenTrigger.SetActive(false);
    }

    public void DisableRightGenTrigger()
    {
        _rightGenTrigger.SetActive(false);
    }
}
