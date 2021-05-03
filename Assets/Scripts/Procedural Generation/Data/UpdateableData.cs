using UnityEngine;

public class UpdateableData : ScriptableObject
{
    public event System.Action OnValuesUpdated;
    public bool autoUpate;

    #if UNITY_EDITOR
    protected virtual void OnValidate()
    {
        if (autoUpate)
            UnityEditor.EditorApplication.update += NotifyOfUpdatedValues;
    }

    public void NotifyOfUpdatedValues()
    {
        UnityEditor.EditorApplication.update -= NotifyOfUpdatedValues;
        if (OnValuesUpdated != null)
            OnValuesUpdated();
    }
    #endif
}
