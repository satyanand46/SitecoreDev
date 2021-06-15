using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Extensions
{
    public static class StringExtensions
    {
        private const char FacetValueSeparator = '|';
        private const char FacetsSeparator = '~';
        private const char FacetSeparator = '=';

        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString) == true) return target;

            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }
            return result;
        }

        public static string TrimEnd(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString) == true) return target;

            string result = target;
            while (result.EndsWith(trimString))
            {
                result = result.Substring(0, result.Length - trimString.Length);
            }
            return result;
        }

        public static string StripUrlCharacters(this string value)
        {
            string returnValue = string.Empty;
            if (string.IsNullOrEmpty(value) == false)
            {
                returnValue = value.Trim().TrimEnd(new char[] { '/' }).Replace(":443", string.Empty);
            }
#if DEBUG
            Sitecore.Diagnostics.Log.Debug("Safe Url: " + returnValue, typeof(ItemExtensions));
#endif
            return returnValue;
        }

        public static string FormatSocial(this string value)
        {
            string returnValue = string.Empty;
            if (string.IsNullOrEmpty(value) == false)
            {
                returnValue = value.Replace(" ", "%20");
            }
#if DEBUG
            Sitecore.Diagnostics.Log.Debug("Social Media : " + returnValue, typeof(ItemExtensions));
#endif
            return returnValue;
        }

        public static string GetFacetQueryString(this IDictionary<string, string[]> searchQueryFacets)
        {
            var returnValue = string.Empty;

            if ((searchQueryFacets != null) && (searchQueryFacets.Keys != null))
            {
                foreach (var key in searchQueryFacets.Keys)
                {
                    var values = string.Join(FacetValueSeparator.ToString(), searchQueryFacets[key]);
                    if (string.IsNullOrEmpty(returnValue) == false)
                    {
                        returnValue += FacetsSeparator;
                    }

                    returnValue += key + FacetSeparator + values;
                }
            }
            return HttpUtility.UrlEncode(returnValue);
        }

        public static IDictionary<string, string[]> ParseQueryStringFacets(this string queryString)
        {
            var returnValue = new Dictionary<string, string[]>();
            string facetQueryString = HttpUtility.UrlDecode(queryString);

            if (string.IsNullOrWhiteSpace(facetQueryString) == false)
            {
                var facetsValuesStrings = facetQueryString.Split(new[] { FacetsSeparator }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var facetValuesString in facetsValuesStrings)
                {
                    var facetValues = facetValuesString.Split(FacetSeparator);
                    if (facetValues.Length <= 1)
                    {
                        continue;
                    }

                    var name = facetValues[0].ToLowerInvariant();
                    var values = facetValues[1].Split(FacetValueSeparator).Distinct().ToArray();
                    if (returnValue.ContainsKey(name) == true)
                    {
                        returnValue[name] = returnValue[name].Union(values).Distinct().ToArray();
                    }
                    else
                    {
                        returnValue.Add(name, values);
                    }
                }
            }
            return returnValue;
        }

        public static string ToggleFacet(string facetQueryString, string facetName, string facetValue)
        {
            if (string.IsNullOrWhiteSpace(facetQueryString) == true)
            {
                return string.Empty;
            }

            var parsedFacets = facetQueryString.ParseQueryStringFacets();
            if (parsedFacets.ContainsKey(facetName))
            {
                var values = parsedFacets[facetName];
                if (values.Any(v => v.Equals(facetValue, StringComparison.InvariantCultureIgnoreCase)))
                {
                    //Remove facet value from list
                    values = values.Where(v => !v.Equals(facetValue, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }
                else
                {
                    //Add facet value from list
                    values = values.Union(new[] { facetValue }).ToArray();
                }

                if (!values.Any())
                {
                    parsedFacets.Remove(facetName);
                }
                else
                {
                    parsedFacets[facetName] = values;
                }
            }
            else
            {
                parsedFacets[facetName] = new[] { facetValue };
            }
            return parsedFacets.GetFacetQueryString();
        }
    }
}