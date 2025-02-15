using UnityEditor;

public static class ToggleComponentsExpanded
{
    [MenuItem("Tools/Collapse All Components %#-")]
    private static void CollapseAllComponents()
    {
        SetEditorsExpanded(false);   
    }
    
    [MenuItem("Tools/Expand All Components %#=")]
    private static void ExpandAllComponents()
    {
        SetEditorsExpanded(true);
    }


    private static void SetEditorsExpanded(bool expanded)
    {
        int visible = expanded ? 1 : 0;
        ActiveEditorTracker tracker = ActiveEditorTracker.sharedTracker;
        for (int i = 0; i < tracker.activeEditors.Length; i++)
        {
            tracker.SetVisible(i, visible);
        }
        
        EditorWindow inspectorWindow = GetInspectorWindow();
        if (inspectorWindow != null) inspectorWindow.Repaint();
    }
    
    private static EditorWindow GetInspectorWindow()
    {
        System.Type inspectorType = typeof(EditorWindow).Assembly.GetType("UnityEditor.InspectorWindow");
        return EditorWindow.GetWindow(inspectorType);
    }
}
