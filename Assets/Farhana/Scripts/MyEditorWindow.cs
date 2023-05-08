using UnityEngine;
using UnityEditor;

public class MyEditorWindow : EditorWindow
{
    private ObjectPreview preview;

    private void OnEnable()
    {
        // Create an instance of the ObjectPreview class
        preview = new ObjectPreview();

        // Do something with the preview instance
        // ...

    }

    private void OnDisable()
    {
        // Cleanup the ObjectPreview instance
        if (preview != null)
        {
            preview.Cleanup();
            preview = null;
        }
    }
}
