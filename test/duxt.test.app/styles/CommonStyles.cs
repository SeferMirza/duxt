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
                Display = "flex",
                FlexDirection = "column",
                JustifyContent = "center",
                AlignItems = "center",
                Height = "100%"
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

    public static (string, Styles) Terminal =>
        (
            "#terminal",
            new() {
                Width = "750px",
                Height = "450px",
                //BackgroundColor = "midnightblue",
                BorderRadius = "15px"
            }
        );
}