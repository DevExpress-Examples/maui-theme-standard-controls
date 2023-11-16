
namespace DXMaterialThemesApp;

public class ColorModel {
    public Color Color { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public bool IsSystemColor { get; set; }

    public ColorModel(Color color, string displayName, bool isSystemColor = false) {
        Color = color;
        DisplayName = displayName;
        IsSystemColor = isSystemColor;
        Name = isSystemColor ? "System" : string.Empty;
    }
}