using Microsoft.AspNetCore.Html;
using System.Reflection;

namespace Nc.Pages.Controls;

public class ShowTableProperties<TEntity>(dynamic? viewBag = null) {
    public IEnumerable<TEntity> Items { get; set; } = [];
    public string? SortOrder { get; set; } = viewBag?.SortOrder;
    public string? SearchString { get; set; } = viewBag?.SearchString;
    public int? PageNumber { get; set; } = viewBag?.PageNumber;
    public bool IsEditable { get; set; } = true;
    public string? Controller { get; set; }
    public string? MasterController { get; set; }
    public int? MasterId { get; set; }
    public IHtmlContent? Label { get; set; }
    public PropertyInfo[] Properties { get; set; } = [];
    public string[] ExcludedProperties { get; set; } = [];
}




