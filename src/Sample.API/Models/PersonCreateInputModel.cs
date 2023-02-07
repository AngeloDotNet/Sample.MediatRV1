namespace Sample.API.Models;

public partial class PersonCreateInputModel
{
    public Guid UserId { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public PersonCreateInputModel(Guid userId, string cognome, string nome, string email)
    {
        UserId = userId;
        Cognome = cognome;
        Nome = nome;
        Email = email;
    }
}