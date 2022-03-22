using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.OutServices
{
    public interface IContentHelper
    {
        void GetTitle();
        List<Article> GetArticles();
    }
}
