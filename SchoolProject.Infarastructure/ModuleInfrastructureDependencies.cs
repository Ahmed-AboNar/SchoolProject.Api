using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infarastructure.Abstracts;
using SchoolProject.Infarastructure.InfrastructureBases;
using SchoolProject.Infarastructure.Repositories;

namespace SchoolProject.Infarastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IInstructorsRepository, InstructorsRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;

        }
    }
}
