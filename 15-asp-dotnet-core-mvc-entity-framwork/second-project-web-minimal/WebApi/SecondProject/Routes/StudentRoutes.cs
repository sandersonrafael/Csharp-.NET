using Microsoft.EntityFrameworkCore;
using SecondProject.Database;
using SecondProject.Model;
using SecondProject.Model.Dtos;
using SecondProject.Model.Requests;

namespace SecondProject.Routes;

public static class StudentRoutes
{
    // To add this method like extension method, we can use "this" modificator
    // The method now can be called with "app.ThisMethod" -> here is app.AddStudentRoutes();
    public static void AddStudentRoutes(this WebApplication app)
    {
        //app.MapGet("students", () => new Student("Fulano"));

        // To create a generalization for Routes, use:
        var students = app.MapGroup("students"); // Optional

        students.MapGet("", async (AppDbContext context) =>
        {
            List<StudentDTO> studentDtos = await context.Students
            .Where(s => s.Active == true)
            .Select(std => new StudentDTO(std.Id, std.Name))
            .ToListAsync();

            return Results.Ok(studentDtos); // Http Results
        });

        // .NET provides in all routes a CancellationToken
        // It's recommended to pass as an argument the CancellationToken for all Async and Results invocations
        // In results invocations, is necessary only if they don't have a argument
        students.MapPost("", async (StudentRequest dto, AppDbContext context, CancellationToken ct) =>
        {
            Student student = new(dto.Name);
            await context.Students.AddAsync(student, ct);
            await context.SaveChangesAsync(ct);
            return Results.Ok(ct); // Http Results
        });

        students.MapPut("{id:guid}", async (Guid id, StudentRequest dto, AppDbContext context, CancellationToken ct) =>
        {
            // This annotation takes the referente of student in db. All changes in this entity, will update automaticaly
            // in the entity. It means that we don't need to call another update async method before saving changes
            Student? student = await context.Students.SingleOrDefaultAsync(student => student.Id == id, ct);

            if (student is null) return Results.NotFound(ct);
            student.UpdateName(dto.Name);
            await context.SaveChangesAsync(ct);

            return Results.Ok(student);
        });

        // Soft Delete -> instead of really delete a student, it will turn that student Active = false
        students.MapDelete("{id:guid}", async (Guid id, AppDbContext context) => {
            Student? dbStudent = await context.Students.SingleOrDefaultAsync(student => student.Id == id);
            if (dbStudent is null || !dbStudent.Active) return Results.NotFound();

            dbStudent.TurnInactive();
            await context.SaveChangesAsync();

            return Results.NoContent();
        });
    }
}
