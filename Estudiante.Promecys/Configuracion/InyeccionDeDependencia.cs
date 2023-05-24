using DSI_BLL.Implementacion.Asiganturas;
using DSI_BLL.Implementacion.Catalogos;
using DSI_BLL.Implementacion.Estudiantes;
using DSI_BLL.Implementacion.Horarios;
using DSI_BLL.Implementacion.Pagos;
using DSI_BLL.Interfaces;
using DSI_BLL.Interfaces.Catalogos;
using DSI_BLL.Interfaces.Estudiantes;
using DSI_BLL.Interfaces.Horarios;
using DSI_BLL.Interfaces.Pagos;

namespace Promecys.API.Configuracion
{
    public static class InyeccionDeDependencia
    {
        public static void AddDSI_DLL(this IServiceCollection services)
        {
            services.AddScoped<IAsignaturas, AsignaturasBLL>();
            services.AddScoped<ICatalogos, CatalogosBLL>();
            services.AddScoped<IEstudiante, EstudiantesBLL>();
            services.AddScoped<IHorarios, HorariosBLL>();
            services.AddScoped<IPagos, PagosBLL>();
        }
    }
}
