namespace GestorDeContactos.Models
{
    public class UpdateContactoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}