using System;

namespace NoJS.Modal.Services
{
    public class NoJSModalResult
    {
        public object Data { get; }
        public Type DataType { get; }
        public bool Cancelled { get; }

        protected NoJSModalResult(object data, Type resultType, bool cancelled)
        {
            Data = data;
            DataType = resultType;
            Cancelled = cancelled;
        }

        public static NoJSModalResult Ok<T>(T result) => new NoJSModalResult(result, typeof(T), false);

        public static NoJSModalResult Cancel() => new NoJSModalResult(default, typeof(object), true);
    }
}
