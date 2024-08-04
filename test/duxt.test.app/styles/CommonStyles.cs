using duxt.styles;

namespace duxt.app;

public static class CommonStyles
{
    public static (string, Styles) AboutParagraph =>
        (
            ".about-paragraph",
            new()
            {
                MarginBlock = "0"
            }
        );

    public static (string, Styles) Body =>
        (
            "body",
            new()
            {
                Margin = "0"
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
                Height = "100%",
                BackgroundColor = "#2e2e2e"
            }
        );

    public static (string, Styles) Command =>
        (
            ".command",
            new Styles
            {
                Color = "#70C0B1",
                FontWeight = "bolder"
            }
        );

    public static (string, Styles) Shell =>
        (
            ".shell",
            new Styles
            {
                Display = "flex",
                Margin = "6px 0 6px 0"
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

    public static (string, Styles) Label =>
        (
            "#label",
            new Styles
            {
                FontWeight = "bold",
                PaddingTop = "3px"
            }
        );

    public static (string, Styles) LinksContainer =>
        (
            ".links-container",
            new Styles
            {
                Display = "flex",
                JustifyContent = "center",
                AlignItems = "center",
                Width = "100%",
                Gap = "20%",
                Padding = "30px 0"
            }
        );

    public static (string, Styles) LinkBox =>
        (
            ".link-box",
            new Styles
            {
                Display = "flex",
                JustifyContent = "center",
                AlignItems = "center",
                Width = "60px",
                Height = "60px",
            }
        );

    public static (string, Styles) ListStar =>
        (
            ".list-star",
            new Styles
            {
                Color = "#D54E53",
            }
        );

    public static (string, Styles) Note =>
        (
            ".note",
            new Styles
            {
                Color = "#969896",
            }
        );

    public static (string, Styles) NoteContainer =>
        (
            ".not-container",
            new Styles
            {
                Display = "flex"
            }
        );

    public static (string, Styles) History =>
        (
            "#history",
            new Styles
            {
                WordWrap = "break-word",
                Margin = "3px"
            }
        );

    public static (string, Styles) Input =>
        (
            "#input",
            new Styles
            {
                BackgroundColor = "transparent",
                Border = "0",
                Color = "#70C0B1",
                JustifyContent = "center",
                FontSize = "16px",
                Width = "100%",
                WordWrap = "break-word",
                FontWeight = "bold",
                FontFamily = @"""Cascadia Mono"", sans-serif",
            }
        );

    public static (string, Styles) InputFocus =>
        (
            "#input:focus-visible",
            new Styles
            {
                Outline = "0"
            }
        );

    public static (string, Styles) InvisibleScrollbar =>
        (
            "::-webkit-scrollbar",
            new Styles
            {
                Border = "0"
            }
        );

    public static (string, Styles) Pointer =>
        (
            ".pointer",
            new Styles
            {
                Color = "#D54E53",
                MarginTop = "auto",
                MarginBottom = "auto"
            }
        );

    public static (string, Styles) List =>
        (
            ".list",
            new Styles
            {
                ListStyleType = "none",
                PaddingLeft = "20px"
            }
        );

    public static (string, Styles) SpecialCharacter =>
        (
            ".special-character",
            new Styles
            {
                Color = "#79A6DA"
            }
        );

    public static (string, Styles) Terminal =>
        (
            "#terminal",
            new() {
                Width = "750px",
                Height = "450px",
                Padding = "10px",
                BackgroundColor = "black",
                Color = "#E7C547",
                BoxShadow = "0 0 10px 7px rgba(255, 255, 255, 0.3)",
                FontFamily = @"""Cascadia Mono"", sans-serif",
                OverflowY = "scroll",
                BorderRadius = "15px"
            }
        );

    public static (string, Styles) Type =>
        (
            ".type",
            new() {
                Color = "#e78c45"
            }
        );

    public static (string, Styles) Variable =>
        (
            ".variable",
            new() {
                Color = "#d54e52"
            }
        );

    public static (string, Styles) UserName =>
        (
            ".username",
            new() {
                Color = "#79A6DA"
            }
        );

    public static (string, Styles) ServerNameWithDomain =>
        (
            ".server-name-with-domain",
            new() {
                Color = "#D54E53"
            }
        );

    public static List<(string, Styles)> GetAllStyles =>
        [
            AboutParagraph,
            Body,
            Container,
            Command,
            Shell,
            Font,
            Label,
            LinksContainer,
            LinkBox,
            ListStar,
            Note,
            NoteContainer,
            History,
            Input,
            InputFocus,
            InvisibleScrollbar,
            Pointer,
            List,
            SpecialCharacter,
            Terminal,
            Type,
            Variable,
            UserName,
            ServerNameWithDomain
        ];
}
