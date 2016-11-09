using AutoMapper;
using ThoitrangShop.Model.Models;
using ThoitrangShop.Web.Models;

namespace ThoitrangShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>

            {

                cfg.CreateMap<PostCat, PostCatViewModel>();

                cfg.CreateMap<Post, PostViewModel>();

                cfg.CreateMap<PostTag, PostTagViewModel>();

                cfg.CreateMap<Tag, TagViewModel>();

            });
            //var a = new MapperConfiguration(cfg =>cfg.CreateMap<Post, PostViewModel>());
            //var b = new MapperConfiguration(cfg => cfg.CreateMap<PostCat, PostCatViewModel>());
            //var c = new MapperConfiguration(cfg => cfg.CreateMap<Tag, TagViewModel>());
            //Mapper.CreateMap<Post, PostViewModel>();
            //Mapper.CreateMap<PostCat, PostCatViewModel>();
            //Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}