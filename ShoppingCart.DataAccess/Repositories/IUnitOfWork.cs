using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }   

        ICategoryRepository CateogoryRepository { get; }

        void Save();
    }
}
