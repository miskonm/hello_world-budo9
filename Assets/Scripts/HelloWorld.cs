using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    #region Unity lifecycle

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log($"Start {Time.frameCount}");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log($"Update {Time.frameCount}");
    }

    #endregion
}