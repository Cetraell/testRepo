using CallForPappersService.Data.Dto;
using CallForPappersService.Data.Entities;
using CallForPappersService.Repository;

namespace CallForPappersService.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly ILogger<ApplicationService> _logger;

        public ApplicationService(IApplicationRepository applicationRepository, ILogger<ApplicationService> logger)
        {
            _applicationRepository = applicationRepository;
            _logger = logger;
        }
        public async Task<ApplicationDto> CreateApplicationAsync(ApplicationCreateDto dto, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(dto);

            // проверить createDto FluentValidator

            // создать сущность
            var application = new Application
            {
                AuthorId = dto.AuthorId,
                Name = dto.Name!,
                Description = dto.Description!,
                Outline = dto.Outline!,
                CreatedDate = DateTime.Now,
                Status = ApplicationStatus.Pending
            };

            // кинуть в репозиторий на создание и вернуть из репозитория объект со всеми нужными полями. ВАЖНО
            //_applicationRepository.CreateApplication(application);


            // в целом добавить логирование и асинхронщину везде, если хватит времени

            // вернуть ApplicationDto в котором будет указан Id заявки и все остальное
            //return new ApplicationDto()
            //{
            //    Id = application.Id,
            //    AuthorId = application.AuthorId,
            //    ActvityTypeName = application.Activity.ActivityType.ToString(),
            //    Name = application.Name,
            //    Description = application.Description,
            //    Outline = application.Outline
            //};


            // это просто для примера
            return new ApplicationDto()
            {
                Id = new Guid("35A80A02-89CF-4F51-AA6B-34AC0D12437B"),
                AuthorId = application.AuthorId,
                ActvityTypeName = ActivityType.Report.ToString(),
                Name = application.Name!,
                Description = application.Description!,
                Outline = application.Outline!,
            };
        }
    }
}

            