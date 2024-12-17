using UnityEngine;
using UnityEngine.UIElements;

public class UI_Script : MonoBehaviour
{
    [SerializeField] private UIDocument _document;
    [SerializeField] private StyleSheet _styleSheet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Generate();
    }

    void Generate()
    {
        var root = _document.rootVisualElement;
        root.styleSheets.Add(_styleSheet);

        var title = new Label("Valley of the Wild");
        title.AddToClassList("label");
        //title.style.fontSize = 30;
        //title.style.unityFontStyleAndWeight = FontStyle.Bold;
        //title.style.color = new Color(0.9f, 0.9f, 0.9f, 1);
        //title.style.unityTextAlign = TextAnchor.MiddleCenter;

        //root.style.backgroundColor = new Color(0.1f, 0.1f, 0.1f, 1);
        root.Add(title);
    }
}
