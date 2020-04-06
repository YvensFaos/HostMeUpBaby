using UnityEngine;

public class SpawnByClick : MonoBehaviour
{
    [SerializeField]
    private Camera spawnCamera;
    [SerializeField]
    private GameObject spawnObject;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = spawnCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(spawnObject, hit.point, Quaternion.identity);
            }
                
        }
    }
}
