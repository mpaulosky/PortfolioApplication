// ============================================
// Copyright (c) 2023. All rights reserved.
// File Name :     Error.cshtml.cs
// Company :       mpaulosky
// Author :        Matthew Paulosky
// Solution Name : PortfolioApplication
// Project Name :  Portfolio.UI
// =============================================

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.UI.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
	public string? RequestId { get; set; }

	public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

	public ErrorModel()
	{
	}

	public void OnGet()
	{
		RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
	}
}
