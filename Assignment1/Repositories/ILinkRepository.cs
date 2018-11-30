using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Repositories
{
    interface ILinkRepository
    {
        List<LinkModel> GetLinks();

        void Insert(LinkModel link);

        void Delete(LinkModel link);
    }
}
