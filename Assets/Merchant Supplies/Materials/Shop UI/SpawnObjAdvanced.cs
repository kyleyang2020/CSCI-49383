using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnDistance = 1.0f;
    public float spawnHeight = 0.0f;
    //added moved
    //float goldtotall = GameObject.Find("GoldTracker").GetComponent<GoldTrackerController>().totalGold;
    // create an object reference to the GoldTrackerController class
    //GoldTrackerController goldTracker = Canvas.FindObjectOfType<GoldTrackerController>();
    //GoldTrackerController goldTracker;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        //GoldTrackerController goldTracker = Canvas.FindObjectOfType<GoldTrackerController>();

        if (button != null)
        {
            button.onClick.AddListener(SpawnObjectOnClick);
        }
        else
        {
            Debug.LogError("SpawnObject: No button component found on game object");
        }
    }

    private void SpawnObjectOnClick()
    {
        if (objectToSpawn == null)
        {
            Debug.LogError("SpawnObject: No object to spawn has been set");
            return;
        }

        // Get the position and rotation of the button
        Vector3 buttonPosition = button.transform.position;
        Quaternion buttonRotation = button.transform.rotation;

        // Calculate the spawn position in front of the button
        Vector3 spawnPosition = buttonPosition + buttonRotation * Vector3.forward * spawnDistance;
        spawnPosition.y = spawnHeight;

        // Spawn the object at the calculated position and rotation
        if (GoldTrackerController.totalGold >= 500 )
        {
	    GoldTrackerController.totalGold = GoldTrackerController.totalGold - 500;
	    GoldTrackerController.goldText.text = "Gold: " + GoldTrackerController.totalGold.ToString();
            Instantiate(objectToSpawn, spawnPosition, buttonRotation);
        }
    }
}
