using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nc.Domain;
using System.ComponentModel;
using System.Reflection;
using System.Text.Encodings.Web;

namespace Nc.Pages.Controls;
public static class HtmlShowTable {
    public static IHtmlContent ShowTable<TModel, TEntity>(this IHtmlHelper<TModel> helper,
        ShowTableProperties<TEntity> properties) where TEntity : IEntity {
        properties.Properties = GetProperties(typeof(TEntity), properties.ExcludedProperties);
        var thead = helper.CreateHead(properties);
        var body = helper.CreateBody(properties);
        var searchForm = CreateControls(helper, properties);

        var div = new TagBuilder("div");
        if (properties.MasterController is not null && searchForm is not null) 
            div.InnerHtml.AppendHtml(searchForm);
        var table = new TagBuilder("table");
        table.AddCssClass("table");
        table.InnerHtml.AppendHtml(thead);
        table.InnerHtml.AppendHtml(body);
        div.InnerHtml.AppendHtml(table);

        if (properties.Label is not null) 
            return HtmlControl.Control(properties.Label, div);
        var writer = new StringWriter();
        div.WriteTo(writer, HtmlEncoder.Default);

        return new HtmlString(writer.ToString());
    }

    private static TagBuilder? CreateControls<TModel, TEntity>(this IHtmlHelper<TModel> helper, ShowTableProperties<TEntity> properties) {
        if (!properties.IsEditable) return null;
        var createNew = helper.ActionLink("Create New", "Create", properties.Controller, new { masterController = properties.MasterController, masterId = properties.MasterId });
        var div = new TagBuilder("div");
        div.AddCssClass("form-actions no-color");
        div.InnerHtml.AppendHtml(createNew);
        return div;
    }

    private static TagBuilder CreateHead<TModel, TEntity>(this IHtmlHelper<TModel> helper,
        ShowTableProperties<TEntity> properties) {
        var thead = new TagBuilder("thead");
        var tr = new TagBuilder("tr");
        foreach (var property in properties.Properties) {
            helper.AddColumn(tr, property, properties.SortOrder, properties.SearchString, properties.PageNumber, properties.MasterController is null);
        }
        if (properties.IsEditable) 
            helper.AddColumn(tr, string.Empty);
        thead.InnerHtml.AppendHtml(tr);
        return thead;
    }
    private static TagBuilder CreateBody<TModel, TEntity>(this IHtmlHelper<TModel> helper,
        ShowTableProperties<TEntity> properties) where TEntity : IEntity {
        var tbody = new TagBuilder("tbody");
        foreach (var item in properties.Items) {
            var tr = new TagBuilder("tr");
            TagBuilder td;
            foreach (var property in properties.Properties) {
                td = new TagBuilder("td");
                var value = property?.GetValue(item);
                var v = value is int intValue && intValue == 0 ? "Not Set" : value?.ToString() ?? "";
                var htmlValue = helper.Raw(v);
                td.InnerHtml.AppendHtml(htmlValue);
                tr.InnerHtml.AppendHtml(td);
            }
            var id = item?.Id.ToString() ?? string.Empty;
            if (properties.IsEditable) {
                td = new TagBuilder("td");
                helper.AddLink("Edit", properties.Controller, id, td, properties.MasterController, properties.MasterId);
                helper.AddLink("Details", properties.Controller, id, td, properties.MasterController, properties.MasterId);
                helper.AddLink("Delete", properties.Controller, id, td, properties.MasterController, properties.MasterId, true);
                tr.InnerHtml.AppendHtml(td);
            }
            tbody.InnerHtml.AppendHtml(tr);
        }
        return tbody;
    }
    private static void AddLink<TModel>(this IHtmlHelper<TModel> helper,
        string action, string? controller, string id, TagBuilder td, string? masterController, int? masterId, bool isLast = false) {
        var link = (controller is null)
            ? helper.ActionLink(action, action, new { Id = id })
            : helper.ActionLink(action, action, controller, new { Id = id, MasterController = masterController, MasterId = masterId });
        td.InnerHtml.AppendHtml(link);
        if (isLast) return;
        td.InnerHtml.AppendHtml(new HtmlString(" | "));
    }
    private static void AddColumn<TModel>(this IHtmlHelper<TModel> helper,
        TagBuilder tr, PropertyInfo propertyInfo, string? sortOrder, string? searchString, int? pageNumber, bool isEditable, string tag = "td") {
        var name = NewName(propertyInfo, sortOrder);
        sortOrder = NewSortOrder(propertyInfo.Name, sortOrder);
        var th = new TagBuilder(tag);
        var value = isEditable
            ? helper.ActionLink(name, "Index", new { SortOrder = sortOrder, SearchString = searchString, PageNumer = pageNumber })
            : helper.Raw(name);
        th.InnerHtml.AppendHtml(value);
        tr.InnerHtml.AppendHtml(th);
    }
    private static string NewName(PropertyInfo propertyInfo, string? sortOrder) {
        var name = propertyInfo.Name;
        var displayName = propertyInfo.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? name;
        if (string.IsNullOrEmpty(sortOrder)) return displayName;
        if (!sortOrder.StartsWith(name)) return displayName;
        if (sortOrder.EndsWith("_desc")) return $"{displayName} ↓";
        return $"{displayName} ↑";
    }
    private static void AddColumn<TModel>(this IHtmlHelper<TModel> helper,
        TagBuilder tr, string name, string tag = "td") {
        var th = new TagBuilder(tag);
        var value = helper.Raw(name);
        th.InnerHtml.AppendHtml(value);
        tr.InnerHtml.AppendHtml(th);
    }
    private static string NewSortOrder(string? name, string? sortOrder) {
        if (name is null) return string.Empty;
        if (sortOrder is null) return name;
        if (!sortOrder.StartsWith(name)) return name;
        if (sortOrder.EndsWith("_desc")) return name;
        return name + "_desc";
    }
    private static PropertyInfo[] GetProperties(Type type, params string[] excludedProperties) {
        var properties = type?.GetProperties()?.Where(x => x.Name != "Id")?.ToArray();
        if (excludedProperties != null) {
            properties = properties?.Where(x => !excludedProperties.Contains(x.Name))?.ToArray();
        }
        return properties ?? [];
    }
}



