using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatR;
using System.Threading.Tasks;
using Catalog.Domain.Entities;

namespace Catalog.Application.UseCases.CatalogCases.Commands
{
    public class CreateCatalogCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
