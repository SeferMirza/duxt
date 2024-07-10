namespace duxt.exception;

public class PageNotExists<T>()
    : Exception($"Page with body content of type {typeof(T)} does not exist");