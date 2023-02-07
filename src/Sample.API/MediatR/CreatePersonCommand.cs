namespace Sample.API.MediatR;

public class CreatePersonCommand : IRequest<PersonEntity>
{
    public Guid Id { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public CreatePersonCommand(PersonCreateInputModel inputModel)
    {
        Id = inputModel.Id;
        Cognome = inputModel.Cognome;
        Nome = inputModel.Nome;
        Email = inputModel.Email;
    }
}