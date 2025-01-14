using UnityEditor;
using UnityEngine;

public static class ToggleInspectorLock
{
    [MenuItem("Tools/Toggle Inspector Lock _F3")]
    private static void ToggleEditorWindowLock()
    {
        ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
        ActiveEditorTracker.sharedTracker.ForceRebuild();
    }
}
