using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{
    const float SPEED = 6f;

    [SerializeField]
    public Transform sectionInfo;

    Vector3 desiredScale = Vector3.zero;

    void Update()
    {
        sectionInfo.localScale = Vector3.Lerp(sectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    public void OpenInfo() 
    {
        desiredScale = Vector3.one;
    }
    public void CloseInfo() 
    {
        desiredScale = Vector3.zero;
    }
}
