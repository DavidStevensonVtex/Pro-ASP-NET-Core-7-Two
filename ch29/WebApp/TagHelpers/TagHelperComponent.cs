﻿// Listing 25.30 The TimeTagHelperComponent.cs file in the TagHelpers folder

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApp.TagHelpers
{
    public class TimeTagHelperComponent : TagHelperComponent
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string timestamp = DateTime.Now.ToLongTimeString();

            if (output.TagName == "body") {
                TagBuilder elem = new TagBuilder("div");
                elem.Attributes.Add("class", "bg-info text-white m-2 p-2");
                elem.InnerHtml.Append($"Time: {timestamp}");
                output.PreContent.AppendHtml(elem);
            }
        }
    }
}
