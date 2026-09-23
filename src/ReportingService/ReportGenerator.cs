using AutoMapper;

namespace ReportingService
{
    public class ReportGenerator
    {
        private readonly IMapper _mapper;

        public ReportGenerator(IMapper mapper)
        {
            _mapper = mapper;
        }

        public object GenerateReport(object data)
        {
            return _mapper.Map<object>(data);
        }
    }
}
