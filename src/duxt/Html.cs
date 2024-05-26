namespace duxt;

public class Html(Head head, Body body)
    : Component([head, body], default, default, "html", default);
