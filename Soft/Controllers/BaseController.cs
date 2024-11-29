using Microsoft.AspNetCore.Mvc;
using Nc.Domain.Common;
using Nc.Facade;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers;
public abstract class BaseController<TModel, TViewModel>(IRepo<TModel> repo) : Controller
where TModel : class where TViewModel : EntityViewModel, new() {
    protected readonly IRepo<TModel> repo = repo;
    protected bool loadLazy;
    protected async virtual Task LoadRelatedItems(TModel? model) => await Task.CompletedTask;
    protected abstract TModel ToModel(TViewModel viewModel);
    protected virtual async Task<TViewModel> ToViewAsync(TModel model) {
        await Task.CompletedTask;
        return PropertyCopier.CopyPropertiesFrom<TModel, TViewModel>(model);
    }
    protected virtual string selectItemTextField => nameof(EntityViewModel.Id);
    public async Task<IActionResult> Index(string sortOrder, string searchString, int? pageNumber) {
        loadLazy = false;
        repo.PageNumber = pageNumber;
        repo.SearchString = searchString;
        repo.SortOrder = sortOrder;
        ViewBag.HasNextPage = repo.HasNextPage;
        ViewBag.HasPreviousPage = repo.HasPreviousPage;
        ViewBag.PageNumber = repo.Page;
        ViewBag.SearchString = repo.SearchString;
        ViewBag.SortOrder = repo.SortOrder;
        ViewBag.TotalPages = repo.TotalPages;
        var list = await repo.GetAsync();
        var tasks = list.Select(ToViewAsync);
        var viewList = await Task.WhenAll(tasks);
        return View(viewList);
    }
    public async Task<IActionResult> Details(int? id, string? masterController, int? masterId) {
        ViewBag.MasterController = masterController;
        ViewBag.MasterId = masterId;
        var model = await repo.GetAsync(id);
        loadLazy = true;
        return model == null ? NotFound() : View(await ToViewAsync(model));
    }
    public async Task<IActionResult> Create(string? masterController, int? masterId) {
        ViewBag.MasterController = masterController;
        ViewBag.MasterId = masterId;
        await LoadRelatedItems(null);
        return View();
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TViewModel viewModel, string? masterController, int? masterId) {
        if (!ModelState.IsValid) 
            return View(viewModel);
        if (await repo.AddAsync(ToModel(viewModel))) {
            if (masterController is null) 
                return RedirectToAction(nameof(Index));
            return RedirectToAction("Edit", masterController, new { id = masterId });
        }
        ViewBag.MasterController = masterController;
        ViewBag.MasterId = masterId;
        ModelState.AddModelError(string.Empty, repo.ErrorMessage);
        return View(viewModel);
    }

    public async Task<IActionResult> Edit(int? id, string? masterController, int? masterId) {
        ViewBag.IsEditView = true;
        ViewBag.MasterController = masterController;
        ViewBag.MasterId = masterId;
        var model = await repo.GetAsync(id);
        loadLazy = true;
        await LoadRelatedItems(model);
        return model == null ? NotFound() : View(await ToViewAsync(model));
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(TViewModel viewModel, string? masterController, int? masterId) {
        if (!ModelState.IsValid) 
            return View(viewModel);
        if (await repo.UpdateAsync(ToModel(viewModel))) {
            if (masterController is null) 
                return RedirectToAction(nameof(Index));
            return RedirectToAction("Edit", masterController, new { id = masterId });
        }
        ViewBag.MasterController = masterController;
        ViewBag.MasterId = masterId;
        ModelState.AddModelError(string.Empty, repo.ErrorMessage);
        return View(viewModel);
    }

    public async Task<IActionResult> Delete(int? id, string? masterController, int? masterId) {
        ViewBag.MasterController = masterController;
        ViewBag.MasterId = masterId;
        var model = await repo.GetAsync(id);
        loadLazy = true;
        return model == null ? NotFound() : View(await ToViewAsync(model));
    }

    [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id, string? masterController, int? masterId) {
        if (await repo.DeleteAsync(id)) {
            if (masterController is null) 
                return RedirectToAction(nameof(Index));
            return RedirectToAction("Edit", masterController, new { id = masterId });
        }
        return RedirectToAction(nameof(Delete), new { id, masterController, masterId });
    }

    public async Task<IActionResult> SelectItems(string searchString, int id) => Ok(await repo.SelectItems(searchString, id));
    public async Task<IActionResult> SelectItem(int id) => Ok(await repo.SelectItem(id));    
}