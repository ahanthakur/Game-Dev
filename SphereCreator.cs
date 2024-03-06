using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public int numberOfSpheres;
    public GameObject spherePrefab;

    void Start()
    {
        CreateSpheres();
    }

    void CreateSpheres()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            GameObject sphere = Instantiate(spherePrefab);
            sphere.transform.position = RandomPosition();
            sphere.GetComponent<Renderer>().material.color = GetRandomColor();
        }
    }

    Vector3 RandomPosition()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        return new Vector3(x, y, 0f);
    }

    Color GetRandomColor()
    {
        int randomColorIndex = Random.Range(0, 3);
        switch (randomColorIndex)
        {
            case 0:
                return Color.red;
            case 1:
                return Color.green;
            case 2:
                return Color.blue;
            default:
                return Color.white;
        }
    }
}
