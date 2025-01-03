﻿// Listing 30.42 Adding ordering the MessageAttribute.cs file in the Filters folder

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace WebApp.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class MessageAttribute : Attribute, IAsyncAlwaysRunResultFilter, IOrderedFilter
    {
        private int counter = 0;
        private string msg;

        public MessageAttribute(string message) => msg = message;

        public int Order { get; set; } = 0;

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            Dictionary<string, string> resultData;
            if (context.Result is ViewResult vr &&
                vr.ViewData.Model is Dictionary<string, string> data)
            {
                resultData = data;
            }
            else
            {
                resultData = new Dictionary<string, string>();
                context.Result = new ViewResult()
                {
                    ViewName = "/Views/Shared/Message.cshtml",
                    ViewData = new ViewDataDictionary(
                        new EmptyModelMetadataProvider(),
                        new ModelStateDictionary())
                    {
                        Model = resultData
                    }
                };
            }

            while (resultData.ContainsKey($"Counter_{counter}"))
            {
                counter++;
            }

            resultData[$"Counter_{counter}"] = msg;
            await next();
        }
    }
}
