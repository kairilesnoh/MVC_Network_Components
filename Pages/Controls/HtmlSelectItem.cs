using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nc.Helpers;
using System.Linq.Expressions;
using System.Text.Encodings.Web;

namespace Nc.Pages.Controls;
public static class HtmlSelectItem {
    public static IHtmlContent SelectItem<TModel, TValue>(this IHtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, SelectList? selectList) {
        var label = helper.LabelFor(expression, new { @class = "control-label" });
        var displayName = helper.DisplayNameFor(expression);
        var editor = helper.DropDownListFor(expression, AddDescription(selectList, displayName), new { @class = "form-control" });
        var validation = helper.ValidationMessageFor(expression, string.Empty, new { @class = "text-danger" });

        var div = new TagBuilder("div");
        div.AddCssClass("form-group");
        div.InnerHtml.AppendHtml(label);
        div.InnerHtml.AppendHtml(editor);
        div.InnerHtml.AppendHtml(validation);

        var writer = new StringWriter();
        div.WriteTo(writer, HtmlEncoder.Default);

        return new HtmlString(writer.ToString());
    }
    public static IHtmlContent SelectItem<TModel, TValue>(this IHtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, string controller) {
        var label = helper.LabelFor(expression, new { @class = "control-label" });
        //var displayName = helper.DisplayNameFor(expression);
        var name = helper.NameFor(expression);
        var value = helper.ValueFor(expression);
        var editor = new HtmlString(
            $"<select name=\"{name}\" " +
            "class=\"selectItems2 form-control\" " +
            $"data-controller=\"{controller}\" " +
            $"data-id=\"{value}\">" +
            "</select>"
        );
        var validation = helper.ValidationMessageFor(expression, string.Empty, new { @class = "text-danger" });

        var div = new TagBuilder("div");
        div.AddCssClass("form-group");
        div.InnerHtml.AppendHtml(label);
        div.InnerHtml.AppendHtml(editor);
        div.InnerHtml.AppendHtml(validation);

        var writer = new StringWriter();
        div.WriteTo(writer, HtmlEncoder.Default);

        return new HtmlString(writer.ToString());
    }

    private static IEnumerable<SelectListItem> AddDescription(SelectList? selectList, string displayName) {
        var list = selectList?.ToList() ?? [];
        list.Insert(0, new SelectListItem { Text = $"-- {Constants.Select} {displayName} --", Value = "" });
        return list;
    }
}
