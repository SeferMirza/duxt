namespace duxt.styles;

public class Styles
{
    private readonly List<(string, object)> _css = [];

    #region fields
    private string _alignItems = "left";
    private string _alignContent = "left";
    private string _alignSelf = "left";
    private string _background = "none";
    private string _backgroundColor = "#000000";
    private string _backgroundImage = "none";
    private string _backgroundRepeat = "none";
    private string _backgroundSize = "none";
    private string _border = "none";
    private string _borderBottom = "none";
    private string _borderBottomColor = "none";
    private string _borderBottomLeftRadius = "none";
    private string _borderBottomRightRadius = "none";
    private string _borderBottomStyle = "none";
    private string _borderBottomWidth = "none";
    private string _borderCollapse = "none";
    private string _borderColor = "none";
    private string _borderLeft = "none";
    private string _borderLeftColor = "none";
    private string _borderLeftStyle = "none";
    private string _borderLeftWidth = "none";
    private string _borderRadius = "none";
    private string _borderRight = "none";
    private string _borderRightColor = "none";
    private string _borderRightStyle = "none";
    private string _borderRightWidth = "none";
    private string _borderSpacing = "none";
    private string _borderStyle = "none";
    private string _borderTop = "none";
    private string _borderTopColor = "none";
    private string _borderTopLeftRadius = "none";
    private string _borderTopRightRadius = "none";
    private string _borderTopStyle = "none";
    private string _borderTopWidth = "none";
    private string _borderWidth = "none";
    private string _color = "#FFFFFF";
    private string _margin = "0";
    private string _justifyContent = "left";
    private string _textAlign = "left";
    private string _bottom = "none";
    private string _boxDecorationBreak = "none";
    private string _boxShadow = "none";
    private string _boxSizing = "none";
    private string _breakAfter = "none";
    private string _breakBefore = "none";
    private string _captionSide = "none";
    private string _caretColor = "none";
    private string _clear = "none";
    private string _columnCount = "none";
    private string _columnFill = "none";
    private string _columnGap = "none";
    private string _columnRule = "none";
    private string _columnRuleColor = "none";
    private string _columnRuleStyle = "none";
    private string _columnRuleWidth = "none";
    private string _columnSpan = "none";
    private string _columnWidth = "none";
    private string _columns = "none";
    private string _content = "none";
    private string _counterReset = "none";
    private string _cursor = "none";
    private string _direction = "none";
    private string _display = "none";
    private string _filter = "none";
    private string _flex = "none";
    private string _flexBasis = "none";
    private string _flexDirection = "none";
    private string _flexFlow = "none";
    private string _flexGrow = "none";
    private string _flexShrink = "none";
    private string _flexWrap = "none";
    private string _font = "none";
    private string _fontFamily = "none";
    private string _fontFeatureSettings = "none";
    private string _fontKerning = "none";
    private string _fontSize = "none";
    private string _fontSizeAdjust = "none";
    private string _fontStretch = "none";
    private string _fontStyle = "none";
    private string _fontSynthesis = "none";
    private string _fontWeight = "none";
    private string _grid = "none";
    private string _gridArea = "none";
    private string _gridAutoColumns = "none";
    private string _gridAutoFlow = "none";
    private string _gridAutoRows = "none";
    private string _gridColumn = "none";
    private string _gridColumnEnd = "none";
    private string _gridColumnGap = "none";
    private string _gridColumnStart = "none";
    private string _gridGap = "none";
    private string _gridRow = "none";
    private string _gridRowEnd = "none";
    private string _gridRowGap = "none";
    private string _gridRowStart = "none";
    private string _gridTemplate = "none";
    private string _gridTemplateAreas = "none";
    private string _gridTemplateColumns = "none";
    private string _gridTemplateRows = "none";
    private string _height = "none";
    private string _left = "none";
    private string _letterSpacing = "none";
    private string _lineBreak = "none";
    private string _lineHeight = "none";
    private string _listStyle = "none";
    private string _listStyleType = "none";
    private string _marginBottom = "none";
    private string _marginLeft = "none";
    private string _marginRight = "none";
    private string _marginTop = "none";
    private string _maxHeight = "none";
    private string _maxWidth = "none";
    private string _minHeight = "none";
    private string _minWidth = "none";
    private string _objectFit = "none";
    private string _opacity = "none";
    private string _order = "none";
    private string _outline = "none";
    private string _outlineColor = "none";
    private string _outlineOffset = "none";
    private string _outlineStyle = "none";
    private string _outlineWidth = "none";
    private string _overflow = "none";
    private string _overflowX = "none";
    private string _overflowY = "none";
    private string _padding = "none";
    private string _paddingBottom = "none";
    private string _paddingLeft = "none";
    private string _paddingRight = "none";
    private string _paddingTop = "none";
    private string _pointerEvents = "none";
    private string _position = "none";
    private string _resize = "none";
    private string _right = "none";
    private string _rotate = "none";
    private string _scale = "none";
    private string _scrollBehavior = "none";
    private string _transition = "none";
    private string _tabSize = "none";
    private string _tableLayout = "none";
    private string _textAlignLast = "none";
    private string _textDecoration = "none";
    private string _textDecorationColor = "none";
    private string _textDecorationLine = "none";
    private string _textDecorationStyle = "none";
    private string _textIndent = "none";
    private string _textJustify = "none";
    private string _textOverflow = "none";
    private string _textShadow = "none";
    private string _textTransform = "none";
    private string _top = "none";
    private string _transform = "none";
    private string _verticalAlign = "none";
    private string _visibility = "none";
    private string _whiteSpace = "none";
    private string _width = "none";
    private string _wordBreak = "none";
    private string _wordSpacing = "none";
    private string _wordWrap = "none";
    #endregion
    #region properties
    public string AlignItems
    {
        get { return _alignItems; }
        set {
            _css.Add(("align-items", value));
            _alignItems = value;
        }
    }
    public string BackgroundColor
    {
        get { return _backgroundColor; }
        set {
            _css.Add(("background-color", value));
            _backgroundColor = value;
        }
    }
    public string AlignContent
    {
        get { return _alignContent; }
        set {
            _css.Add(("align-content", value));
            _alignContent = value;
        }
    }
    public string AlignSelf
    {
        get { return _alignSelf; }
        set {
            _css.Add(("align-self", value));
            _alignSelf = value;
        }
    }
    public string Background
    {
        get { return _background; }
        set {
            _css.Add(("background", value));
            _background = value;
        }
    }
    public string BackgroundImage
    {
        get { return _backgroundImage; }
        set {
            _css.Add(("background-image", value));
            _backgroundImage = value;
        }
    }
    public string BackgroundRepeat
    {
        get { return _backgroundRepeat; }
        set {
            _css.Add(("background-repeat", value));
            _backgroundRepeat = value;
        }
    }
    public string BackgroundSize
    {
        get { return _backgroundSize; }
        set {
            _css.Add(("background-size", value));
            _backgroundSize = value;
        }
    }
    public string Border
    {
        get { return _border; }
        set {
            _css.Add(("border", value));
            _border = value;
        }
    }
    public string BorderBottom
    {
        get { return _borderBottom; }
        set {
            _css.Add(("border-bottom", value));
            _borderBottom = value;
        }
    }
    public string BorderBottomColor
    {
        get { return _borderBottomColor; }
        set {
            _css.Add(("border-bottom-color", value));
            _borderBottomColor = value;
        }
    }
    public string BorderBottomLeftRadius
    {
        get { return _borderBottomLeftRadius; }
        set {
            _css.Add(("border-bottom-left-radius", value));
            _borderBottomLeftRadius = value;
        }
    }
    public string BorderBottomRightRadius
    {
        get { return _borderBottomRightRadius; }
        set {
            _css.Add(("border-bottom-right-radius", value));
            _borderBottomRightRadius = value;
        }
    }
    public string BorderBottomStyle
    {
        get { return _borderBottomStyle; }
        set {
            _css.Add(("border-bottom-style", value));
            _borderBottomStyle = value;
        }
    }
    public string BorderBottomWidth
    {
        get { return _borderBottomWidth; }
        set {
            _css.Add(("border-bottom-width", value));
            _borderBottomWidth = value;
        }
    }
    public string BorderCollapse
    {
        get { return _borderCollapse; }
        set {
            _css.Add(("border-collapse", value));
            _borderCollapse = value;
        }
    }
    public string BorderColor
    {
        get { return _borderColor; }
        set {
            _css.Add(("border-color", value));
            _borderColor = value;
        }
    }
    public string BorderLeft
    {
        get { return _borderLeft; }
        set {
            _css.Add(("border-left", value));
            _borderLeft = value;
        }
    }
    public string BorderLeftColor
    {
        get { return _borderLeftColor; }
        set {
            _css.Add(("border-left-color", value));
            _borderLeftColor = value;
        }
    }
    public string BorderLeftStyle
    {
        get { return _borderLeftStyle; }
        set {
            _css.Add(("border-left-style", value));
            _borderLeftStyle = value;
        }
    }
    public string BorderLeftWidth
    {
        get { return _borderLeftWidth; }
        set {
            _css.Add(("border-left-width", value));
            _borderLeftWidth = value;
        }
    }
    public string BorderRadius
    {
        get { return _borderRadius; }
        set {
            _css.Add(("border-radius", value));
            _borderRadius = value;
        }
    }
    public string BorderRight
    {
        get { return _borderRight; }
        set {
            _css.Add(("border-right", value));
            _borderRight = value;
        }
    }
    public string BorderRightColor
    {
        get { return _borderRightColor; }
        set {
            _css.Add(("border-right-color", value));
            _borderRightColor = value;
        }
    }
    public string BorderRightStyle
    {
        get { return _borderRightStyle; }
        set {
            _css.Add(("border-right-style", value));
            _borderRightStyle = value;
        }
    }
    public string BorderRightWidth
    {
        get { return _borderRightWidth; }
        set {
            _css.Add(("border-right-width", value));
            _borderRightWidth = value;
        }
    }
    public string BorderSpacing
    {
        get { return _borderSpacing; }
        set {
            _css.Add(("border-spacing", value));
            _borderSpacing = value;
        }
    }
    public string BorderStyle
    {
        get { return _borderStyle; }
        set {
            _css.Add(("border-style", value));
            _borderStyle = value;
        }
    }
    public string BorderTop
    {
        get { return _borderTop; }
        set {
            _css.Add(("border-top", value));
            _borderTop = value;
        }
    }
    public string BorderTopColor
    {
        get { return _borderTopColor; }
        set {
            _css.Add(("border-top-color", value));
            _borderTopColor = value;
        }
    }
    public string BorderTopLeftRadius
    {
        get { return _borderTopLeftRadius; }
        set {
            _css.Add(("border-top-left-radius", value));
            _borderTopLeftRadius = value;
        }
    }
    public string BorderTopRightRadius
    {
        get { return _borderTopRightRadius; }
        set {
            _css.Add(("border-top-right-radius", value));
            _borderTopRightRadius = value;
        }
    }
    public string BorderTopStyle
    {
        get { return _borderTopStyle; }
        set {
            _css.Add(("border-top-style", value));
            _borderTopStyle = value;
        }
    }
    public string BorderTopWidth
    {
        get { return _borderTopWidth; }
        set {
            _css.Add(("border-top-width", value));
            _borderTopWidth = value;
        }
    }
    public string BorderWidth
    {
        get { return _borderWidth; }
        set {
            _css.Add(("border-width", value));
            _borderWidth = value;
        }
    }
    public string Bottom
    {
        get { return _bottom; }
        set {
            _css.Add(("bottom", value));
            _bottom = value;
        }
    }
    public string BoxDecorationBreak
    {
        get { return _boxDecorationBreak; }
        set {
            _css.Add(("box-decoration-break", value));
            _boxDecorationBreak = value;
        }
    }
    public string BoxShadow
    {
        get { return _boxShadow; }
        set {
            _css.Add(("box-shadow", value));
            _boxShadow = value;
        }
    }
    public string BoxSizing
    {
        get { return _boxSizing; }
        set {
            _css.Add(("box-sizing", value));
            _boxSizing = value;
        }
    }
    public string BreakAfter
    {
        get { return _breakAfter; }
        set {
            _css.Add(("break-after", value));
            _breakAfter = value;
        }
    }
    public string BreakBefore
    {
        get { return _breakBefore; }
        set {
            _css.Add(("break-before", value));
            _breakBefore = value;
        }
    }
    public string CaptionSide
    {
        get { return _captionSide; }
        set {
            _css.Add(("caption-side", value));
            _captionSide = value;
        }
    }
    public string CaretColor
    {
        get { return _caretColor; }
        set {
            _css.Add(("caret-color", value));
            _caretColor = value;
        }
    }
    public string Clear
    {
        get { return _clear; }
        set {
            _css.Add(("clear", value));
            _clear = value;
        }
    }
    public string Columns
    {
        get { return _columns; }
        set {
            _css.Add(("columns", value));
            _columns = value;
        }
    }
    public string ColumnCount
    {
        get { return _columnCount; }
        set {
            _css.Add(("column-count", value));
            _columnCount = value;
        }
    }
    public string ColumnFill
    {
        get { return _columnFill; }
        set {
            _css.Add(("column-fill", value));
            _columnFill = value;
        }
    }
    public string ColumnGap
    {
        get { return _columnGap; }
        set {
            _css.Add(("column-gap", value));
            _columnGap = value;
        }
    }
    public string ColumnRule
    {
        get { return _columnRule; }
        set {
            _css.Add(("column-rule", value));
            _columnRule = value;
        }
    }
    public string ColumnRuleColor
    {
        get { return _columnRuleColor; }
        set {
            _css.Add(("column-rule-color", value));
            _columnRuleColor = value;
        }
    }
    public string ColumnRuleStyle
    {
        get { return _columnRuleStyle; }
        set {
            _css.Add(("column-rule-style", value));
            _columnRuleStyle = value;
        }
    }
    public string ColumnRuleWidth
    {
        get { return _columnRuleWidth; }
        set {
            _css.Add(("column-rule-width", value));
            _columnRuleWidth = value;
        }
    }
    public string ColumnSpan
    {
        get { return _columnSpan; }
        set {
            _css.Add(("column-span", value));
            _columnSpan = value;
        }
    }
    public string ColumnWidth
    {
        get { return _columnWidth; }
        set {
            _css.Add(("column-width", value));
            _columnWidth = value;
        }
    }
    public string Color
    {
        get { return _color; }
        set {
            _css.Add(("color", value));
            _color = value;
        }
    }
    public string Content
    {
        get { return _content; }
        set {
            _css.Add(("content", value));
            _content = value;
        }
    }
    public string CounterReset
    {
        get { return _counterReset; }
        set {
            _css.Add(("counter-reset", value));
            _counterReset = value;
        }
    }
    public string Cursor
    {
        get { return _cursor; }
        set {
            _css.Add(("cursor", value));
            _cursor = value;
        }
    }
    public string Direction
    {
        get { return _direction; }
        set {
            _css.Add(("direction", value));
            _direction = value;
        }
    }
    public string Display
    {
        get { return _display; }
        set {
            _css.Add(("display", value));
            _display = value;
        }
    }
    public string Filter
    {
        get { return _filter; }
        set {
            _css.Add(("filter", value));
            _filter = value;
        }
    }
    public string Flex
    {
        get { return _flex; }
        set {
            _css.Add(("flex", value));
            _flex = value;
        }
    }
    public string FlexBasis
    {
        get { return _flexBasis; }
        set {
            _css.Add(("flex-basis", value));
            _flexBasis = value;
        }
    }
    public string FlexDirection
    {
        get { return _flexDirection; }
        set {
            _css.Add(("flex-direction", value));
            _flexDirection = value;
        }
    }
    public string FlexFlow
    {
        get { return _flexFlow; }
        set {
            _css.Add(("flex-flow", value));
            _flexFlow = value;
        }
    }
    public string FlexGrow
    {
        get { return _flexGrow; }
        set {
            _css.Add(("flex-grow", value));
            _flexGrow = value;
        }
    }
    public string FlexShrink
    {
        get { return _flexShrink; }
        set {
            _css.Add(("flex-shrink", value));
            _flexShrink = value;
        }
    }
    public string FlexWrap
    {
        get { return _flexWrap; }
        set {
            _css.Add(("flex-wrap", value));
            _flexWrap = value;
        }
    }
    public string Font
    {
        get { return _font; }
        set {
            _css.Add(("font", value));
            _font = value;
        }
    }
    public string FontFamily
    {
        get { return _fontFamily; }
        set {
            _css.Add(("font-family", value));
            _fontFamily = value;
        }
    }
    public string FontFeatureSettings
    {
        get { return _fontFeatureSettings; }
        set {
            _css.Add(("font-feature-settings", value));
            _fontFeatureSettings = value;
        }
    }
    public string FontKerning
    {
        get { return _fontKerning; }
        set {
            _css.Add(("font-kerning", value));
            _fontKerning = value;
        }
    }
    public string FontSize
    {
        get { return _fontSize; }
        set {
            _css.Add(("font-size", value));
            _fontSize = value;
        }
    }
    public string FontSizeAdjust
    {
        get { return _fontSizeAdjust; }
        set {
            _css.Add(("font-size-adjust", value));
            _fontSizeAdjust = value;
        }
    }
    public string FontStretch
    {
        get { return _fontStretch; }
        set {
            _css.Add(("font-stretch", value));
            _fontStretch = value;
        }
    }
    public string FontStyle
    {
        get { return _fontStyle; }
        set {
            _css.Add(("font-style", value));
            _fontStyle = value;
        }
    }
    public string FontSynthesis
    {
        get { return _fontSynthesis; }
        set {
            _css.Add(("font-synthesis", value));
            _fontSynthesis = value;
        }
    }
    public string FontWeight
    {
        get { return _fontWeight; }
        set {
            _css.Add(("font-weight", value));
            _fontWeight = value;
        }
    }
    public string Grid
    {
        get { return _grid; }
        set {
            _css.Add(("grid", value));
            _grid = value;
        }
    }
    public string GridArea
    {
        get { return _gridArea; }
        set {
            _css.Add(("grid-area", value));
            _gridArea = value;
        }
    }
    public string GridAutoColumns
    {
        get { return _gridAutoColumns; }
        set {
            _css.Add(("grid-auto-columns", value));
            _gridAutoColumns = value;
        }
    }
    public string GridAutoFlow
    {
        get { return _gridAutoFlow; }
        set {
            _css.Add(("grid-auto-flow", value));
            _gridAutoFlow = value;
        }
    }
    public string GridAutoRows
    {
        get { return _gridAutoRows; }
        set {
            _css.Add(("grid-auto-rows", value));
            _gridAutoRows = value;
        }
    }
    public string GridColumn
    {
        get { return _gridColumn; }
        set {
            _css.Add(("grid-column", value));
            _gridColumn = value;
        }
    }
    public string GridColumnEnd
    {
        get { return _gridColumnEnd; }
        set {
            _css.Add(("grid-column-end", value));
            _gridColumnEnd = value;
        }
    }
    public string GridColumnGap
    {
        get { return _gridColumnGap; }
        set {
            _css.Add(("grid-column-gap", value));
            _gridColumnGap = value;
        }
    }
    public string GridColumnStart
    {
        get { return _gridColumnStart; }
        set {
            _css.Add(("grid-column-start", value));
            _gridColumnStart = value;
        }
    }
    public string GridGap
    {
        get { return _gridGap; }
        set {
            _css.Add(("grid-gap", value));
            _gridGap = value;
        }
    }
    public string GridRow
    {
        get { return _gridRow; }
        set {
            _css.Add(("grid-row", value));
            _gridRow = value;
        }
    }
    public string GridRowEnd
    {
        get { return _gridRowEnd; }
        set {
            _css.Add(("grid-row-end", value));
            _gridRowEnd = value;
        }
    }
    public string GridRowGap
    {
        get { return _gridRowGap; }
        set {
            _css.Add(("grid-row-gap", value));
            _gridRowGap = value;
        }
    }
    public string GridRowStart
    {
        get { return _gridRowStart; }
        set {
            _css.Add(("grid-row-start", value));
            _gridRowStart = value;
        }
    }
    public string GridTemplate
    {
        get { return _gridTemplate; }
        set {
            _css.Add(("grid-template", value));
            _gridTemplate = value;
        }
    }
    public string GridTemplateAreas
    {
        get { return _gridTemplateAreas; }
        set {
            _css.Add(("grid-template-areas", value));
            _gridTemplateAreas = value;
        }
    }
    public string GridTemplateColumns
    {
        get { return _gridTemplateColumns; }
        set {
            _css.Add(("grid-template-columns", value));
            _gridTemplateColumns = value;
        }
    }
    public string GridTemplateRows
    {
        get { return _gridTemplateRows; }
        set {
            _css.Add(("grid-template-rows", value));
            _gridTemplateRows = value;
        }
    }
    public string Height
    {
        get { return _height; }
        set {
            _css.Add(("height", value));
            _height = value;
        }
    }
    public string Left
    {
        get { return _left; }
        set {
            _css.Add(("left", value));
            _left = value;
        }
    }
    public string LetterSpacing
    {
        get { return _letterSpacing; }
        set {
            _css.Add(("letter-spacing", value));
            _letterSpacing = value;
        }
    }
    public string LineBreak
    {
        get { return _lineBreak; }
        set {
            _css.Add(("line-break", value));
            _lineBreak = value;
        }
    }
    public string LineHeight
    {
        get { return _lineHeight; }
        set {
            _css.Add(("line-height", value));
            _lineHeight = value;
        }
    }
    public string ListStyle
    {
        get { return _listStyle; }
        set {
            _css.Add(("list-style", value));
            _listStyle = value;
        }
    }
    public string ListStyleType
    {
        get { return _listStyleType; }
        set {
            _css.Add(("list-style-type", value));
            _listStyleType = value;
        }
    }
    public string MarginBottom
    {
        get { return _marginBottom; }
        set {
            _css.Add(("margin-bottom", value));
            _marginBottom = value;
        }
    }
    public string MarginLeft
    {
        get { return _marginLeft; }
        set {
            _css.Add(("margin-left", value));
            _marginLeft = value;
        }
    }
    public string MarginRight
    {
        get { return _marginRight; }
        set {
            _css.Add(("margin-right", value));
            _marginRight = value;
        }
    }
    public string MarginTop
    {
        get { return _marginTop; }
        set {
            _css.Add(("margin-top", value));
            _marginTop = value;
        }
    }
    public string Margin
    {
        get { return _margin; }
        set {
            _css.Add(("margin", value));
            _margin = value;
        }
    }
    public string MaxHeight
    {
        get { return _maxHeight; }
        set {
            _css.Add(("max-height", value));
            _maxHeight = value;
        }
    }
    public string MaxWidth
    {
        get { return _maxWidth; }
        set {
            _css.Add(("max-width", value));
            _maxWidth = value;
        }
    }
    public string MinHeight
    {
        get { return _minHeight; }
        set {
            _css.Add(("min-height", value));
            _minHeight = value;
        }
    }
    public string MinWidth
    {
        get { return _minWidth; }
        set {
            _css.Add(("min-width", value));
            _minWidth = value;
        }
    }
    public string ObjectFit
    {
        get { return _objectFit; }
        set {
            _css.Add(("object-fit", value));
            _objectFit = value;
        }
    }
    public string Opacity
    {
        get { return _opacity; }
        set {
            _css.Add(("opacity", value));
            _opacity = value;
        }
    }
    public string Order
    {
        get { return _order; }
        set {
            _css.Add(("order", value));
            _order = value;
        }
    }
    public string Outline
    {
        get { return _outline; }
        set {
            _css.Add(("outline", value));
            _outline = value;
        }
    }
    public string OutlineColor
    {
        get { return _outlineColor; }
        set {
            _css.Add(("outline-color", value));
            _outlineColor = value;
        }
    }
    public string OutlineOffset
    {
        get { return _outlineOffset; }
        set {
            _css.Add(("outline-offset", value));
            _outlineOffset = value;
        }
    }
    public string OutlineStyle
    {
        get { return _outlineStyle; }
        set {
            _css.Add(("outline-style", value));
            _outlineStyle = value;
        }
    }
    public string OutlineWidth
    {
        get { return _outlineWidth; }
        set {
            _css.Add(("outline-width", value));
            _outlineWidth = value;
        }
    }
    public string Overflow
    {
        get { return _overflow; }
        set {
            _css.Add(("overflow", value));
            _overflow = value;
        }
    }
    public string OverflowX
    {
        get { return _overflowX; }
        set {
            _css.Add(("overflow-x", value));
            _overflowX = value;
        }
    }
    public string OverflowY
    {
        get { return _overflowY; }
        set {
            _css.Add(("overflow-y", value));
            _overflowY = value;
        }
    }
    public string Padding
    {
        get { return _padding; }
        set {
            _css.Add(("padding", value));
            _padding = value;
        }
    }
    public string PaddingBottom
    {
        get { return _paddingBottom; }
        set {
            _css.Add(("padding-bottom", value));
            _paddingBottom = value;
        }
    }
    public string PaddingLeft
    {
        get { return _paddingLeft; }
        set {
            _css.Add(("padding-left", value));
            _paddingLeft = value;
        }
    }
    public string PaddingRight
    {
        get { return _paddingRight; }
        set {
            _css.Add(("padding-right", value));
            _paddingRight = value;
        }
    }
    public string PaddingTop
    {
        get { return _paddingTop; }
        set {
            _css.Add(("padding-top", value));
            _paddingTop = value;
        }
    }
    public string PointerEvents
    {
        get { return _pointerEvents; }
        set {
            _css.Add(("pointer-events", value));
            _pointerEvents = value;
        }
    }
    public string Position
    {
        get { return _position; }
        set {
            _css.Add(("position", value));
            _position = value;
        }
    }
    public string Resize
    {
        get { return _resize; }
        set {
            _css.Add(("resize", value));
            _resize = value;
        }
    }
    public string Right
    {
        get { return _right; }
        set {
            _css.Add(("right", value));
            _right = value;
        }
    }
    public string Rotate
    {
        get { return _rotate; }
        set {
            _css.Add(("rotate", value));
            _rotate = value;
        }
    }
    public string Scale
    {
        get { return _scale; }
        set {
            _css.Add(("scale", value));
            _scale = value;
        }
    }
    public string ScrollBehavior
    {
        get { return _scrollBehavior; }
        set {
            _css.Add(("scroll-behavior", value));
            _scrollBehavior = value;
        }
    }
    public string TabSize
    {
        get { return _tabSize; }
        set {
            _css.Add(("tab-size", value));
            _tabSize = value;
        }
    }
    public string Transition
    {
        get { return _transition; }
        set {
            _css.Add(("transition", value));
            _transition = value;
        }
    }
    public string TableLayout
    {
        get { return _tableLayout; }
        set {
            _css.Add(("table-layout", value));
            _tableLayout = value;
        }
    }
    public string TextAlignLast
    {
        get { return _textAlignLast; }
        set {
            _css.Add(("text-align-last", value));
            _textAlignLast = value;
        }
    }
    public string TextDecoration
    {
        get { return _textDecoration; }
        set {
            _css.Add(("text-decoration", value));
            _textDecoration = value;
        }
    }
    public string TextDecorationColor
    {
        get { return _textDecorationColor; }
        set {
            _css.Add(("text-decoration-color", value));
            _textDecorationColor = value;
        }
    }
    public string TextDecorationLine
    {
        get { return _textDecorationLine; }
        set {
            _css.Add(("text-decoration-line", value));
            _textDecorationLine = value;
        }
    }
    public string TextDecorationStyle
    {
        get { return _textDecorationStyle; }
        set {
            _css.Add(("text-decoration-style", value));
            _textDecorationStyle = value;
        }
    }
    public string TextIndent
    {
        get { return _textIndent; }
        set {
            _css.Add(("text-indent", value));
            _textIndent = value;
        }
    }
    public string TextJustify
    {
        get { return _textJustify; }
        set {
            _css.Add(("text-justify", value));
            _textJustify = value;
        }
    }
    public string TextOverflow
    {
        get { return _textOverflow; }
        set {
            _css.Add(("text-overflow", value));
            _textOverflow = value;
        }
    }
    public string TextShadow
    {
        get { return _textShadow; }
        set {
            _css.Add(("text-shadow", value));
            _textShadow = value;
        }
    }
    public string TextTransform
    {
        get { return _textTransform; }
        set {
            _css.Add(("text-transform", value));
            _textTransform = value;
        }
    }
    public string Top
    {
        get { return _top; }
        set {
            _css.Add(("top", value));
            _top = value;
        }
    }
    public string Transform
    {
        get { return _transform; }
        set {
            _css.Add(("transform", value));
            _transform = value;
        }
    }
    public string VerticalAlign
    {
        get { return _verticalAlign; }
        set {
            _css.Add(("vertical-align", value));
            _verticalAlign = value;
        }
    }
    public string Visibility
    {
        get { return _visibility; }
        set {
            _css.Add(("visibility", value));
            _visibility = value;
        }
    }
    public string WhiteSpace
    {
        get { return _whiteSpace; }
        set {
            _css.Add(("white-space", value));
            _whiteSpace = value;
        }
    }
    public string Width
    {
        get { return _width; }
        set {
            _css.Add(("width", value));
            _width = value;
        }
    }
    public string WordBreak
    {
        get { return _wordBreak; }
        set {
            _css.Add(("word-break", value));
            _wordBreak = value;
        }
    }
    public string WordSpacing
    {
        get { return _wordSpacing; }
        set {
            _css.Add(("word-spacing", value));
            _wordSpacing = value;
        }
    }
    public string WordWrap
    {
        get { return _wordWrap; }
        set {
            _css.Add(("word-wrap", value));
            _wordWrap = value;
        }
    }
    public string JustifyContent
    {
        get { return _justifyContent; }
        set {
            _css.Add(("justify-content", value));
            _justifyContent = value;
        }
    }
    public string TextAlign
    {
        get { return _textAlign; }
        set {
            _css.Add(("text-align", value));
            _textAlign = value;
        }
    }
    #endregion

    public string DisplayYDirection() => DisplayStyles("\n");

    public string DisplayXDirection() => DisplayStyles(" ");

    private string DisplayStyles(string separator)
    {
        var cssDisplay = _css.Select(css => $"{css.Item1}: {css.Item2};");
        return $"{string.Join(separator, cssDisplay)}";
    }
}
