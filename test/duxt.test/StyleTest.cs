using System.Text.RegularExpressions;
using duxt.styles;

namespace duxt.test;

[TestFixture]
public class StyleTest
{
    static string ToStyleProperty(string text) =>
        Regex.Replace(text, "(?<=[a-z])([A-Z])", "-$1").ToLower();

    [Test]
    public void All_properties_generate_name_correctly()
    {
        var properties = typeof(Styles).GetProperties();
        List<string> styleProperties = [];

        var styles = new Styles{
            AlignItems = "x",
            BackgroundColor = "x",
            AlignContent = "x",
            AlignSelf = "x",
            Background = "x",
            BackgroundImage = "x",
            BackgroundRepeat = "x",
            BackgroundSize = "x",
            Border = "x",
            BorderBottom = "x",
            BorderBottomColor = "x",
            BorderBottomLeftRadius = "x",
            BorderBottomRightRadius = "x",
            BorderBottomStyle = "x",
            BorderBottomWidth = "x",
            BorderCollapse = "x",
            BorderColor = "x",
            BorderLeft = "x",
            BorderLeftColor = "x",
            BorderLeftStyle = "x",
            BorderLeftWidth = "x",
            BorderRadius = "x",
            BorderRight = "x",
            BorderRightColor = "x",
            BorderRightStyle = "x",
            BorderRightWidth = "x",
            BorderSpacing = "x",
            BorderStyle = "x",
            BorderTop = "x",
            BorderTopColor = "x",
            BorderTopLeftRadius = "x",
            BorderTopRightRadius = "x",
            BorderTopStyle = "x",
            BorderTopWidth = "x",
            BorderWidth = "x",
            Bottom = "x",
            BoxDecorationBreak = "x",
            BoxShadow = "x",
            BoxSizing = "x",
            BreakAfter = "x",
            BreakBefore = "x",
            CaptionSide = "x",
            CaretColor = "x",
            Clear = "x",
            Columns = "x",
            ColumnCount = "x",
            ColumnFill = "x",
            ColumnGap = "x",
            ColumnRule = "x",
            ColumnRuleColor = "x",
            ColumnRuleStyle = "x",
            ColumnRuleWidth = "x",
            ColumnSpan = "x",
            ColumnWidth = "x",
            Color = "x",
            Content = "x",
            CounterReset = "x",
            Cursor = "x",
            Direction = "x",
            Display = "x",
            Filter = "x",
            Flex = "x",
            FlexBasis = "x",
            FlexDirection = "x",
            FlexFlow = "x",
            FlexGrow = "x",
            FlexShrink = "x",
            FlexWrap = "x",
            Font = "x",
            FontFamily = "x",
            FontFeatureSettings = "x",
            FontKerning = "x",
            FontSize = "x",
            FontSizeAdjust = "x",
            FontStretch = "x",
            FontStyle = "x",
            FontSynthesis = "x",
            FontWeight = "x",
            Grid = "x",
            GridArea = "x",
            GridAutoColumns = "x",
            GridAutoFlow = "x",
            GridAutoRows = "x",
            GridColumn = "x",
            GridColumnEnd = "x",
            GridColumnGap = "x",
            GridColumnStart = "x",
            GridGap = "x",
            GridRow = "x",
            GridRowEnd = "x",
            GridRowGap = "x",
            GridRowStart = "x",
            GridTemplate = "x",
            GridTemplateAreas = "x",
            GridTemplateColumns = "x",
            GridTemplateRows = "x",
            Height = "x",
            Left = "x",
            LetterSpacing = "x",
            LineBreak = "x",
            LineHeight = "x",
            ListStyle = "x",
            ListStyleType = "x",
            MarginBottom = "x",
            MarginLeft = "x",
            MarginRight = "x",
            MarginTop = "x",
            Margin = "x",
            MaxHeight = "x",
            MaxWidth = "x",
            MinHeight = "x",
            MinWidth = "x",
            ObjectFit = "x",
            Opacity = "x",
            Order = "x",
            Outline = "x",
            OutlineColor = "x",
            OutlineOffset = "x",
            OutlineStyle = "x",
            OutlineWidth = "x",
            Overflow = "x",
            OverflowX = "x",
            OverflowY = "x",
            Padding = "x",
            PaddingBottom = "x",
            PaddingLeft = "x",
            PaddingRight = "x",
            PaddingTop = "x",
            PointerEvents = "x",
            Position = "x",
            Resize = "x",
            Right = "x",
            Rotate = "x",
            Scale = "x",
            ScrollBehavior = "x",
            TabSize = "x",
            Transition = "x",
            TableLayout = "x",
            TextAlignLast = "x",
            TextDecoration = "x",
            TextDecorationColor = "x",
            TextDecorationLine = "x",
            TextDecorationStyle = "x",
            TextIndent = "x",
            TextJustify = "x",
            TextOverflow = "x",
            TextShadow = "x",
            TextTransform = "x",
            Top = "x",
            Transform = "x",
            VerticalAlign = "x",
            Visibility = "x",
            WhiteSpace = "x",
            Width = "x",
            WordBreak = "x",
            WordSpacing = "x",
            WordWrap = "x",
            JustifyContent = "x",
            TextAlign = "x",
        };
        var display = styles.DisplayYDirection();
        foreach(var property in properties)
        {
            styleProperties.Add($"{ToStyleProperty(property.Name)}: x;");
        }

        Assert.That(display, Is.EqualTo(string.Join("\n", styleProperties)));
    }

    [Test]
    public void If_property_not_set_a_value_its_not_display()
    {
        var styles = new Styles();
        var stylePropertyName = "background-color";

        Assert.That(styles.DisplayYDirection(), Is.Not.Contains(stylePropertyName));

        styles.BackgroundColor = "#111111";

        Assert.That(styles.DisplayYDirection(), Contains.Substring(stylePropertyName));
    }

    [Test]
    public void If_set_a_value_to_property_its_display_correctly()
    {
        var styles = new Styles
        {
            BackgroundColor = "#111111"
        };

        var actual = styles.DisplayYDirection();

        Assert.That(actual, Contains.Substring("background-color: #111111;"));
    }
}
