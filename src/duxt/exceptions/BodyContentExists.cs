namespace duxt.exception;

public class BodyContentExists<T>()
    : Exception($"{typeof(T)} type of body content already registered");