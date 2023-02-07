namespace Sample.API.Models;

public partial class PersonCreateInputModel
{
    public Guid Id { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public PersonCreateInputModel(Guid id, string cognome, string nome, string email)
    {
        Id = id;
        Cognome = cognome;
        Nome = nome;
        Email = email;
    }
}