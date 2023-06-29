using E_Ticaret.Application.Repositories.Categories;
using E_Ticaret.Domain.Entities;
using MediatR;

namespace E_Ticaret.Application.Features.Queries.CategoryQueries.GetAllQuery
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
    {
        private ICategoryReadRepository _categoryReadRepository;

        public GetAllCategoryQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = _categoryReadRepository.GetAll().Select(c => new Category (){Id = c.Id, Name = c.Name}).ToList();
            return categories.Count() > 0 ? new (categories, "Kategoriler listelendi", true) : new(null, "Kayıtlı kategori bulunamadı", false);
        }
    }
}