using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.eShopWeb.Web;

public class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? value)
    {
        if (value == null) { return null; }
        string? str = value.ToString();
        if (string.IsNullOrEmpty(str)) { return null; }