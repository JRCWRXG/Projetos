using AutoMapper;
using IntegracaoBRApi.DTO;
using IntegracaoBRApi.Models;

namespace IntegracaoBRApi.Mapping
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}
