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
                Color = "aqua",
                FontWeight = "bolder"
            }
        );

    public static (string, Styles) Entry =>
        (
            ".entry",
            new Styles
            {
                Display = "flex",
                FlexDirection = "row",
                JustifyContent = "center",
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
                FontWeight = "bold"
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
                Color = "darkred",
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
                Color = "#c98b19"
            }
        );

    public static (string, Styles) Input =>
        (
            "#input",
            new Styles
            {
                BackgroundColor = "transparent",
                Border = "0",
                Color = "#eaeaea",
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
                Color = "darkred",
                MarginTop = "auto",
                MarginBottom = "auto"
            }
        );

    public static (string, Styles) SkillsContainer =>
        (
            ".skills-container",
            new Styles
            {
                ListStyleType = "none",
                PaddingLeft = "10px"
            }
        );

    public static (string, Styles) SpecialCharacter =>
        (
            ".special-character",
            new Styles
            {
                Color = "darkblue"
            }
        );

    public static (string, Styles) Terminal =>
        (
            "#terminal",
            new() {
                Width = "750px",
                Height = "450px",
                Padding = "10px",
                BackgroundColor = "#2e2e2e",
                Color = "#eaeaea",
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

    public static List<(string, Styles)> GetAllStyles =>
        [
            AboutParagraph,
            Body,
            Container,
            Command,
            Entry,
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
            SkillsContainer,
            SpecialCharacter,
            Terminal,
            Type,
            Variable
        ];
}

/* Tomorrow Yellow */
// .hljs-attribute {
//   color: #e7c547;
// }

// /* Tomorrow Green */
// .hljs-string,
// .hljs-symbol,
// .hljs-bullet,
// .hljs-addition {
//   color: #b9ca4a;
// }

// /* Tomorrow Blue */
// .hljs-title,
// .hljs-section {
//   color: #7aa6da;
// }

// /* Tomorrow Purple */
// .hljs-keyword,
// .hljs-selector-tag {
//   color: #c397d8;
// }

// .hljs-emphasis {
//   font-style: italic;
// }

// .hljs-strong {
//   font-weight: bold;
// }