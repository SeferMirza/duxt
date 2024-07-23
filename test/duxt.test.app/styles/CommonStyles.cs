using duxt.styles;

namespace duxt.app;

public static class CommonStyles
{
    public static (string, Styles) Body =>
        (
            "body",
            new()
            {
                Margin = "0",
                BackgroundColor = "black",
                Color = "white"
            }
        );

    public static (string, Styles) Container =>
        (
            ".container",
            new Styles
            {
                FlexDirection = "column",
                AlignItems = "center"
            }
        );

    public static (string, Styles) Content =>
        (
            ".centered-content",
            new() {
                Display = "flex",
                JustifyContent = "center",
                AlignItems = "center"
            }
        );

    public static (string, Styles) Font =>
        (
            ".monospace",
            new() {
                FontFamily = "VT323, monospace",
                FontWeight = "400"
            }
        );
}