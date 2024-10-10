using Microsoft.AspNetCore.Mvc;
using ProductsOrdersAPI.Repositories;

namespace ProductsOrdersAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
public class CategoriesController : ControllerBase
{
    protected readonly ICategoryRepository _categoryRepository;

    public CategoriesController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
}
