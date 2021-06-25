using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Controllers
{

    [Authorize]
    public class BaseCRUDController<T, TSearch,TInsert,TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        public BaseCRUDController(ICRUDService<T, TSearch,TInsert,TUpdate> service) : base(service)
        {
            _service = service;
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]

        public T Update(int id, [FromBody] TUpdate request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
