using Microsoft.EntityFrameworkCore;

namespace DAL.Modelo
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<entityBasicoContext>();
            context.Database.EnsureCreated();
            AddEmpleado(context);
        }

        private static void AddEmpleado(entityBasicoContext context)
        {
            //var empleado = context.Empleados.FirstOrDefault();
            //if (empleado != null) return;

            context.Empleados.Add(new Empleado(2,"Juan"));

            context.SaveChanges();

        }

        //private static void SlectEmployee(entityBasicoContext context)
        //{
        //    context.Empleados.AsSingleQuery();

        //    Console.WriteLine(context);

        //    context.SaveChanges();
        //}

    }
}
