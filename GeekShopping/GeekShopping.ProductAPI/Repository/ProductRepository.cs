using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model.Context;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : MySqlConnector
    {
        private readonly MySqlConnector _context;
        private IMapper _mapper;
        public Task<ProductVO> Create(ProductVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductVO>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> Update(ProductVO vo)
        {
            throw new NotImplementedException();
        }
    }
}
