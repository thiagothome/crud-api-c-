using Crud2.Data;

namespace Crud2.Estudantes
{
    public static class EstudantesRota
    {
        public static void AddEstudantes(WebApplication app)
        {
            var rotasEstudante = app.MapGroup("estudantes");

            rotasEstudante.MapPost("", (AddEstudante request, CrudContext context) =>
            {
                var Estudante = new Estudante(request.Nome);
                context.Estudantes.Add(Estudante);
                context.SaveChanges();
            });

            rotasEstudante.MapGet("", (CrudContext context) =>
            {
                var estudantes = context.Estudantes
                .Where(estudante => estudante.Ativo)
                .ToList();
                return estudantes;
            });

            rotasEstudante.MapPut("{id}", (Guid id, AddEstudante request, CrudContext context) =>
            {
                var estudante = context.Estudantes.SingleOrDefault(e => e.Id == id );

                if (estudante == null)
                {
                    return Results.NotFound();
                }

                estudante.AtualizaNome(request.Nome);

                context.SaveChanges();

                return Results.Ok(estudante);
            });

            rotasEstudante.MapDelete("{id}", (Guid id, AddEstudante request, CrudContext context) =>
            {
                var estudante = context.Estudantes.SingleOrDefault(e => e.Id == id);

                if (estudante == null)
                {
                    return Results.NotFound();
                }

                estudante.Desativar();

                context.SaveChanges();

                return Results.Ok();
            });
        }
    }
}
