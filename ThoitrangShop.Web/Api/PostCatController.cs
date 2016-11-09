using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThoitrangShop.Model.Models;
using ThoitrangShop.Service;
using ThoitrangShop.Web.infrastructure.Core;
using ThoitrangShop.Web.infrastructure.Extensions;
using ThoitrangShop.Web.Models;

namespace ThoitrangShop.Web.Api
{
    [RoutePrefix("api/postcat")]
    public class PostCatController : ApiControllerBase
    {
        IPostCatService _postCatService;

        public PostCatController(IErrorService errorService, IPostCatService postCatService) :
            base(errorService)
        {
            this._postCatService = postCatService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCat = _postCatService.GetAll();

                var listPostCatVm = Mapper.Map<List<PostCatViewModel>>(listCat);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPostCatVm);


                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, PostCatViewModel postCatVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCat newPostCat = new PostCat();
                    newPostCat.UpdatePostCat(postCatVm);

                    var cat = _postCatService.Add(newPostCat);
                    _postCatService.Save();

                    response = request.CreateResponse(HttpStatusCode.Created, cat);

                }
                return response;
            });
        }

        [Route("update")]

        public HttpResponseMessage Put(HttpRequestMessage request, PostCatViewModel postCatVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCatDb = _postCatService.GetById(postCatVm.ID_PostCat);
                    postCatDb.UpdatePostCat(postCatVm);
                    _postCatService.Update(postCatDb);
                    _postCatService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCatService.Delete(id);
                    _postCatService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}