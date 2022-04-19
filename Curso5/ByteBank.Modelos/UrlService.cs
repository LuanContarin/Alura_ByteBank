using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBank.Modelos
{
    public class UrlService
    {
        /// <summary>
        /// List all the parameters of a specified URL.
        /// </summary>
        /// <param name="url"> URL for the search. </param>
        /// <returns> A list with objects, containing the <see cref="Param.Name"/> and <see cref="Param.Value"/> of all parameters. </returns>
        /// <exception cref="ArgumentException"></exception>
        public List<Param> GetAllParams(string url)
        {
            #region Exceptions

            if (String.IsNullOrEmpty(url))
                throw new ArgumentException("URL null or empty.", nameof(url));

            if (!url.Contains("?") && url.Split('?').Length <= 1)
                throw new ArgumentException("URL without parameters.", nameof(url));

            #endregion

            string[] parameters = url.Split('?')[1].Split('&');

            var result = new List<Param>();

            foreach (var param in parameters)
            {
                var NameAndValue = param.Split('=');

                if (NameAndValue.Length > 1)
                {
                    result.Add(new Param
                    {
                        Name = NameAndValue[0],
                        Value = NameAndValue[1]
                    });
                }
            }

            return result;
        }

        public class Param
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        /// <summary>
        /// Try to find the parameter in URL for the specified <paramref name="paramName"/>.
        /// </summary>
        /// <param name="url"> URL to search for the parameter.</param>
        /// <param name="paramName"> The name of parameter (not sensitive case). </param>
        /// <returns> <see cref="Param.Value"/> or <see langword="null"/> if not found. </returns>
        /// <exception cref="ArgumentException"></exception>
        public string ParamValue(string url, string paramName)
        {
            #region Exceptions

            if (String.IsNullOrEmpty(paramName))
                throw new ArgumentException("Invalid param name.", nameof(paramName));

            #endregion

            var paramList = GetAllParams(url);

            var paramValue = paramList.FirstOrDefault
                                       (
                                            x => x.Name.Equals(paramName, StringComparison.CurrentCultureIgnoreCase)
                                       )
                                      ?.Value;

            return paramValue;
        }
    }
}
