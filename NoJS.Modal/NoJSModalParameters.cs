
using System.Collections.Generic;

namespace NoJS.Modal
{

        public class NoJSModalParameters
        {
            private Dictionary<string, object> _parameters;

            public NoJSModalParameters()
            {
                _parameters = new Dictionary<string, object>();
            }

            public void Add(string parameterName, object value)
            {
                _parameters[parameterName] = value;
            }

            public T Get<T>(string parameterName)
            {
                if (!_parameters.ContainsKey(parameterName))
                {
                    throw new KeyNotFoundException($"{parameterName} does not exist in modal parameters");
                }

                return (T)_parameters[parameterName];
            }
        }
}
