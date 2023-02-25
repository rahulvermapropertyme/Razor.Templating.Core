﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Razor.Templating.Core
{
    public interface IRazorTemplateEngine
    {
        /// <summary>
        /// Renders the Razor View(.cshtml) To String
        /// </summary>
        /// <param name="viewName">Relative path of the .cshtml view. Eg:  /Views/YourView.cshtml or ~/Views/YourView.cshtml</param>
        /// <param name="viewModel">Optional model data</param>
        /// <param name="viewBagOrViewData">Optional view bag or view data</param>
        /// <returns>Rendered HTML string of the view</returns>
        Task<string> RenderAsync(string viewName, object? viewModel = null, Dictionary<string, object>? viewBagOrViewData = null);

        /// <summary>
        /// Renders the Razor View(.cshtml) Without Layout to String
        /// </summary>
        /// <param name="viewName">Relative path of the .cshtml view. Eg:  /Views/YourView.cshtml or ~/Views/YourView.cshtml</param>
        /// <param name="viewModel">Optional model data</param>
        /// <param name="viewBagOrViewData">Optional view bag or view data</param>
        /// <returns>Rendered HTML string of the view</returns>
        Task<string> RenderPartialAsync(string viewName, object? viewModel = null, Dictionary<string, object>? viewBagOrViewData = null);
    }
}