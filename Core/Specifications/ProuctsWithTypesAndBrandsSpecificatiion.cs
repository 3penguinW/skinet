using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProuctsWithTypesAndBrandsSpecificatiion : BaseSpecification<Product>
    {
        public ProuctsWithTypesAndBrandsSpecificatiion()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }

        public ProuctsWithTypesAndBrandsSpecificatiion(int id) :base(x=>x.Id==id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }
    }
}